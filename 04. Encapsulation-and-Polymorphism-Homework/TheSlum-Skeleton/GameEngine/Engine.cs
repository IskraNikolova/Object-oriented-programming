namespace TheSlum.GameEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum.GameObjects.Characters;
    using TheSlum.GameObjects.Items;
    using TheSlum.GameObjects.Items.Bonus;
    using TheSlum.Interfaces;

    public class Engine
    {
        private const int GameTurns = 4;

        private readonly List<Character> characterList;

        private List<Bonus> timeoutItems;

        public Engine(IRenderer renderer, IInputHandler inputHandler)
        {
            this.characterList = new List<Character>();
            this.Renderer = renderer;
            this.InputHandler = inputHandler;
        }

        public IRenderer Renderer { get; set; }

        public IInputHandler InputHandler { get; set; }

        public void Run()
        {
            this.ReadUserInput();

            this.InitializeTimeoutItems();

            for (int i = 0; i < GameTurns; i++)
            {
                foreach (var character in this.characterList)
                {
                    if (character.IsAlive)
                    {
                        this.ProcessTargetSearch(character);
                    }
                }

                this.ProcessItemTimeout(this.timeoutItems);
            }

            this.PrintGameOutcome();
        }

        private void ProcessItemTimeout(List<Bonus> timeOutItems)
        {
            for (int i = 0; i < timeOutItems.Count; i++)
            {
                timeOutItems[i].Countdown--;
                if (timeOutItems[i].Countdown == 0)
                {
                    var item = timeOutItems[i];
                    item.HasTimedOut = true;
                    var itemHolder = this.GetCharacterByItem(item);
                    itemHolder.RemoveFromInventory(item);
                    i--;
                }
            }
        }

        private void InitializeTimeoutItems()
        {
            this.timeoutItems = this.characterList
                .SelectMany(c => c.Inventory)
                .Where(i => i is Bonus)
                .Cast<Bonus>()
                .ToList();
        }

        private void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0].ToLower())
            {
                case "status":
                    this.PrintCharactersStatus(this.characterList);
                    break;
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
            }
        }

        private void CreateCharacter(string[] inputParams)
        {
            Character newCharacter;
            switch (inputParams[1].ToLower())
            {
                case "mage":
                    newCharacter = new Mage(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        150,
                        50,
                        300,
                        (Team)Enum.Parse(typeof(Team), 
                        inputParams[5], true),
                        5);
                    this.characterList.Add(newCharacter);
                    break;
                case "warrior":
                    newCharacter = new Warrior(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        200,
                        100,
                        150,
                        (Team)Enum.Parse(typeof(Team), 
                        inputParams[5], true),
                        2);
                    this.characterList.Add(newCharacter);
                    break;
                case "healer":
                    newCharacter = new Healer(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        75,
                        50,
                        60,
                        (Team)Enum.Parse(typeof(Team), 
                        inputParams[5], true),
                        6);
                    this.characterList.Add(newCharacter);
                    break;
                default:
                    break;
            }
        }

        private void AddItem(string[] inputParams)
        {
            Character characterToAcceptIitem = this.GetCharacterById(inputParams[1]);
            Item itemToAdd;
            switch (inputParams[2].ToLower())
            {
                case "axe":
                    itemToAdd = new Axe(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "shield":
                    itemToAdd = new Shield(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "pill":
                    itemToAdd = new Pill(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "injection":
                    itemToAdd = new Injection(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                default:
                    break;
            }
        }

        private void ProcessTargetSearch(Character currentCharacter)
        {
            var availableTargets =this.characterList
                .Where(t => this.IsWithinRange(currentCharacter.X, currentCharacter.Y, t.X, t.Y, currentCharacter.Range))
                .ToList();

            if (availableTargets.Count == 0)
            {
                return;
            }

            var target = currentCharacter.GetTarget(availableTargets);
            if (target == null)
            {
                return;
            }

            this.ProcessInteraction(currentCharacter, target);
        }

        private void ProcessInteraction(Character currentCharacter, Character target)
        {
            if (currentCharacter is IHeal)
            {
                target.HealthPoints += (currentCharacter as IHeal).HealingPoints;
            }
            else if (currentCharacter is IAttack)
            {
                target.HealthPoints -= (currentCharacter as IAttack).AttackPoints - target.DefensePoints;
                if (target.HealthPoints <= 0)
                {
                    target.IsAlive = false;
                }
            }
        }

        private bool IsWithinRange(int attackerX, int attackerY, int targetX, int targetY, int range)
        {
            double distance = Math.Sqrt(((attackerX - targetX) * (attackerX - targetX)) + 
                ((attackerY - targetY) * (attackerY - targetY)));

            return distance <= range;
        }

        private Character GetCharacterById(string characterId)
        {
            return this.characterList.FirstOrDefault(x => x.Id == characterId);
        }

        private Character GetCharacterByItem(Item item)
        {
            return this.characterList.FirstOrDefault(x => x.Inventory.Contains(item));
        }

        private void PrintCharactersStatus(IEnumerable<Character> characters)
        {
            foreach (var character in characters)
            {
               this.Renderer.WriteLine(character.ToString());
            }
        }

        private void PrintGameOutcome()
        {
            var charactersAlive = this.characterList.Where(c => c.IsAlive);
            var redTeamCount = charactersAlive
                .Count(x => x.Team == Team.Red);

            var blueTeamCount = charactersAlive
                .Count(x => x.Team == Team.Blue);

            if (redTeamCount == blueTeamCount)
            {
                this.Renderer.WriteLine("Tie game!");
            }
            else
            {
                string winningTeam = redTeamCount > blueTeamCount ? "Red" : "Blue";
                this.Renderer.WriteLine(winningTeam + " team wins the game!");
            }

            var aliveCharacters = this.characterList.Where(c => c.IsAlive);
            this.PrintCharactersStatus(aliveCharacters);
        }

        private void ReadUserInput()
        {
            string inputLine = this.InputHandler.ReadLine();
            while (inputLine != string.Empty)
            {
                string[] parameters = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                this.ExecuteCommand(parameters);
                inputLine = this.InputHandler.ReadLine();
            }
        }
    }
}
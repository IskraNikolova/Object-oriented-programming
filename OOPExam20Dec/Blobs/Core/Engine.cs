using System.Text;

namespace Blobs.Core
{
    using Interfaces;
    using System;
    using System.Linq;
    using Enums;
    using Models;

    public class Engine : IRunnable
    {
        private const int UpdateableBlobHealth = 50;
        private const int UpdateableBlobDamage = 2;

        private IBlobFactory blobFactory;
        private IData data;
        private IInputReader reader;
        private IOutputWriter writer;

        public Engine(IBlobFactory blobFactory, 
            IData data, 
            IInputReader reader, 
            IOutputWriter writer)
        {
            this.blobFactory = blobFactory;
            this.data = data;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();
                this.ExecuteCommands(input);
                this.UpdateBlobs();
            }
        }

        private void UpdateBlobs()
        {
            foreach (IBlob blob in this.data.Blobs)
            {
                if (blob.IsUpdatable())
                {                 
                    OnceUpdateableBloop(blob);
                    blob.Update();
                }
            }
        }

        private static void OnceUpdateableBloop(IBlob blob)
        {         
            if (blob is AggressiveBehaviorBlob)
            {
                var newDamage = blob.Damage*UpdateableBlobDamage;
                blob.Damage = newDamage;
            }
            else if (blob is InflatedBehaviorBlob)
            {
                var newHealth = blob.Health + UpdateableBlobHealth;
                blob.Health = newHealth;
            }           
        }

        private void ExecuteCommands(string[] input)
        {
            switch (input[0])
            {
                case "create":
                    this.CreateNewBlop(input);
                    break;
                case "attack":
                    this.ExecuteAttack(input[1], input[2]);
                    break;
                case "pass":
                    break;
                case "status":
                    this.ExecuteStatusCommand();
                    break;
                case "drop":
                    Environment.Exit(0);
                    break;
                default:
                    throw new AggregateException("Uknow command.");
            }
        }

        private void ExecuteStatusCommand()
        {
            StringBuilder output = new StringBuilder();
            foreach (var blop in data.Blobs)
            {
                if (blop.Health == 0)
                {
                    output.AppendLine($"Blob {blop.Name} KILLED");
                }
                else
                {
                    output.AppendLine($"Blob {blop.Name}: {blop.Health} HP, {blop.Damage} Damage");
                }               
            }

            this.writer.Print(output.ToString().Trim());
        }

        private void ExecuteAttack(string attackerName, string attackedName)
        {
            IBlob attackBlop = this.data.Blobs.First(b => b.Name == attackerName);
            IBlob attackedBlop = this.data.Blobs.First(b => b.Name == attackedName);

            attackBlop.Attack(attackedBlop);
            
        }

        private void CreateNewBlop(string[] info)
        {
            BlobType bp = (BlobType)Enum.Parse(typeof(BlobType), info[4]);
            AttackType attackType = (AttackType) Enum.Parse(typeof (AttackType), info[5]);
            IBlob blob = this.blobFactory.CreateBlob(info[1], int.Parse(info[2]), int.Parse(info[3]), bp, attackType);
            data.AddBlobs(blob);
        }
    }
}

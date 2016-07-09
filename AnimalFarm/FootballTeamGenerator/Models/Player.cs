namespace FootballTeamGenerator.Models
{
    using System;
    using FootballTeamGenerator.Interfaces;

    public class Player : IPlayer
    {
        private const int LengthOfSkills = 5;

        private string name;
        private double endurance;
        private double sprint;
        private double dribble;
        private double passing;
        private double shooting;

        public Player(string name,
            double endurance, 
            double sprint, 
            double dribble, 
            double passing, 
            double shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public double Endurance
        {
            get
            {
                return this.endurance;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Endurance should be between 0 and 100. ");
                }

                this.endurance = value;
            }
        }

        public double Sprint
        {
            get
            {
                return this.sprint;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Sprint should be between 0 and 100. ");
                }

                this.sprint = value;
            }
        }
              
        public double Dribble
        {
            get
            {
                return this.dribble;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Dribble should be between 0 and 100. ");
                }

                this.dribble = value;
            }
        }
               
        public double Passing
        {
            get
            {
                return this.passing;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Passing should be between 0 and 100. ");
                }

                this.passing = value;
            }
        }
              
        public double Shooting
        {
            get
            {
                return this.shooting;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Shooting should be between 0 and 100. ");
                }

                this.shooting = value;
            }
        }

        public double CalculateAvarageOfStatus()
        {
            double avarageStatus = (this.Endurance + 
                this.Sprint + 
                this.Dribble + 
                this.Passing + 
                this.Shooting)/LengthOfSkills;

            return avarageStatus;
        }
    }
}

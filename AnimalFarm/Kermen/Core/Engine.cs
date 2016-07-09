using System;

namespace Kermen.Core
{
    using System.Collections.Generic;
    using System.Linq;
    using Kermen.Interfaces;

    public class Engine : IEngine
    {
        private readonly List<IHome> kermen; 
        public Engine(IWriter writer, IReader reader)
        {
            this.Writer = writer;
            this.Reader = reader;
            this.Factory = new Factory();
            this.Command = new Command();
            this.kermen = new List<IHome>();
        }

        public IWriter Writer { get; }

        public IReader Reader { get; }

        public Factory Factory { get; }

        public Command Command { get; set; }

        public void Run()
        {
            string input = this.Reader.ReadLine();
            int counter = 0;
            while (input != "Democracy")
            {

                string commandName = this.Command.TakeCommandName(input);
                switch (commandName)
                {
                    case "YoungCouple":
                        IHome youngCouple = this.Factory.CreateYongCouple(input);
                        this.kermen.Add(youngCouple);
                        break;
                    case "YoungCoupleWithChildren":
                        IHome youngCoupleWithChildren = this.Factory.CreateYongCoupleWithChildren(input);
                        this.kermen.Add(youngCoupleWithChildren);
                        break;
                    case "AloneYoung":
                        IHome aloneYoung = this.Factory.CreateAloneYoung(input);
                        this.kermen.Add(aloneYoung);
                        break;
                    case "OldCouple":
                        IHome oldCouple = this.Factory.CreateOldCouple(input);
                        this.kermen.Add(oldCouple);
                        break;
                    case "AloneOld":
                        IHome aloneOld = this.Factory.CreateAloneOld(input);
                        this.kermen.Add(aloneOld);
                        break;
                }
                counter++;
                if (counter % 3 == 0)
                {
                    this.kermen.ForEach(h => h.PaySalary());
                }

                if (input == "EVN bill")
                {
                    this.kermen.RemoveAll(h => !h.IsAbleToPay);
                    this.kermen.ForEach(h => h.Bill());
                }
                else if (input == "EVN")
                {
                    this.Writer.WriteLine($"Total consumption: {this.kermen.Sum(h => h.Consumption)}");
                }


                input = this.Reader.ReadLine();
            }

            this.Writer.WriteLine($"Total population: {this.kermen.Sum(h => h.Population)}");
        }
    }
}

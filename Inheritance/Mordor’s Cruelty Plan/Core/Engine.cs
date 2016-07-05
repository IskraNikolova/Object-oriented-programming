using System;
using System.Collections;
using System.Collections.Generic;
using Mordor_s_Cruelty_Plan.Factories;
using Mordor_s_Cruelty_Plan.Foods;
using Mordor_s_Cruelty_Plan.Interfaces;
using Mordor_s_Cruelty_Plan.Moods;
using Mordor_s_Cruelty_Plan.UI;

namespace Mordor_s_Cruelty_Plan.Core
{
    public class Engine
    {
        private readonly IWriter writer;
        private readonly IReader reader;
        private readonly FoodFactory foodFactory;
        private readonly MoodFactory moodFactory;

        public Engine()
        {
            this.writer = new ConsoleWriter();
            this.reader = new ConsoleReader(); 
            this.foodFactory = new FoodFactory();
            this.moodFactory = new MoodFactory();
        }

        public void Start()
        {
            string line = this.reader.ReadLine();
            string[] data = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int points = 0;
            foreach (var element in data)
            {
                Food food = this.foodFactory.CreateFood(element);
                points += food.Points;
            }

            Mood mood = this.moodFactory.CreateMood(points);

            this.writer.WriteLine($"{points}\n{mood.GetType().Name}");
        }
    }
}

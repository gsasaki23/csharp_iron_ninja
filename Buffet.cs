using System;
using System.Collections.Generic;

namespace Iron_Ninja
{
    class Buffet
    {
        // Fields
        public List<IConsumable> Menu;

        // Constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Burger", 1000, true, false),
                new Food("Sweet & Sour Chicken Wings", 800, true, true),
                new Food("Cajun Fries", 900, true, true),
                new Drink("Soda", 1000, false),
                new Food("Salad", 200, false, false),
                new Drink("Dollar Sweet Tea", 10, false),
                new Food("Donut", 1000, false, true)
            };
        }

        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0,Menu.Count)];
        }
    }

}

using System;
using System.Collections.Generic;

namespace Iron_Ninja
{
    class SpiceHound : Ninja
    {
        // Note: no need to re-initialize calorieIntake or ConsumptionHistory because Ninja already does!
        public override bool IsFull{ get;set;}

        public SpiceHound()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
            IsFull = false;
        }

        public override void Consume(IConsumable item)
        {
            if (IsFull) 
            {
                Console.WriteLine("SpiceHound cannot eat anymore...");
                return;
            }
            // Make calorie changes
            int calorieToAdd = item.Calories;
            if (item.IsSpicy) calorieToAdd -= 5;
            calorieIntake += calorieToAdd;
            if (calorieIntake >= 1200) IsFull = true;
            // Add to history
            ConsumptionHistory.Add(item);
            // Make prints
            Console.WriteLine("SpiceHound ate:");
            Console.WriteLine(item.GetInfo());
            return;
        }
    }

}
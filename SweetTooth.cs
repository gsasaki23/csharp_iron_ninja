using System;
using System.Collections.Generic;

namespace Iron_Ninja
{
    class SweetTooth : Ninja
    {
        // Note: no need to re-initialize calorieIntake or ConsumptionHistory because Ninja already does!
        public override bool IsFull{ get;set;}

        public SweetTooth()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
            IsFull = false;
        }
        
        public override void Consume(IConsumable item)
        {
            if (IsFull) 
            {
                Console.WriteLine("SweetTooth cannot eat anymore...");
                return;
            }
            // Make calorie changes
            int calorieToAdd = item.Calories;
            if (item.IsSweet) calorieToAdd += 10;
            calorieIntake += calorieToAdd;
            if (calorieIntake >= 1500) IsFull = true;
            // Add to history
            ConsumptionHistory.Add(item);
            // Make prints
            Console.WriteLine("SweetTooth ate:");
            Console.WriteLine(item.GetInfo());
            return;
        }
    }


}
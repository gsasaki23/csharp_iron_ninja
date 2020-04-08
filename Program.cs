using System;
using System.Collections.Generic;

namespace Iron_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            SweetTooth neil = new SweetTooth();
            SpiceHound bruno = new SpiceHound();

            while(!neil.IsFull)
            {
                neil.Consume(buffet.Serve());
            }
            Console.WriteLine("SweetTooth is full...\n");
            while(!bruno.IsFull)
            {
                bruno.Consume(buffet.Serve());
            }
            Console.WriteLine("SpiceHound is full...\n");

            if (neil.ConsumptionHistory.Count > bruno.ConsumptionHistory.Count) 
            {
                Console.WriteLine($"SweetTooth ate more items, {neil.ConsumptionHistory.Count} to be exact.");
            }
            else if (neil.ConsumptionHistory.Count < bruno.ConsumptionHistory.Count) 
            {
                Console.WriteLine($"SpiceHound ate more items, {bruno.ConsumptionHistory.Count} to be exact.");
            }
            else
            {
                Console.WriteLine($"SweetTooth and SpiceHound both ate {neil.ConsumptionHistory.Count} items.");
            }


        }
    }
    public interface IConsumable
    {
        string Name { get; set; }
        int Calories { get; set; }
        bool IsSpicy { get; set; }
        bool IsSweet { get; set; }
        string GetInfo();
    }

    public abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> ConsumptionHistory;
        public Ninja()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        public abstract bool IsFull { get;set;}
        public abstract void Consume(IConsumable item);
    }

}
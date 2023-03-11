using System;
using System.Collections.Generic;

namespace UseCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kitchen = new Queue<string>();

            kitchen.Enqueue("Cheese Burger");
            kitchen.Enqueue("Pizza");
            kitchen.Enqueue("Tacos");
            kitchen.Enqueue("Club Sandwich");
            kitchen.Enqueue("Chicken Tenders");

            Console.WriteLine($"There are {kitchen.Count()} items waiting to be cooked.");
            Console.WriteLine($"Here are items waiting to be cooked.");
            foreach (var kit in kitchen)
            {
                Console.WriteLine(kit);
            }

            Console.WriteLine("Would you like to check the status of an order? (yes or no)");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                Console.WriteLine($"Enter an item to search for: ");
                string orderItem = Console.ReadLine();
                if (kitchen.Contains(orderItem))
                {
                    Console.WriteLine("That item is waiting to be cooked!");
                }
                else
                {
                    Console.WriteLine("I am sorry, that order is not in the queue.");
                }
                Console.WriteLine("Would you like to enter another item? (yes or no)");
                answer = Console.ReadLine();
            }

            string firstOrder = kitchen.Peek();
            Console.WriteLine($"Would you like to cook and serve {firstOrder} (yes or no)?");
            string result = Console.ReadLine();
            while (result == "yes")
            {
                kitchen.Dequeue();
                firstOrder = kitchen.Peek();
                Console.WriteLine($"Would you like to cook and serve {firstOrder} (yes or no)?");
                result = Console.ReadLine();
            }

            if (kitchen.Peek() == null)
                Console.WriteLine("All orders have been processed.");
            else
                Console.WriteLine($"You have {kitchen.Count} item(s) left to cook.");
        }
    }
}
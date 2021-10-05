using System;
using System.Collections.Generic;
using System.Linq;


namespace AronGibsonLab7ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,double> items = new Dictionary<string,double>();
            List<string> userItems = new List<string>();
            List<double> prices = new List<double>();
            items.Add("pringles",1.99);
            items.Add("gasoline",3.5);
            items.Add("chocolate covered honeybun",1);
            items.Add("monster",2.50);
            items.Add("soda",1.50);
            items.Add("red bull",3.39);
            items.Add("baja blast",1.89);
            items.Add("protein bar",3);
            items.Add("tall boy",2.50);
            items.Add("chex mix",3.20);
            items.Add("hot cheeto puffcorn",2);
            items.Add("reeses",3.5);

            string again ="y" ;
            do
            {


                foreach (KeyValuePair<string, double> item in items)
                {
                    Console.WriteLine($"{item.Key}  {item.Value}");
                }

                Console.WriteLine("Enter item.");
                string userInput = Console.ReadLine().ToLower().Trim();
                if (!items.ContainsKey(userInput))
                {
                    Console.WriteLine("No such item");
                    continue;
                }

                userItems.Add(userInput);
                prices.Add(items.GetValueOrDefault(userInput,0) );
                Console.WriteLine($"added {userInput} for {items.GetValueOrDefault(userInput, 0)}$");

                do{
                    Console.WriteLine("add more items? y or n");
                    again = Console.ReadLine().Trim().ToLower();
                    if (again == "y")
                        break;
                    else if (again == "n")
                        break;
                    Console.WriteLine("Invalid");
                } while (true);

            } while (again=="y");


            Console.WriteLine("Item        price");
            Console.WriteLine("==========   =============");
            for (int i = 0; i < userItems.Count; i++)
            {
                Console.WriteLine($"{userItems[i]}          {prices[i]}$");
            }
            Console.WriteLine("========================================");
            Console.WriteLine($"average price = {prices.Average()}$");
        }
    }
}

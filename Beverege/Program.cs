using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beverege;
using Beverege.Dispensers;

public class Drinks_Service
{
    public static void Main(string[] args)
    {
        DrinkDispenser order;

        string selectedBeverage = "";

        while (true)
        {
            Console.WriteLine($"Choose the type of beverage you want to order: \n1 - Coffee(45)\n2 - Tea(30)");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                selectedBeverage = "Coffee";
                order = new Coffee();
                break;
            }
            else if (choice == "2")
            {
                selectedBeverage = "Tea";
                order = new Tea();
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose 1 or 2");
            }
        }

        while (true)
        {
            Console.WriteLine("Choose the number of cups: ");
            if (int.TryParse(Console.ReadLine(), out int cupsCount) && cupsCount > 0)
            {
                if (selectedBeverage == "Coffee" && order is Coffee coffeeBeverage)
                {
                    if (cupsCount > 0)
                    {
                        int totalCost = coffeeBeverage.Price * cupsCount;
                        Console.WriteLine($"Total cost for {cupsCount} Coffee is {totalCost}. Help yourself! :)");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\"Invalid input. Please enter a number greater than 0.\"");
                    }
                }
                else if (selectedBeverage == "Tea" && order is Tea teaBeverage)
                {
                    if (cupsCount > 0)
                    {
                        int totalCost = teaBeverage.Price * cupsCount;
                        Console.WriteLine($"Total cost for {cupsCount} Tea is {totalCost}. Help yourself! :)");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\"Invalid input. Please enter a number greater than 0.\"");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
    }
}
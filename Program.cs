/*
* Author: Sheetal Rana
* Date: 13 Feburary 2025
* Project: Assignment 2 : Task_1
* Description: Program that take information from the unlimited number of customers for Electrician. At the end,
the information is displayed back to the electrician.
*
*/

namespace AssignmentTwoTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Asking user for customer details and processing
                while (true)
                {
                    try
                    {
                        // Get Customer Name
                        string name;
                        while (true)
                        {
                            Console.Write("Enter Customer Name: ");
                            name = Console.ReadLine();
                            if (!string.IsNullOrEmpty(name)) break;
                            Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                        }

                        // Select Building Type
                        string type;
                        while (true)
                        {
                            Console.WriteLine("Select Building Type (House, Barn, Garage): ");
                            type = Console.ReadLine().ToLower();
                            if (type == "house" || type == "barn" || type == "garage") break;
                            Console.WriteLine("Invalid input. Please enter House, Barn, or Garage.");
                        }

                        // Get Building Size
                        int size;
                        while (true)
                        {
                            Console.Write("Enter Building Size (1000 - 50000 sqft): ");
                            if (int.TryParse(Console.ReadLine(), out size) && size >= 1000 && size <= 50000) break;
                            Console.WriteLine("Invalid size. Please enter a value between 1000 and 50000.");
                        }

                        // Get Number of Bulbs
                        int bulbs;
                        while (true)
                        {
                            Console.Write("Enter Number of Bulbs (Max 20): ");
                            if (int.TryParse(Console.ReadLine(), out bulbs) && bulbs >= 0 && bulbs <= 20) break;
                            Console.WriteLine("Invalid number. Enter a value between 0 and 20.");
                        }

                        // Get Number of Outlets
                        int outlets;
                        while (true)
                        {
                            Console.Write("Enter Number of Outlets (Max 50): ");
                            if (int.TryParse(Console.ReadLine(), out outlets) && outlets >= 0 && outlets <= 50) break;
                            Console.WriteLine("Invalid number. Enter a value between 0 and 50.");
                        }

                        // Get 16-digit Credit Card Number
                        string creditCard;
                        while (true)
                        {
                            Console.Write("Enter 16-digit Credit Card Number: ");
                            creditCard = Console.ReadLine();
                            if (creditCard.Length == 16 && long.TryParse(creditCard, out _)) break;
                            Console.WriteLine("Invalid credit card. Enter exactly 16 digits.");
                        }

                        // Display Summary Information
                        Console.WriteLine("\n--- Customer Summary ---");
                        Console.WriteLine($"Name: {name}");
                        Console.WriteLine($"Building Type: {type}");
                        Console.WriteLine($"Building Size: {size} sqft");
                        Console.WriteLine($"Bulbs: {bulbs}");
                        Console.WriteLine($"Outlets: {outlets}");
                        Console.WriteLine($"Credit Card: {creditCard.Substring(0, 4)} XXXX XXXX {creditCard.Substring(12)}");

                        // Perform tasks based on building type using switch-case
                        switch (type)
                        {
                            case "house":
                                Console.WriteLine("Installing fire alarms.");
                                break;
                            case "barn":
                                Console.WriteLine("Wiring milking equipment.");
                                break;
                            case "garage":
                                Console.WriteLine("Installing automatic doors.");
                                break;
                            default:
                                Console.WriteLine("Invalid building type.");
                                break;
                        }

                        // Ask if the user wants to continue
                        Console.Write("Do you want to enter another customer? (yes/no): ");
                        string response = Console.ReadLine().ToLower();
                        if (response != "yes")
                        {
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any unexpected errors
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
        }
    }
}

/*
* Author: Sheetal Rana
* Date: 13 Feburary 2025
* Project: Assignment 2 : Task_1
* Description: Program that take information from the unlimited number of customers for Electrician. At the end,
the information is displayed back to the electrician.
*
*/

using System;

namespace AssignmentTwoTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string allCustomerDetails = ""; // To store all customer details

            // Asking user for customer details and processing
            while (true)
            {
                try
                {
                    string name = GetCustomerName();
                    string type = GetBuildingType();
                    int size = GetBuildingSize();
                    int bulbs = GetNumberOfBulbs();
                    int outlets = GetNumberOfOutlets();
                    string creditCard = GetCreditCardNumber();

                    string customerDetails = GetCustomerDetails(name, type, size, bulbs, outlets, creditCard);
                    allCustomerDetails += customerDetails + "\n\n\n"; // Append current customer details
                    
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

            // Display all customer details at the end
            Console.WriteLine("\n--- All Customer Details ---");
            Console.WriteLine(allCustomerDetails);
        }

        static string GetCustomerName()
        {
            while (true)
            {
                Console.Write("Enter Customer Name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                    continue;
                }

                bool isValid = true;
                foreach (char c in name)
                {
                    if (!char.IsLetter(c))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    return name;
                }
                else
                {
                    Console.WriteLine("Name should contain alphabets only. Please enter a valid name.");
                }
            }
        }

        static string GetBuildingType()
        {
            while (true)
            {
                Console.WriteLine("Select Building Type (House, Barn, Garage): ");
                string type = Console.ReadLine().ToLower();
                if (type == "house" || type == "barn" || type == "garage") return type;
                Console.WriteLine("Invalid input. Please enter House, Barn, or Garage.");
            }
        }

        static int GetBuildingSize()
        {
            while (true)
            {
                Console.Write("Enter Building Size (1000 - 50000 sqft): ");
                try
                {
                    int size = int.Parse(Console.ReadLine());
                    if (size >= 1000 && size <= 50000) return size;
                    Console.WriteLine("Invalid size. Please enter a value between 1000 and 50000.");
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        static int GetNumberOfBulbs()
        {
            while (true)
            {
                Console.Write("Enter Number of Bulbs (Max 20): ");
                try
                {
                    int bulbs = int.Parse(Console.ReadLine());
                    if (bulbs >= 0 && bulbs <= 20) return bulbs;
                    Console.WriteLine("Invalid number. Enter a value between 0 and 20.");
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        static int GetNumberOfOutlets()
        {
            while (true)
            {
                Console.Write("Enter Number of Outlets (Max 50): ");
                try
                {
                    int outlets = int.Parse(Console.ReadLine());
                    if (outlets >= 0 && outlets <= 50) return outlets;
                    Console.WriteLine("Invalid number. Enter a value between 0 and 50.");
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        static string GetCreditCardNumber()
        {
            while (true)
            {
                Console.Write("Enter 16-digit Credit Card Number: ");
                string creditCard = Console.ReadLine();
                if (creditCard.Length == 16 && long.TryParse(creditCard, out _)) return creditCard;
                Console.WriteLine("Invalid credit card. Enter exactly 16 digits.");
            }

        }

        static string GetCustomerDetails(string name, string type, int size, int bulbs, int outlets, string creditCard)
        {
            string customerDetails = $"Customer Name: {name}, Building Type: {type}, Size: {size} sqft, {bulbs} bulbs, {outlets} outlets, Credit Card No.: {creditCard.Substring(0, 4)} XXXX XXXX {creditCard.Substring(12)}, Special Task: {GetSpecialTask(type)}, Common Tasks: Create wiring schemas and Purchase necessary parts.";
            return customerDetails;
        }

        static string GetSpecialTask(string type)
        {
            switch (type)
            {
                case "house":
                    return "Installing fire alarms";
                case "barn":
                    return "Wiring milking equipment";
                case "garage":
                    return "Installing automatic doors";
                default:
                    return "Invalid building type";
            }
        }
    }
}
        
       
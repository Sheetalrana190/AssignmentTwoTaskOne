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
            int size = 0;
            int bulbs = 0;
            int outlets = 0;

            // Enter the name of customer
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            // Enter information of type of building
            Console.WriteLine("Select Building Type (0: House, 1: Barn, 2: Garage): ");
            int typeInput = int.Parse(Console.ReadLine());
            if ((typeInput == 0 ) || (typeInput == 1) || (typeInput == 2))
            {
                if (typeInput == 0)
                {
                    Console.WriteLine("House");
                }
                if (typeInput == 1)
                {
                    Console.WriteLine("Barn");
                }
                if (typeInput == 2)
                {
                    Console.WriteLine("Garage");
                }
            }
            else
            {
                Console.Write("Invalid input. Please enter 0 (House), 1 (Barn), or 2 (Garage): ");
            }
            // Get Building Size
            
            Console.Write("Enter Building Size (1000 - 50000 sqft): ");
            size = int.Parse(Console.ReadLine());
            if (size >= 1000 && size <= 50000)
            { 
                return;
            }
            else
                Console.Write("Invalid size. Please enter a value between 1000 and 50000: ");

            // Get Number of Bulbs
            
            Console.Write("Enter Number of Bulbs (Max 20): ");
            bulbs = int.Parse(Console.ReadLine());
            if (bulbs >= 0 && bulbs <= 20)
            {
                return;
            }
            else
                Console.Write("Invalid number. Enter a value between 0 and 20: ");

            // Get Number of Outlets
            
            Console.Write("Enter Number of Outlets (Max 50): ");
            outlets = int.Parse(Console.ReadLine());
            if (outlets >= 0 && outlets <= 50)
            {
                return; 
            }
            else
                Console.Write("Invalid number. Enter a value between 0 and 50: ");
            // Get 16-digit Credit Card Number
            string creditCard;
            Console.Write("Enter 16-digit Credit Card Number: ");
            while (true)
            {
                creditCard = Console.ReadLine();
                if (creditCard.Length == 16 && long.TryParse(creditCard, out _))
                    break;
                Console.Write("Invalid credit card. Enter exactly 16 digits: ");
            }

        }
    }
}

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
                if (typeInput == 1)
                {
                    Console.WriteLine("Garage");
                }
            }
            else
            {
                Console.Write("Invalid input. Please enter 0 (House), 1 (Barn), or 2 (Garage): ");
            }

        }
    }
}

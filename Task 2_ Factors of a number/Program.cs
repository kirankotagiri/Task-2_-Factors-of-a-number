using System;


namespace Task_2__Factors_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Pseudocode
               1. Start
               2. Declare variable number
               3. Accept number from user
               4. Print "Factors of number are:"
               5. Loop from i = 1 to number
               6. Check if i is a factor of number
               7. If yes, print i
               8. End*/


            // Declare variable to hold the user's input
            int number;


            // Prompt user for input
            Console.Write("Enter a number to display all the factors of that number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factors of {0} are:", number);

            // Find factors using loop
            for (int i = 1; i <= number; i++) 
            {

                // Check if i is a factor of the number
                if (number % i == 0)

                {
                    // Display the factor
                    Console.WriteLine(i);

                }
               
            }

            Console.ReadLine();

        }
    }
}

using System;

namespace HigherNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HigherNumber");
            int number = 0;
            int higherNumber = int.MinValue; //smallest possible int like -300 million
            do
            {
                Console.WriteLine("Please enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number > higherNumber)
                {
                    higherNumber = number;
                }
            } while (number != 0);
            Console.WriteLine("From all the numbers that you have been entered, the higher number is:" + higherNumber);
            Console.ReadKey();
        }
    }
}

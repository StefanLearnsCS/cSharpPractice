using System.Globalization;
using System.Numerics;

namespace Exercise
{
  class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of array: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[num];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            
            int result = SumOfNumbers(numbers);

            if (result > -1)
            {
                Console.WriteLine($"Sum is {result}");
            }
            else
            {
                Console.WriteLine("Error: Empty array.");
            }
        }

        static int SumOfNumbers(int[] numArray)
        {
            if (numArray.Length < 1) 
            {
                return -1;
            }

            int total = 0;
            foreach (int item in numArray)
            {
                total += item;
            }

            return total;
        }
    }
}
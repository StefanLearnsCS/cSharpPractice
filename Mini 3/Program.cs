using System.Transactions;

namespace exercise
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Put number for times table: ");
            string input = Console.ReadLine();

            bool success = false;

            while (!success)
            {
                if (int.TryParse(input, out int num))
                {
                    success = true;
                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine("{0} x {1} = {2}", i, num, i * num );
                    }
                }
                else
                {
                    Console.Write("Invalid, put new number:");
                    input = Console.ReadLine();
                }
            }
            
        }
    }
}
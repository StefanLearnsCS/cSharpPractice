namespace Exercise
{
  class Program 
    {
        static void Main(string[] args)
        {
            bool threeDiv;
            bool fiveDiv;

            for (int i = 1; i <= 15; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;
                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
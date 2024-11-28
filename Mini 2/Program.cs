namespace Exercise
{
  class Program 
    {
        static void Main(string[] args)
        {
            int num1 = 26;
            int num2 = 4;
            int remainder = num1 % num2;

            Console.WriteLine(remainder);

            num2 = 7;

            remainder = num1 % num2;

            Console.WriteLine(remainder);
        }
    }
}
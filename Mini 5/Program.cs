namespace Exercise
{
  class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password: ");
            string pw1 = Console.ReadLine();
            Console.Write("Enter password again: ");
            string pw2 = Console.ReadLine();
            Console.WriteLine();

            if (!String.IsNullOrEmpty(pw1) && !String.IsNullOrEmpty(pw2))
            {
                if (pw1.Equals(pw2))
                {
                    Console.WriteLine("Match");
                }
                else
                {
                    Console.WriteLine("No match");
                }
            }
            else
            {
                Console.WriteLine("Missed input");
            }

        }
    }
}
namespace Exercise
{
  class Program 
    {
        static void Main(string[] args)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0) 
                {
                    even.Add(i);
                }
                else {
                    odd.Add(i);
                }
            }

            foreach (var item in even)
            {
                Console.WriteLine(item);
            }
            foreach (var item in odd)
            {
                Console.WriteLine(item);
            }


        }
    }
}
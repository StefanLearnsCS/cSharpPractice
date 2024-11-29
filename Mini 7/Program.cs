namespace Exercise
{
  class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Give a length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] numarray = new int[length];

            for (int i = 1; i <= numarray.Length; i++)
            {
                numarray[i-1] = num * i;
            }

            foreach (var item in numarray)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
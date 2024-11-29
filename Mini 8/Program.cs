namespace Exercise
{
  class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Triangle Height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Triangle Width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int area = calculateArea(height, width);

            Console.Write($"Triangle Area is: {area}");
        }

        static int calculateArea(int height, int width)
        {
            return height*width/2;
        }
    }
}
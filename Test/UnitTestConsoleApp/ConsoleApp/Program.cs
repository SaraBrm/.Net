using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MathHelper mathHelper = new MathHelper();
            while (true)
            {
                Console.WriteLine("X ra Vared Kind...");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Y ra Vared Kind...");
                int y = Convert.ToInt32(Console.ReadLine());

                var result = mathHelper.Jam(x, y);
                Console.WriteLine($"X:{x} + Y:{y} = {result}");
            }

            Console.ReadLine();
        }
    }
}

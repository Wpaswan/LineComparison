using System;
//using System.Math;
using static System.Math;

namespace LINE

{
    class Program1

    {
        public static void Main(string[] args)
        {
            //user Input
            Console.Write("Enter any  value x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            if (x1 == x2 && y1 == y2)
            {
                Console.WriteLine("Two lines are equal");
            }
            else
            {
                Console.WriteLine("Two lines are not equal");
            }


            Console.ReadKey();
        }
    }


}

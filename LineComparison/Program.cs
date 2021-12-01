using static System.Math;

namespace LINECOMPARISION
{
    class Program

    {


        //user Input

        public static void Main(string[] args)
        {
            //Cordinates of first line
            Console.Write("Enter any  value x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            //Cordinates of second line
            Console.Write("Enter any  value X1: ");
            double X1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value X2: ");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value Y1: ");
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value Y2: ");
            double Y2 = Convert.ToDouble(Console.ReadLine());

            double d1 = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
            double d2 = Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1));

            int distance = d1.CompareTo(d2);
            Console.WriteLine("Length of first line:"+d1);
            Console.WriteLine("Length of second line:"+d2);
            // checking the status
            if (distance > 0)
                Console.WriteLine("line 1 is greater than line 2");
            else if (distance < 0)
                Console.WriteLine("line 1 is less than line 2");
            else
                Console.WriteLine("line 1 is equal to line 2");


            Console.ReadKey();
        }


    }
}
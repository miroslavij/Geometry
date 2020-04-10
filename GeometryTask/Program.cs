using GeometryTask.Implementation;
using System;

namespace GeometryTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure fig = new Triangle(3.0,4.0,5.0);

            Figure cir = new Circle(10.0);

            double res1 = cir.GetSquare();
            double res2 = fig.GetSquare();

            Console.WriteLine((res1 == res2) ? "true" : "false");
            Console.WriteLine(res1);
            Console.ReadKey();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Calculate the distance between 3 points--------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("---------Distance 1 Points A y B--------");
            Console.WriteLine("Input the coordinate x1: ");
            var x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the coordinate x2: ");
            var x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the coordinate y1: ");
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the coordinate y2: ");
            var y2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            
            var d1 = Math.Round(CalculateDistanceBetween2Points(x1, y1, x2, y2), 2);

            Console.WriteLine("---------Distancia 1 Puntos A y C--------");
            Console.WriteLine("Input the coordinate x1: ");
            var ACx1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the coordinate x2: ");
            var ACx2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the coordinate y1: ");
            var ACy1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the coordinate y2: ");
            var ACy2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            var d2 = Math.Round(CalculateDistanceBetween2Points(ACx1, ACy1, ACx2, ACy2), 2);

            Console.WriteLine("---------Distancia 1 Puntos B y C--------");
            Console.WriteLine("Input the coordinate x1: ");
            var BCx1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the coordinate x2: ");
            var BCx2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the coordinate y1: ");
            var BCy1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the coordinate y2: ");
            var BCy2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
               
            var d3 = Math.Round(CalculateDistanceBetween2Points(BCx1, BCy1, BCx2, BCy2), 2);

            var DistanciaTotal = (d1 + d2 + d3) / 3;

            Console.WriteLine("The distance between the 3 points is: " + DistanciaTotal);
            Console.ReadLine();
        }

        private static double CalculateDistanceBetween2Points(double x1, double y1, double x2, double y2)
        {
            double d1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return d1;
        }
    }
}

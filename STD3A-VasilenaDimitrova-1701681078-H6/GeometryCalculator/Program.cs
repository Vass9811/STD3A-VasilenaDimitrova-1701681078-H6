using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option (triangle, square or radiant)");
            string answer = Console.ReadLine();
            switch(answer)
            {
                case "triangle":
                    Triangle();
                    break;
                case "square":
                    Square();
                    break;
                case "radiant":
                    Radiant();
                    break;
            }
          
        }
        static void Triangle()
        {
            Console.WriteLine("Enter side:");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height:");
            double height = double.Parse(Console.ReadLine());
            double area = (side * height) / 2;
            double roundedarea = Math.Round(area, 2);
            Console.WriteLine("The area of the triangle is:{0}",roundedarea);
        }
        static void Square()
        {
            Console.WriteLine("Enter side:");
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            double roundedarea = Math.Round(area, 2);
            Console.WriteLine("The area of the square is:{0}",roundedarea);
        }
        static void Radiant()
        {
            Console.WriteLine("Enter the degrees you want to transform to radiants");
            double degrees = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double result = (pi / 180) * degrees;
            Console.WriteLine("Your degrees in radiants are = {0}",result);
        }
    }
}

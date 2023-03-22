using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.NewClasses
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(string name, string color, int[] position, int radius) : base(name, color, position)
        {
            Radius = radius;
        }

        public override void GetArea()
        {
            double area = 3.14 * Radius * Radius;
            Console.WriteLine($"The area of the circle is {area}");
        }

        public override void GetPerimeter()
        {
            double perimeter = 2 * 3.14 * Radius;
            Console.WriteLine($"The perimeter of the circle is {perimeter}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.NewClasses
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public Rectangle(string name, string color, int[] position, int sideA, int sideB) : base(name, color, position)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override void GetArea()
        {
            int area = SideA * SideB;
            Console.WriteLine($"The area of the rectangle is {area}");
        }

        public override void GetPerimeter()
        {
            int perimeter = 2 * (SideA + SideB);
            Console.WriteLine($"The perimeter of the rectangle is {perimeter}");
        }
    }
}
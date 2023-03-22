using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.NewClasses
{
    public class Shape
    {
        private string _name;
        private string _color;
        public int[] Position { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name cannot be null or whitespace");
                    return;
                }
                Console.WriteLine($"Setting the name of the shape to {value}");
                _name = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Color cannot be null or whitespace");
                    return;
                }
                Console.WriteLine($"Setting the color of the shape to {value}");
                _color = value;
            }
        }

        public Shape(string name, string color, int[] position)
        {
            Name = name;
            Color = color;
            Position = position;
        }

        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for area.");
        }

        public virtual void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter.");
        }

        public void Move(Shape shape)
        {
            shape.Position[0] += 5;
            shape.Position[1] += 5;
            Console.WriteLine($"{shape.Name} moved to position ({shape.Position[0]}, {shape.Position[1]})");
        }
    }
}
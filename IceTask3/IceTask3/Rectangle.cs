using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    // Rectangle class implementing IShape and extending Shape
    class Rectangle : Shape, IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        // Constructor
        public Rectangle(string name, double length, double width) : base(name)
        {
            Length = length;
            Width = width;
        }

        // Implement Calculate Area Method
        public double CalculateArea()
        {
            return Length * Width;
        }

        // Override Display Method
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Length: {Length}, Width: {Width}, Area: {CalculateArea()}");
        }
    }
}

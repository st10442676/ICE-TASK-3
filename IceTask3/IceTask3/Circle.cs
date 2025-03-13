using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    // Circle class implementing IShape and extending Shape
    class Circle : Shape, IShape
    {
        public double Radius { get; set; }

        // Constructor
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        // Implement Calculate Area Method
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Override Display Method
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Radius: {Radius}, Area: {CalculateArea():F2}");
        }
    }
}

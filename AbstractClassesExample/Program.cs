// See https://aka.ms/new-console-template for more information
using System;

namespace AbstractClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Abstract Classes and Methods:");
            
            // Create circle with radius 5
            Circle circle = new Circle(5);
            Console.WriteLine($"\nCircle area: {circle.GetArea():F2}");
            
            // Create rectangle with width 4 and height 6
            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
            
        }
    }
}

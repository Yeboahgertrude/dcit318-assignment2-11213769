// See https://aka.ms/new-console-template for more information
using System;

namespace InterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Interfaces:");
            
            // Create and move car
            Car car = new Car();
            Console.WriteLine("\nCar movement:");
            car.Move();
            
            // Create and move bicycle
            Bicycle bicycle = new Bicycle();
            Console.WriteLine("\nBicycle movement:");
            bicycle.Move();
            
            // Polymorphism demonstration
            Console.WriteLine("\nPolymorphism demonstration:");
            IMovable[] movables = new IMovable[] { car, bicycle };
            foreach (var movable in movables)
            {
                movable.Move();
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

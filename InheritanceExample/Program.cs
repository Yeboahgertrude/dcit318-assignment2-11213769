// See https://aka.ms/new-console-template for more information
using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Inheritance and Method Overriding:");
            
            // Base class
            Animal animal = new Animal();
            Console.WriteLine("Animal sound:");
            animal.MakeSound();
            
            // Derived classes
            Dog dog = new Dog();
            Console.WriteLine("\nDog sound:");
            dog.MakeSound();
            
            Cat cat = new Cat();
            Console.WriteLine("\nCat sound:");
            cat.MakeSound();
            
            // Polymorphism demonstration
            Console.WriteLine("\nPolymorphism demonstration:");
            Animal myAnimal = new Dog();
            myAnimal.MakeSound();
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

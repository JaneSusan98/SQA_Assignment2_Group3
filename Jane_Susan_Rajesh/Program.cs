using System;

namespace Jane_Susan_Rajesh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            int radius = 0;
            while (!Int32.TryParse(Console.ReadLine(), out radius) || radius < 1)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the radius:");
            }

            Circle circle = new Circle(radius);

            int choice;
            do
            {
                Console.WriteLine("1. Get Circle Radius");
                Console.WriteLine("2. Change Circle Radius");
                Console.WriteLine("3. Get Circle Circumference");
                Console.WriteLine("4. Get Circle Area");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice:");

                while (!Int32.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5:");
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The radius of the circle is: " + circle.GetRadius());
                        break;
                    case 2:
                        Console.WriteLine("Enter the new radius of the circle:");
                        int newRadius = 0;
                        while (!Int32.TryParse(Console.ReadLine(), out newRadius) || newRadius < 1)
                        {
                            Console.WriteLine("Invalid input. Please enter a positive integer for the radius:");
                        }
                        circle.SetRadius(newRadius);
                        break;
                    case 3:
                        Console.WriteLine("The circumference of the circle is: " + circle.GetCircumference());
                        break;
                    case 4:
                        Console.WriteLine("The area of the circle is: " + circle.GetArea());
                        break;
                }
            } while (choice != 5);
        }
    }
}

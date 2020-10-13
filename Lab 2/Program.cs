using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.CompilerServices;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            Console.WriteLine("Hello and welcome to the room size calculator!");
            do
            {
                double roomLength;
                double roomWidth;
                double roomHeight;
                Console.WriteLine("Enter the Length of your room in inches:");
                roomLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Width of your room in inches:");
                roomWidth = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of your room in inches:");
                roomHeight = double.Parse(Console.ReadLine());
                double perimeter = (2 * (roomLength + roomWidth));
                double area = (roomLength * roomWidth);
                double volume = (roomLength * roomWidth * roomHeight);
                Console.WriteLine($"Your room perimeter is {perimeter} inches");
                Console.WriteLine($"Your room area is {area} inches");
                Console.WriteLine($"The volume of your room is {volume} cubic inches");
                Console.WriteLine("Would you like to calculate another room? (y/n?)");
                response = Console.ReadLine();
            } while (response.ToLower() == "y");





        }
    }
}

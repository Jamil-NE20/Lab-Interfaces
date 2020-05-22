using System;
using System.Collections.Generic;

namespace Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Redius value: ");
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            Console.Write("Enter the Width value: ");
            var width = int.Parse(Console.ReadLine());

            Console.Write("Enter the Height value: ");
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);

            Console.WriteLine("\n//Drawing as below// \n");


            Console.WriteLine("\n Circle \n");
            circle.Draw();
            
            Console.WriteLine("\n Rectangle \n");
            rect.Draw();


            Console.WriteLine("\nAny Key to Quit!");
            Console.ReadLine();

        }
    }
}

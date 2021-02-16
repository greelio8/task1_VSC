using System;

namespace Geometry
{
     class Program
     {
          static void Main(string[] args) {
               Rectangle rect = new Rectangle(1, 5);
               Circle circle = new Circle(5);

               Console.WriteLine(rect.Area());
               Console.WriteLine(circle.Radius);
          }
     }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
     class Rectangle
     {
          public int Width { get; set; }
          public int Height { get; set; }

          public Rectangle(int width, int height) 
          {
               this.Width = width;
               this.Height = height;
          }

          public int Area() {
               return Width * Height;
          }
     }
}

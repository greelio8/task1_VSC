using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
     class Rectangle
     {
          public int width { get; set; }
          public int height { get; set; }

          public Rectangle(int width, int height) 
          {
               this.width = width;
               this.height = height;
          }

          public int Area() {
               return width * height;
          }
     }
}

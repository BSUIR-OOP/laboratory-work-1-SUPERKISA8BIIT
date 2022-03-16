using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    static class ListOfFigures
    {
       public static Circle circle
        {

            get
            {
                Circle c = new Circle(0, 0, 200, 200);
                return c;
            }
        }

   public  static   Ellipse ellipse
        {
            get
            {
                Ellipse e = new Ellipse(200, 0, 300, 150);
                return e;
            }
        }

   public  static   Line line
       {
            get
            {
              Line l = new Line(200, 300, 300, 150);
                return l;
            }
         }

     public static   Rhombus rhombus
        {
            get => new Rhombus(400, 250, 300, 150);
        }

       public static Square square
        {
            get
            {
                Square s = new Square(500, 0, 300, 150);
                return s;
            }
        }
       public static Triangle triangle
        {
            get
            {
                Triangle t = new Triangle(0, 200, 200, 200);
                return t;
            }
        }
    }
}

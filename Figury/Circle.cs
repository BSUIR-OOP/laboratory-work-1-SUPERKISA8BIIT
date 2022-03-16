using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    class Circle: Figure
    {
        
        public string circle_file = "circle.png";
        public override string fileName => "circle.png";
        public Circle(int x, int y, int width, int height) : base(x, y, width, height) { }
    }
}

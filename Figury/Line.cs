using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    class Line: Figure
    {
        public string line_file = "line.png";
        public override string fileName => "line.png";
        public Line(int x, int y, int width, int height) : base(x, y, width, height) { }
    }
}

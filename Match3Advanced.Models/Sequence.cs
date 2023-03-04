using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models
{
    public class Sequence
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        
        public int GetX2()
        {
            return width + X;
        }

        public int GetY2()
        {
            return height + Y;
        }
    }
}

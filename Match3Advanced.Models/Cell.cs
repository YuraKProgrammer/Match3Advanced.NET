using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models
{
    public class Cell
    {
        public Chip Chip { get; set; }

        public bool IsBlocked { get; set; }
    }
}

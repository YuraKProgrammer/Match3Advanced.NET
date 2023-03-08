using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models
{
    public class Purpose
    {
        public IPurposable Purposable { get; set; }

        public int Count { get; set; }

        public Purpose(IPurposable purposable, int count)
        {
            Purposable = purposable;
            Count = count;
        }
    }
}

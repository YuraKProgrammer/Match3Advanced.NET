﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models
{
    public class Cell
    {
        public IOnField OnField { get; set; }

        public Cell(IOnField onField)
        {
            OnField = onField;
        }
    }
}

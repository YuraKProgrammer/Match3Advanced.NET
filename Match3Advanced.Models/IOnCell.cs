﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models
{
    public interface IOnCell : IOnObject , IPurposable
    {
        public string FileName { get; set; }
    }
}

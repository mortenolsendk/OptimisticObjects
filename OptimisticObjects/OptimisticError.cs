﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimisticObjects
{
    public class OptimisticError
    {
        public string Title { get; set; }
        public string Key { get; set; }
        public bool Breaking { get; set; }
    }
}

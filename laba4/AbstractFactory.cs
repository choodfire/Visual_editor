﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    public abstract class AbstractFactory
    {
        public abstract Base createShape(string shape);
    }
}

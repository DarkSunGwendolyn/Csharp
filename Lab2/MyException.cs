﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class MyException : Exception
    {
        public MyException(string message) : base(message) { }
    }
}

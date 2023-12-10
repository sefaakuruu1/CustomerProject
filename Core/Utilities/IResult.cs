﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public interface IResult
    {
        bool Success { get; } //readonly=sadece constructor anda atama yapılır.
        string Message { get; }
    }
}

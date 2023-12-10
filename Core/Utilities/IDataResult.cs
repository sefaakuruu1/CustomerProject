﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public interface IDataResult<T> :IResult  //implemente edilen inrterface in success ve message ını kullanabiliriz
    {
        T Data { get; }
    }
}

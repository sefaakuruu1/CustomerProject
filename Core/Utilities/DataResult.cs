using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success,string message):base(message,true)
        {
            Data = data;
        }
        public DataResult(T data , bool success) : base(true)
        {
            Data = data;
        }
        public T Data { get; }

        public bool Success { get; }

        public string Message { get;
        }
    }
}

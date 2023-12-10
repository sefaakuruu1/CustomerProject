using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {
            Data = data;
        }
        public SuccessDataResult(T data):base(data,true)
        {
            Data = data;
        }
        public SuccessDataResult(string message):base(default,true,message)
        {
           }
        public T Data { get; }
    }
}

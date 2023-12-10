using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data,string message):base(data,false,message){
            Data = data;
        }
        public ErrorDataResult(T data) : base(data,false) {
            Data = data;
      }

        public ErrorDataResult(string message) : base(default,false,message) { }
        
        public ErrorDataResult() : base(default, true) { }

        public T Data { get; }
    }
}

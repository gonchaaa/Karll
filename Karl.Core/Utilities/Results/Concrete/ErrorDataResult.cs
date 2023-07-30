using Karl.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Core.Utilities.Results.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>,IDataResult<T>
    {
        public ErrorDataResult(T data, bool success, string message) : base(data, false, message)
        {
        }
        public ErrorDataResult(T data, bool success) : base(data, false)
        {
        }
    }
}

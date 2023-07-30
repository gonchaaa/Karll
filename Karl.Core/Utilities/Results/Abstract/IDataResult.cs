using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Core.Utilities.Results.Abstract
{
    public interface IDataResult<T>
    {
        public T Data { get; }
    }
}

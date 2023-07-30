﻿using Karl.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>,IDataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data,true, message)
        {
        }
        public SuccessDataResult(T data) : base(data, true)
        {
        }
    }
}

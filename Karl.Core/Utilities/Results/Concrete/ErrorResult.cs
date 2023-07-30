using Karl.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Core.Utilities.Results.Concrete
{
    public class ErrorResult : Result,IResult
    {
        public ErrorResult(string message) : base(false,message)
        {
        }
        public ErrorResult():base(false)
        {
        }
    }
}

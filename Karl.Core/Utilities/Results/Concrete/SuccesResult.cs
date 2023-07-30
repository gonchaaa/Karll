using Karl.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Core.Utilities.Results.Concrete
{
    public class SuccesResult : Result,IResult
    {
        public SuccesResult(string message) : base(true,message)
        {
        }
        public SuccesResult() : base(true)
        {
        }
    }
}

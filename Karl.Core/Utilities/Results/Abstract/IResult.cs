using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Core.Utilities.Results.Abstract
{
    public interface IResult
    {
        //set yoxdur. cunki sonra elave olunmasini istemirik. constructor vasitesile edeciyik
        public bool Success { get; }
        public string Message { get; }
    }
}

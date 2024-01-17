using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Exceptions
{
    internal class LessThanZeroException : ArgumentOutOfRangeException
    {
        public LessThanZeroException(object? actualValue, string parameterName) 
            : base(parameterName, actualValue, "Parameter must be greater than zero")
        {
            
        }
    }
}

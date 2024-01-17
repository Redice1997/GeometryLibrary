using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Exceptions
{
    internal class GeometryException : Exception
    {
        public GeometryException(string? message = null) : base(message)
        {
            
        }
    }
}

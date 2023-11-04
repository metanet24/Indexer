using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExceptionHomeWork.Exceptions
{
    public class MathExceptions: Exception
    {
        public MathExceptions(): this("Can not be zero")
        {
            
        }

        public MathExceptions( string msj) : base(msj) 
        {
            
        }
    }
}

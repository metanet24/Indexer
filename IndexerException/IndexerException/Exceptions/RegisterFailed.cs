using IndexerException.Helpers.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerException.Exceptions
{
    public class RegisterFailed :Exception
    {
        public RegisterFailed():this(AccountMessages.RegisterFailed)
        {
            
        }
        public RegisterFailed(string msj) :base(msj) 
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltaApi.Exceptions.Exceptions
{
    public class UnrecognizedMessageException: Exception
    {

        public UnrecognizedMessageException(string Description)
        {
            this.Data.Add("UNRECOGNIZED_MESSAGE_EXCEPTION", Description);
        }
    }
}

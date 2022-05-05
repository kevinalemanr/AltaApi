using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltaApi.Exceptions.Exceptions
{
    public class RequestInitiateException: Exception
    {
        public RequestInitiateException(string Description)
        {
            this.Data.Add("REQUEST_INITIATE_EXCEPTION", Description);
        }

    }
}

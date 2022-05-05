using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltaApi.Exceptions.Exceptions
{
    public class NotAuthenticatedException: Exception
    {
        public NotAuthenticatedException(string Description)
        {
            this.Data.Add("NOT_AUTHENTICATED_EXCEPTION", Description);
        }
    }
}

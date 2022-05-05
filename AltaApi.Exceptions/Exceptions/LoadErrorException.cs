using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltaApi.Exceptions.Exceptions
{
    public class LoadErrorException: Exception
    {
        public LoadErrorException(string Description)
        {
            this.Data.Add("LOAD_ERROR_EXCEPTION", Description);
        }
    }
}

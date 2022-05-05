using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltaApi.Exceptions.Exceptions
{
    public class LoadDetailException: Exception
    {
        public LoadDetailException(string Description)
        {
            this.Data.Add("LOAD_DETAIL_EXCEPTION", Description);
        }
    }
}

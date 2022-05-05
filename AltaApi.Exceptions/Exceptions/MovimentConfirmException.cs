using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltaApi.Exceptions.Exceptions
{
    public class MovimentConfirmException: Exception
    {
        public MovimentConfirmException(string Description)
        {
            this.Data.Add("MOVEMENT_CONFIRM_EXCEPTION", Description);
        }
    }
}

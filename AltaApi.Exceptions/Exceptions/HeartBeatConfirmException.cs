using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltaApi.Exceptions.Exceptions
{
    public class HeartBeatConfirmException: Exception
    {
        public HeartBeatConfirmException(string Description)
        {
            this.Data.Add("HEART_BEAT_CONFIRM_EXCEPTION", Description);
        }
    }
}

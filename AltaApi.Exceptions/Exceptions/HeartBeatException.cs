using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltaApi.Exceptions.Exceptions
{
    public class HeartBeatException: Exception
    {
        public HeartBeatException(string Description)
        {
            this.Data.Add("HEART_BEAT_EXCEPTION", Description);
        }
    }
}

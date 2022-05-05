using Serilog;

namespace AltaApi.Exceptions.Exceptions
{
    public class HeartBeatException: Exception
    {
        public HeartBeatException(string Description)
        {
            Log.Error("HEART_BEAT_EXCEPTION", Description);
        }
    }
}

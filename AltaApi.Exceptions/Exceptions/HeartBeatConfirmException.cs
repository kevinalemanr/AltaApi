using Serilog;

namespace AltaApi.Exceptions.Exceptions
{
    public class HeartBeatConfirmException: Exception
    {
        public HeartBeatConfirmException(string Description)
        {
            Log.Error("HEART_BEAT_CONFIRM_EXCEPTION", Description);
        }
    }
}

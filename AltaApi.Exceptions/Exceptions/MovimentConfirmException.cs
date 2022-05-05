using Serilog;

namespace AltaApi.Exceptions.Exceptions
{
    public class MovimentConfirmException: Exception
    {
        public MovimentConfirmException(string Description)
        {
            Log.Error("ERR_MOVEMENT_CONFIRM_EXCEPTION", Description);
        }
    }
}

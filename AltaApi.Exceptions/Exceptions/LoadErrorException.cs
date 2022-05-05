using Serilog;

namespace AltaApi.Exceptions.Exceptions
{
    public class LoadErrorException : Exception
    {
        public LoadErrorException(string Description)
        {
            Log.Error("LOAD_ERROR_EXCEPTION", Description);
        }
    }
}

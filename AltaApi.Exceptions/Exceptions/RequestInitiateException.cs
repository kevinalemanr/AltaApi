using Serilog;
namespace AltaApi.Exceptions.Exceptions
{
    public class RequestInitiateException: Exception
    {
        public RequestInitiateException(string Description)
        {
            Log.Error("ERR_REQUEST_INITIATE_EXCEPTION", Description);
        }

    }
}

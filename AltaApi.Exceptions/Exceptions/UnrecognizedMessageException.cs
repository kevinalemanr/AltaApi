using Serilog;
namespace AltaApi.Exceptions.Exceptions
{
    public class UnrecognizedMessageException : Exception
    {
        public UnrecognizedMessageException(string Description)
        {
            Log.Error("UNRECOGNIZED_MESSAGE_EXCEPTION", Description);
        }
    }
}

using Serilog;

namespace AltaApi.Exceptions.Exceptions
{
    public class LoadDetailException: Exception
    {
        public LoadDetailException(string Description)
        {
            Log.Error("LOAD_DETAIL_EXCEPTION", Description);
        }
    }
}

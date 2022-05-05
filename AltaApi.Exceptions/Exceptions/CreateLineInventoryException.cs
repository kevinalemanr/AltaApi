using Serilog;

namespace AltaApi.Exceptions.Exceptions
{
    public class CreateLineInventoryException: Exception
    {
        public CreateLineInventoryException(string Description)
        {
            Log.Error("ERROR_CREATE_LINE_INVENTORY_EXCEPTION: {0}", Description);
        }
    }
}

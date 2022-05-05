using AltaApi.DTOs;


namespace AltaApi.UseCasesPorts
{
    public interface ICreateLineInventoryInputPort
    {
         Task HandleCreateLineInventory(dynamic data, string applicationAccess);
        Task HandleConfirmMovement(dynamic data, string applicationAccess); 

        
    }
}

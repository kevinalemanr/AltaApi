using AltaApi.DTOs;


namespace AltaApi.UseCasesPorts
{
    public interface ICreateLineInventoryInputPort
    {
        Task Handle(SaveToPrimeCreationDTO saveToPrimeCreationDTO);

        
    }
}

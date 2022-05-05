using AltaApi.DTOs;


namespace AltaApi.Entities.Interfaces
{
    public interface IInventoryRepository
    {
        public Task<SaveToPrimeCreationDTO> CreateLineInventory(SaveToPrimeCreationDTO saveToPrimeCreationDto);
        public Task<IEnumerable<SaveToPrimeDTO>> GetAllInventory();
    }
}

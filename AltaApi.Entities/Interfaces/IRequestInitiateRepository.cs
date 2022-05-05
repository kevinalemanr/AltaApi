
using AltaApi.DTOs;

namespace AltaApi.Entities.Interfaces
{
    public interface IRequestInitiateRepository
    {
        public Task<RequestInitiateCreationDTO> CreateRequestInitiate(RequestInitiateCreationDTO requestInitiateCreationDTO);

        public Task<RequestInitiateCreationDTO> UpdateRequestInitiate(RequestInitiateCreationDTO requestInitiateCreationDTO);
    }
}

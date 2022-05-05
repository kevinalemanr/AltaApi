using AltaApi.DTOs;

namespace AltaApi.Entities.Interfaces
{
    public interface IHeartBeatRepository
    {
        public Task<HeartBeatInitiateCreationDTO> CreateHeartBeatInitiate(HeartBeatInitiateCreationDTO heartBeatInitiateCreationDTO);

        public Task<HeartBeatInitiateCreationDTO> UpdateHeartBeatInitiate(HeartBeatInitiateCreationDTO heartBeatInitiateCreationDTO);

    }
}

using AltaApi.DTOs;
using AltaApi.Entities.POCOs;
using AutoMapper;

namespace AltaApi.EFCore.Services
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<SaveToPrimeCreationDTO, SaveToPrime>().ReverseMap();
            CreateMap<HeartBeatInitiateCreationDTO, HeartBeatInitiate>().ReverseMap();
            CreateMap<RequestInitiateCreationDTO, RequestInitiate>().ReverseMap();
            CreateMap<RequestInboxCreationDTO, RequestInbox>().ReverseMap();

        }
    }
}

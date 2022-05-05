using AltaApi.DTOs;
using AltaApi.Entities.Interfaces;
using AltaApi.UseCasesPorts;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.UseCases
{
    public class CreateHeartBeatInitiate : ICreateHeartBeatInitiateInputPort
    {
        private readonly IHeartBeatRepository _heartBeatRepository;
        private readonly IMapper _mapper;

        public CreateHeartBeatInitiate(IHeartBeatRepository heartBeatRepository, IMapper mapper)
        {
            this._heartBeatRepository = heartBeatRepository;
            this._mapper = mapper;
        }

        public async Task Handle(HeartBeatInitiateCreationDTO heartBeatInitiateCreationDTO)
        {
            await _heartBeatRepository.CreateHeartBeatInitiate(heartBeatInitiateCreationDTO);
        }
    }
}

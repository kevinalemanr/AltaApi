using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AltaApi.DTOs;
using AltaApi.Entities.Interfaces;
using AltaApi.UseCasesPorts;
using AutoMapper;

namespace AltaApi.UseCases
{
    public class CreateRequestInitiate : ICreateRequestInitiateInputPort
    {
        private readonly IRequestInitiateRepository _requestInitiateRepository;
        private readonly IMapper _mapper;

        public CreateRequestInitiate(IRequestInitiateRepository requestInitiateRepository, IMapper mapper)
        {
            this._requestInitiateRepository = requestInitiateRepository;
            this._mapper = mapper;
        }
        public async Task Handle(RequestInitiateCreationDTO requestInitiateCreationDTO)
        {
            await _requestInitiateRepository.CreateRequestInitiate(requestInitiateCreationDTO);
        }
    }
}

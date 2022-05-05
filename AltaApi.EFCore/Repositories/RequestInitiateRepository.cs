using AltaApi.DTOs;
using AltaApi.EFCore.DataContext;
using AltaApi.Entities.Interfaces;
using AltaApi.Entities.POCOs;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.EFCore.Repositories
{
    public class RequestInitiateRepository : IRequestInitiateRepository
    {
        private readonly ApplicationDataContext _context;
        private readonly IMapper _mapper;

        public RequestInitiateRepository(ApplicationDataContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;

        }
        public async Task<RequestInitiateCreationDTO> CreateRequestInitiate(RequestInitiateCreationDTO requestInitiateCreationDTO)
        {
            RequestInitiate newReq = _mapper.Map<RequestInitiate>(requestInitiateCreationDTO);
            await _context.AddAsync(newReq);
            await _context.SaveChangesAsync();

            return _mapper.Map<RequestInitiateCreationDTO>(newReq);
          
        }

        public async Task<RequestInitiateCreationDTO> UpdateRequestInitiate(RequestInitiateCreationDTO requestInitiateCreationDTO)
        {
            var updReq = await this._context.RequestInitiates.AsTracking().
                                                              FirstOrDefaultAsync(a => a.LodNum == requestInitiateCreationDTO.LodNum);

            updReq = _mapper.Map(requestInitiateCreationDTO, updReq);
            await this._context.SaveChangesAsync();

            return _mapper.Map<RequestInitiateCreationDTO>(updReq);
        }
    }
}

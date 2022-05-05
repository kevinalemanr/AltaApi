using AltaApi.DTOs;
using AltaApi.EFCore.DataContext;
using AltaApi.Entities.Interfaces;
using AltaApi.Entities.POCOs;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.EFCore.Repositories
{
    public class HeartBeatInitiateRespository : IHeartBeatRepository
    {
        private readonly ApplicationDataContext _context;
        private readonly IMapper _mapper;
        public HeartBeatInitiateRespository(ApplicationDataContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }


       public async Task<HeartBeatInitiateCreationDTO> CreateHeartBeatInitiate(HeartBeatInitiateCreationDTO heartBeatInitiateCreationDTO)
        {

            HeartBeatInitiate heartBeatInitiate = _mapper.Map<HeartBeatInitiate>(heartBeatInitiateCreationDTO);
            await this._context.AddAsync(heartBeatInitiate);
            await this._context.SaveChangesAsync();

            return _mapper.Map<HeartBeatInitiateCreationDTO>(heartBeatInitiate);
        }

        public async Task<HeartBeatInitiateCreationDTO> UpdateHeartBeatInitiate(HeartBeatInitiateCreationDTO heartBeatInitiateCreationDTO)
        {
            var eventHBI = await this._context.HeartBeatInitiates.AsTracking()
                                                                 .FirstOrDefaultAsync(a =>  a.TranDt == heartBeatInitiateCreationDTO.TranDt &&
                                                                                            a.Wcs_Id == heartBeatInitiateCreationDTO.Wcs_Id &&
                                                                                            a.Wh_Id == heartBeatInitiateCreationDTO.Wh_Id);

            eventHBI = _mapper.Map(heartBeatInitiateCreationDTO, eventHBI);
            await this._context.SaveChangesAsync();

            return _mapper.Map<HeartBeatInitiateCreationDTO>(eventHBI);
        }
    }
}

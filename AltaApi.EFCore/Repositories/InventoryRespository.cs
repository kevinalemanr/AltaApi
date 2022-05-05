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
    public class InventoryRespository : IInventoryRepository
    {
        private readonly ApplicationDataContext _context;
        private readonly IMapper _mapper;
        public InventoryRespository(ApplicationDataContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;  
        }
        public async Task<SaveToPrimeCreationDTO> CreateLineInventory(SaveToPrimeCreationDTO saveToPrimeCreationDto)
        {


            SaveToPrime saveToPrime = _mapper.Map<SaveToPrime>(saveToPrimeCreationDto);
            await this._context.AddAsync(saveToPrime);
            await this._context.SaveChangesAsync();

            return _mapper.Map<SaveToPrimeCreationDTO>(saveToPrime);

            
        }

        public async Task<IEnumerable<SaveToPrimeDTO>> GetAllInventory()
        {
            /*  return await _context.SaveToPrimes.Select
                                      (a => new SaveToPrimeDTO
                                      { TranId = a.TranId, Data = a.Data, Endpoint = a.Endpoint, Date = a.Date })
                                      .ToListAsync();
            */

            return await _context.SaveToPrimes.ProjectTo<SaveToPrimeDTO>(_mapper.ConfigurationProvider).ToListAsync();
             
        }


    }
}

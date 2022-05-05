using AltaApi.DTOs;
using AltaApi.Entities.Interfaces;
using AltaApi.Entities.POCOs;
using AltaApi.UseCasesPorts;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.UseCases
{
    public class CreateLineInventory : ICreateLineInventoryInputPort
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;

        public CreateLineInventory(IInventoryRepository inventoryRepository, IMapper mapper)
        {
            this._inventoryRepository = inventoryRepository; 
            this._mapper = mapper;

        }
        public async Task Handle(SaveToPrimeCreationDTO saveToPrimeCreationDTO)
        {
            await this._inventoryRepository.CreateLineInventory(saveToPrimeCreationDTO);
        }
    }
}

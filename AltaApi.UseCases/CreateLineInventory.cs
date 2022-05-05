using AltaApi.Adapters.Folders;
using AltaApi.DTOs;
using AltaApi.Entities.Interfaces;
using AltaApi.Entities.POCOs;
using AltaApi.Exceptions.Exceptions;
using AltaApi.UseCases.Helpers;
using AltaApi.UseCasesPorts;
using AutoMapper;
using Newtonsoft.Json;
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


        public async Task HandleCreateLineInventory(dynamic data, string applicationAccess)
        {
            try
            {
                string jsonSting = Convert.ToString(data);
                CreateLineInventoryAdapter dataValue = ReadInputData.ReadInventory(jsonSting);
                string dataToDB = JsonConvert.SerializeObject(dataValue);
                string tranId = dataValue.CreateLineInventoryInIfd.CtrlSeg.Tranid.ToString();

                SaveToPrimeCreationDTO primeDto = new SaveToPrimeCreationDTO();
                primeDto.TranId = tranId;
                primeDto.Data = dataToDB;
                primeDto.Application = applicationAccess;
                primeDto.Endpoint = "CREATE_LINE_INVENTORY_IN_IFD";
                primeDto.Date = DateTime.Now;

                await this._inventoryRepository.CreateLineInventory(primeDto);

            }catch (Exception ex)
            {
                throw new CreateLineInventoryException(ex.ToString());
            }
        }

        public  async Task HandleConfirmMovement(dynamic data, string applicationAccess)
        {
            try
            {
                string jsonSting = Convert.ToString(data);
                MovementConfirmAdapter dataValue = ReadInputData.ReadMovementConfirm(jsonSting);
                string dataToDB = JsonConvert.SerializeObject(dataValue);
                string tranId = dataValue.MovimentConfirm.CtrlSeg.Tranid.ToString();

                SaveToPrimeCreationDTO primeDto = new SaveToPrimeCreationDTO();
                primeDto.TranId = tranId;
                primeDto.Data = dataToDB;
                primeDto.Application = applicationAccess;
                primeDto.Endpoint = "MOVEMENT_CONFIRM";
                primeDto.Date = DateTime.Now;

                await this._inventoryRepository.CreateLineInventory(primeDto);
            }
            catch (Exception ex)
            {
                throw new MovimentConfirmException(ex.ToString());
            }



        }

    }
}

using AltaApi.Adapters;
using AltaApi.Adapters.Folders;
using AltaApi.DTOs;
using AltaApi.Entities.Interfaces;
using AltaApi.Exceptions.Exceptions;
using AltaApi.UseCases.Helpers;
using AltaApi.UseCasesPorts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.UseCases
{
    public class CreateMessage : ICreateMessageInputPort
    {
        private readonly IHeartBeatRepository _heartBeatRepository;
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IRequestInitiateRepository _requestInitiateRepository;
        private readonly IRequestInboxRepository _requestInboxRepository;

        public CreateMessage(IHeartBeatRepository heartBeatRepository, IInventoryRepository inventoryRepository, IRequestInitiateRepository requestInitiateRepository, IRequestInboxRepository requestInboxRepository )
        {
            this._heartBeatRepository = heartBeatRepository;
            this._inventoryRepository = inventoryRepository;
            this._requestInitiateRepository = requestInitiateRepository;
            this._requestInboxRepository = requestInboxRepository;
        }   
        public async Task<dynamic> ProcessMessage(dynamic data)
        {
            string _data = Convert.ToString(data);

            if (_data.Contains("HEARTBEAT_CONFIRM"))
            {
                return await PROCESS_HEARTBEAT_CONFIRM(_data);
            }
            else if (_data.Contains("LOAD_DETAIL"))
            {
                return await PROCESS_LOAD_DETAIL(_data);
            }
            else if (_data.Contains("LOAD_ERROR"))
            {
                return await PROCESS_LOAD_ERROR(_data);
            }
            else
            {
                throw new UnrecognizedMessageException("UNRECOGNIZED MESSAGE ");

            }


        }

        public async Task<dynamic> PROCESS_HEARTBEAT_CONFIRM(string data)
        {
            try
            {
                var updateDBC = JsonConvert.DeserializeObject<HeartBeatConfirmAdapter>(data);

                HeartBeatInitiateCreationDTO newHBI = new HeartBeatInitiateCreationDTO();
                SaveToPrimeCreationDTO newPrimeEvent = new SaveToPrimeCreationDTO();


                newHBI.TranId = updateDBC.HeartBeatConfirm.CtrlSeg.Tranid.ToString();
                newHBI.TranDt = updateDBC.HeartBeatConfirm.CtrlSeg.Trandt.ToString();
                newHBI.Wcs_Id = updateDBC.HeartBeatConfirm.CtrlSeg.WcsId.ToString();
                newHBI.Wh_Id = updateDBC.HeartBeatConfirm.CtrlSeg.WhId.ToString();
                newHBI.ResponseTime = DateTime.Now;
                newHBI.MessageRecived = data;

                newPrimeEvent.TranId = updateDBC.HeartBeatConfirm.CtrlSeg.Tranid.ToString();
                newPrimeEvent.Data = data;
                newPrimeEvent.Application = "PRIME - HEARTBEAT_CONFIRM";
                newPrimeEvent.Endpoint = "SEND_MESSAGE";

                await _heartBeatRepository.UpdateHeartBeatInitiate(newHBI);
                await _inventoryRepository.CreateLineInventory(newPrimeEvent);

                return updateDBC;
            }
            catch (Exception ex)
            {
                throw new HeartBeatConfirmException(ex.ToString());
            }

        }

        public async Task<dynamic> PROCESS_LOAD_DETAIL(string data)
        {
            try
            {
                var message = JsonConvert.DeserializeObject<LoadDetailMessageAdapter>(data);

                RequestInitiateCreationDTO newRequest = new RequestInitiateCreationDTO();
                SaveToPrimeCreationDTO newPrimeEvent = new SaveToPrimeCreationDTO();


                newRequest.TranId = message.LoadDetail.CtrlSeg.Tranid.ToString();
                newRequest.Wh_id = message.LoadDetail.CtrlSeg.WhId.ToString();
                newRequest.Wcs_id = message.LoadDetail.CtrlSeg.WcsId.ToString();
                newRequest.LodNum = message.LoadDetail.CtrlSeg.InvSeg.LODNUM.ToString();
                newRequest.Apointed = 1;
                newRequest.MessageReceived = data;
                newRequest.LotNum = message.LoadDetail.CtrlSeg.InvSeg.LOTNUM.ToString();

                newPrimeEvent.TranId = message.LoadDetail.CtrlSeg.Tranid.ToString();
                newPrimeEvent.Data = data;
                newPrimeEvent.Date = DateTime.Now;
                newPrimeEvent.Application = "SEND_MESSAGE";
                newPrimeEvent.Endpoint = "PRIME - LOAD_DETAIL";


                await _requestInitiateRepository.UpdateRequestInitiate(newRequest);
                await _inventoryRepository.CreateLineInventory(newPrimeEvent);

                return message;
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.ToString());
            }

        }

        public async Task<dynamic> PROCESS_LOAD_ERROR(string data)
        {
            try
            {
                var message = JsonConvert.DeserializeObject<LoadErrorMessageAdapter>(data);

                RequestInitiateCreationDTO newRequest = new RequestInitiateCreationDTO();
                SaveToPrimeCreationDTO newPrimeEvent = new SaveToPrimeCreationDTO();
                RequestInboxReadDTO readInbox = new RequestInboxReadDTO();


                newRequest.TranId = message.LoadError.CtrlSeg.Tranid.ToString();
                newRequest.Wh_id = message.LoadError.CtrlSeg.WhId.ToString();
                newRequest.Wcs_id = message.LoadError.CtrlSeg.WcsId.ToString();
                newRequest.LodNum = message.LoadError.CtrlSeg.LoadErrorSeg.LODNUM.ToString();
                newRequest.Apointed = 0;
                newRequest.MessageReceived = data;

                newPrimeEvent.TranId = message.LoadError.CtrlSeg.Tranid.ToString();
                newPrimeEvent.Data = data;
                newPrimeEvent.Date = DateTime.Now;
                newPrimeEvent.Application = "SEND_MESSAGE";
                newPrimeEvent.Endpoint = "PRIME - LOAD_ERROR";

                readInbox.LodNum = message.LoadError.CtrlSeg.LoadErrorSeg.LODNUM.ToString();


                await _requestInitiateRepository.UpdateRequestInitiate(newRequest);
                await _inventoryRepository.CreateLineInventory(newPrimeEvent);

                var reProcess = await _requestInboxRepository.GetRequestInbox(readInbox);

                if (reProcess.Count() >= 1)
                {
                    await Task.Delay(3000);

                    var dataToSend = reProcess.FirstOrDefault();
                    dataToSend.TranId = CreateData.GetDateTimeNowWithMiliseconds();
                    dataToSend.TranDt = CreateData.GetDateTimeNow();

                    await _requestInboxRepository.CreateRequestInbox(dataToSend);


                }

                return message;
            }
            catch (Exception ex)
            {
                throw new LoadErrorException(ex.ToString());
            }
        }
    }
}

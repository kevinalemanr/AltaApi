using AltaApi.Adapters.Folders;
using AltaApi.Controllers.Helpers;
using AltaApi.DTOs;
using AltaApi.Entities.Interfaces;
using AltaApi.UseCasesPorts;
using AltaApi.WebClients.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AltaApi.Controllers
{
    [Route("api/createinventory")]
    [ApiController]
    public class CreateInventaryController : ControllerBase
    {
        private readonly ICreateLineInventoryInputPort _createLineInventoryInputPort;
        private readonly IWebHelpers _webHelpers;
        private readonly ISendToPrime _sendToPrime;
        public CreateInventaryController(ICreateLineInventoryInputPort createLineInventoryInputPort, IWebHelpers webHelpers, ISendToPrime sendToPrime)
        {
            this._createLineInventoryInputPort = createLineInventoryInputPort;
            this._webHelpers = webHelpers;
            this._sendToPrime = sendToPrime;    
        }

        [HttpPost("CREATE_LINE_INVENTORY_IN_IFD")]
        public async Task<ActionResult<SaveToPrimeCreationDTO>> CREATE_LINE_INVENTORY_IN_IFD(dynamic data)
        {
            string jsonSting = Convert.ToString(data);

            string applicationAccess = _webHelpers.GeValueFromHeader(HttpContext.Request.Headers, "x-applicationaccess");
            CreateLineInventoryAdapter dataValue = ReadJSON.ReadInventory(jsonSting);
            string dataToDB = JsonConvert.SerializeObject(dataValue);
            string tranId = dataValue.CreateLineInventoryInIfd.CtrlSeg.Tranid.ToString();

            SaveToPrimeCreationDTO primeDto = new SaveToPrimeCreationDTO();
            primeDto.TranId = tranId;
            primeDto.Data = dataToDB;
            primeDto.Application = applicationAccess;
            primeDto.Endpoint = "CREATE_LINE_INVENTORY_IN_IFD";
            primeDto.Date = DateTime.Now;

            //await _sendToPrime.SendDataToPrime(primeDto);   
            await _createLineInventoryInputPort.Handle(primeDto);

            return Ok(primeDto);
        }

    }
}

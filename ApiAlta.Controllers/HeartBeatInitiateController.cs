using AltaApi.Adapters;
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
    [Route("api/heartbeatinitiate")]
    [ApiController]
    public class HeartBeatController : ControllerBase
    {
        private readonly ICreateHeartBeatInitiateInputPort _createHeartBeatInitiateInputPort;
        private readonly IWebHelpers _webHelpers;
        private readonly ISendToPrime _sendToPrime;
        public HeartBeatController(ICreateHeartBeatInitiateInputPort createHeartBeatInitiateInputPort, IWebHelpers webHelpers, ISendToPrime sendToPrime)
        {
            this._createHeartBeatInitiateInputPort = createHeartBeatInitiateInputPort;
            this._webHelpers = webHelpers;
            this._sendToPrime = sendToPrime;
        }

        [HttpPost("HEARTBEAT_INITIATE")]
        public async Task<ActionResult<HeartBeatInitiateCreationDTO>> HEARTBEAT_INITIATE(dynamic data)
        {
            string jsonSting = Convert.ToString(data);
            string applicationAccess = _webHelpers.GeValueFromHeader(HttpContext.Request.Headers, "x-applicationaccess");
            HeartBeatInitiateAdapter dataValue = ReadJSON.ReadHeartBeat(jsonSting);
            string dataToDB = JsonConvert.SerializeObject(dataValue);

            HeartBeatInitiateCreationDTO crateHBI = new HeartBeatInitiateCreationDTO();
            crateHBI.TranId = dataValue.HeartBeat.CtrlSeg.Tranid.ToString();
            crateHBI.TranDt = dataValue.HeartBeat.CtrlSeg.Trandt.ToString();
            crateHBI.Wcs_Id = dataValue.HeartBeat.CtrlSeg.WcsId.ToString(); 
            crateHBI.Wh_Id = dataValue.HeartBeat.CtrlSeg .WhId.ToString();
            crateHBI.Text = dataValue.HeartBeat.HeartBeatSeg.TEXT.ToString();
            crateHBI.CreationDate = DateTime.Now;

            //await _sendToPrime.SendDataToPrime(primeDto);   
            await _createHeartBeatInitiateInputPort.Handle(crateHBI);

            return Ok(crateHBI);
        }

    }
}

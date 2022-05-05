using AltaApi.DTOs;
using AltaApi.UseCasesPorts;
using AltaApi.WebClients.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace AltaApi.Controllers
{
    [Route("api/heartbeatinitiate")]
    [ApiController]
    public class HeartBeatController : ControllerBase
    {
        private readonly ICreateHeartBeatInitiateInputPort _createHeartBeatInitiateInputPort;
        private readonly IWebHelpers _webHelpers;
        public HeartBeatController(ICreateHeartBeatInitiateInputPort createHeartBeatInitiateInputPort, IWebHelpers webHelpers, ISendToPrime sendToPrime)
        {
            this._createHeartBeatInitiateInputPort = createHeartBeatInitiateInputPort;
            this._webHelpers = webHelpers;
        }

        [HttpPost("HEARTBEAT_INITIATE")]
        public async Task<ActionResult<HeartBeatInitiateCreationDTO>> HEARTBEAT_INITIATE(dynamic data)
        {
            string applicationAccess = _webHelpers.GeValueFromHeader(HttpContext.Request.Headers, "x-applicationaccess");

            await _createHeartBeatInitiateInputPort.Handle(data, applicationAccess);

            return Ok();
        }

    }
}

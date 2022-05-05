using AltaApi.DTOs;
using AltaApi.UseCasesPorts;
using AltaApi.WebClients.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace AltaApi.Controllers
{
    [Route("api/requestinitiate")]
    [ApiController]
    public class RequestInitiateController : ControllerBase
    {
        private readonly ICreateRequestInitiateInputPort _createRequestInitiateInputPort;
        private readonly IWebHelpers _webHelpers;
        private readonly ISendToPrime _sendToPrime;

        public RequestInitiateController(ICreateRequestInitiateInputPort createRequestInitiateInputPort, IWebHelpers webHelpers, ISendToPrime sendToPrime)
        {
            this._createRequestInitiateInputPort = createRequestInitiateInputPort;
            this._webHelpers = webHelpers;
            this._sendToPrime = sendToPrime;
        }

        [HttpPost("REQUEST_INITIATE")]
        public async Task<ActionResult<RequestInitiateCreationDTO>> REQUEST_INITIATE(dynamic value)
        { 

            string applicationAccess = _webHelpers.GeValueFromHeader(HttpContext.Request.Headers, "x-applicationaccess");
            await _createRequestInitiateInputPort.Handle(value, applicationAccess);

            return Ok();



        }

    }
}

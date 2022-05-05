using AltaApi.DTOs;
using AltaApi.UseCasesPorts;
using AltaApi.WebClients.Interfaces;
using Microsoft.AspNetCore.Mvc;



namespace AltaApi.Controllers
{
    [Route("api/movementconfirm")]
    [ApiController]
    public class MovementConfirmController : ControllerBase
    {
        private readonly ICreateLineInventoryInputPort _createLineInventoryInputPort;
        private readonly IWebHelpers _webHelpers;
        public MovementConfirmController(ICreateLineInventoryInputPort createLineInventoryInputPort, IWebHelpers webHelpers)
        {
            this._createLineInventoryInputPort = createLineInventoryInputPort;
            this._webHelpers = webHelpers;
        }

        [HttpPost("MOVEMENT_CONFIRM")]
        public async Task<ActionResult<SaveToPrimeCreationDTO>> MOVEMENT_CONFIRM(dynamic data)
        {

            string applicationAccess = _webHelpers.GeValueFromHeader(HttpContext.Request.Headers, "x-applicationaccess");
            await _createLineInventoryInputPort.HandleConfirmMovement(data, applicationAccess);

            return Ok();
        }

    }
}
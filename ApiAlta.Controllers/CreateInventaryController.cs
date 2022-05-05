using AltaApi.DTOs;
using AltaApi.UseCasesPorts;
using AltaApi.WebClients.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AltaApi.Controllers
{
    [Route("api/createinventory")]
    [ApiController]
    public class CreateInventaryController : ControllerBase
    {
        private readonly ICreateLineInventoryInputPort _createLineInventoryInputPort;
        private readonly IWebHelpers _webHelpers;
        public CreateInventaryController(ICreateLineInventoryInputPort createLineInventoryInputPort, IWebHelpers webHelpers)
        {
            this._createLineInventoryInputPort = createLineInventoryInputPort;
            this._webHelpers = webHelpers;
        }

        [HttpPost("CREATE_LINE_INVENTORY_IN_IFD")]
        public async Task<ActionResult<SaveToPrimeCreationDTO>> CREATE_LINE_INVENTORY_IN_IFD(dynamic data)
        {

            string applicationAccess = _webHelpers.GeValueFromHeader(HttpContext.Request.Headers, "x-applicationaccess");         
            await _createLineInventoryInputPort.HandleCreateLineInventory(data, applicationAccess);

            return Ok();
        }

    }
}

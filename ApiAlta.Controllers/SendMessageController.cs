using AltaApi.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.Controllers
{
    [Route("api/sendmessage")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ICreateMessageInputPort _createMessageInputPort;

        public SendMessageController(ICreateMessageInputPort createMessageInputPort)
        {
            this._createMessageInputPort = createMessageInputPort;
        }

        [HttpPost("SEND_MESSAGE")]
        public async Task<ActionResult> SEND_MESSAGE(dynamic data)
        {
            await _createMessageInputPort.ProcessMessage(data);

            return Ok();
        }

    }
}

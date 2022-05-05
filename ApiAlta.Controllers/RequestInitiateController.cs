using AltaApi.Adapters.Folders;
using AltaApi.Controllers.Helpers;
using AltaApi.DTOs;
using AltaApi.UseCasesPorts;
using AltaApi.WebClients.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string jsonString = Convert.ToString(value);
            string applicationAccess = _webHelpers.GeValueFromHeader(HttpContext.Request.Headers, "x-applicationaccess");
            RequestInitiateAdapter dataValue = ReadJSON.ReadRequestInitiate(jsonString);

            RequestInitiateCreationDTO newRID = new RequestInitiateCreationDTO();
            newRID.TranId = dataValue.Request.CtrlSeg.Tranid.ToString();
            newRID.Wh_id = dataValue.Request.CtrlSeg.WhId.ToString();
            newRID.Wcs_id = dataValue.Request.CtrlSeg.WcsId.ToString();
            newRID.LodNum = dataValue.Request.CtrlSeg.RequestSeg.LODNUM.ToString();
            newRID.Req_Contents_Flg = dataValue.Request.CtrlSeg.RequestSeg.REQ_CONTENTS_FLG.ToString();
            newRID.Req_Stoloc_flg = dataValue.Request.CtrlSeg.RequestSeg.REQ_STOLOC_FLG.ToString();
            newRID.CreatedDate = DateTime.Now;

            await _createRequestInitiateInputPort.Handle(newRID);

            return Ok(newRID);



        }

    }
}

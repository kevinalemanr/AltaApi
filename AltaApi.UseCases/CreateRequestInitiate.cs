using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AltaApi.Adapters.Folders;
using AltaApi.DTOs;
using AltaApi.Entities.Interfaces;
using AltaApi.Exceptions.Exceptions;
using AltaApi.UseCases.Helpers;
using AltaApi.UseCasesPorts;
using AutoMapper;

namespace AltaApi.UseCases
{
    public class CreateRequestInitiate : ICreateRequestInitiateInputPort
    {
        private readonly IRequestInitiateRepository _requestInitiateRepository;
        private readonly IMapper _mapper;

        public CreateRequestInitiate(IRequestInitiateRepository requestInitiateRepository, IMapper mapper)
        {
            this._requestInitiateRepository = requestInitiateRepository;
            this._mapper = mapper;
        }
        public async Task Handle(dynamic value, string applicationAccess)
        {
            try
            {

                string jsonString = Convert.ToString(value);
                RequestInitiateAdapter dataValue = ReadInputData.ReadRequestInitiate(jsonString);

                RequestInitiateCreationDTO newRID = new RequestInitiateCreationDTO();
                newRID.TranId = dataValue.Request.CtrlSeg.Tranid.ToString();
                newRID.Wh_id = dataValue.Request.CtrlSeg.WhId.ToString();
                newRID.Wcs_id = dataValue.Request.CtrlSeg.WcsId.ToString();
                newRID.LodNum = dataValue.Request.CtrlSeg.RequestSeg.LODNUM.ToString();
                newRID.Req_Contents_Flg = dataValue.Request.CtrlSeg.RequestSeg.REQ_CONTENTS_FLG.ToString();
                newRID.Req_Stoloc_flg = dataValue.Request.CtrlSeg.RequestSeg.REQ_STOLOC_FLG.ToString();
                newRID.CreatedDate = DateTime.Now;

                await _requestInitiateRepository.CreateRequestInitiate(newRID);
            }
            catch (Exception ex)
            {
                throw new RequestInitiateException(ex.ToString());
            }
        }
    }
}

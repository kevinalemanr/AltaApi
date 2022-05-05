using AltaApi.Adapters.Folders;
using AltaApi.DTOs;
using AltaApi.Entities.Interfaces;
using AltaApi.Exceptions.Exceptions;
using AltaApi.UseCases.Helpers;
using AltaApi.UseCasesPorts;
using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.UseCases
{
    public class CreateHeartBeatInitiate : ICreateHeartBeatInitiateInputPort
    {
        private readonly IHeartBeatRepository _heartBeatRepository;
        private readonly IMapper _mapper;

        public CreateHeartBeatInitiate(IHeartBeatRepository heartBeatRepository, IMapper mapper)
        {
            this._heartBeatRepository = heartBeatRepository;
            this._mapper = mapper;
        }

        public async Task Handle(dynamic data, string applicationAccess)
        {
            try
            {

                string jsonSting = Convert.ToString(data);
                HeartBeatInitiateAdapter dataValue = ReadInputData.ReadHeartBeat(jsonSting);
                string dataToDB = JsonConvert.SerializeObject(dataValue);


                HeartBeatInitiateCreationDTO crateHBI = new HeartBeatInitiateCreationDTO();
                crateHBI.TranId = dataValue.HeartBeat.CtrlSeg.Tranid.ToString();
                crateHBI.TranDt = dataValue.HeartBeat.CtrlSeg.Trandt.ToString();
                crateHBI.Wcs_Id = dataValue.HeartBeat.CtrlSeg.WcsId.ToString();
                crateHBI.Wh_Id = dataValue.HeartBeat.CtrlSeg.WhId.ToString();
                crateHBI.Text = dataValue.HeartBeat.HeartBeatSeg.TEXT.ToString();
                crateHBI.CreationDate = DateTime.Now;

                await _heartBeatRepository.CreateHeartBeatInitiate(crateHBI);
            }
            catch (Exception ex)
            {
                throw new HeartBeatException(ex.ToString());
            }
        }
    }
}

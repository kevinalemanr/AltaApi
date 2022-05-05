using AltaApi.DTOs;
using AltaApi.EFCore.DataContext;
using AltaApi.Entities.Interfaces;
using AltaApi.Entities.POCOs;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.EFCore.Repositories
{
    public class RequestInboxRepository : IRequestInboxRepository
    {
        private readonly ApplicationDataContext _context;
        private readonly IMapper _mapper;

        public RequestInboxRepository(ApplicationDataContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;

        }
        public async Task<RequestInboxCreationDTO> CreateRequestInbox(RequestInboxCreationDTO requestInboxCreationDTO)
        {
            RequestInbox requestInbox = _mapper.Map<RequestInbox>(requestInboxCreationDTO);
            await this._context.AddAsync(requestInboxCreationDTO);
            await this._context.SaveChangesAsync();

            return _mapper.Map<RequestInboxCreationDTO>(requestInbox);
        }

        public async Task<IEnumerable<RequestInboxCreationDTO>> GetRequestInbox(RequestInboxReadDTO requestInboxReadDTO)
        {
            //  var requestInbox = await _context.RequestsInbox.AsTracking()
            //                                               .FirstOrDefaultAsync(a => a.LodNum == requestInboxReadDTO.LodNum);

           // List<RequestInboxReadDTO> request =  new List<RequestInboxReadDTO>();

            var request = await _context.RequestsInbox.ProjectTo<RequestInboxCreationDTO>(_mapper.ConfigurationProvider).Where(c => c.LodNum == requestInboxReadDTO.LodNum)
                                                      .Select(c => new RequestInboxCreationDTO
                                                      { 
                                                          TranId = c.TranId,
                                                          TranDt = c.TranDt,
                                                          Wh_Id = c.Wh_Id,
                                                          Wcs_Id = c.Wcs_Id,
                                                          LodNum = c.LodNum,
                                                          Req_Contents_Flag = c.Req_Contents_Flag,
                                                          Req_Stoloc_Flag = c.Req_Stoloc_Flag,
                                                          Processing = c.Processing,
                                                          Concluded = c.Concluded,
                                                          failed = c.failed,
                                                          Reprocess = c.Reprocess,
                                                          CreationDate = c.CreationDate,
                                                          StatusCode = c.StatusCode
                                                      }).ToListAsync();

            return request;

        }


    }
}

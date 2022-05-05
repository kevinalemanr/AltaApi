using AltaApi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.Entities.Interfaces
{
    public interface IRequestInboxRepository
    {
        public Task<IEnumerable<RequestInboxCreationDTO>> GetRequestInbox(RequestInboxReadDTO requestInboxReadDTO);

        public Task<RequestInboxCreationDTO> CreateRequestInbox(RequestInboxCreationDTO requestInboxCreationDTO);
    }
}

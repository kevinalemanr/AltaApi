using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.UseCasesPorts
{
    public interface ICreateMessageInputPort
    {
        public Task<dynamic> ProcessMessage(dynamic data);
        public Task<dynamic> PROCESS_HEARTBEAT_CONFIRM(string data);
        public Task<dynamic> PROCESS_LOAD_DETAIL(string data);
        public Task<dynamic> PROCESS_LOAD_ERROR(string data);

    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.WebClients.Interfaces
{
    public interface IWebHelpers
    {
        public string GetValueFromExceptionDATA(Exception ex, string Key);
        public string GeValueFromHeader(IHeaderDictionary headers, string key);


    }
}

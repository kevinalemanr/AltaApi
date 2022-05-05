using AltaApi.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.WebClients.Interfaces
{
    public interface ISendToPrime
    {
        public Task<TransactionResult> SendDataToPrime(dynamic objectData);
    }
}

using AltaApi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.UseCasesPorts
{
    public  interface ICreateLineInventoryOutputPort
    {
        Task Handle(SaveToPrimeDTO saveToPrimeDto);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.Entities.POCOs
{
    public class SaveToPrime
    {
        public int Id { get; set; }
        public string TranId { get; set; }
        public string? Data { get; set; }
        public string Endpoint { get; set; }
        public string Application { get; set; }
        public DateTime Date { get; set; }
    }
}

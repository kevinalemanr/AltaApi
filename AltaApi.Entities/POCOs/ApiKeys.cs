using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.Entities.POCOs
{
    public class ApiKeys
    {
        public int Id { get; set; }
        public string KeyValue { get; set; }
        public string ApiName { get; set; }
        public string ApplicationAccess { get; set; }
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }

    }
}

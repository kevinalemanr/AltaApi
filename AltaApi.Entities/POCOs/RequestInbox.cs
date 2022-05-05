using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.Entities.POCOs
{
    public class RequestInbox
    {
        public int Id { get; set; }
        public string TranId { get; set; }
        public string TranDt { get; set; }
        public string Wh_Id { get; set; }
        public string Wcs_Id { get; set; }
        public string LodNum { get; set; }
        public string Req_Contents_Flag { get; set; }
        public string Req_Stoloc_Flag { get; set; }
        public bool Processing { get; set; }
        public bool Concluded { get; set; }
        public bool failed { get; set; }
        public bool Reprocess { get; set; }
        public DateTime CreationDate { get; set; }
        public int? StatusCode { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.DTOs
{
    public  class RequestInitiateCreationDTO
    {
        public string TranId { get; set; }
        public string Wh_id { get; set; }
        public string Wcs_id { get; set; }
        public string LodNum { get; set; }
        public string Req_Contents_Flg { get; set; }
        public string Req_Stoloc_flg { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? Apointed { get; set; }
        public string? MessageReceived { get; set; }
        public string? LotNum { get; set; }

    }
}

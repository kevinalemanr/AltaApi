using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.Entities.POCOs
{
    public class HeartBeatInitiate
    {
        public int Id { get; set; }
        public string TranId { get; set; }
        public string TranDt { get; set; }
        public string Wcs_Id { get; set; }
        public string Wh_Id { get; set; }
        public string? Text { get; set; }
        public DateTime CreationDate { get; set; }
        public string? MessageRecived { get; set; }
        public DateTime? ResponseTime { get; set; }
    }
}

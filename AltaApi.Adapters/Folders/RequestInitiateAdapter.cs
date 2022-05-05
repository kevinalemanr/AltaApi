using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.Adapters.Folders
{
    public class RequestInitiateAdapter
    {
        [JsonProperty("REQUEST")]
        public REQUEST Request { get; set; }
    }

    public partial class REQUEST
    {
        [JsonProperty("CTRL_SEG")]
        public REQUEST_CTRLSEG CtrlSeg { get; set; }
    }

    public partial class REQUEST_CTRLSEG
    {
        [JsonProperty("TRANID")]
        public string Tranid { get; set; }

        [JsonProperty("TRANDT")]
        public string Trandt { get; set; }

        [JsonProperty("WH_ID")]
        public string WhId { get; set; }

        [JsonProperty("WCS_ID")]
        public string WcsId { get; set; }

        [JsonProperty("REQ_SEG")]
        public REQUEST_SEG RequestSeg { get; set; }

    }
    public partial class REQUEST_SEG
    {
        [JsonProperty("LODNUM")]
        public string LODNUM { get; set; }

        [JsonProperty("REQ_CONTENTS_FLG")]
        public string REQ_CONTENTS_FLG { get; set; }

        [JsonProperty("REQ_STOLOC_FLG")]
        public string REQ_STOLOC_FLG { get; set; }
    }
}

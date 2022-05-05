using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.Adapters.Folders
{
    public partial class CreateLineInventoryAdapter
    {
        [JsonProperty("createLineInventoryInIfd")]
        public CREATELINEINVENTORYINIF CreateLineInventoryInIfd { get; set; }
    }
    public partial class CREATELINEINVENTORYINIF
    {
        [JsonProperty("ctrlSeg")]
        public CTRLSEG CtrlSeg { get; set; }

        [JsonProperty("createLineInventorySeg")]
        public CREATELINEINVENTORYSEG CreateLineInventorySeg { get; set; }
    }
    public partial class CREATELINEINVENTORYSEG
    {
        [JsonProperty("WKONUM")]
        public string Wkonum { get; set; }

        [JsonProperty("WKOREV")]
        public string Wkorev { get; set; }

        [JsonProperty("PRDLIN")]
        public string Prdlin { get; set; }

        [JsonProperty("UOMCOD")]
        public string Uomcod { get; set; }

        [JsonProperty("PRTNUM")]
        public long Prtnum { get; set; }

        [JsonProperty("INVSTS")]
        public string Invsts { get; set; }

        [JsonProperty("UNTQTY")]
        public long Untqty { get; set; }

        [JsonProperty("LOTNUM")]
        public string Lotnum { get; set; }

        [JsonProperty("DSTLOC")]
        public string Dstloc { get; set; }

        [JsonProperty("LODNUM")]
        public string Lodnum { get; set; }

        [JsonProperty("assetTyp")]
        public string AssetTyp { get; set; }

        [JsonProperty("invAttrDte1")]
        public string InvAttrDte1 { get; set; }

        [JsonProperty("invAttrDte2")]
        public string InvAttrDte2 { get; set; }
    }

    public partial class CTRLSEG
    {
        [JsonProperty("TRANID")]
        public string Tranid { get; set; }

        [JsonProperty("TRANDT")]
        public string Trandt { get; set; }

        [JsonProperty("wcsId")]
        public string WcsId { get; set; }

        [JsonProperty("whId")]
        public string WhId { get; set; }
    }
}

using Newtonsoft.Json;


namespace AltaApi.Adapters.Folders
{
    public class LoadErrorMessageAdapter
    {
        [JsonProperty("LOAD_ERROR")]
        public LOAD_ERROR LoadError { get; set; }
    }

    public partial class LOAD_ERROR
    {
        [JsonProperty("CTRL_SEG")]
        public LOAD_ERROR_CTRLSEG CtrlSeg { get; set; }

    }

    public partial class LOAD_ERROR_CTRLSEG
    {
        [JsonProperty("TRANID")]
        public string Tranid { get; set; }

        [JsonProperty("TRANDT")]
        public string Trandt { get; set; }

        [JsonProperty("WH_ID")]
        public string WhId { get; set; }

        [JsonProperty("WCS_ID")]
        public string WcsId { get; set; }


        [JsonProperty("LOAD_ERR_SEG")]
        public LOAD_ERROR_SEG LoadErrorSeg { get; set; }

    }


    public partial class LOAD_ERROR_SEG
    {
        [JsonProperty("LODNUM")]
        public string LODNUM { get; set; }

        [JsonProperty("ERROR_CODE")]
        public string ERROR_CODE { get; set; }

    }
}

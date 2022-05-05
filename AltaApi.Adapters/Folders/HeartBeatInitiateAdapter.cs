using Newtonsoft.Json;


namespace AltaApi.Adapters.Folders
{
    public partial class HeartBeatInitiateAdapter
    {
        [JsonProperty("HEARTBEAT_INITIATE")]
        public HEARTBEAT_INITIATE HeartBeat { get; set; }
    }

    public partial class HEARTBEAT_INITIATE
    {
        [JsonProperty("CTRL_SEG")]
        public HEARTBEAT_CTRLSEG CtrlSeg { get; set; }

        [JsonProperty("HEARTBEAT_SEG")]
        public HEARTBEAT_SEG HeartBeatSeg { get; set; }

    }
    public partial class HEARTBEAT_CTRLSEG
    {
        [JsonProperty("TRANID")]
        public string Tranid { get; set; }

        [JsonProperty("TRANDT")]
        public string Trandt { get; set; }

        [JsonProperty("WCS_ID")]
        public string WcsId { get; set; }

        [JsonProperty("WH_ID")]
        public string WhId { get; set; }
    }
    public partial class HEARTBEAT_SEG
    {
        [JsonProperty("TEXT")]
        public string TEXT { get; set; }
    }
}

using Newtonsoft.Json;

namespace AltaApi.Adapters.Folders
{
    public class HeartBeatConfirmAdapter
    {
        [JsonProperty("HEARTBEAT_CONFIRM")]
        public HEARTBEAT_CONFIRM HeartBeatConfirm { get; set; }
    }

    public partial class HEARTBEAT_CONFIRM
    {
        [JsonProperty("CTRL_SEG")]
        public HEARTBEAT_CONFIRM_CTRLSEG CtrlSeg { get; set; }

    }

    public partial class HEARTBEAT_CONFIRM_CTRLSEG
    {
        [JsonProperty("TRANID")]
        public string Tranid { get; set; }

        [JsonProperty("TRANDT")]
        public string Trandt { get; set; }

        [JsonProperty("WH_ID")]
        public string WhId { get; set; }

        [JsonProperty("WCS_ID")]
        public string WcsId { get; set; }


        [JsonProperty("HEARTBEAT_SEG")]
        public HEARTBEAT_CONFIRM_SEG HeartBeatConfirmSeg { get; set; }

    }

    public partial class HEARTBEAT_CONFIRM_SEG
    {
        [JsonProperty("TEXT")]
        public string TEXT { get; set; }
    }
}

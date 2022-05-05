using Newtonsoft.Json;


namespace AltaApi.Adapters.Folders
{
    public class MovementConfirmAdapter
    {
        [JsonProperty("MOVEMENT_CONFIRM")]
        public MOVEMENT_CONFIRM MovimentConfirm { get; set; }
    }

    public partial class MOVEMENT_CONFIRM
    {
        [JsonProperty("CTRL_SEG")]
        public MOVEMENT_CONFIRM_CTRLSEG CtrlSeg { get; set; }

    }

    public partial class MOVEMENT_CONFIRM_CTRLSEG
    {
        [JsonProperty("TRANID")]
        public string Tranid { get; set; }

        [JsonProperty("TRANDT")]
        public string Trandt { get; set; }

        [JsonProperty("WH_ID")]
        public string WhId { get; set; }

        [JsonProperty("WCS_ID")]
        public string WcsId { get; set; }


        [JsonProperty("MOVE_CONF_SEG")]
        public MOVEMENT_CONFIRM_SEG MovimentConfirmSeg { get; set; }

    }

    public partial class MOVEMENT_CONFIRM_SEG
    {
        [JsonProperty("LODNUM")]
        public string LODNUM { get; set; }

        [JsonProperty("DSTLOC")]
        public string DSTLOC { get; set; }
    }


}

using Newtonsoft.Json;


namespace AltaApi.Adapters.Folders
{
    public class LoadDetailMessageAdapter
    {
        [JsonProperty("LOAD_DETAIL")]
        public LOAD_DETAIL LoadDetail { get; set; }
    }

    public partial class LOAD_DETAIL
    {
        [JsonProperty("CTRL_SEG")]
        public LOAD_DETAIL_CTRLSEG CtrlSeg { get; set; }

    }


    public partial class LOAD_DETAIL_CTRLSEG
    {
        [JsonProperty("TRANID")]
        public string Tranid { get; set; }

        [JsonProperty("TRANDT")]
        public string Trandt { get; set; }

        [JsonProperty("WH_ID")]
        public string WhId { get; set; }

        [JsonProperty("WCS_ID")]
        public string WcsId { get; set; }


        [JsonProperty("INV_SEG")]
        public INV_SEG InvSeg { get; set; }

    }

    public partial class INV_SEG
    {
        [JsonProperty("PRTNUM")]
        public string PRTNUM { get; set; }

        [JsonProperty("PRT_CLIENT_ID")]
        public string PRT_CLIENT_ID { get; set; }

        [JsonProperty("UNTCAS")]
        public string UNTCAS { get; set; }

        [JsonProperty("INVSTS")]
        public string INVSTS { get; set; }

        [JsonProperty("UNTQTY")]
        public string UNTQTY { get; set; }

        [JsonProperty("ORGCOD")]
        public string ORGCOD { get; set; }

        [JsonProperty("REVLVL")]
        public string REVLVL { get; set; }

        [JsonProperty("LOTNUM")]
        public string LOTNUM { get; set; }

        [JsonProperty("DSTLOC")]
        public string DSTLOC { get; set; }

        [JsonProperty("LODNUM")]
        public string LODNUM { get; set; }

        [JsonProperty("SUBNUM")]
        public string SUBNUM { get; set; }

        [JsonProperty("DTLNUM")]
        public string DTLNUM { get; set; }

        [JsonProperty("FTPCOD")]
        public string FTPCOD { get; set; }

        [JsonProperty("UNTPAK")]
        public string UNTPAK { get; set; }

        [JsonProperty("FIFDTE")]
        public string FIFDTE { get; set; }

        [JsonProperty("MANDTE")]
        public string MANDTE { get; set; }

        [JsonProperty("CATCH_QTY")]
        public string CATCH_QTY { get; set; }

        [JsonProperty("PHYFLG")]
        public string PHYFLG { get; set; }

        [JsonProperty("CNSG_FLG")]
        public string CNSG_FLG { get; set; }

        [JsonProperty("ASSET_TYP")]
        public string ASSET_TYP { get; set; }

        [JsonProperty("INV_ATTR_INT1")]
        public string INV_ATTR_INT1 { get; set; }

        [JsonProperty("INV_ATTR_INT2")]
        public string INV_ATTR_INT2 { get; set; }

        [JsonProperty("INV_ATTR_INT3")]
        public string INV_ATTR_INT3 { get; set; }

        [JsonProperty("INV_ATTR_INT4")]
        public string INV_ATTR_INT4 { get; set; }

        [JsonProperty("INV_ATTR_INT5")]
        public string INV_ATTR_INT5 { get; set; }

        [JsonProperty("INV_ATTR_FLT1")]
        public string INV_ATTR_FLT1 { get; set; }

        [JsonProperty("INV_ATTR_FLT2")]
        public string INV_ATTR_FLT2 { get; set; }

        [JsonProperty("INV_ATTR_FLT3")]
        public string INV_ATTR_FLT3 { get; set; }

        [JsonProperty("CSTMS_BOND_FLG")]
        public string CSTMS_BOND_FLG { get; set; }

        [JsonProperty("DTY_STMP_FLG")]
        public string DTY_STMP_FLG { get; set; }

        [JsonProperty("LOAD_ATTR1_FLG")]
        public string LOAD_ATTR1_FLG { get; set; }

        [JsonProperty("LOAD_ATTR2_FLG")]
        public string LOAD_ATTR2_FLG { get; set; }

        [JsonProperty("LOAD_ATTR3_FLG")]
        public string LOAD_ATTR3_FLG { get; set; }

        [JsonProperty("LOAD_ATTR4_FLG")]
        public string LOAD_ATTR4_FLG { get; set; }

        [JsonProperty("LOAD_ATTR5_FLG")]
        public string LOAD_ATTR5_FLG { get; set; }
    }

}

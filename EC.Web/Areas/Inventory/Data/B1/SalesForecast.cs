using System;

namespace EC.Web.Areas.Inventory.Data.B1
{
    public partial class SalesForecast
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string USMgr { get; set; }
        public string USRep { get; set; }
        public string USPerson { get; set; }
        public string UPj { get; set; }
        public string UCardCode { get; set; }
        public string UModel { get; set; }
        public string UItemGroup { get; set; }
        public short? UYear { get; set; }
        public decimal? UJan { get; set; }
        public decimal? UFeb { get; set; }
        public decimal? UMar { get; set; }
        public decimal? UApr { get; set; }
        public decimal? UMay { get; set; }
        public decimal? UJun { get; set; }
        public decimal? UJul { get; set; }
        public decimal? UAug { get; set; }
        public decimal? USep { get; set; }
        public decimal? UOct { get; set; }
        public decimal? UNov { get; set; }
        public decimal? UDec { get; set; }
        public DateTime? ULatestDate { get; set; }
        public decimal? UPrice { get; set; }
    }
}

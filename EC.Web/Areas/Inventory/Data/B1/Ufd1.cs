using System;

namespace EC.Web.Areas.Inventory.Data.B1
{
    public partial class Ufd1
    {
        public string TableId { get; set; }
        public short FieldId { get; set; }
        public short IndexId { get; set; }
        public string FldValue { get; set; }
        public string Descr { get; set; }
        public DateTime? FldDate { get; set; }
    }
}

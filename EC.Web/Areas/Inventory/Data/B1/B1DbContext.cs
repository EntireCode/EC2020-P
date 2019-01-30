using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Inventory.Data.B1
{
    public partial class B1DbContext : DbContext
    {
        public B1DbContext(DbContextOptions<B1DbContext> options)
            : base(options)
        {

        }

        //public virtual DbSet<Dln1> Dln1s { get; set; }

        //public virtual DbSet<Ohem> Ohems { get; set; }

        public virtual DbSet<Oitw> Oitws { get; set; }

        public virtual DbSet<Oitb> Oitbs { get; set; }

        public virtual DbSet<Oinv> Oinvs { get; set; }

        public virtual DbSet<Ufd1> Ufd1s { get; set; }

        public virtual DbSet<Orin> Orins { get; set; }

        public virtual DbSet<Ordr> Ordrs { get; set; }

        public virtual DbSet<SalesForecast> SalesForecasts { get; set; }

        public virtual DbSet<SalesWorldwide> SalesWorldwides { get; set; }

        //public virtual DbSet<Oshp> Oshps { get; set; }

        //public virtual DbSet<Oslp> Oslps { get; set; }

        public virtual DbSet<Ocrd> Ocrds { get; set; }

        public virtual DbSet<Rin1> Rin1s { get; set; }

        //public virtual DbSet<Rdr1> Rdr1s { get; set; }

        public virtual DbSet<Oitm> Oitms { get; set; }

        public virtual DbSet<Oitt> Oitts { get; set; }

        public virtual DbSet<Itt1> Itt1s { get; set; }

        public virtual DbSet<Inv1> Inv1s { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inv1>(entity =>
            {
                entity.HasKey(e => new { e.DocEntry, e.LineNum });

                entity.ToTable("INV1");

                entity.HasIndex(e => e.AcctCode)
                    .HasName("INV1_ACCOUNT");

                entity.HasIndex(e => e.Currency)
                    .HasName("INV1_CURRENCY");

                entity.HasIndex(e => e.LineStatus)
                    .HasName("INV1_STATUS");

                entity.HasIndex(e => e.OwnerCode)
                    .HasName("INV1_OWNER_CODE");

                entity.HasIndex(e => new { e.DocEntry, e.VisOrder })
                    .HasName("INV1_VIS_ORDER");

                entity.HasIndex(e => new { e.BaseEntry, e.BaseType, e.BaseLine })
                    .HasName("INV1_BASE_ENTRY");

                entity.HasIndex(e => new { e.ItemCode, e.WhsCode, e.OpenQty })
                    .HasName("INV1_ITM_WHS_OQ");

                entity.Property(e => e.AcctCode).HasMaxLength(15);

                entity.Property(e => e.ActDelDate).HasColumnType("datetime");

                entity.Property(e => e.Address).HasMaxLength(254);

                entity.Property(e => e.AllocBinC).HasMaxLength(11);

                entity.Property(e => e.AssblValue).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BackOrdr)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BaseAtCard).HasMaxLength(100);

                entity.Property(e => e.BaseCard).HasMaxLength(15);

                entity.Property(e => e.BaseOpnQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BasePrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.BaseQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseRef).HasMaxLength(16);

                entity.Property(e => e.BaseType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.BlockNum).HasMaxLength(100);

                entity.Property(e => e.Ceecflag)
                    .HasColumnName("CEECFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.Cfopcode)
                    .HasColumnName("CFOPCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ChgAsmBoMw)
                    .HasColumnName("ChgAsmBoMW")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CiOppLineN).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CodeBars).HasMaxLength(254);

                entity.Property(e => e.CogsAcct).HasMaxLength(15);

                entity.Property(e => e.CogsOcrCo2).HasMaxLength(8);

                entity.Property(e => e.CogsOcrCo3).HasMaxLength(8);

                entity.Property(e => e.CogsOcrCo4).HasMaxLength(8);

                entity.Property(e => e.CogsOcrCo5).HasMaxLength(8);

                entity.Property(e => e.CogsOcrCod).HasMaxLength(8);

                entity.Property(e => e.Commission).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ConsumeFct)
                    .HasColumnName("ConsumeFCT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOrg).HasMaxLength(3);

                entity.Property(e => e.CredOrigin)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cstcode)
                    .HasColumnName("CSTCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CstfCofins)
                    .HasColumnName("CSTfCOFINS")
                    .HasMaxLength(2);

                entity.Property(e => e.CstfIpi)
                    .HasColumnName("CSTfIPI")
                    .HasMaxLength(2);

                entity.Property(e => e.CstfPis)
                    .HasColumnName("CSTfPIS")
                    .HasMaxLength(2);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.DedVatSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DedVatSumF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DedVatSumS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DefBreak).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DeferrTax)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DelivrdQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DescOw)
                    .HasColumnName("DescOW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DetailsOw)
                    .HasColumnName("DetailsOW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DiscPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DistribExp)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DistribIs)
                    .HasColumnName("DistribIS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DistribSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.DropShip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Dscription).HasMaxLength(100);

                entity.Property(e => e.DstrbSumFc)
                    .HasColumnName("DstrbSumFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DstrbSumSc)
                    .HasColumnName("DstrbSumSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EnSetCost)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EquVatPer).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EquVatSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EquVatSumF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EquVatSumS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExLineNo).HasMaxLength(10);

                entity.Property(e => e.Excisable)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExciseAmt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Factor1).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Factor2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Factor3).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Factor4).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FisrtBin).HasMaxLength(228);

                entity.Property(e => e.Flags).HasDefaultValueSql("((0))");

                entity.Property(e => e.FreeChrgBp)
                    .HasColumnName("FreeChrgBP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FreeTxt).HasMaxLength(100);

                entity.Property(e => e.FromWhsCod).HasMaxLength(8);

                entity.Property(e => e.GpttlBasPr)
                    .HasColumnName("GPTtlBasPr")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrossBuyPr).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrssProfFc)
                    .HasColumnName("GrssProfFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrssProfSc)
                    .HasColumnName("GrssProfSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrssProfit).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Gtotal)
                    .HasColumnName("GTotal")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GtotalFc)
                    .HasColumnName("GTotalFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GtotalSc)
                    .HasColumnName("GTotalSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Height1).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Height2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ImportLog).HasMaxLength(20);

                entity.Property(e => e.Incoterms).HasDefaultValueSql("((0))");

                entity.Property(e => e.Inmprice)
                    .HasColumnName("INMPrice")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.InvQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.InvQtyOnly)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.InvntSttus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.IsAqcuistn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsByPrdct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsSrvCall)
                    .HasColumnName("isSrvCall")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Isdistrb)
                    .HasColumnName("ISDistrb")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.IsdistrbFc)
                    .HasColumnName("ISDistrbFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.IsdistrbSc)
                    .HasColumnName("ISDistrbSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ItemCode).HasMaxLength(20);

                entity.Property(e => e.ItemType).HasDefaultValueSql("((4))");

                entity.Property(e => e.LegalText).HasMaxLength(254);

                entity.Property(e => e.Length1).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Length2)
                    .HasColumnName("length2")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LicTradNum).HasMaxLength(32);

                entity.Property(e => e.LinManClsd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.LinePoPrss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.LineTotal).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LineType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('R')");

                entity.Property(e => e.LineVat).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LineVatS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LineVatlF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LineVendor).HasMaxLength(15);

                entity.Property(e => e.LnExcised)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LogInstanc).HasDefaultValueSql("((0))");

                entity.Property(e => e.LstBinmpr)
                    .HasColumnName("LstBINMPr")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LstByDsFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LstByDsSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LstByDsSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NeedQty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NoInvtryMv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NumPerMsr).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NumPerMsr2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ObjType)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('13')");

                entity.Property(e => e.OcrCode).HasMaxLength(8);

                entity.Property(e => e.OcrCode2).HasMaxLength(8);

                entity.Property(e => e.OcrCode3).HasMaxLength(8);

                entity.Property(e => e.OcrCode4).HasMaxLength(8);

                entity.Property(e => e.OcrCode5).HasMaxLength(8);

                entity.Property(e => e.OpenCreQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OpenInvQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OpenQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OpenRtnQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OpenSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OpenSumFc)
                    .HasColumnName("OpenSumFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OpenSumSys).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OrderedQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OrigItem).HasMaxLength(20);

                entity.Property(e => e.PackQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PartRetire)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PcDocType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PcQuantity).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PickOty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PickStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PoTrgEntry).HasMaxLength(11);

                entity.Property(e => e.PostTax)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.PqtreqDate)
                    .HasColumnName("PQTReqDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PqtreqQty)
                    .HasColumnName("PQTReqQty")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Price).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PriceAfVat)
                    .HasColumnName("PriceAfVAT")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PriceBefDi).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PriceEdit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Project).HasMaxLength(20);

                entity.Property(e => e.QtyToShip).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Rate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ReleasQtty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RetCost).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RetirApcfc)
                    .HasColumnName("RetirAPCFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RetirApcsc)
                    .HasColumnName("RetirAPCSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RetireApc)
                    .HasColumnName("RetireAPC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RetireQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Rg23apart1).HasColumnName("RG23APart1");

                entity.Property(e => e.Rg23apart2).HasColumnName("RG23APart2");

                entity.Property(e => e.Rg23cpart1).HasColumnName("RG23CPart1");

                entity.Property(e => e.Rg23cpart2).HasColumnName("RG23CPart2");

                entity.Property(e => e.SerialNum).HasMaxLength(17);

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.Property(e => e.ShipFromCo).HasMaxLength(50);

                entity.Property(e => e.ShipFromDe).HasMaxLength(254);

                entity.Property(e => e.ShipToCode).HasMaxLength(50);

                entity.Property(e => e.ShipToDesc).HasMaxLength(254);

                entity.Property(e => e.Shortages).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SlpCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SpecPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.StckAppD).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckAppDfc)
                    .HasColumnName("StckAppDFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckAppDsc)
                    .HasColumnName("StckAppDSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckAppFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckAppSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckDstFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckDstSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckDstSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckInmpr)
                    .HasColumnName("StckINMPr")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckSumApp).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StockPrice).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StockSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StockSumFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StockSumSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StockValue).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SubCatNum).HasMaxLength(20);

                entity.Property(e => e.Surpluses).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Sww)
                    .HasColumnName("SWW")
                    .HasMaxLength(16);

                entity.Property(e => e.TargetType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.TaxCode).HasMaxLength(8);

                entity.Property(e => e.TaxDistSfc)
                    .HasColumnName("TaxDistSFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxDistSsc)
                    .HasColumnName("TaxDistSSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxDistSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnly)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPerUnit).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxRelev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.TaxStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.Property(e => e.ThirdParty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ToDiff).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ToStock).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotInclTax).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotalFrgn).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotalSumSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TranType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransMod).HasDefaultValueSql("((0))");

                entity.Property(e => e.TreeType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TrnsCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UGlacctName)
                    .HasColumnName("U_GLAcctName")
                    .HasMaxLength(60);

                entity.Property(e => e.UGrorgOrdQty)
                    .HasColumnName("U_GROrgOrdQty")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UGrpotl)
                    .HasColumnName("U_GRPOTL")
                    .HasMaxLength(15);

                entity.Property(e => e.UReqDate)
                    .HasColumnName("U_ReqDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UnitMsr)
                    .HasColumnName("unitMsr")
                    .HasMaxLength(100);

                entity.Property(e => e.UnitMsr2)
                    .HasColumnName("unitMsr2")
                    .HasMaxLength(100);

                entity.Property(e => e.UomCode).HasMaxLength(20);

                entity.Property(e => e.UomCode2).HasMaxLength(20);

                entity.Property(e => e.UomEntry).HasDefaultValueSql("((0))");

                entity.Property(e => e.UomEntry2).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdInvntry)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.UseBaseUn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.VatAppld).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatAppldFc)
                    .HasColumnName("VatAppldFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatAppldSc)
                    .HasColumnName("VatAppldSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatDscntPr).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatGroup).HasMaxLength(8);

                entity.Property(e => e.VatGrpSrc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.VatPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSumFrgn).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSumSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatWoDpm).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatWoDpmFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatWoDpmSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VendorNum).HasMaxLength(17);

                entity.Property(e => e.Volume).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Weight1).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Weight2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WhsCode).HasMaxLength(8);

                entity.Property(e => e.Width1).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Width2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtCalced)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.WtLiable)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Itt1>(entity =>
            {
                entity.HasKey(e => new { e.Father, e.ChildNum });

                entity.ToTable("ITT1");

                entity.HasIndex(e => e.Code)
                    .HasName("ITT1_CHILD");

                entity.HasIndex(e => e.Father)
                    .HasName("ITT1_FATHER");

                entity.HasIndex(e => e.PriceList)
                    .HasName("ITT1_PRICE_LIST");

                entity.Property(e => e.Father).HasMaxLength(20);

                entity.Property(e => e.AddQuantit).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Comment).HasMaxLength(254);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.IssueMthd)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LineText).HasColumnType("ntext");

                entity.Property(e => e.Object)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('66')");

                entity.Property(e => e.OcrCode).HasMaxLength(8);

                entity.Property(e => e.OcrCode2).HasMaxLength(8);

                entity.Property(e => e.OcrCode3).HasMaxLength(8);

                entity.Property(e => e.OcrCode4).HasMaxLength(8);

                entity.Property(e => e.OcrCode5).HasMaxLength(8);

                entity.Property(e => e.OrigCurr).HasMaxLength(3);

                entity.Property(e => e.OrigPrice).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Price).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PriceList).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrncpInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Project).HasMaxLength(20);

                entity.Property(e => e.Quantity).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Type).HasDefaultValueSql("((4))");

                entity.Property(e => e.Uom).HasMaxLength(100);

                entity.Property(e => e.Warehouse).HasMaxLength(8);

                entity.Property(e => e.WipActCode).HasMaxLength(15);
            });

            modelBuilder.Entity<Oitt>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("OITT");

                entity.HasIndex(e => e.PriceList)
                    .HasName("OITT_PRICE_LIST");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DataSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DispCurr).HasMaxLength(3);

                entity.Property(e => e.HideComp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Object)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('66')");

                entity.Property(e => e.OcrCode).HasMaxLength(8);

                entity.Property(e => e.OcrCode2).HasMaxLength(8);

                entity.Property(e => e.OcrCode3).HasMaxLength(8);

                entity.Property(e => e.OcrCode4).HasMaxLength(8);

                entity.Property(e => e.OcrCode5).HasMaxLength(8);

                entity.Property(e => e.PriceList).HasDefaultValueSql("((0))");

                entity.Property(e => e.Project).HasMaxLength(20);

                entity.Property(e => e.Qauntity).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Scncounter).HasColumnName("SCNCounter");

                entity.Property(e => e.ToWh)
                    .HasColumnName("ToWH")
                    .HasMaxLength(8);

                entity.Property(e => e.Transfered)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TreeType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UseFthrWhs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<Oitm>(entity =>
            {
                entity.HasKey(e => e.ItemCode);

                entity.ToTable("OITM");

                entity.HasIndex(e => e.CommisGrp)
                    .HasName("OITM_COM_GROUP");

                entity.HasIndex(e => e.InvntItem)
                    .HasName("OITM_INVENTORY");

                entity.HasIndex(e => e.ItemName)
                    .HasName("OITM_ITEM_NAME");

                entity.HasIndex(e => e.PrchseItem)
                    .HasName("OITM_PURCHASE");

                entity.HasIndex(e => e.SellItem)
                    .HasName("OITM_SALE");

                entity.HasIndex(e => e.TreeType)
                    .HasName("OITM_TREE_TYPE");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.AcqDate).HasColumnType("datetime");

                entity.Property(e => e.AssblValue).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.AssetAmnt1).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.AssetAmnt2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.AssetClass).HasMaxLength(20);

                entity.Property(e => e.AssetGroup).HasMaxLength(15);

                entity.Property(e => e.AssetItem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AssetRmk1).HasMaxLength(100);

                entity.Property(e => e.AssetRmk2).HasMaxLength(100);

                entity.Property(e => e.AssetSerNo).HasMaxLength(32);

                entity.Property(e => e.AsstStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Attachment).HasColumnType("ntext");

                entity.Property(e => e.AvgPrice).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseUnit).HasMaxLength(20);

                entity.Property(e => e.BeverGrpC).HasMaxLength(2);

                entity.Property(e => e.BeverTblC).HasMaxLength(2);

                entity.Property(e => e.BeverTm)
                    .HasColumnName("BeverTM")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Bheight1)
                    .HasColumnName("BHeight1")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Bheight2)
                    .HasColumnName("BHeight2")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Bhght1Unit).HasColumnName("BHght1Unit");

                entity.Property(e => e.Bhght2Unit).HasColumnName("BHght2Unit");

                entity.Property(e => e.Blen1Unit).HasColumnName("BLen1Unit");

                entity.Property(e => e.Blen2Unit).HasColumnName("BLen2Unit");

                entity.Property(e => e.Blength1)
                    .HasColumnName("BLength1")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Blength2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BlncTrnsfr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BlockOut)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.BuyUnitMsr).HasMaxLength(100);

                entity.Property(e => e.BvolUnit).HasColumnName("BVolUnit");

                entity.Property(e => e.Bvolume)
                    .HasColumnName("BVolume")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Bwdth1Unit).HasColumnName("BWdth1Unit");

                entity.Property(e => e.Bwdth2Unit).HasColumnName("BWdth2Unit");

                entity.Property(e => e.Bweight1)
                    .HasColumnName("BWeight1")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Bweight2)
                    .HasColumnName("BWeight2")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Bwght1Unit).HasColumnName("BWght1Unit");

                entity.Property(e => e.Bwght2Unit).HasColumnName("BWght2Unit");

                entity.Property(e => e.Bwidth1)
                    .HasColumnName("BWidth1")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Bwidth2)
                    .HasColumnName("BWidth2")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ByWh)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Canceled)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CapDate).HasColumnType("datetime");

                entity.Property(e => e.CardCode).HasMaxLength(15);

                entity.Property(e => e.Cession)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ChapterId)
                    .HasColumnName("ChapterID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CntUnitMsr).HasMaxLength(100);

                entity.Property(e => e.CodeBars).HasMaxLength(254);

                entity.Property(e => e.CommisGrp).HasDefaultValueSql("((0))");

                entity.Property(e => e.CommisPcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CommisSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CompoWh)
                    .HasColumnName("CompoWH")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')");

                entity.Property(e => e.Consig).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Counted).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CountryOrg).HasMaxLength(3);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTs).HasColumnName("CreateTS");

                entity.Property(e => e.CstGrpCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CustomPer).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DataSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DeacAftUl)
                    .HasColumnName("DeacAftUL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Deleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DeprGroup).HasMaxLength(15);

                entity.Property(e => e.DfltWh)
                    .HasColumnName("DfltWH")
                    .HasMaxLength(8);

                entity.Property(e => e.Dnfentry)
                    .HasColumnName("DNFEntry")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.EcexpAcc)
                    .HasColumnName("ECExpAcc")
                    .HasMaxLength(15);

                entity.Property(e => e.EcinAcct)
                    .HasColumnName("ECInAcct")
                    .HasMaxLength(15);

                entity.Property(e => e.EvalSystem)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Excisable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ExitCur).HasMaxLength(3);

                entity.Property(e => e.ExitPrice).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExitWh)
                    .HasColumnName("ExitWH")
                    .HasMaxLength(8);

                entity.Property(e => e.ExmptIncom).HasMaxLength(15);

                entity.Property(e => e.ExpensAcct).HasMaxLength(15);

                entity.Property(e => e.ExportCode).HasMaxLength(20);

                entity.Property(e => e.FirmCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.FixCurrCms).HasMaxLength(3);

                entity.Property(e => e.Free)
                    .HasColumnName("FREE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Free1)
                    .HasColumnName("FREE1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FrgnExpAcc).HasMaxLength(15);

                entity.Property(e => e.FrgnInAcct).HasMaxLength(15);

                entity.Property(e => e.FrgnName).HasMaxLength(100);

                entity.Property(e => e.FrozenComm).HasMaxLength(30);

                entity.Property(e => e.FrozenFor)
                    .HasColumnName("frozenFor")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FrozenFrom)
                    .HasColumnName("frozenFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.FrozenTo)
                    .HasColumnName("frozenTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.FuelCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Glmethod)
                    .HasColumnName("GLMethod")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('W')");

                entity.Property(e => e.GlpickMeth)
                    .HasColumnName("GLPickMeth")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.IncomeAcct).HasMaxLength(15);

                entity.Property(e => e.IndirctTax)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.InuoMentry).HasColumnName("INUoMEntry");

                entity.Property(e => e.InventryNo).HasMaxLength(12);

                entity.Property(e => e.InvntItem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.InvntryUom).HasMaxLength(100);

                entity.Property(e => e.IsCommited).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.IssueMthd)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsvcCode)
                    .HasColumnName("ISvcCode")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('2')");

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.ItemType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.ItmsGrpCod).HasDefaultValueSql("((100))");

                entity.Property(e => e.IuoMentry).HasColumnName("IUoMEntry");

                entity.Property(e => e.Iweight1)
                    .HasColumnName("IWeight1")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Iweight2)
                    .HasColumnName("IWeight2")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Iwght1Unit).HasColumnName("IWght1Unit");

                entity.Property(e => e.Iwght2Unit).HasColumnName("IWght2Unit");

                entity.Property(e => e.LastPurCur).HasMaxLength(3);

                entity.Property(e => e.LastPurDat).HasColumnType("datetime");

                entity.Property(e => e.LastPurPrc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LogInstanc).HasDefaultValueSql("((0))");

                entity.Property(e => e.LstEvlDate).HasColumnType("datetime");

                entity.Property(e => e.LstEvlPric).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LstSalDate).HasColumnType("datetime");

                entity.Property(e => e.ManBtchNum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ManOutOnly)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ManSerNum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MatGrp).HasDefaultValueSql("((-1))");

                entity.Property(e => e.MatType)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.MaxLevel).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.MgrByQty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MinLevel).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.MinOrdrQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.MngMethod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('R')");

                entity.Property(e => e.Ncmcode)
                    .HasColumnName("NCMCode")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.NoDiscount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NotifyAsn)
                    .HasColumnName("NotifyASN")
                    .HasMaxLength(40);

                entity.Property(e => e.NumInBuy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NumInCnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NumInSale).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ObjType)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('4')");

                entity.Property(e => e.OnHand).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OnOrder).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OneBoneRec)
                    .HasColumnName("OneBOneRec")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.OpenBlnc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OrdrMulti).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OsvcCode)
                    .HasColumnName("OSvcCode")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Phantom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PicturName).HasMaxLength(200);

                entity.Property(e => e.PlaningSys)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PrchseItem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.PrcrmntMtd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')");

                entity.Property(e => e.PricingPrc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ProAssNum).HasMaxLength(20);

                entity.Property(e => e.ProductSrc)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PuoMentry).HasColumnName("PUoMEntry");

                entity.Property(e => e.PurFactor1).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PurFactor2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PurFactor3).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PurFactor4).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PurFormula).HasMaxLength(40);

                entity.Property(e => e.PurPackMsr).HasMaxLength(30);

                entity.Property(e => e.PurPackUn).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.QryGroup1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup10)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup11)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup12)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup13)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup14)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup15)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup16)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup17)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup18)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup19)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup20)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup21)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup22)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup23)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup24)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup25)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup26)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup27)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup28)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup29)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup30)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup31)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup32)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup33)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup34)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup35)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup36)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup37)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup38)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup39)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup40)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup41)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup42)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup43)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup44)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup45)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup46)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup47)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup48)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup49)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup50)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup51)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup52)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup53)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup54)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup55)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup56)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup57)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup58)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup59)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup60)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup61)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup62)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup63)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup64)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QueryGroup).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReorderPnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ReorderQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RetDate).HasColumnType("datetime");

                entity.Property(e => e.RetilrTax)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RuleCode).HasMaxLength(2);

                entity.Property(e => e.SalFactor1).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SalFactor2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SalFactor3).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SalFactor4).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SalFormula).HasMaxLength(40);

                entity.Property(e => e.SalPackMsr).HasMaxLength(30);

                entity.Property(e => e.SalPackUn).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SalUnitMsr).HasMaxLength(100);

                entity.Property(e => e.Scncounter).HasColumnName("SCNCounter");

                entity.Property(e => e.ScsCode).HasMaxLength(10);

                entity.Property(e => e.SellItem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.SerialNum).HasMaxLength(17);

                entity.Property(e => e.ServiceCtg).HasDefaultValueSql("((-1))");

                entity.Property(e => e.ServiceGrp).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Sheight1)
                    .HasColumnName("SHeight1")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Sheight2)
                    .HasColumnName("SHeight2")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Shght1Unit).HasColumnName("SHght1Unit");

                entity.Property(e => e.Shght2Unit).HasColumnName("SHght2Unit");

                entity.Property(e => e.Slen1Unit).HasColumnName("SLen1Unit");

                entity.Property(e => e.Slen2Unit).HasColumnName("SLen2Unit");

                entity.Property(e => e.Slength1)
                    .HasColumnName("SLength1")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Slength2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SpProdType).HasMaxLength(2);

                entity.Property(e => e.SpcialDisc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Spec).HasMaxLength(30);

                entity.Property(e => e.StatAsset)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.StockValue).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SuoMentry).HasColumnName("SUoMEntry");

                entity.Property(e => e.SuppCatNum).HasMaxLength(17);

                entity.Property(e => e.SvolUnit).HasColumnName("SVolUnit");

                entity.Property(e => e.Svolume)
                    .HasColumnName("SVolume")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Swdth1Unit).HasColumnName("SWdth1Unit");

                entity.Property(e => e.Swdth2Unit).HasColumnName("SWdth2Unit");

                entity.Property(e => e.Sweight1)
                    .HasColumnName("SWeight1")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Sweight2)
                    .HasColumnName("SWeight2")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Swght1Unit).HasColumnName("SWght1Unit");

                entity.Property(e => e.Swght2Unit).HasColumnName("SWght2Unit");

                entity.Property(e => e.Swidth1)
                    .HasColumnName("SWidth1")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Swidth2)
                    .HasColumnName("SWidth2")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Sww)
                    .HasColumnName("SWW")
                    .HasMaxLength(16);

                entity.Property(e => e.TaxCodeAp)
                    .HasColumnName("TaxCodeAP")
                    .HasMaxLength(8);

                entity.Property(e => e.TaxCodeAr)
                    .HasColumnName("TaxCodeAR")
                    .HasMaxLength(8);

                entity.Property(e => e.TaxCtg).HasMaxLength(4);

                entity.Property(e => e.TaxType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.TrackSales)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Transfered)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TreeQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TreeType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UBaseline)
                    .HasColumnName("U_Baseline")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UBomcost)
                    .HasColumnName("U_BOMcost")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UBoyTb0)
                    .IsRequired()
                    .HasColumnName("U_BOY_TB_0")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UBuApp)
                    .HasColumnName("U_BU_APP")
                    .HasMaxLength(30);

                entity.Property(e => e.UCoc)
                    .HasColumnName("U_COC")
                    .HasMaxLength(2);

                entity.Property(e => e.UCreateDate)
                    .HasColumnName("U_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UGrossVolume)
                    .HasColumnName("U_GrossVolume")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ULaborCost)
                    .HasColumnName("U_LaborCost")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UPhadesign)
                    .HasColumnName("U_PHADesign")
                    .HasMaxLength(3);

                entity.Property(e => e.UPhnydesign)
                    .HasColumnName("U_PHNYDesign")
                    .HasMaxLength(3);

                entity.Property(e => e.UPhtBu)
                    .HasColumnName("U_PHT_BU")
                    .HasMaxLength(12);

                entity.Property(e => e.UPhtdesign)
                    .HasColumnName("U_PHTDesign")
                    .HasMaxLength(4);

                entity.Property(e => e.UTariff)
                    .HasColumnName("U_Tariff")
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UTariffHn)
                    .HasColumnName("U_Tariff_HN")
                    .HasMaxLength(12);

                entity.Property(e => e.UTracking1)
                    .HasColumnName("U_Tracking_1")
                    .HasMaxLength(30);

                entity.Property(e => e.UTracking2)
                    .HasColumnName("U_Tracking_2")
                    .HasMaxLength(30);

                entity.Property(e => e.UUserSign)
                    .HasColumnName("U_UserSign")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTs).HasColumnName("UpdateTS");

                entity.Property(e => e.UserText).HasColumnType("ntext");

                entity.Property(e => e.ValidComm).HasMaxLength(30);

                entity.Property(e => e.ValidFor)
                    .HasColumnName("validFor")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("validFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("validTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.VatGourpSa).HasMaxLength(8);

                entity.Property(e => e.VatGroupPu).HasMaxLength(8);

                entity.Property(e => e.Vatliable)
                    .HasColumnName("VATLiable")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.WarrntTmpl).HasMaxLength(20);

                entity.Property(e => e.WasCounted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.WholSlsTax)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Wtliable)
                    .HasColumnName("WTLiable")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<Rin1>(entity =>
            {
                entity.HasKey(e => new { e.DocEntry, e.LineNum });

                entity.ToTable("RIN1");

                entity.HasIndex(e => e.AcctCode)
                    .HasName("RIN1_ACCOUNT");

                entity.HasIndex(e => e.Currency)
                    .HasName("RIN1_CURRENCY");

                entity.HasIndex(e => e.LineStatus)
                    .HasName("RIN1_STATUS");

                entity.HasIndex(e => e.OwnerCode)
                    .HasName("RIN1_OWNER_CODE");

                entity.HasIndex(e => new { e.DocEntry, e.VisOrder })
                    .HasName("RIN1_VIS_ORDER");

                entity.HasIndex(e => new { e.BaseEntry, e.BaseType, e.BaseLine })
                    .HasName("RIN1_BASE_ENTRY");

                entity.HasIndex(e => new { e.ItemCode, e.WhsCode, e.OpenQty })
                    .HasName("RIN1_ITM_WHS_OQ");

                entity.Property(e => e.AcctCode).HasMaxLength(15);

                entity.Property(e => e.ActDelDate).HasColumnType("datetime");

                entity.Property(e => e.Address).HasMaxLength(254);

                entity.Property(e => e.AllocBinC).HasMaxLength(11);

                entity.Property(e => e.AssblValue).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BackOrdr)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BaseAtCard).HasMaxLength(100);

                entity.Property(e => e.BaseCard).HasMaxLength(15);

                entity.Property(e => e.BaseOpnQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BasePrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.BaseQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseRef).HasMaxLength(16);

                entity.Property(e => e.BaseType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.BlockNum).HasMaxLength(100);

                entity.Property(e => e.Ceecflag)
                    .HasColumnName("CEECFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.Cfopcode)
                    .HasColumnName("CFOPCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ChgAsmBoMw)
                    .HasColumnName("ChgAsmBoMW")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CiOppLineN).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CodeBars).HasMaxLength(254);

                entity.Property(e => e.CogsAcct).HasMaxLength(15);

                entity.Property(e => e.CogsOcrCo2).HasMaxLength(8);

                entity.Property(e => e.CogsOcrCo3).HasMaxLength(8);

                entity.Property(e => e.CogsOcrCo4).HasMaxLength(8);

                entity.Property(e => e.CogsOcrCo5).HasMaxLength(8);

                entity.Property(e => e.CogsOcrCod).HasMaxLength(8);

                entity.Property(e => e.Commission).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ConsumeFct)
                    .HasColumnName("ConsumeFCT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOrg).HasMaxLength(3);

                entity.Property(e => e.CredOrigin)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cstcode)
                    .HasColumnName("CSTCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CstfCofins)
                    .HasColumnName("CSTfCOFINS")
                    .HasMaxLength(2);

                entity.Property(e => e.CstfIpi)
                    .HasColumnName("CSTfIPI")
                    .HasMaxLength(2);

                entity.Property(e => e.CstfPis)
                    .HasColumnName("CSTfPIS")
                    .HasMaxLength(2);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.DedVatSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DedVatSumF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DedVatSumS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DefBreak).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DeferrTax)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DelivrdQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DescOw)
                    .HasColumnName("DescOW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DetailsOw)
                    .HasColumnName("DetailsOW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DiscPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DistribExp)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DistribIs)
                    .HasColumnName("DistribIS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DistribSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.DropShip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Dscription).HasMaxLength(100);

                entity.Property(e => e.DstrbSumFc)
                    .HasColumnName("DstrbSumFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DstrbSumSc)
                    .HasColumnName("DstrbSumSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EnSetCost)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EquVatPer).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EquVatSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EquVatSumF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EquVatSumS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExLineNo).HasMaxLength(10);

                entity.Property(e => e.Excisable)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExciseAmt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Factor1).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Factor2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Factor3).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Factor4).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FisrtBin).HasMaxLength(228);

                entity.Property(e => e.Flags).HasDefaultValueSql("((0))");

                entity.Property(e => e.FreeChrgBp)
                    .HasColumnName("FreeChrgBP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FreeTxt).HasMaxLength(100);

                entity.Property(e => e.FromWhsCod).HasMaxLength(8);

                entity.Property(e => e.GpttlBasPr)
                    .HasColumnName("GPTtlBasPr")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrossBuyPr).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrssProfFc)
                    .HasColumnName("GrssProfFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrssProfSc)
                    .HasColumnName("GrssProfSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrssProfit).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Gtotal)
                    .HasColumnName("GTotal")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GtotalFc)
                    .HasColumnName("GTotalFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GtotalSc)
                    .HasColumnName("GTotalSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Height1).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Height2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ImportLog).HasMaxLength(20);

                entity.Property(e => e.Incoterms).HasDefaultValueSql("((0))");

                entity.Property(e => e.Inmprice)
                    .HasColumnName("INMPrice")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.InvQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.InvQtyOnly)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.InvntSttus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.IsAqcuistn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsByPrdct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsSrvCall)
                    .HasColumnName("isSrvCall")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Isdistrb)
                    .HasColumnName("ISDistrb")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.IsdistrbFc)
                    .HasColumnName("ISDistrbFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.IsdistrbSc)
                    .HasColumnName("ISDistrbSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ItemCode).HasMaxLength(20);

                entity.Property(e => e.ItemType).HasDefaultValueSql("((4))");

                entity.Property(e => e.LegalText).HasMaxLength(254);

                entity.Property(e => e.Length1).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Length2)
                    .HasColumnName("length2")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LicTradNum).HasMaxLength(32);

                entity.Property(e => e.LinManClsd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.LinePoPrss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.LineTotal).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LineType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('R')");

                entity.Property(e => e.LineVat).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LineVatS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LineVatlF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LineVendor).HasMaxLength(15);

                entity.Property(e => e.LnExcised)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LogInstanc).HasDefaultValueSql("((0))");

                entity.Property(e => e.LstBinmpr)
                    .HasColumnName("LstBINMPr")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LstByDsFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LstByDsSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LstByDsSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NeedQty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NoInvtryMv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NumPerMsr).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NumPerMsr2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ObjType)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('14')");

                entity.Property(e => e.OcrCode).HasMaxLength(8);

                entity.Property(e => e.OcrCode2).HasMaxLength(8);

                entity.Property(e => e.OcrCode3).HasMaxLength(8);

                entity.Property(e => e.OcrCode4).HasMaxLength(8);

                entity.Property(e => e.OcrCode5).HasMaxLength(8);

                entity.Property(e => e.OpenCreQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OpenInvQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OpenQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OpenRtnQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OpenSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OpenSumFc)
                    .HasColumnName("OpenSumFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OpenSumSys).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OrderedQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OrigItem).HasMaxLength(20);

                entity.Property(e => e.PackQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PartRetire)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PcDocType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PcQuantity).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PickOty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PickStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PoTrgEntry).HasMaxLength(11);

                entity.Property(e => e.PostTax)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.PqtreqDate)
                    .HasColumnName("PQTReqDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PqtreqQty)
                    .HasColumnName("PQTReqQty")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Price).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PriceAfVat)
                    .HasColumnName("PriceAfVAT")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PriceBefDi).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PriceEdit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Project).HasMaxLength(20);

                entity.Property(e => e.QtyToShip).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Rate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ReleasQtty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RetCost).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RetirApcfc)
                    .HasColumnName("RetirAPCFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RetirApcsc)
                    .HasColumnName("RetirAPCSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RetireApc)
                    .HasColumnName("RetireAPC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RetireQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Rg23apart1).HasColumnName("RG23APart1");

                entity.Property(e => e.Rg23apart2).HasColumnName("RG23APart2");

                entity.Property(e => e.Rg23cpart1).HasColumnName("RG23CPart1");

                entity.Property(e => e.Rg23cpart2).HasColumnName("RG23CPart2");

                entity.Property(e => e.SerialNum).HasMaxLength(17);

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.Property(e => e.ShipFromCo).HasMaxLength(50);

                entity.Property(e => e.ShipFromDe).HasMaxLength(254);

                entity.Property(e => e.ShipToCode).HasMaxLength(50);

                entity.Property(e => e.ShipToDesc).HasMaxLength(254);

                entity.Property(e => e.Shortages).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SlpCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SpecPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.StckAppD).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckAppDfc)
                    .HasColumnName("StckAppDFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckAppDsc)
                    .HasColumnName("StckAppDSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckAppFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckAppSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckDstFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckDstSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckDstSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckInmpr)
                    .HasColumnName("StckINMPr")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StckSumApp).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StockPrice).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StockSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StockSumFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StockSumSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StockValue).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SubCatNum).HasMaxLength(20);

                entity.Property(e => e.Surpluses).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Sww)
                    .HasColumnName("SWW")
                    .HasMaxLength(16);

                entity.Property(e => e.TargetType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.TaxCode).HasMaxLength(8);

                entity.Property(e => e.TaxDistSfc)
                    .HasColumnName("TaxDistSFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxDistSsc)
                    .HasColumnName("TaxDistSSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxDistSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnly)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPerUnit).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxRelev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.TaxStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.Property(e => e.ThirdParty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ToDiff).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ToStock).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotInclTax).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotalFrgn).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotalSumSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TranType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransMod).HasDefaultValueSql("((0))");

                entity.Property(e => e.TreeType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TrnsCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UGlacctName)
                    .HasColumnName("U_GLAcctName")
                    .HasMaxLength(60);

                entity.Property(e => e.UGrorgOrdQty)
                    .HasColumnName("U_GROrgOrdQty")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UGrpotl)
                    .HasColumnName("U_GRPOTL")
                    .HasMaxLength(15);

                entity.Property(e => e.UReqDate)
                    .HasColumnName("U_ReqDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UnitMsr)
                    .HasColumnName("unitMsr")
                    .HasMaxLength(100);

                entity.Property(e => e.UnitMsr2)
                    .HasColumnName("unitMsr2")
                    .HasMaxLength(100);

                entity.Property(e => e.UomCode).HasMaxLength(20);

                entity.Property(e => e.UomCode2).HasMaxLength(20);

                entity.Property(e => e.UomEntry).HasDefaultValueSql("((0))");

                entity.Property(e => e.UomEntry2).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdInvntry)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.UseBaseUn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.VatAppld).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatAppldFc)
                    .HasColumnName("VatAppldFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatAppldSc)
                    .HasColumnName("VatAppldSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatDscntPr).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatGroup).HasMaxLength(8);

                entity.Property(e => e.VatGrpSrc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.VatPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSumFrgn).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSumSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatWoDpm).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatWoDpmFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatWoDpmSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VendorNum).HasMaxLength(17);

                entity.Property(e => e.Volume).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Weight1).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Weight2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WhsCode).HasMaxLength(8);

                entity.Property(e => e.Width1).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Width2).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtCalced)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.WtLiable)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ocrd>(entity =>
            {
                entity.HasKey(e => e.CardCode);

                entity.ToTable("OCRD");

                entity.HasIndex(e => e.CardName)
                    .HasName("OCRD_CARD_NAME");

                entity.HasIndex(e => e.CardType)
                    .HasName("OCRD_CARD_TYPE");

                entity.HasIndex(e => e.CommGrCode)
                    .HasName("OCRD_COM_GROUP");

                entity.HasIndex(e => e.Currency)
                    .HasName("OCRD_CURRENCY");

                entity.HasIndex(e => e.DebPayAcct)
                    .HasName("OCRD_PAY_ACCT");

                entity.HasIndex(e => e.DocEntry)
                    .HasName("OCRD_ABS_ENTRY")
                    .IsUnique();

                entity.HasIndex(e => e.FatherCard)
                    .HasName("OCRD_FATHER");

                entity.HasIndex(e => e.GroupNum)
                    .HasName("OCRD_TERMS");

                entity.HasIndex(e => e.ListNum)
                    .HasName("OCRD_PRICE_LIST");

                entity.HasIndex(e => e.OwnerCode)
                    .HasName("OCRD_OWNER_CODE");

                entity.Property(e => e.CardCode)
                    .HasMaxLength(15)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccCritria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AddId)
                    .HasColumnName("AddID")
                    .HasMaxLength(64);

                entity.Property(e => e.AddrType).HasMaxLength(100);

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Affiliate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AgentCode).HasMaxLength(32);

                entity.Property(e => e.AliasName).HasColumnType("ntext");

                entity.Property(e => e.Attachment).HasColumnType("ntext");

                entity.Property(e => e.AutoCalBcg)
                    .HasColumnName("AutoCalBCG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AutoPost)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BackOrder)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.BalTrnsfrd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Balance).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BalanceFc)
                    .HasColumnName("BalanceFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BalanceSys).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('-1')");

                entity.Property(e => e.BankCountr).HasMaxLength(3);

                entity.Property(e => e.BankCtlKey).HasMaxLength(2);

                entity.Property(e => e.Bcacode)
                    .HasColumnName("BCACode")
                    .HasMaxLength(3);

                entity.Property(e => e.BillToDef).HasMaxLength(50);

                entity.Property(e => e.Block).HasMaxLength(100);

                entity.Property(e => e.BlockComm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BlockDunn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Bnkcounter).HasColumnName("BNKCounter");

                entity.Property(e => e.BoEdiscnt)
                    .HasColumnName("BoEDiscnt")
                    .HasMaxLength(15);

                entity.Property(e => e.BoEonClct)
                    .HasColumnName("BoEOnClct")
                    .HasMaxLength(15);

                entity.Property(e => e.BoEprsnt)
                    .HasColumnName("BoEPrsnt")
                    .HasMaxLength(15);

                entity.Property(e => e.Box1099).HasMaxLength(20);

                entity.Property(e => e.Building).HasColumnType("ntext");

                entity.Property(e => e.Business).HasColumnType("ntext");

                entity.Property(e => e.CardFname)
                    .HasColumnName("CardFName")
                    .HasMaxLength(100);

                entity.Property(e => e.CardName).HasMaxLength(100);

                entity.Property(e => e.CardType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.CardValid).HasColumnType("datetime");

                entity.Property(e => e.Cdpnum).HasColumnName("CDPNum");

                entity.Property(e => e.Cellular).HasMaxLength(50);

                entity.Property(e => e.CertBkeep)
                    .HasColumnName("CertBKeep")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CertWht)
                    .HasColumnName("CertWHT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ChainStore)
                    .HasColumnName("chainStore")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ChannlBp)
                    .HasColumnName("ChannlBP")
                    .HasMaxLength(15);

                entity.Property(e => e.ChecksBal).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CmpPrivate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.CntctPrsn).HasMaxLength(90);

                entity.Property(e => e.CollecAuth)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CommGrCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.Commission).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ConCerti).HasMaxLength(20);

                entity.Property(e => e.ConnBp)
                    .HasColumnName("ConnBP")
                    .HasMaxLength(15);

                entity.Property(e => e.Country).HasMaxLength(3);

                entity.Property(e => e.County).HasMaxLength(100);

                entity.Property(e => e.CrCardNum).HasMaxLength(64);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTs).HasColumnName("CreateTS");

                entity.Property(e => e.CreditCard).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreditLine).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CrtfcateNo)
                    .HasColumnName("CrtfcateNO")
                    .HasMaxLength(20);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTill).HasColumnType("datetime");

                entity.Property(e => e.DatevFirst)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.DdctFileNo).HasMaxLength(9);

                entity.Property(e => e.DdctOffice).HasMaxLength(10);

                entity.Property(e => e.DdctPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DdctStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DdgKey).HasDefaultValueSql("((-1))");

                entity.Property(e => e.DdtKey).HasDefaultValueSql("((-1))");

                entity.Property(e => e.DebPayAcct).HasMaxLength(15);

                entity.Property(e => e.DebtLine).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DeferrTax)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Deleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DflAccount).HasMaxLength(50);

                entity.Property(e => e.DflBranch).HasMaxLength(50);

                entity.Property(e => e.DflIban)
                    .HasColumnName("DflIBAN")
                    .HasMaxLength(50);

                entity.Property(e => e.DflSwift).HasMaxLength(50);

                entity.Property(e => e.DiscInRet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DiscRel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('L')");

                entity.Property(e => e.Discount).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Dme)
                    .HasColumnName("DME")
                    .HasMaxLength(5);

                entity.Property(e => e.DnoteBalFc)
                    .HasColumnName("DNoteBalFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DnoteBalSy)
                    .HasColumnName("DNoteBalSy")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DnotesBal)
                    .HasColumnName("DNotesBal")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmClear).HasMaxLength(15);

                entity.Property(e => e.DpmIntAct).HasMaxLength(15);

                entity.Property(e => e.DscntObjct).HasDefaultValueSql("((-1))");

                entity.Property(e => e.DscntRel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('L')");

                entity.Property(e => e.DunTerm).HasMaxLength(25);

                entity.Property(e => e.DunnDate).HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("E_Mail")
                    .HasMaxLength(100);

                entity.Property(e => e.EcvatGroup)
                    .HasColumnName("ECVatGroup")
                    .HasMaxLength(8);

                entity.Property(e => e.EdocExpFrm).HasColumnName("EDocExpFrm");

                entity.Property(e => e.EdrsFromBp)
                    .HasColumnName("EdrsFromBP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.EdrsToBp)
                    .HasColumnName("EdrsToBP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EmplymntCt).HasMaxLength(2);

                entity.Property(e => e.Equ)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ExcptnlEvt)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExemptNo).HasMaxLength(50);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.ExpnPrfFnd).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExportCode).HasMaxLength(8);

                entity.Property(e => e.FatherCard).HasMaxLength(15);

                entity.Property(e => e.FatherType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.FeeAcc).HasMaxLength(15);

                entity.Property(e => e.Free312)
                    .HasColumnName("free312")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Free313)
                    .HasColumnName("free313")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FreeText)
                    .HasColumnName("Free_Text")
                    .HasColumnType("ntext");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FrozenComm).HasMaxLength(30);

                entity.Property(e => e.FrozenFor)
                    .HasColumnName("frozenFor")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FrozenFrom)
                    .HasColumnName("frozenFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.FrozenTo)
                    .HasColumnName("frozenTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.GlblLocNum).HasMaxLength(50);

                entity.Property(e => e.GroupNum).HasDefaultValueSql("((-1))");

                entity.Property(e => e.GtsbankAct)
                    .HasColumnName("GTSBankAct")
                    .HasMaxLength(80);

                entity.Property(e => e.GtsbilAddr)
                    .HasColumnName("GTSBilAddr")
                    .HasMaxLength(80);

                entity.Property(e => e.GtsregNum)
                    .HasColumnName("GTSRegNum")
                    .HasMaxLength(20);

                entity.Property(e => e.HierchDdct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.HldCode).HasMaxLength(20);

                entity.Property(e => e.HousBnkAct).HasMaxLength(50);

                entity.Property(e => e.HousBnkBrn).HasMaxLength(50);

                entity.Property(e => e.HousBnkCry).HasMaxLength(3);

                entity.Property(e => e.HousCtlKey).HasMaxLength(2);

                entity.Property(e => e.HouseBank)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('-1')");

                entity.Property(e => e.HsBnkIban)
                    .HasColumnName("HsBnkIBAN")
                    .HasMaxLength(50);

                entity.Property(e => e.HsBnkSwift).HasMaxLength(50);

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(50);

                entity.Property(e => e.Indicator).HasMaxLength(2);

                entity.Property(e => e.Industry).HasColumnType("ntext");

                entity.Property(e => e.InstrucKey).HasMaxLength(30);

                entity.Property(e => e.InsurOp347)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IntrAcc).HasMaxLength(15);

                entity.Property(e => e.IntrntSite).HasMaxLength(100);

                entity.Property(e => e.IntrstRate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.IsDomestic)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.IsResident)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.IsrbillId)
                    .HasColumnName("ISRBillId")
                    .HasMaxLength(9);

                entity.Property(e => e.Itwtcode)
                    .HasColumnName("ITWTCode")
                    .HasMaxLength(4);

                entity.Property(e => e.Kbkcode)
                    .HasColumnName("KBKCode")
                    .HasMaxLength(20);

                entity.Property(e => e.LetterNum).HasMaxLength(20);

                entity.Property(e => e.LicTradNum).HasMaxLength(32);

                entity.Property(e => e.LocMth)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LogInstanc).HasDefaultValueSql("((0))");

                entity.Property(e => e.MailAddrTy).HasMaxLength(100);

                entity.Property(e => e.MailAddres).HasMaxLength(100);

                entity.Property(e => e.MailBlock).HasMaxLength(100);

                entity.Property(e => e.MailBuildi).HasColumnType("ntext");

                entity.Property(e => e.MailCity).HasMaxLength(100);

                entity.Property(e => e.MailCountr).HasMaxLength(3);

                entity.Property(e => e.MailCounty).HasMaxLength(100);

                entity.Property(e => e.MailStrNo).HasMaxLength(100);

                entity.Property(e => e.MailZipCod).HasMaxLength(20);

                entity.Property(e => e.MandateId)
                    .HasColumnName("MandateID")
                    .HasMaxLength(35);

                entity.Property(e => e.MaxAmount).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.MinIntrst).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.MivzExpSts)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')");

                entity.Property(e => e.Mthcounter).HasColumnName("MTHCounter");

                entity.Property(e => e.Ninum)
                    .HasColumnName("NINum")
                    .HasMaxLength(20);

                entity.Property(e => e.NoDiscount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.NtswebSite).HasColumnName("NTSWebSite");

                entity.Property(e => e.ObjType)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('2')");

                entity.Property(e => e.Okato)
                    .HasColumnName("OKATO")
                    .HasMaxLength(11);

                entity.Property(e => e.Oktmo)
                    .HasColumnName("OKTMO")
                    .HasMaxLength(12);

                entity.Property(e => e.OpCode347)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.OrderBalFc)
                    .HasColumnName("OrderBalFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OrderBalSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OrdersBal).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OtrCtlAcct).HasMaxLength(15);

                entity.Property(e => e.OwnerIdNum).HasMaxLength(15);

                entity.Property(e => e.Pager).HasMaxLength(30);

                entity.Property(e => e.PartDelivr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Password).HasMaxLength(32);

                entity.Property(e => e.PaymBlock)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Phone1).HasMaxLength(20);

                entity.Property(e => e.Phone2).HasMaxLength(20);

                entity.Property(e => e.Picture).HasMaxLength(200);

                entity.Property(e => e.PlngGroup).HasMaxLength(10);

                entity.Property(e => e.PrevYearAc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Priority).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Profession).HasMaxLength(50);

                entity.Property(e => e.ProjectCod).HasMaxLength(20);

                entity.Property(e => e.Protected)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PyBlckDesc).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PymCode)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('-1')");

                entity.Property(e => e.QryGroup1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup10)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup11)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup12)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup13)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup14)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup15)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup16)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup17)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup18)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup19)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup20)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup21)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup22)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup23)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup24)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup25)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup26)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup27)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup28)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup29)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup30)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup31)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup32)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup33)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup34)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup35)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup36)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup37)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup38)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup39)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup40)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup41)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup42)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup43)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup44)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup45)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup46)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup47)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup48)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup49)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup50)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup51)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup52)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup53)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup54)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup55)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup56)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup57)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup58)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup59)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup60)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup61)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup62)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup63)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup64)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.QryGroup9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.RateDifAct).HasMaxLength(15);

                entity.Property(e => e.RcpntId)
                    .HasColumnName("RcpntID")
                    .HasMaxLength(50);

                entity.Property(e => e.RefDetails).HasMaxLength(20);

                entity.Property(e => e.RegNum).HasMaxLength(32);

                entity.Property(e => e.RelCode).HasMaxLength(2);

                entity.Property(e => e.RepName).HasMaxLength(15);

                entity.Property(e => e.ResidenNum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.RoleTypCod).HasMaxLength(2);

                entity.Property(e => e.SEmployed)
                    .HasColumnName("sEmployed")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Scadjust)
                    .HasColumnName("SCAdjust")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Scncounter).HasColumnName("SCNCounter");

                entity.Property(e => e.SefazCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SelfInvoic)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SenderId)
                    .HasColumnName("SenderID")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToDef).HasMaxLength(50);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.SinglePaym)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SlpCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Spgcounter)
                    .HasColumnName("SPGCounter")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sppcounter)
                    .HasColumnName("SPPCounter")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.State1).HasMaxLength(3);

                entity.Property(e => e.State2).HasMaxLength(3);

                entity.Property(e => e.StreetNo).HasMaxLength(100);

                entity.Property(e => e.SurOver)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SysMatchNo).HasDefaultValueSql("((-1))");

                entity.Property(e => e.TaxIdIdent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('3')");

                entity.Property(e => e.TaxRndRule)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('D')");

                entity.Property(e => e.ThreshOver)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.TpCusPres).HasDefaultValueSql("((9))");

                entity.Property(e => e.Transfered)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TypWtreprt)
                    .HasColumnName("TypWTReprt")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.TypeOfOp)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UBoy23Adprtcd)
                    .HasColumnName("U_BOY_23_ADPRTCD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UBoy23Qccs)
                    .HasColumnName("U_BOY_23_QCCS")
                    .HasMaxLength(254);

                entity.Property(e => e.UBoyTb0)
                    .IsRequired()
                    .HasColumnName("U_BOY_TB_0")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UCreateDate)
                    .HasColumnName("U_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UFedEx)
                    .HasColumnName("U_FedEx")
                    .HasMaxLength(50);

                entity.Property(e => e.UIncoPoint)
                    .HasColumnName("U_IncoPoint")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('Hong Kong')");

                entity.Property(e => e.UIncoTerm)
                    .HasColumnName("U_IncoTerm")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('FCA')");

                entity.Property(e => e.UInsAmt)
                    .HasColumnName("U_InsAmt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UMgrList)
                    .HasColumnName("U_MgrList")
                    .HasMaxLength(100);

                entity.Property(e => e.USalesManager)
                    .HasColumnName("U_SalesManager")
                    .HasMaxLength(20);

                entity.Property(e => e.UUps)
                    .HasColumnName("U_UPS")
                    .HasMaxLength(50);

                entity.Property(e => e.UUserList)
                    .HasColumnName("U_UserList")
                    .HasMaxLength(100);

                entity.Property(e => e.UUserSign1)
                    .HasColumnName("U_UserSign1")
                    .HasMaxLength(20);

                entity.Property(e => e.UUserSign2).HasColumnName("U_UserSign2");

                entity.Property(e => e.UnpaidBoE).HasMaxLength(15);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTs).HasColumnName("UpdateTS");

                entity.Property(e => e.UseShpdGd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ValidComm).HasMaxLength(30);

                entity.Property(e => e.ValidFor)
                    .HasColumnName("validFor")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("validFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("validTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidUntil).HasColumnType("datetime");

                entity.Property(e => e.VatGroup).HasMaxLength(8);

                entity.Property(e => e.VatIdUnCmp).HasMaxLength(32);

                entity.Property(e => e.VatIdnum)
                    .HasColumnName("VatIDNum")
                    .HasMaxLength(32);

                entity.Property(e => e.VatStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.VatregNum)
                    .HasColumnName("VATRegNum")
                    .HasMaxLength(32);

                entity.Property(e => e.VendTid).HasColumnName("VendTID");

                entity.Property(e => e.VendorOcup).HasMaxLength(15);

                entity.Property(e => e.VerifNum).HasMaxLength(32);

                entity.Property(e => e.WhshaamGrp)
                    .HasColumnName("WHShaamGrp")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Wtcode)
                    .HasColumnName("WTCode")
                    .HasMaxLength(4);

                entity.Property(e => e.Wtliable)
                    .HasColumnName("WTLiable")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WttaxCat)
                    .HasColumnName("WTTaxCat")
                    .HasColumnType("ntext");

                entity.Property(e => e.ZipCode).HasMaxLength(20);
            });

            modelBuilder.Entity<SalesWorldwide>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("@SALES_WORLDWIDE");

                entity.HasIndex(e => e.Name)
                    .HasName("KSALES_WORLDWIDE_NAME")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UDocMth).HasColumnName("U_DocMth");

                entity.Property(e => e.UDocYr).HasColumnName("U_DocYr");

                entity.Property(e => e.UOrdAmt)
                    .HasColumnName("U_OrdAmt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UPj)
                    .HasColumnName("U_PJ")
                    .HasMaxLength(30);

                entity.Property(e => e.USMgr)
                    .HasColumnName("U_S_Mgr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.USalesAmt)
                    .HasColumnName("U_SalesAmt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.USlpRep)
                    .HasColumnName("U_SlpRep")
                    .HasMaxLength(2);

                entity.Property(e => e.USlpname)
                    .HasColumnName("U_Slpname")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SalesForecast>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("@SALES_FORECAST");

                entity.HasIndex(e => e.Name)
                    .HasName("KSALES_FORECAST_NAME")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UApr)
                    .HasColumnName("U_Apr")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UAug)
                    .HasColumnName("U_Aug")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UCardCode)
                    .HasColumnName("U_CardCode")
                    .HasMaxLength(50);

                entity.Property(e => e.UDec)
                    .HasColumnName("U_Dec")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UFeb)
                    .HasColumnName("U_Feb")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UItemGroup)
                    .HasColumnName("U_ItemGroup")
                    .HasMaxLength(50);

                entity.Property(e => e.UJan)
                    .HasColumnName("U_Jan")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UJul)
                    .HasColumnName("U_Jul")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UJun)
                    .HasColumnName("U_Jun")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ULatestDate)
                    .HasColumnName("U_LatestDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UMar)
                    .HasColumnName("U_Mar")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UMay)
                    .HasColumnName("U_May")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UModel)
                    .HasColumnName("U_Model")
                    .HasMaxLength(100);

                entity.Property(e => e.UNov)
                    .HasColumnName("U_Nov")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UOct)
                    .HasColumnName("U_Oct")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UPj)
                    .HasColumnName("U_PJ")
                    .HasMaxLength(50);

                entity.Property(e => e.UPrice)
                    .HasColumnName("U_price")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.USMgr)
                    .HasColumnName("U_S_Mgr")
                    .HasMaxLength(8);

                entity.Property(e => e.USPerson)
                    .HasColumnName("U_S_Person")
                    .HasMaxLength(50);

                entity.Property(e => e.USRep)
                    .HasColumnName("U_S_Rep")
                    .HasMaxLength(8);

                entity.Property(e => e.USep)
                    .HasColumnName("U_Sep")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UYear).HasColumnName("U_Year");
            });

            modelBuilder.Entity<Ordr>(entity =>
            {
                entity.HasKey(e => e.DocEntry);

                entity.ToTable("ORDR");

                entity.HasIndex(e => e.CardCode)
                    .HasName("ORDR_CUSTOMER");

                entity.HasIndex(e => e.OwnerCode)
                    .HasName("ORDR_OWNER_CODE");

                entity.HasIndex(e => e.Series)
                    .HasName("ORDR_SERIES");

                entity.HasIndex(e => new { e.DocDate, e.Pindicator })
                    .HasName("ORDR_DATE_PIND");

                entity.HasIndex(e => new { e.DocStatus, e.Canceled })
                    .HasName("ORDR_DOC_STATUS");

                entity.HasIndex(e => new { e.Eseries, e.EdocNum })
                    .HasName("ORDR_ESERIES");

                entity.HasIndex(e => new { e.FatherCard, e.FatherType })
                    .HasName("ORDR_FTHR_CARD");

                entity.HasIndex(e => new { e.NumAtCard, e.CardCode })
                    .HasName("ORDR_AT_CARD");

                entity.HasIndex(e => new { e.DocNum, e.Instance, e.Segment, e.DocSubType, e.Pindicator })
                    .HasName("ORDR_NUM")
                    .IsUnique();

                entity.Property(e => e.DocEntry).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(254);

                entity.Property(e => e.Address2).HasMaxLength(254);

                entity.Property(e => e.AgentCode).HasMaxLength(32);

                entity.Property(e => e.AltBaseTyp).HasDefaultValueSql("((-1))");

                entity.Property(e => e.AqcsTax).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.AqcsTaxFc)
                    .HasColumnName("AqcsTaxFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.AqcsTaxSc)
                    .HasColumnName("AqcsTaxSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.AssetDate).HasColumnType("datetime");

                entity.Property(e => e.AtDocType).HasMaxLength(2);

                entity.Property(e => e.Attachment).HasColumnType("ntext");

                entity.Property(e => e.AuthCode).HasMaxLength(250);

                entity.Property(e => e.AutoCrtFlw)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BankCode).HasMaxLength(30);

                entity.Property(e => e.BaseAmnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseAmntFc)
                    .HasColumnName("BaseAmntFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseAmntSc)
                    .HasColumnName("BaseAmntSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseDisc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseDiscFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseDiscPr).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseDiscSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseVtAt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseVtAtFc)
                    .HasColumnName("BaseVtAtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseVtAtSc)
                    .HasColumnName("BaseVtAtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BillToOw)
                    .HasColumnName("BillToOW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BlkCredMmo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BlockDunn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BnkAccount).HasMaxLength(50);

                entity.Property(e => e.BnkBranch).HasMaxLength(50);

                entity.Property(e => e.BnkCntry).HasMaxLength(3);

                entity.Property(e => e.BoeReserev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Box1099).HasMaxLength(20);

                entity.Property(e => e.BpchCntc).HasColumnName("BPChCntc");

                entity.Property(e => e.BpchCode)
                    .HasColumnName("BPChCode")
                    .HasMaxLength(15);

                entity.Property(e => e.Bplid).HasColumnName("BPLId");

                entity.Property(e => e.Bplname)
                    .HasColumnName("BPLName")
                    .HasMaxLength(100);

                entity.Property(e => e.BpnameOw)
                    .HasColumnName("BPNameOW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BuildDesc).HasMaxLength(50);

                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.Canceled)
                    .HasColumnName("CANCELED")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CardCode).HasMaxLength(15);

                entity.Property(e => e.CardName).HasMaxLength(100);

                entity.Property(e => e.CashDiscFc)
                    .HasColumnName("CashDiscFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CashDiscPr).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CashDiscSc)
                    .HasColumnName("CashDiscSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CashDiscnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Ccdentry).HasColumnName("CCDEntry");

                entity.Property(e => e.CdcOffset).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ceecflag)
                    .HasColumnName("CEECFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CertNum).HasMaxLength(31);

                entity.Property(e => e.CertifNum).HasMaxLength(50);

                entity.Property(e => e.CheckDigit)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cig).HasColumnName("CIG");

                entity.Property(e => e.ClosingOpt).HasDefaultValueSql("((1))");

                entity.Property(e => e.ClsDate).HasColumnType("datetime");

                entity.Property(e => e.CntrlBnk).HasMaxLength(15);

                entity.Property(e => e.Comments).HasMaxLength(254);

                entity.Property(e => e.Confirmed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.CopyNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.CorrExt).HasMaxLength(25);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTran)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CreateTs).HasColumnName("CreateTS");

                entity.Property(e => e.CtlAccount).HasMaxLength(15);

                entity.Property(e => e.Cup).HasColumnName("CUP");

                entity.Property(e => e.CurSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.DataSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DeferrTax)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DiscPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DiscSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DiscSumFc)
                    .HasColumnName("DiscSumFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DiscSumSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocCur).HasMaxLength(3);

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.DocDlvry)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DocDueDate).HasColumnType("datetime");

                entity.Property(e => e.DocManClsd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DocRate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.DocSubType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.DocTotal).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocTotalFc)
                    .HasColumnName("DocTotalFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocTotalSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.DpmAmnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAmntFc)
                    .HasColumnName("DpmAmntFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAmntSc)
                    .HasColumnName("DpmAmntSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAppVat).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAppVatF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAppVatS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAppl).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmApplFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmApplSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAsDscnt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DpmDrawn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DpmPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.DpmVat).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmVatFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmVatSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DraftKey)
                    .HasColumnName("draftKey")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.DutyStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.EdocCancel)
                    .HasColumnName("EDocCancel")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EdocCntnt)
                    .HasColumnName("EDocCntnt")
                    .HasColumnType("ntext");

                entity.Property(e => e.EdocErrCod)
                    .HasColumnName("EDocErrCod")
                    .HasMaxLength(50);

                entity.Property(e => e.EdocErrMsg)
                    .HasColumnName("EDocErrMsg")
                    .HasColumnType("ntext");

                entity.Property(e => e.EdocExpFrm).HasColumnName("EDocExpFrm");

                entity.Property(e => e.EdocGenTyp)
                    .HasColumnName("EDocGenTyp")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EdocNum)
                    .HasColumnName("EDocNum")
                    .HasMaxLength(50);

                entity.Property(e => e.EdocPrefix)
                    .HasColumnName("EDocPrefix")
                    .HasMaxLength(10);

                entity.Property(e => e.EdocProces)
                    .HasColumnName("EDocProces")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.EdocStatus)
                    .HasColumnName("EDocStatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.EdocTest)
                    .HasColumnName("EDocTest")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ElCoMsg).HasMaxLength(254);

                entity.Property(e => e.ElCoStatus).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EndDlvDate).HasColumnType("datetime");

                entity.Property(e => e.EnvTypeNfe)
                    .HasColumnName("EnvTypeNFe")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.EquVatSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EquVatSumF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EquVatSumS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Eseries).HasColumnName("ESeries");

                entity.Property(e => e.ExcDocDate).HasColumnType("datetime");

                entity.Property(e => e.ExcRefDate).HasColumnType("datetime");

                entity.Property(e => e.ExcRmvTime).HasMaxLength(8);

                entity.Property(e => e.Excised)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.ExepAmnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExepAmntFc)
                    .HasColumnName("ExepAmntFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExepAmntSc)
                    .HasColumnName("ExepAmntSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpAnFrgn).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpAnSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpAnSys).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpAppl).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpApplFc)
                    .HasColumnName("ExpApplFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpApplSc)
                    .HasColumnName("ExpApplSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Exported)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ExptVat)
                    .HasColumnName("ExptVAt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExptVatFc)
                    .HasColumnName("ExptVAtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExptVatSc)
                    .HasColumnName("ExptVAtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FatherCard).HasMaxLength(15);

                entity.Property(e => e.FatherType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.Filler).HasMaxLength(8);

                entity.Property(e => e.FiscDocNum).HasMaxLength(100);

                entity.Property(e => e.Flags).HasDefaultValueSql("((0))");

                entity.Property(e => e.FlwRefDate).HasColumnType("datetime");

                entity.Property(e => e.FlwRefNum).HasMaxLength(100);

                entity.Property(e => e.FoCfrght)
                    .HasColumnName("FoCFrght")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCfrghtFc)
                    .HasColumnName("FoCFrghtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCfrghtSc)
                    .HasColumnName("FoCFrghtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCtax)
                    .HasColumnName("FoCTax")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCtaxFc)
                    .HasColumnName("FoCTaxFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCtaxSc)
                    .HasColumnName("FoCTaxSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FolioPref).HasMaxLength(4);

                entity.Property(e => e.Footer).HasColumnType("ntext");

                entity.Property(e => e.FreeChrg).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FreeChrgFc)
                    .HasColumnName("FreeChrgFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FreeChrgSc)
                    .HasColumnName("FreeChrgSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.GrosProfFc)
                    .HasColumnName("GrosProfFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrosProfSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrosProfit).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrossBase).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gtsrlvnt)
                    .HasColumnName("GTSRlvnt")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Handwrtten)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Header).HasColumnType("ntext");

                entity.Property(e => e.IgnRelDoc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Indicator).HasMaxLength(2);

                entity.Property(e => e.Installmnt).HasDefaultValueSql("((1))");

                entity.Property(e => e.InsurOp347)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.InterimTyp).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvntDirec)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.InvntSttus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.IsAlt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsCrin)
                    .HasColumnName("isCrin")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsIct)
                    .HasColumnName("IsICT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsIns)
                    .HasColumnName("isIns")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsPaytoBnk)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsReuseNfn)
                    .HasColumnName("IsReuseNFN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsReuseNum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsrcodLine)
                    .HasColumnName("ISRCodLine")
                    .HasMaxLength(53);

                entity.Property(e => e.JrnlMemo).HasMaxLength(50);

                entity.Property(e => e.Kvvatcode)
                    .HasColumnName("KVVATCode")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastPmnTyp)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Letter)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LetterNum).HasMaxLength(20);

                entity.Property(e => e.LicTradNum).HasMaxLength(32);

                entity.Property(e => e.LogInstanc).HasDefaultValueSql("((0))");

                entity.Property(e => e.LpgFolioN).HasColumnName("LPgFolioN");

                entity.Property(e => e.LypmtAt)
                    .HasColumnName("LYPmtAt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LypmtAtFc)
                    .HasColumnName("LYPmtAtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LypmtAtSc)
                    .HasColumnName("LYPmtAtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ManualNum).HasMaxLength(20);

                entity.Property(e => e.Max1099).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.MaxDscn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MinvDate)
                    .HasColumnName("MInvDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MinvNum).HasColumnName("MInvNum");

                entity.Property(e => e.Model)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.NbSbAmntFc)
                    .HasColumnName("NbSbAmntFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NbSbVatFc)
                    .HasColumnName("NbSbVAtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NcorrInv).HasColumnName("NCorrInv");

                entity.Property(e => e.NetProc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NfePrntFo).HasDefaultValueSql("((0))");

                entity.Property(e => e.NfeValue).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NnSbAmnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NnSbAmntSc)
                    .HasColumnName("NnSbAmntSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NnSbVat)
                    .HasColumnName("NnSbVAt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NnSbVatSc)
                    .HasColumnName("NnSbVAtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Notify)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NtsapprNo)
                    .HasColumnName("NTSApprNo")
                    .HasMaxLength(50);

                entity.Property(e => e.Ntsapprov)
                    .HasColumnName("NTSApprov")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NtseTaxNo)
                    .HasColumnName("NTSeTaxNo")
                    .HasMaxLength(50);

                entity.Property(e => e.NtswebSite).HasColumnName("NTSWebSite");

                entity.Property(e => e.NumAtCard).HasMaxLength(100);

                entity.Property(e => e.ObjType)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('17')");

                entity.Property(e => e.OnlineQuo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.OpenForLaC)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Ordered)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.OriginType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.PaidDpm).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidDpmF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidDpmS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidFc)
                    .HasColumnName("PaidFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidSumFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidSumSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidSys).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidToDate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PartSupply)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.PayBlock)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PayDuMonth)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PayToCode).HasMaxLength(50);

                entity.Property(e => e.PaymentRef).HasMaxLength(27);

                entity.Property(e => e.PeyMethod).HasMaxLength(15);

                entity.Property(e => e.Pick)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PickRmrk).HasMaxLength(254);

                entity.Property(e => e.PickStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Pindicator)
                    .IsRequired()
                    .HasColumnName("PIndicator")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PoPrss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PoscashN).HasColumnName("POSCashN");

                entity.Property(e => e.PoseqNum)
                    .HasColumnName("POSEqNum")
                    .HasMaxLength(20);

                entity.Property(e => e.PosmanufSn)
                    .HasColumnName("POSManufSN")
                    .HasMaxLength(20);

                entity.Property(e => e.PosrcptNo).HasColumnName("POSRcptNo");

                entity.Property(e => e.Posted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.PqtgrpHw)
                    .HasColumnName("PQTGrpHW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PqtgrpNum).HasColumnName("PQTGrpNum");

                entity.Property(e => e.PqtgrpSer).HasColumnName("PQTGrpSer");

                entity.Property(e => e.PrintSepa)
                    .HasColumnName("PrintSEPA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Printed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Project).HasMaxLength(20);

                entity.Property(e => e.Pticode)
                    .HasColumnName("PTICode")
                    .HasMaxLength(5);

                entity.Property(e => e.Ref1).HasMaxLength(11);

                entity.Property(e => e.Ref2).HasMaxLength(11);

                entity.Property(e => e.RelatedTyp).HasDefaultValueSql("((-1))");

                entity.Property(e => e.ReopManCls)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReopOriDoc)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReqDate).HasColumnType("datetime");

                entity.Property(e => e.ReqName).HasMaxLength(155);

                entity.Property(e => e.ReqType).HasDefaultValueSql("((12))");

                entity.Property(e => e.Requester).HasMaxLength(8);

                entity.Property(e => e.Reserve)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ResidenNum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.RetInvoice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.RevisionPo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.RoundDif).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RoundDifFc)
                    .HasColumnName("RoundDifFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RoundDifSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Rounding)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SelfInv)
                    .HasColumnName("selfInv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SeriesStr).HasMaxLength(3);

                entity.Property(e => e.ShipToCode).HasMaxLength(50);

                entity.Property(e => e.ShipToOw)
                    .HasColumnName("ShipToOW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ShowScn)
                    .HasColumnName("ShowSCN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SignDigest).HasColumnType("ntext");

                entity.Property(e => e.SignMsg).HasColumnType("ntext");

                entity.Property(e => e.SlpCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SpecDate).HasColumnType("datetime");

                entity.Property(e => e.SplitTax).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SplitTaxFc)
                    .HasColumnName("SplitTaxFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SplitTaxSc)
                    .HasColumnName("SplitTaxSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SrvGpPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SrvTaxRule)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Ssiexmpt)
                    .HasColumnName("SSIExmpt")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StDlvDate).HasColumnType("datetime");

                entity.Property(e => e.StampNum).HasMaxLength(16);

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.SubStr).HasMaxLength(3);

                entity.Property(e => e.Submitted)
                    .HasColumnName("submitted")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SumAbsId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SumRptDate).HasColumnType("datetime");

                entity.Property(e => e.SummryType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SupplCode).HasMaxLength(254);

                entity.Property(e => e.Supplier).HasMaxLength(15);

                entity.Property(e => e.SysRate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxDate).HasColumnType("datetime");

                entity.Property(e => e.TaxOnExAp).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExApF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExApS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExp).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExpFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExpSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ToBinCode).HasMaxLength(228);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToWhsCode).HasMaxLength(8);

                entity.Property(e => e.TotalExpFc)
                    .HasColumnName("TotalExpFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotalExpSc)
                    .HasColumnName("TotalExpSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotalExpns).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TrackNo).HasMaxLength(30);

                entity.Property(e => e.Transfered)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TrnspCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.TxInvRptDt).HasColumnType("datetime");

                entity.Property(e => e.TxInvRptNo).HasMaxLength(10);

                entity.Property(e => e.UAgingDays).HasColumnName("U_AgingDays");

                entity.Property(e => e.UAprefNo)
                    .HasColumnName("U_APRefNo")
                    .HasMaxLength(20);

                entity.Property(e => e.UCreateDate)
                    .HasColumnName("U_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UEcsDocFreight)
                    .HasColumnName("U_ECS_DOC_FREIGHT")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('0.0')");

                entity.Property(e => e.UIncoPoint)
                    .HasColumnName("U_IncoPoint")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('Hong Kong')");

                entity.Property(e => e.UIncoTerm)
                    .HasColumnName("U_IncoTerm")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('FCA')");

                entity.Property(e => e.UItnNumber)
                    .HasColumnName("U_ItnNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.UIvcivpdate)
                    .HasColumnName("U_IVCIVPDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UIvcivpno)
                    .HasColumnName("U_IVCIVPNo")
                    .HasMaxLength(50);

                entity.Property(e => e.UMemo1)
                    .HasColumnName("U_Memo1")
                    .HasMaxLength(200);

                entity.Property(e => e.UOrderFor)
                    .HasColumnName("U_OrderFor")
                    .HasMaxLength(15);

                entity.Property(e => e.URemarks2)
                    .HasColumnName("U_Remarks2")
                    .HasMaxLength(200);

                entity.Property(e => e.USalesAmt)
                    .HasColumnName("U_SalesAmt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.USalesManager)
                    .HasColumnName("U_SalesManager")
                    .HasMaxLength(20);

                entity.Property(e => e.USono)
                    .HasColumnName("U_SONo")
                    .HasMaxLength(10);

                entity.Property(e => e.UTlno)
                    .HasColumnName("U_TLNo")
                    .HasMaxLength(15);

                entity.Property(e => e.UpdCardBal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UpdInvnt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTs).HasColumnName("UpdateTS");

                entity.Property(e => e.UseCorrVat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UseShpdGd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.VatDate).HasColumnType("datetime");

                entity.Property(e => e.VatJenum)
                    .HasColumnName("VatJENum")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.VatPaid).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatPaidFc)
                    .HasColumnName("VatPaidFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatPaidSys).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatPercent).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSumFc)
                    .HasColumnName("VatSumFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSumSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Vatfirst)
                    .HasColumnName("VATFirst")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VatregNum)
                    .HasColumnName("VATRegNum")
                    .HasMaxLength(32);

                entity.Property(e => e.VclPlate).HasMaxLength(20);

                entity.Property(e => e.VersionNum).HasMaxLength(11);

                entity.Property(e => e.Volume).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WddStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Weight).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Wtapplied)
                    .HasColumnName("WTApplied")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtappliedF)
                    .HasColumnName("WTAppliedF")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtappliedS)
                    .HasColumnName("WTAppliedS")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Wtdetails)
                    .HasColumnName("WTDetails")
                    .HasMaxLength(100);

                entity.Property(e => e.Wtsum)
                    .HasColumnName("WTSum")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtsumFc)
                    .HasColumnName("WTSumFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtsumSc)
                    .HasColumnName("WTSumSC")
                    .HasColumnType("numeric(19, 6)");
            });

            modelBuilder.Entity<Orin>(entity =>
            {
                entity.HasKey(e => e.DocEntry);

                entity.ToTable("ORIN");

                entity.HasIndex(e => e.CardCode)
                    .HasName("ORIN_CUSTOMER");

                entity.HasIndex(e => e.FolSeries)
                    .HasName("ORIN_FOL_SERIES");

                entity.HasIndex(e => e.OwnerCode)
                    .HasName("ORIN_OWNER_CODE");

                entity.HasIndex(e => e.Series)
                    .HasName("ORIN_SERIES");

                entity.HasIndex(e => new { e.DocDate, e.Pindicator })
                    .HasName("ORIN_DATE_PIND");

                entity.HasIndex(e => new { e.DocStatus, e.Canceled })
                    .HasName("ORIN_DOC_STATUS");

                entity.HasIndex(e => new { e.Eseries, e.EdocNum })
                    .HasName("ORIN_ESERIES");

                entity.HasIndex(e => new { e.FatherCard, e.FatherType })
                    .HasName("ORIN_FTHR_CARD");

                entity.HasIndex(e => new { e.NumAtCard, e.CardCode })
                    .HasName("ORIN_AT_CARD");

                entity.HasIndex(e => new { e.DocNum, e.Instance, e.Segment, e.DocSubType, e.Pindicator })
                    .HasName("ORIN_NUM");

                entity.Property(e => e.DocEntry).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(254);

                entity.Property(e => e.Address2).HasMaxLength(254);

                entity.Property(e => e.AgentCode).HasMaxLength(32);

                entity.Property(e => e.AltBaseTyp).HasDefaultValueSql("((-1))");

                entity.Property(e => e.AqcsTax).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.AqcsTaxFc)
                    .HasColumnName("AqcsTaxFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.AqcsTaxSc)
                    .HasColumnName("AqcsTaxSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.AssetDate).HasColumnType("datetime");

                entity.Property(e => e.AtDocType).HasMaxLength(2);

                entity.Property(e => e.Attachment).HasColumnType("ntext");

                entity.Property(e => e.AuthCode).HasMaxLength(250);

                entity.Property(e => e.AutoCrtFlw)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BankCode).HasMaxLength(30);

                entity.Property(e => e.BaseAmnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseAmntFc)
                    .HasColumnName("BaseAmntFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseAmntSc)
                    .HasColumnName("BaseAmntSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseDisc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseDiscFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseDiscPr).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseDiscSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseVtAt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseVtAtFc)
                    .HasColumnName("BaseVtAtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseVtAtSc)
                    .HasColumnName("BaseVtAtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BillToOw)
                    .HasColumnName("BillToOW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BlkCredMmo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BlockDunn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BnkAccount).HasMaxLength(50);

                entity.Property(e => e.BnkBranch).HasMaxLength(50);

                entity.Property(e => e.BnkCntry).HasMaxLength(3);

                entity.Property(e => e.BoeReserev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Box1099).HasMaxLength(20);

                entity.Property(e => e.BpchCntc).HasColumnName("BPChCntc");

                entity.Property(e => e.BpchCode)
                    .HasColumnName("BPChCode")
                    .HasMaxLength(15);

                entity.Property(e => e.Bplid).HasColumnName("BPLId");

                entity.Property(e => e.Bplname)
                    .HasColumnName("BPLName")
                    .HasMaxLength(100);

                entity.Property(e => e.BpnameOw)
                    .HasColumnName("BPNameOW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BuildDesc).HasMaxLength(50);

                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.Canceled)
                    .HasColumnName("CANCELED")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CardCode).HasMaxLength(15);

                entity.Property(e => e.CardName).HasMaxLength(100);

                entity.Property(e => e.CashDiscFc)
                    .HasColumnName("CashDiscFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CashDiscPr).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CashDiscSc)
                    .HasColumnName("CashDiscSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CashDiscnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Ccdentry).HasColumnName("CCDEntry");

                entity.Property(e => e.CdcOffset).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ceecflag)
                    .HasColumnName("CEECFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CertNum).HasMaxLength(31);

                entity.Property(e => e.CertifNum).HasMaxLength(50);

                entity.Property(e => e.CheckDigit)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cig).HasColumnName("CIG");

                entity.Property(e => e.ClosingOpt).HasDefaultValueSql("((1))");

                entity.Property(e => e.ClsDate).HasColumnType("datetime");

                entity.Property(e => e.CntrlBnk).HasMaxLength(15);

                entity.Property(e => e.Comments).HasMaxLength(254);

                entity.Property(e => e.Confirmed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.CopyNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.CorrExt).HasMaxLength(25);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTran)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CreateTs).HasColumnName("CreateTS");

                entity.Property(e => e.CtlAccount).HasMaxLength(15);

                entity.Property(e => e.Cup).HasColumnName("CUP");

                entity.Property(e => e.CurSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.DataSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DeferrTax)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DiscPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DiscSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DiscSumFc)
                    .HasColumnName("DiscSumFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DiscSumSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocCur).HasMaxLength(3);

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.DocDlvry)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DocDueDate).HasColumnType("datetime");

                entity.Property(e => e.DocManClsd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DocRate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.DocSubType)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.DocTotal).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocTotalFc)
                    .HasColumnName("DocTotalFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocTotalSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.DpmAmnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAmntFc)
                    .HasColumnName("DpmAmntFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAmntSc)
                    .HasColumnName("DpmAmntSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAppVat).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAppVatF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAppVatS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAppl).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmApplFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmApplSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAsDscnt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DpmDrawn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DpmPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.DpmVat).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmVatFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmVatSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DraftKey)
                    .HasColumnName("draftKey")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.DutyStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.EdocCancel)
                    .HasColumnName("EDocCancel")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EdocCntnt)
                    .HasColumnName("EDocCntnt")
                    .HasColumnType("ntext");

                entity.Property(e => e.EdocErrCod)
                    .HasColumnName("EDocErrCod")
                    .HasMaxLength(50);

                entity.Property(e => e.EdocErrMsg)
                    .HasColumnName("EDocErrMsg")
                    .HasColumnType("ntext");

                entity.Property(e => e.EdocExpFrm).HasColumnName("EDocExpFrm");

                entity.Property(e => e.EdocGenTyp)
                    .HasColumnName("EDocGenTyp")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EdocNum)
                    .HasColumnName("EDocNum")
                    .HasMaxLength(50);

                entity.Property(e => e.EdocPrefix)
                    .HasColumnName("EDocPrefix")
                    .HasMaxLength(10);

                entity.Property(e => e.EdocProces)
                    .HasColumnName("EDocProces")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.EdocStatus)
                    .HasColumnName("EDocStatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.EdocTest)
                    .HasColumnName("EDocTest")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ElCoMsg).HasMaxLength(254);

                entity.Property(e => e.ElCoStatus).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EndDlvDate).HasColumnType("datetime");

                entity.Property(e => e.EnvTypeNfe)
                    .HasColumnName("EnvTypeNFe")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.EquVatSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EquVatSumF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EquVatSumS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Eseries).HasColumnName("ESeries");

                entity.Property(e => e.ExcDocDate).HasColumnType("datetime");

                entity.Property(e => e.ExcRefDate).HasColumnType("datetime");

                entity.Property(e => e.ExcRmvTime).HasMaxLength(8);

                entity.Property(e => e.Excised)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.ExepAmnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExepAmntFc)
                    .HasColumnName("ExepAmntFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExepAmntSc)
                    .HasColumnName("ExepAmntSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpAnFrgn).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpAnSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpAnSys).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpAppl).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpApplFc)
                    .HasColumnName("ExpApplFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpApplSc)
                    .HasColumnName("ExpApplSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Exported)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ExptVat)
                    .HasColumnName("ExptVAt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExptVatFc)
                    .HasColumnName("ExptVAtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExptVatSc)
                    .HasColumnName("ExptVAtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FatherCard).HasMaxLength(15);

                entity.Property(e => e.FatherType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.Filler).HasMaxLength(8);

                entity.Property(e => e.FiscDocNum).HasMaxLength(100);

                entity.Property(e => e.Flags).HasDefaultValueSql("((0))");

                entity.Property(e => e.FlwRefDate).HasColumnType("datetime");

                entity.Property(e => e.FlwRefNum).HasMaxLength(100);

                entity.Property(e => e.FoCfrght)
                    .HasColumnName("FoCFrght")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCfrghtFc)
                    .HasColumnName("FoCFrghtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCfrghtSc)
                    .HasColumnName("FoCFrghtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCtax)
                    .HasColumnName("FoCTax")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCtaxFc)
                    .HasColumnName("FoCTaxFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCtaxSc)
                    .HasColumnName("FoCTaxSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FolioPref).HasMaxLength(4);

                entity.Property(e => e.Footer).HasColumnType("ntext");

                entity.Property(e => e.FreeChrg).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FreeChrgFc)
                    .HasColumnName("FreeChrgFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FreeChrgSc)
                    .HasColumnName("FreeChrgSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.GrosProfFc)
                    .HasColumnName("GrosProfFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrosProfSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrosProfit).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrossBase).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gtsrlvnt)
                    .HasColumnName("GTSRlvnt")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Handwrtten)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Header).HasColumnType("ntext");

                entity.Property(e => e.IgnRelDoc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Indicator).HasMaxLength(2);

                entity.Property(e => e.Installmnt).HasDefaultValueSql("((1))");

                entity.Property(e => e.Instance).HasDefaultValueSql("((0))");

                entity.Property(e => e.InsurOp347)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.InterimTyp).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvntDirec)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.InvntSttus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.IsAlt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsCrin)
                    .HasColumnName("isCrin")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsIct)
                    .HasColumnName("IsICT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsIns)
                    .HasColumnName("isIns")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsPaytoBnk)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsReuseNfn)
                    .HasColumnName("IsReuseNFN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsReuseNum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsrcodLine)
                    .HasColumnName("ISRCodLine")
                    .HasMaxLength(53);

                entity.Property(e => e.JrnlMemo).HasMaxLength(50);

                entity.Property(e => e.Kvvatcode)
                    .HasColumnName("KVVATCode")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastPmnTyp)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Letter)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LetterNum).HasMaxLength(20);

                entity.Property(e => e.LicTradNum).HasMaxLength(32);

                entity.Property(e => e.LogInstanc).HasDefaultValueSql("((0))");

                entity.Property(e => e.LpgFolioN).HasColumnName("LPgFolioN");

                entity.Property(e => e.LypmtAt)
                    .HasColumnName("LYPmtAt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LypmtAtFc)
                    .HasColumnName("LYPmtAtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LypmtAtSc)
                    .HasColumnName("LYPmtAtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ManualNum).HasMaxLength(20);

                entity.Property(e => e.Max1099).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.MaxDscn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MinvDate)
                    .HasColumnName("MInvDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MinvNum).HasColumnName("MInvNum");

                entity.Property(e => e.Model)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.NbSbAmntFc)
                    .HasColumnName("NbSbAmntFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NbSbVatFc)
                    .HasColumnName("NbSbVAtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NcorrInv).HasColumnName("NCorrInv");

                entity.Property(e => e.NetProc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NfePrntFo).HasDefaultValueSql("((0))");

                entity.Property(e => e.NfeValue).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NnSbAmnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NnSbAmntSc)
                    .HasColumnName("NnSbAmntSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NnSbVat)
                    .HasColumnName("NnSbVAt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NnSbVatSc)
                    .HasColumnName("NnSbVAtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Notify)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NtsapprNo)
                    .HasColumnName("NTSApprNo")
                    .HasMaxLength(50);

                entity.Property(e => e.Ntsapprov)
                    .HasColumnName("NTSApprov")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NtseTaxNo)
                    .HasColumnName("NTSeTaxNo")
                    .HasMaxLength(50);

                entity.Property(e => e.NtswebSite).HasColumnName("NTSWebSite");

                entity.Property(e => e.NumAtCard).HasMaxLength(100);

                entity.Property(e => e.ObjType)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('14')");

                entity.Property(e => e.OnlineQuo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.OpenForLaC)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Ordered)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.OriginType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.PaidDpm).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidDpmF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidDpmS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidFc)
                    .HasColumnName("PaidFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidSumFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidSumSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidSys).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidToDate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PartSupply)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.PayBlock)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PayDuMonth)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PayToCode).HasMaxLength(50);

                entity.Property(e => e.PaymentRef).HasMaxLength(27);

                entity.Property(e => e.PeyMethod).HasMaxLength(15);

                entity.Property(e => e.Pick)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PickRmrk).HasMaxLength(254);

                entity.Property(e => e.PickStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Pindicator)
                    .HasColumnName("PIndicator")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PoPrss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PoscashN).HasColumnName("POSCashN");

                entity.Property(e => e.PoseqNum)
                    .HasColumnName("POSEqNum")
                    .HasMaxLength(20);

                entity.Property(e => e.PosmanufSn)
                    .HasColumnName("POSManufSN")
                    .HasMaxLength(20);

                entity.Property(e => e.PosrcptNo).HasColumnName("POSRcptNo");

                entity.Property(e => e.Posted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.PqtgrpHw)
                    .HasColumnName("PQTGrpHW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PqtgrpNum).HasColumnName("PQTGrpNum");

                entity.Property(e => e.PqtgrpSer).HasColumnName("PQTGrpSer");

                entity.Property(e => e.PrintSepa)
                    .HasColumnName("PrintSEPA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Printed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Project).HasMaxLength(20);

                entity.Property(e => e.Pticode)
                    .HasColumnName("PTICode")
                    .HasMaxLength(5);

                entity.Property(e => e.Ref1).HasMaxLength(11);

                entity.Property(e => e.Ref2).HasMaxLength(11);

                entity.Property(e => e.RelatedTyp).HasDefaultValueSql("((-1))");

                entity.Property(e => e.ReopManCls)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReopOriDoc)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReqDate).HasColumnType("datetime");

                entity.Property(e => e.ReqName).HasMaxLength(155);

                entity.Property(e => e.ReqType).HasDefaultValueSql("((12))");

                entity.Property(e => e.Requester).HasMaxLength(8);

                entity.Property(e => e.Reserve)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ResidenNum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.RetInvoice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.RevisionPo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.RoundDif).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RoundDifFc)
                    .HasColumnName("RoundDifFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RoundDifSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Rounding)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Segment).HasDefaultValueSql("((0))");

                entity.Property(e => e.SelfInv)
                    .HasColumnName("selfInv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SeriesStr).HasMaxLength(3);

                entity.Property(e => e.ShipToCode).HasMaxLength(50);

                entity.Property(e => e.ShipToOw)
                    .HasColumnName("ShipToOW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ShowScn)
                    .HasColumnName("ShowSCN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SignDigest).HasColumnType("ntext");

                entity.Property(e => e.SignMsg).HasColumnType("ntext");

                entity.Property(e => e.SlpCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SpecDate).HasColumnType("datetime");

                entity.Property(e => e.SplitTax).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SplitTaxFc)
                    .HasColumnName("SplitTaxFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SplitTaxSc)
                    .HasColumnName("SplitTaxSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SrvGpPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SrvTaxRule)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Ssiexmpt)
                    .HasColumnName("SSIExmpt")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StDlvDate).HasColumnType("datetime");

                entity.Property(e => e.StampNum).HasMaxLength(16);

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.SubStr).HasMaxLength(3);

                entity.Property(e => e.Submitted)
                    .HasColumnName("submitted")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SumAbsId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SumRptDate).HasColumnType("datetime");

                entity.Property(e => e.SummryType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SupplCode).HasMaxLength(254);

                entity.Property(e => e.Supplier).HasMaxLength(15);

                entity.Property(e => e.SysRate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxDate).HasColumnType("datetime");

                entity.Property(e => e.TaxOnExAp).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExApF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExApS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExp).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExpFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExpSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ToBinCode).HasMaxLength(228);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToWhsCode).HasMaxLength(8);

                entity.Property(e => e.TotalExpFc)
                    .HasColumnName("TotalExpFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotalExpSc)
                    .HasColumnName("TotalExpSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotalExpns).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TrackNo).HasMaxLength(30);

                entity.Property(e => e.Transfered)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TrnspCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.TxInvRptDt).HasColumnType("datetime");

                entity.Property(e => e.TxInvRptNo).HasMaxLength(10);

                entity.Property(e => e.UAgingDays).HasColumnName("U_AgingDays");

                entity.Property(e => e.UAprefNo)
                    .HasColumnName("U_APRefNo")
                    .HasMaxLength(20);

                entity.Property(e => e.UCreateDate)
                    .HasColumnName("U_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UEcsDocFreight)
                    .HasColumnName("U_ECS_DOC_FREIGHT")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('0.0')");

                entity.Property(e => e.UIncoPoint)
                    .HasColumnName("U_IncoPoint")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('Hong Kong')");

                entity.Property(e => e.UIncoTerm)
                    .HasColumnName("U_IncoTerm")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('FCA')");

                entity.Property(e => e.UItnNumber)
                    .HasColumnName("U_ItnNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.UIvcivpdate)
                    .HasColumnName("U_IVCIVPDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UIvcivpno)
                    .HasColumnName("U_IVCIVPNo")
                    .HasMaxLength(50);

                entity.Property(e => e.UMemo1)
                    .HasColumnName("U_Memo1")
                    .HasMaxLength(200);

                entity.Property(e => e.UOrderFor)
                    .HasColumnName("U_OrderFor")
                    .HasMaxLength(15);

                entity.Property(e => e.URemarks2)
                    .HasColumnName("U_Remarks2")
                    .HasMaxLength(200);

                entity.Property(e => e.USalesAmt)
                    .HasColumnName("U_SalesAmt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.USalesManager)
                    .HasColumnName("U_SalesManager")
                    .HasMaxLength(20);

                entity.Property(e => e.USono)
                    .HasColumnName("U_SONo")
                    .HasMaxLength(10);

                entity.Property(e => e.UTlno)
                    .HasColumnName("U_TLNo")
                    .HasMaxLength(15);

                entity.Property(e => e.UpdCardBal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UpdInvnt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTs).HasColumnName("UpdateTS");

                entity.Property(e => e.UseCorrVat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UseShpdGd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.VatDate).HasColumnType("datetime");

                entity.Property(e => e.VatJenum)
                    .HasColumnName("VatJENum")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.VatPaid).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatPaidFc)
                    .HasColumnName("VatPaidFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatPaidSys).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatPercent).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSumFc)
                    .HasColumnName("VatSumFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSumSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Vatfirst)
                    .HasColumnName("VATFirst")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VatregNum)
                    .HasColumnName("VATRegNum")
                    .HasMaxLength(32);

                entity.Property(e => e.VclPlate).HasMaxLength(20);

                entity.Property(e => e.VersionNum).HasMaxLength(11);

                entity.Property(e => e.Volume).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WddStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Weight).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Wtapplied)
                    .HasColumnName("WTApplied")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtappliedF)
                    .HasColumnName("WTAppliedF")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtappliedS)
                    .HasColumnName("WTAppliedS")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Wtdetails)
                    .HasColumnName("WTDetails")
                    .HasMaxLength(100);

                entity.Property(e => e.Wtsum)
                    .HasColumnName("WTSum")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtsumFc)
                    .HasColumnName("WTSumFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtsumSc)
                    .HasColumnName("WTSumSC")
                    .HasColumnType("numeric(19, 6)");
            });

            modelBuilder.Entity<Ufd1>(entity =>
            {
                entity.HasKey(e => new { e.TableId, e.FieldId, e.IndexId });

                entity.ToTable("UFD1");

                entity.Property(e => e.TableId)
                    .HasColumnName("TableID")
                    .HasMaxLength(20);

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.Descr).HasMaxLength(254);

                entity.Property(e => e.FldDate).HasColumnType("datetime");

                entity.Property(e => e.FldValue).HasMaxLength(254);
            });

            modelBuilder.Entity<Oinv>(entity =>
            {
                entity.HasKey(e => e.DocEntry);

                entity.ToTable("OINV");

                entity.HasIndex(e => e.CardCode)
                    .HasName("OINV_CUSTOMER");

                entity.HasIndex(e => e.FolSeries)
                    .HasName("OINV_FOL_SERIES");

                entity.HasIndex(e => e.OwnerCode)
                    .HasName("OINV_OWNER_CODE");

                entity.HasIndex(e => e.Series)
                    .HasName("OINV_SERIES");

                entity.HasIndex(e => new { e.DocDate, e.Pindicator })
                    .HasName("OINV_DATE_PIND");

                entity.HasIndex(e => new { e.DocStatus, e.Canceled })
                    .HasName("OINV_DOC_STATUS");

                entity.HasIndex(e => new { e.Eseries, e.EdocNum })
                    .HasName("OINV_ESERIES");

                entity.HasIndex(e => new { e.FatherCard, e.FatherType })
                    .HasName("OINV_FTHR_CARD");

                entity.HasIndex(e => new { e.NumAtCard, e.CardCode })
                    .HasName("OINV_AT_CARD");

                entity.HasIndex(e => new { e.InvntSttus, e.Canceled, e.IsIns })
                    .HasName("OINV_STS_CNCL");

                entity.HasIndex(e => new { e.DocNum, e.Instance, e.Segment, e.DocSubType, e.Pindicator })
                    .HasName("OINV_NUM");

                entity.Property(e => e.DocEntry).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(254);

                entity.Property(e => e.Address2).HasMaxLength(254);

                entity.Property(e => e.AgentCode).HasMaxLength(32);

                entity.Property(e => e.AltBaseTyp).HasDefaultValueSql("((-1))");

                entity.Property(e => e.AqcsTax).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.AqcsTaxFc)
                    .HasColumnName("AqcsTaxFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.AqcsTaxSc)
                    .HasColumnName("AqcsTaxSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.AssetDate).HasColumnType("datetime");

                entity.Property(e => e.AtDocType).HasMaxLength(2);

                entity.Property(e => e.Attachment).HasColumnType("ntext");

                entity.Property(e => e.AuthCode).HasMaxLength(250);

                entity.Property(e => e.AutoCrtFlw)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BankCode).HasMaxLength(30);

                entity.Property(e => e.BaseAmnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseAmntFc)
                    .HasColumnName("BaseAmntFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseAmntSc)
                    .HasColumnName("BaseAmntSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseDisc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseDiscFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseDiscPr).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseDiscSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseVtAt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseVtAtFc)
                    .HasColumnName("BaseVtAtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BaseVtAtSc)
                    .HasColumnName("BaseVtAtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BillToOw)
                    .HasColumnName("BillToOW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BlkCredMmo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BlockDunn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BnkAccount).HasMaxLength(50);

                entity.Property(e => e.BnkBranch).HasMaxLength(50);

                entity.Property(e => e.BnkCntry).HasMaxLength(3);

                entity.Property(e => e.BoeReserev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Box1099).HasMaxLength(20);

                entity.Property(e => e.BpchCntc).HasColumnName("BPChCntc");

                entity.Property(e => e.BpchCode)
                    .HasColumnName("BPChCode")
                    .HasMaxLength(15);

                entity.Property(e => e.Bplid).HasColumnName("BPLId");

                entity.Property(e => e.Bplname)
                    .HasColumnName("BPLName")
                    .HasMaxLength(100);

                entity.Property(e => e.BpnameOw)
                    .HasColumnName("BPNameOW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BuildDesc).HasMaxLength(50);

                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.Canceled)
                    .HasColumnName("CANCELED")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CardCode).HasMaxLength(15);

                entity.Property(e => e.CardName).HasMaxLength(100);

                entity.Property(e => e.CashDiscFc)
                    .HasColumnName("CashDiscFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CashDiscPr).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CashDiscSc)
                    .HasColumnName("CashDiscSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CashDiscnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Ccdentry).HasColumnName("CCDEntry");

                entity.Property(e => e.CdcOffset).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ceecflag)
                    .HasColumnName("CEECFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CertNum).HasMaxLength(31);

                entity.Property(e => e.CertifNum).HasMaxLength(50);

                entity.Property(e => e.CheckDigit)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cig).HasColumnName("CIG");

                entity.Property(e => e.ClosingOpt).HasDefaultValueSql("((1))");

                entity.Property(e => e.ClsDate).HasColumnType("datetime");

                entity.Property(e => e.CntrlBnk).HasMaxLength(15);

                entity.Property(e => e.Comments).HasMaxLength(254);

                entity.Property(e => e.Confirmed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.CopyNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.CorrExt).HasMaxLength(25);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTran)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CreateTs).HasColumnName("CreateTS");

                entity.Property(e => e.CtlAccount).HasMaxLength(15);

                entity.Property(e => e.Cup).HasColumnName("CUP");

                entity.Property(e => e.CurSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.DataSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DeferrTax)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DiscPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DiscSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DiscSumFc)
                    .HasColumnName("DiscSumFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DiscSumSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocCur).HasMaxLength(3);

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.DocDlvry)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DocDueDate).HasColumnType("datetime");

                entity.Property(e => e.DocManClsd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DocRate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.DocSubType)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.DocTotal).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocTotalFc)
                    .HasColumnName("DocTotalFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocTotalSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DocType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.DpmAmnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAmntFc)
                    .HasColumnName("DpmAmntFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAmntSc)
                    .HasColumnName("DpmAmntSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAppVat).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAppVatF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAppVatS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAppl).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmApplFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmApplSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmAsDscnt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DpmDrawn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DpmPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.DpmVat).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmVatFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DpmVatSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DraftKey)
                    .HasColumnName("draftKey")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.DutyStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.EdocCancel)
                    .HasColumnName("EDocCancel")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EdocCntnt)
                    .HasColumnName("EDocCntnt")
                    .HasColumnType("ntext");

                entity.Property(e => e.EdocErrCod)
                    .HasColumnName("EDocErrCod")
                    .HasMaxLength(50);

                entity.Property(e => e.EdocErrMsg)
                    .HasColumnName("EDocErrMsg")
                    .HasColumnType("ntext");

                entity.Property(e => e.EdocExpFrm).HasColumnName("EDocExpFrm");

                entity.Property(e => e.EdocGenTyp)
                    .HasColumnName("EDocGenTyp")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EdocNum)
                    .HasColumnName("EDocNum")
                    .HasMaxLength(50);

                entity.Property(e => e.EdocPrefix)
                    .HasColumnName("EDocPrefix")
                    .HasMaxLength(10);

                entity.Property(e => e.EdocProces)
                    .HasColumnName("EDocProces")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.EdocStatus)
                    .HasColumnName("EDocStatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.EdocTest)
                    .HasColumnName("EDocTest")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ElCoMsg).HasMaxLength(254);

                entity.Property(e => e.ElCoStatus).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EndDlvDate).HasColumnType("datetime");

                entity.Property(e => e.EnvTypeNfe)
                    .HasColumnName("EnvTypeNFe")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.EquVatSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EquVatSumF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.EquVatSumS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Eseries).HasColumnName("ESeries");

                entity.Property(e => e.ExcDocDate).HasColumnType("datetime");

                entity.Property(e => e.ExcRefDate).HasColumnType("datetime");

                entity.Property(e => e.ExcRmvTime).HasMaxLength(8);

                entity.Property(e => e.Excised)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.ExepAmnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExepAmntFc)
                    .HasColumnName("ExepAmntFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExepAmntSc)
                    .HasColumnName("ExepAmntSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpAnFrgn).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpAnSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpAnSys).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpAppl).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpApplFc)
                    .HasColumnName("ExpApplFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExpApplSc)
                    .HasColumnName("ExpApplSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Exported)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ExptVat)
                    .HasColumnName("ExptVAt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExptVatFc)
                    .HasColumnName("ExptVAtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ExptVatSc)
                    .HasColumnName("ExptVAtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FatherCard).HasMaxLength(15);

                entity.Property(e => e.FatherType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.Filler).HasMaxLength(8);

                entity.Property(e => e.FiscDocNum).HasMaxLength(100);

                entity.Property(e => e.Flags).HasDefaultValueSql("((0))");

                entity.Property(e => e.FlwRefDate).HasColumnType("datetime");

                entity.Property(e => e.FlwRefNum).HasMaxLength(100);

                entity.Property(e => e.FoCfrght)
                    .HasColumnName("FoCFrght")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCfrghtFc)
                    .HasColumnName("FoCFrghtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCfrghtSc)
                    .HasColumnName("FoCFrghtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCtax)
                    .HasColumnName("FoCTax")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCtaxFc)
                    .HasColumnName("FoCTaxFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FoCtaxSc)
                    .HasColumnName("FoCTaxSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FolioPref).HasMaxLength(4);

                entity.Property(e => e.Footer).HasColumnType("ntext");

                entity.Property(e => e.FreeChrg).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FreeChrgFc)
                    .HasColumnName("FreeChrgFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FreeChrgSc)
                    .HasColumnName("FreeChrgSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.GrosProfFc)
                    .HasColumnName("GrosProfFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrosProfSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrosProfit).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.GrossBase).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gtsrlvnt)
                    .HasColumnName("GTSRlvnt")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Handwrtten)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Header).HasColumnType("ntext");

                entity.Property(e => e.IgnRelDoc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Indicator).HasMaxLength(2);

                entity.Property(e => e.Installmnt).HasDefaultValueSql("((1))");

                entity.Property(e => e.Instance).HasDefaultValueSql("((0))");

                entity.Property(e => e.InsurOp347)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.InterimTyp).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvntDirec)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.InvntSttus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.IsAlt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsCrin)
                    .HasColumnName("isCrin")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsIct)
                    .HasColumnName("IsICT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsIns)
                    .HasColumnName("isIns")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsPaytoBnk)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsReuseNfn)
                    .HasColumnName("IsReuseNFN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsReuseNum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsrcodLine)
                    .HasColumnName("ISRCodLine")
                    .HasMaxLength(53);

                entity.Property(e => e.JrnlMemo).HasMaxLength(50);

                entity.Property(e => e.Kvvatcode)
                    .HasColumnName("KVVATCode")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastPmnTyp)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Letter)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LetterNum).HasMaxLength(20);

                entity.Property(e => e.LicTradNum).HasMaxLength(32);

                entity.Property(e => e.LogInstanc).HasDefaultValueSql("((0))");

                entity.Property(e => e.LpgFolioN).HasColumnName("LPgFolioN");

                entity.Property(e => e.LypmtAt)
                    .HasColumnName("LYPmtAt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LypmtAtFc)
                    .HasColumnName("LYPmtAtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LypmtAtSc)
                    .HasColumnName("LYPmtAtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ManualNum).HasMaxLength(20);

                entity.Property(e => e.Max1099).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.MaxDscn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MinvDate)
                    .HasColumnName("MInvDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MinvNum).HasColumnName("MInvNum");

                entity.Property(e => e.Model)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.NbSbAmntFc)
                    .HasColumnName("NbSbAmntFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NbSbVatFc)
                    .HasColumnName("NbSbVAtFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NcorrInv).HasColumnName("NCorrInv");

                entity.Property(e => e.NetProc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NfePrntFo).HasDefaultValueSql("((0))");

                entity.Property(e => e.NfeValue).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NnSbAmnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NnSbAmntSc)
                    .HasColumnName("NnSbAmntSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NnSbVat)
                    .HasColumnName("NnSbVAt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NnSbVatSc)
                    .HasColumnName("NnSbVAtSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Notify)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NtsapprNo)
                    .HasColumnName("NTSApprNo")
                    .HasMaxLength(50);

                entity.Property(e => e.Ntsapprov)
                    .HasColumnName("NTSApprov")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NtseTaxNo)
                    .HasColumnName("NTSeTaxNo")
                    .HasMaxLength(50);

                entity.Property(e => e.NtswebSite).HasColumnName("NTSWebSite");

                entity.Property(e => e.NumAtCard).HasMaxLength(100);

                entity.Property(e => e.ObjType)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('13')");

                entity.Property(e => e.OnlineQuo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.OpenForLaC)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Ordered)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.OriginType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.PaidDpm).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidDpmF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidDpmS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidFc)
                    .HasColumnName("PaidFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidSumFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidSumSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidSys).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PaidToDate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PartSupply)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.PayBlock)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PayDuMonth)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PayToCode).HasMaxLength(50);

                entity.Property(e => e.PaymentRef).HasMaxLength(27);

                entity.Property(e => e.PeyMethod).HasMaxLength(15);

                entity.Property(e => e.Pick)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PickRmrk).HasMaxLength(254);

                entity.Property(e => e.PickStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Pindicator)
                    .HasColumnName("PIndicator")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PoPrss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PoscashN).HasColumnName("POSCashN");

                entity.Property(e => e.PoseqNum)
                    .HasColumnName("POSEqNum")
                    .HasMaxLength(20);

                entity.Property(e => e.PosmanufSn)
                    .HasColumnName("POSManufSN")
                    .HasMaxLength(20);

                entity.Property(e => e.PosrcptNo).HasColumnName("POSRcptNo");

                entity.Property(e => e.Posted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.PqtgrpHw)
                    .HasColumnName("PQTGrpHW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PqtgrpNum).HasColumnName("PQTGrpNum");

                entity.Property(e => e.PqtgrpSer).HasColumnName("PQTGrpSer");

                entity.Property(e => e.PrintSepa)
                    .HasColumnName("PrintSEPA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Printed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Project).HasMaxLength(20);

                entity.Property(e => e.Pticode)
                    .HasColumnName("PTICode")
                    .HasMaxLength(5);

                entity.Property(e => e.Ref1).HasMaxLength(11);

                entity.Property(e => e.Ref2).HasMaxLength(11);

                entity.Property(e => e.RelatedTyp).HasDefaultValueSql("((-1))");

                entity.Property(e => e.ReopManCls)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReopOriDoc)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReqDate).HasColumnType("datetime");

                entity.Property(e => e.ReqName).HasMaxLength(155);

                entity.Property(e => e.ReqType).HasDefaultValueSql("((12))");

                entity.Property(e => e.Requester).HasMaxLength(8);

                entity.Property(e => e.Reserve)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ResidenNum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.RetInvoice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.RevisionPo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.RoundDif).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RoundDifFc)
                    .HasColumnName("RoundDifFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RoundDifSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Rounding)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Segment).HasDefaultValueSql("((0))");

                entity.Property(e => e.SelfInv)
                    .HasColumnName("selfInv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SeriesStr).HasMaxLength(3);

                entity.Property(e => e.ShipToCode).HasMaxLength(50);

                entity.Property(e => e.ShipToOw)
                    .HasColumnName("ShipToOW")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ShowScn)
                    .HasColumnName("ShowSCN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SignDigest).HasColumnType("ntext");

                entity.Property(e => e.SignMsg).HasColumnType("ntext");

                entity.Property(e => e.SlpCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SpecDate).HasColumnType("datetime");

                entity.Property(e => e.SplitTax).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SplitTaxFc)
                    .HasColumnName("SplitTaxFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SplitTaxSc)
                    .HasColumnName("SplitTaxSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SrvGpPrcnt).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SrvTaxRule)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Ssiexmpt)
                    .HasColumnName("SSIExmpt")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StDlvDate).HasColumnType("datetime");

                entity.Property(e => e.StampNum).HasMaxLength(16);

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.SubStr).HasMaxLength(3);

                entity.Property(e => e.Submitted)
                    .HasColumnName("submitted")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SumAbsId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SumRptDate).HasColumnType("datetime");

                entity.Property(e => e.SummryType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SupplCode).HasMaxLength(254);

                entity.Property(e => e.Supplier).HasMaxLength(15);

                entity.Property(e => e.SysRate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxDate).HasColumnType("datetime");

                entity.Property(e => e.TaxOnExAp).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExApF).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExApS).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExp).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExpFc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxOnExpSc).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.ToBinCode).HasMaxLength(228);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToWhsCode).HasMaxLength(8);

                entity.Property(e => e.TotalExpFc)
                    .HasColumnName("TotalExpFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotalExpSc)
                    .HasColumnName("TotalExpSC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotalExpns).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TrackNo).HasMaxLength(30);

                entity.Property(e => e.Transfered)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TrnspCode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.TxInvRptDt).HasColumnType("datetime");

                entity.Property(e => e.TxInvRptNo).HasMaxLength(10);

                entity.Property(e => e.UAgingDays).HasColumnName("U_AgingDays");

                entity.Property(e => e.UAprefNo)
                    .HasColumnName("U_APRefNo")
                    .HasMaxLength(20);

                entity.Property(e => e.UCreateDate)
                    .HasColumnName("U_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UEcsDocFreight)
                    .HasColumnName("U_ECS_DOC_FREIGHT")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('0.0')");

                entity.Property(e => e.UIncoPoint)
                    .HasColumnName("U_IncoPoint")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('Hong Kong')");

                entity.Property(e => e.UIncoTerm)
                    .HasColumnName("U_IncoTerm")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('FCA')");

                entity.Property(e => e.UItnNumber)
                    .HasColumnName("U_ItnNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.UIvcivpdate)
                    .HasColumnName("U_IVCIVPDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UIvcivpno)
                    .HasColumnName("U_IVCIVPNo")
                    .HasMaxLength(50);

                entity.Property(e => e.UMemo1)
                    .HasColumnName("U_Memo1")
                    .HasMaxLength(200);

                entity.Property(e => e.UOrderFor)
                    .HasColumnName("U_OrderFor")
                    .HasMaxLength(15);

                entity.Property(e => e.URemarks2)
                    .HasColumnName("U_Remarks2")
                    .HasMaxLength(200);

                entity.Property(e => e.USalesAmt)
                    .HasColumnName("U_SalesAmt")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.USalesManager)
                    .HasColumnName("U_SalesManager")
                    .HasMaxLength(20);

                entity.Property(e => e.USono)
                    .HasColumnName("U_SONo")
                    .HasMaxLength(10);

                entity.Property(e => e.UTlno)
                    .HasColumnName("U_TLNo")
                    .HasMaxLength(15);

                entity.Property(e => e.UpdCardBal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UpdInvnt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTs).HasColumnName("UpdateTS");

                entity.Property(e => e.UseCorrVat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UseShpdGd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.VatDate).HasColumnType("datetime");

                entity.Property(e => e.VatJenum)
                    .HasColumnName("VatJENum")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.VatPaid).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatPaidFc)
                    .HasColumnName("VatPaidFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatPaidSys).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatPercent).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSum).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSumFc)
                    .HasColumnName("VatSumFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.VatSumSy).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Vatfirst)
                    .HasColumnName("VATFirst")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VatregNum)
                    .HasColumnName("VATRegNum")
                    .HasMaxLength(32);

                entity.Property(e => e.VclPlate).HasMaxLength(20);

                entity.Property(e => e.VersionNum).HasMaxLength(11);

                entity.Property(e => e.Volume).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WddStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Weight).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Wtapplied)
                    .HasColumnName("WTApplied")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtappliedF)
                    .HasColumnName("WTAppliedF")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtappliedS)
                    .HasColumnName("WTAppliedS")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Wtdetails)
                    .HasColumnName("WTDetails")
                    .HasMaxLength(100);

                entity.Property(e => e.Wtsum)
                    .HasColumnName("WTSum")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtsumFc)
                    .HasColumnName("WTSumFC")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.WtsumSc)
                    .HasColumnName("WTSumSC")
                    .HasColumnType("numeric(19, 6)");
            });

            modelBuilder.Entity<Oitb>(entity =>
            {
                entity.HasKey(e => e.ItmsGrpCod);

                entity.ToTable("OITB");

                entity.HasIndex(e => e.ItmsGrpNam)
                    .HasName("OITB_GROUP_NAME")
                    .IsUnique();

                entity.Property(e => e.ItmsGrpCod).ValueGeneratedNever();

                entity.Property(e => e.Alert)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Apcmact)
                    .HasColumnName("APCMAct")
                    .HasMaxLength(15);

                entity.Property(e => e.Apcmeuact)
                    .HasColumnName("APCMEUAct")
                    .HasMaxLength(15);

                entity.Property(e => e.ApcmfrnAct)
                    .HasColumnName("APCMFrnAct")
                    .HasMaxLength(15);

                entity.Property(e => e.Arcmact)
                    .HasColumnName("ARCMAct")
                    .HasMaxLength(15);

                entity.Property(e => e.Arcmeuact)
                    .HasColumnName("ARCMEUAct")
                    .HasMaxLength(15);

                entity.Property(e => e.ArcmexpAct)
                    .HasColumnName("ARCMExpAct")
                    .HasMaxLength(15);

                entity.Property(e => e.ArcmfrnAct)
                    .HasColumnName("ARCMFrnAct")
                    .HasMaxLength(15);

                entity.Property(e => e.BalInvntAc).HasMaxLength(15);

                entity.Property(e => e.BalanceAcc).HasMaxLength(15);

                entity.Property(e => e.CompoWh)
                    .HasColumnName("CompoWH")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')");

                entity.Property(e => e.CostRvlAct).HasMaxLength(15);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CstOffsAct).HasMaxLength(15);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DecreasAc).HasMaxLength(15);

                entity.Property(e => e.DecresGlAc).HasMaxLength(15);

                entity.Property(e => e.EuexpensAc)
                    .HasColumnName("EUExpensAc")
                    .HasMaxLength(15);

                entity.Property(e => e.EurevenuAc)
                    .HasColumnName("EURevenuAc")
                    .HasMaxLength(15);

                entity.Property(e => e.ExchangeAc).HasMaxLength(15);

                entity.Property(e => e.ExmptIncom).HasMaxLength(15);

                entity.Property(e => e.ExpClrAct).HasMaxLength(15);

                entity.Property(e => e.ExpOfstAct).HasMaxLength(15);

                entity.Property(e => e.ExpensesAc).HasMaxLength(15);

                entity.Property(e => e.FrExpensAc).HasMaxLength(15);

                entity.Property(e => e.FrRevenuAc).HasMaxLength(15);

                entity.Property(e => e.FreeChrgPu)
                    .HasColumnName("FreeChrgPU")
                    .HasMaxLength(15);

                entity.Property(e => e.FreeChrgSa)
                    .HasColumnName("FreeChrgSA")
                    .HasMaxLength(15);

                entity.Property(e => e.IncreasAc).HasMaxLength(15);

                entity.Property(e => e.IncresGlAc).HasMaxLength(15);

                entity.Property(e => e.InvntSys)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsvcCode)
                    .HasColumnName("ISvcCode")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('2')");

                entity.Property(e => e.ItmsGrpNam)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IuoMentry).HasColumnName("IUoMEntry");

                entity.Property(e => e.Locked)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.LogInstanc).HasColumnName("logInstanc");

                entity.Property(e => e.MatGrp).HasDefaultValueSql("((-1))");

                entity.Property(e => e.MatType)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.MinOrdrQty).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Ncmcode)
                    .HasColumnName("NCMCode")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.NegStckAct).HasMaxLength(15);

                entity.Property(e => e.Object)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('52')");

                entity.Property(e => e.OrdrMulti).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OsvcCode)
                    .HasColumnName("OSvcCode")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.PareturnAc)
                    .HasColumnName("PAReturnAc")
                    .HasMaxLength(15);

                entity.Property(e => e.PlaningSys)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PrcrmntMtd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')");

                entity.Property(e => e.PriceDifAc).HasMaxLength(15);

                entity.Property(e => e.ProductSrc)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PurBalAct).HasMaxLength(15);

                entity.Property(e => e.PurchOfsAc).HasMaxLength(15);

                entity.Property(e => e.PurchaseAc).HasMaxLength(15);

                entity.Property(e => e.ReturnAc).HasMaxLength(15);

                entity.Property(e => e.RevRetAct).HasMaxLength(15);

                entity.Property(e => e.RevenuesAc).HasMaxLength(15);

                entity.Property(e => e.RuleCode).HasMaxLength(2);

                entity.Property(e => e.SaleCostAc).HasMaxLength(15);

                entity.Property(e => e.ServiceGrp).HasDefaultValueSql("((-1))");

                entity.Property(e => e.ShpdGdsAct).HasMaxLength(15);

                entity.Property(e => e.StkInTnAct).HasMaxLength(15);

                entity.Property(e => e.StkOffsAct).HasMaxLength(15);

                entity.Property(e => e.StockOffst).HasMaxLength(15);

                entity.Property(e => e.StokRvlAct).HasMaxLength(15);

                entity.Property(e => e.TransferAc).HasMaxLength(15);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserSign2).HasColumnName("userSign2");

                entity.Property(e => e.VarianceAc).HasMaxLength(15);

                entity.Property(e => e.VatRevAct).HasMaxLength(15);

                entity.Property(e => e.WhIcenAct)
                    .HasColumnName("WhICenAct")
                    .HasMaxLength(15);

                entity.Property(e => e.WhOcenAct)
                    .HasColumnName("WhOCenAct")
                    .HasMaxLength(15);

                entity.Property(e => e.WipAcct).HasMaxLength(15);

                entity.Property(e => e.WipOffset).HasMaxLength(15);

                entity.Property(e => e.WipVarAcct).HasMaxLength(15);
            });

            modelBuilder.Entity<Oitw>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.WhsCode });

                entity.ToTable("OITW");

                entity.HasIndex(e => e.DftBinAbs)
                    .HasName("OITW_DFT_BIN");

                entity.HasIndex(e => e.WhsCode)
                    .HasName("OITW_WHS");

                entity.Property(e => e.ItemCode).HasMaxLength(20);

                entity.Property(e => e.WhsCode).HasMaxLength(8);

                entity.Property(e => e.Apcmact)
                    .HasColumnName("APCMAct")
                    .HasMaxLength(15);

                entity.Property(e => e.Apcmeuact)
                    .HasColumnName("APCMEUAct")
                    .HasMaxLength(15);

                entity.Property(e => e.ApcmfrnAct)
                    .HasColumnName("APCMFrnAct")
                    .HasMaxLength(15);

                entity.Property(e => e.Arcmact)
                    .HasColumnName("ARCMAct")
                    .HasMaxLength(15);

                entity.Property(e => e.Arcmeuact)
                    .HasColumnName("ARCMEUAct")
                    .HasMaxLength(15);

                entity.Property(e => e.ArcmexpAct)
                    .HasColumnName("ARCMExpAct")
                    .HasMaxLength(15);

                entity.Property(e => e.ArcmfrnAct)
                    .HasColumnName("ARCMFrnAct")
                    .HasMaxLength(15);

                entity.Property(e => e.AvgPrice).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.BalInvntAc).HasMaxLength(15);

                entity.Property(e => e.BalanceAcc).HasMaxLength(15);

                entity.Property(e => e.Consig).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CostRvlAct).HasMaxLength(15);

                entity.Property(e => e.Counted).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CstOffsAct).HasMaxLength(15);

                entity.Property(e => e.DecreasAc).HasMaxLength(15);

                entity.Property(e => e.DecresGlAc).HasMaxLength(15);

                entity.Property(e => e.DftBinEnfd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EuexpensAc)
                    .HasColumnName("EUExpensAc")
                    .HasMaxLength(15);

                entity.Property(e => e.EurevenuAc)
                    .HasColumnName("EURevenuAc")
                    .HasMaxLength(15);

                entity.Property(e => e.ExchangeAc).HasMaxLength(15);

                entity.Property(e => e.ExmptIncom).HasMaxLength(15);

                entity.Property(e => e.ExpClrAct).HasMaxLength(15);

                entity.Property(e => e.ExpOfstAct).HasMaxLength(15);

                entity.Property(e => e.ExpensesAc).HasMaxLength(15);

                entity.Property(e => e.FrExpensAc).HasMaxLength(15);

                entity.Property(e => e.FrRevenuAc).HasMaxLength(15);

                entity.Property(e => e.FreeChrgPu)
                    .HasColumnName("FreeChrgPU")
                    .HasMaxLength(15);

                entity.Property(e => e.FreeChrgSa)
                    .HasColumnName("FreeChrgSA")
                    .HasMaxLength(15);

                entity.Property(e => e.Freezed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IncreasAc).HasMaxLength(15);

                entity.Property(e => e.IncresGlAc).HasMaxLength(15);

                entity.Property(e => e.IsCommited).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Locked)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.LogInstanc).HasColumnName("logInstanc");

                entity.Property(e => e.MaxStock).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.MinOrder).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.MinStock).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.NegStckAct).HasMaxLength(15);

                entity.Property(e => e.Object)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('31')");

                entity.Property(e => e.OnHand).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.OnOrder).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PareturnAc)
                    .HasColumnName("PAReturnAc")
                    .HasMaxLength(15);

                entity.Property(e => e.PriceDifAc).HasMaxLength(15);

                entity.Property(e => e.PurBalAct).HasMaxLength(15);

                entity.Property(e => e.PurchOfsAc).HasMaxLength(15);

                entity.Property(e => e.PurchaseAc).HasMaxLength(15);

                entity.Property(e => e.ReturnAc).HasMaxLength(15);

                entity.Property(e => e.RevRetAct).HasMaxLength(15);

                entity.Property(e => e.RevenuesAc).HasMaxLength(15);

                entity.Property(e => e.SaleCostAc).HasMaxLength(15);

                entity.Property(e => e.ShpdGdsAct).HasMaxLength(15);

                entity.Property(e => e.StkInTnAct).HasMaxLength(15);

                entity.Property(e => e.StkOffsAct).HasMaxLength(15);

                entity.Property(e => e.StockOffst).HasMaxLength(15);

                entity.Property(e => e.StockValue).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StokRvlAct).HasMaxLength(15);

                entity.Property(e => e.TransferAc).HasMaxLength(15);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserSign2).HasColumnName("userSign2");

                entity.Property(e => e.VarianceAc).HasMaxLength(15);

                entity.Property(e => e.VatRevAct).HasMaxLength(15);

                entity.Property(e => e.WasCounted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.WhIcenAct)
                    .HasColumnName("WhICenAct")
                    .HasMaxLength(15);

                entity.Property(e => e.WhOcenAct)
                    .HasColumnName("WhOCenAct")
                    .HasMaxLength(15);

                entity.Property(e => e.WipAcct).HasMaxLength(15);

                entity.Property(e => e.WipOffset).HasMaxLength(15);

                entity.Property(e => e.WipVarAcct).HasMaxLength(15);
            });
        }

    }
}

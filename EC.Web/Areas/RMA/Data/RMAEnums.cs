namespace EC.Web.Areas.RMA.Data
{
    public enum RMAStatus
    {
        Open,
        RMAIssued,
        Closed
    }

    public enum RMAReport
    {
        None,
        EightD,
        FA
    }

    public enum RMACaseStatus
    {
        Received,
        Closed
    }

    public enum RMALocation
    {
        PHA,
        PHC,
        PHNY
    }

    public enum WarrantyStatus
    {
        UnderWarranty,
        OutofWarranty
    }

    public enum RMACorrectiveAction
    {
        CreditBack,
        Repaired,
        Replacement,
        Scrap
    }
    
}

using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class AllotmentLetter
{
    public int Id { get; set; }

    public int? Prid { get; set; }

    public string? Reason { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Letter { get; set; }

    public string? HeadofDivision { get; set; }

    public string? HeadofDivisionPos { get; set; }

    public string? Pbo { get; set; }

    public string? Pbopos { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public int? AppropriationId { get; set; }

    public virtual Appropriation? Appropriation { get; set; }

    public virtual PurchaseRequest? Pr { get; set; }
}

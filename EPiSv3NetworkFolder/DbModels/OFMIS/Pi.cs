using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Pi
{
    public int Id { get; set; }

    public int? Prid { get; set; }

    public int? TransferorId { get; set; }

    public int? TransfereeId { get; set; }

    public DateTime? Date { get; set; }

    public string? PreparedBy { get; set; }

    public string? PreparedByPos { get; set; }

    public virtual ICollection<Pisdetail> Pisdetails { get; set; } = new List<Pisdetail>();

    public virtual PurchaseRequest? Pr { get; set; }

    public virtual User? PreparedByNavigation { get; set; }
}

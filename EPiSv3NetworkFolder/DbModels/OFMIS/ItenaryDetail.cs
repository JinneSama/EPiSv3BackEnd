using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class ItenaryDetail
{
    public int Id { get; set; }

    public int? Iotid { get; set; }

    public DateTime? Date { get; set; }

    public string? PlaceVisited { get; set; }

    public DateTime? DepartureTime { get; set; }

    public DateTime? ArrivalTime { get; set; }

    public string? MeansOfTransportation { get; set; }

    public decimal? TransportationFee { get; set; }

    public decimal? PerDiems { get; set; }

    public decimal? DailyAllowance { get; set; }

    public decimal? TotalAmount { get; set; }

    public DateTime DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public string? InclusiveTime { get; set; }

    public virtual ItenaryofTravel? Iot { get; set; }
}

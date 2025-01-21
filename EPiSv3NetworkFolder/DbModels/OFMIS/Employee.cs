using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Employee
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? ExtName { get; set; }

    public string? Position { get; set; }

    public string? OfficeName { get; set; }

    public string? OffcAcr { get; set; }

    public int? OfficeId { get; set; }

    public string? Tin { get; set; }

    public string? PagIbig { get; set; }

    public string? PhilHealth { get; set; }

    public string? Sss { get; set; }

    public string? Status { get; set; }

    public string? Salutation { get; set; }

    public string? Sg { get; set; }

    public string? Gsis { get; set; }

    public string? SalaryGrade { get; set; }

    public string? Steps { get; set; }

    public decimal? MonthlySalary { get; set; }

    public decimal? DailySalary { get; set; }

    public bool? IsHead { get; set; }

    public bool? IsSignatories { get; set; }

    public string? Note { get; set; }

    public string EmployeeNameByLastName { get; set; } = null!;

    public string EmployeeName { get; set; } = null!;

    public string? Lbpaccount { get; set; }

    public bool Deactivate { get; set; }

    public virtual ICollection<Bacmember> Bacmembers { get; set; } = new List<Bacmember>();

    public virtual ICollection<ItenaryofTravel> ItenaryofTravelApprovedByNavigations { get; set; } = new List<ItenaryofTravel>();

    public virtual ICollection<ItenaryofTravel> ItenaryofTravelEmployees { get; set; } = new List<ItenaryofTravel>();

    public virtual ICollection<Liquidation> Liquidations { get; set; } = new List<Liquidation>();

    public virtual Office? Office { get; set; }

    public virtual ICollection<Office> Offices { get; set; } = new List<Office>();

    public virtual ICollection<PayrollDetail> PayrollDetails { get; set; } = new List<PayrollDetail>();

    public virtual ICollection<PayrollDifferentialDetail> PayrollDifferentialDetails { get; set; } = new List<PayrollDifferentialDetail>();

    public virtual ICollection<PayrollHazardDetail> PayrollHazardDetails { get; set; } = new List<PayrollHazardDetail>();

    public virtual ICollection<PayrollOtdetail> PayrollOtdetails { get; set; } = new List<PayrollOtdetail>();

    public virtual ICollection<PayrollSpesdetail> PayrollSpesdetails { get; set; } = new List<PayrollSpesdetail>();

    public virtual ICollection<PayrollWageDetail> PayrollWageDetails { get; set; } = new List<PayrollWageDetail>();

    public virtual ICollection<PayrollWagesPermanentDetail> PayrollWagesPermanentDetails { get; set; } = new List<PayrollWagesPermanentDetail>();

    public virtual ICollection<PayrollWagesPermanentDetailsEnd> PayrollWagesPermanentDetailsEnds { get; set; } = new List<PayrollWagesPermanentDetailsEnd>();

    public virtual ICollection<Signatory> Signatories { get; set; } = new List<Signatory>();

    public virtual ICollection<TripTicket> TripTickets { get; set; } = new List<TripTicket>();

    public virtual ICollection<VehicleDetail> VehicleDetails { get; set; } = new List<VehicleDetail>();

    public virtual ICollection<WasteMaterial> WasteMaterialCertifieds { get; set; } = new List<WasteMaterial>();

    public virtual ICollection<WasteMaterial> WasteMaterialPgsocertifieds { get; set; } = new List<WasteMaterial>();

    public virtual ICollection<Payee> Payees { get; set; } = new List<Payee>();
}

using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Jim
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
}

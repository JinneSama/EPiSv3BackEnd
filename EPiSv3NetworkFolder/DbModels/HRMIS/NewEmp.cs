using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class NewEmp
{
    public long FldEmpId { get; set; }

    public string? FldOfficeId { get; set; }

    public string? FldLastname { get; set; }

    public string? FldFirstname { get; set; }

    public string? FldMiddleName { get; set; }

    public string? FldPosition { get; set; }

    public string? FldStatus { get; set; }

    public bool FldSex { get; set; }

    public string? FldCivilStatus { get; set; }

    public DateTime? FldBirthDate { get; set; }

    public string? FldBirthPlace { get; set; }

    public string? FldCitizenship { get; set; }

    public double? FldHeight { get; set; }

    public double? FldWeight { get; set; }

    public string? FldBloodType { get; set; }

    public string? FldStreet { get; set; }

    public string? FldBarangay { get; set; }

    public string? FldMunicipality { get; set; }

    public string? FldProvince { get; set; }

    public string? FldTelNo { get; set; }

    public string? FldEmailAdd { get; set; }

    public string? FldCellNo { get; set; }
}

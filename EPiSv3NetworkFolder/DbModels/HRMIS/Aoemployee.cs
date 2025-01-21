using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Aoemployee
{
    public long FldIndex { get; set; }

    public long FldEmpId { get; set; }

    public string? FldDmsno { get; set; }

    public DateTime? FldDteReceived { get; set; }

    public string? FldLastname { get; set; }

    public string? FldFirstname { get; set; }

    public string? FldMiddleName { get; set; }

    public string? FldNameEx { get; set; }

    public string? FldPreviousOfficeId { get; set; }

    public string? FldPreviousDivision { get; set; }

    public string? FldPreviousPosition { get; set; }

    public string? FldPreviousStatus { get; set; }

    public string? FldOfficeId { get; set; }

    public string? FldOffice { get; set; }

    public string? FldDivision { get; set; }

    public string? FldPosition { get; set; }

    public string? FldStatus { get; set; }

    public double? FldSalaryGrade { get; set; }

    public string? FldStepInc { get; set; }

    public double? FldSalary { get; set; }

    public string? FldTitle { get; set; }

    public DateTime? FldFrom { get; set; }

    public DateTime? FldTo { get; set; }

    public string? FldChargeTo { get; set; }

    /// <summary>
    /// Note for the Contract of Service
    /// </summary>
    public string? FldNote { get; set; }

    public string? FldMov1 { get; set; }

    public DateTime? FldDteIssued1 { get; set; }

    public string? FldPlace1 { get; set; }

    public string? FldMov2 { get; set; }

    public DateTime? FldDteIssued2 { get; set; }

    public string? FldPlace2 { get; set; }

    public string? FldAppointmentStatus { get; set; }

    public string? FldPlantillaNo { get; set; }

    public int? FldPlantillaItemNo { get; set; }

    public int? FldPage { get; set; }

    public string? FldPublishedAt { get; set; }

    public DateTime? FldPublishedFrom { get; set; }

    public DateTime? FldPublishedTo { get; set; }

    public string? FldPostedAt { get; set; }

    public DateTime? FldPostedFrom { get; set; }

    public DateTime? FldPostedTo { get; set; }

    public DateTime? FldHrmpsb { get; set; }

    public string? FldHrmpsbdesignate { get; set; }

    public bool? FldProcessed { get; set; }

    public DateTime? FldHrmpsb2 { get; set; }

    public string? FldGovernor { get; set; }

    public string? FldGovernorPostion { get; set; }

    public string? FldHrmo { get; set; }

    public string? FldHrmopostition { get; set; }
}

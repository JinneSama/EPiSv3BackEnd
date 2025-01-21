using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Employee
{
    public long FldEmpId { get; set; }

    public string? FldOfficeId { get; set; }

    public string? FldLastname { get; set; }

    public string? FldFirstname { get; set; }

    public string? FldMiddleName { get; set; }

    public double? FldSalaryGrade { get; set; }

    public string? FldStepInc { get; set; }

    public string? FldDivision { get; set; }

    public double? FldSalary { get; set; }

    public string? FldPosition { get; set; }

    public string? FldStatus { get; set; }

    public string? FldTitle { get; set; }

    public string? FldSex { get; set; }

    public string? FldCivilStatus { get; set; }

    public DateTime? FldBirthDate { get; set; }

    public string? FldBirthPlace { get; set; }

    public string? FldCitizenship { get; set; }

    public double? FldHeight { get; set; }

    public double? FldWeight { get; set; }

    public string? FldBloodType { get; set; }

    public string? FldGsisno { get; set; }

    public string? FldPagibigId { get; set; }

    public string? FldPhilHealthNo { get; set; }

    public string? FldBarangayCode { get; set; }

    public string? FldMunicipalityCode { get; set; }

    public string? FldPastreet { get; set; }

    public string? FldPabarangay { get; set; }

    public string? FldPamunicipality { get; set; }

    public string? FldPaprovince { get; set; }

    public string? FldPazipCode { get; set; }

    public string? FldPatelNo { get; set; }

    public string? FldStreet { get; set; }

    public string? FldBarangay { get; set; }

    public string? FldMunicipality { get; set; }

    public string? FldProvince { get; set; }

    public string? FldZipCode { get; set; }

    public string? FldTelNo { get; set; }

    public string? FldEmailAdd { get; set; }

    public string? FldCellNo { get; set; }

    public string? FldTin { get; set; }

    public string? FldSpouseName { get; set; }

    public string? FldSpouseOccup { get; set; }

    public string? FldSpsEmp { get; set; }

    public string? FldSpsEmpAdd { get; set; }

    public string? FldSpsEmpTel { get; set; }

    public string? FldFather { get; set; }

    public string? FldMother { get; set; }

    public string? FldParentAdd { get; set; }

    public string? FldElementary { get; set; }

    public double? FldEstartYear { get; set; }

    public double? FldEendYear { get; set; }

    public string? FldEdegreee { get; set; }

    public double? FldEyearGrad { get; set; }

    public string? FldEunits { get; set; }

    public string? FldEhonors { get; set; }

    public string? FldSecondary { get; set; }

    public double? FldSsyear { get; set; }

    public double? FldSeyear { get; set; }

    public string? FldSdegree { get; set; }

    public double? FldSyearGrad { get; set; }

    public string? FldSunits { get; set; }

    public string? FldShonors { get; set; }

    public string? FldVocational { get; set; }

    public double? FldVsyear { get; set; }

    public double? FldVeyear { get; set; }

    public string? FldVdegree { get; set; }

    public double? FldVyearGrad { get; set; }

    public string? FldVunits { get; set; }

    public string? FldVhonors { get; set; }

    public string? FldCollege { get; set; }

    public double? FldCsyear { get; set; }

    public double? FldCeyear { get; set; }

    public string? FldCdegree { get; set; }

    public double? FldCyearGrad { get; set; }

    public string? FldCunits { get; set; }

    public string? FldChonors { get; set; }

    public string? FldGsdiploma { get; set; }

    public double? FldGsdsyear { get; set; }

    public double? FldGsdeyear { get; set; }

    public string? FldGsddegree { get; set; }

    public double? FldGsdyearGrad { get; set; }

    public string? FldGsdunits { get; set; }

    public string? FldGsdhonors { get; set; }

    public string? FldGsmaster { get; set; }

    public double? FldGsmsyear { get; set; }

    public double? FldGsmeyear { get; set; }

    public string? FldGsmdegree { get; set; }

    public double? FldGsmyearGrad { get; set; }

    public string? FldGsmunits { get; set; }

    public string? FldGsmhonors { get; set; }

    public string? FldGsdoctor { get; set; }

    public double? FldGsrmsyear { get; set; }

    public double? FldGsreyear { get; set; }

    public string? FldGsrdegree { get; set; }

    public double? FldGsryearGrad { get; set; }

    public string? FldGsrunits { get; set; }

    public string? FldGsrhonors { get; set; }

    public bool? FldThirdDeg { get; set; }

    public string? Fld3DegParticulars { get; set; }

    public bool? FldFourthDeg { get; set; }

    public string? FldDegParticulars { get; set; }

    public bool? FldFormallyCharged { get; set; }

    public string? FldFchargeDetails { get; set; }

    public bool? FldCrimeConvicted { get; set; }

    public string? FldCrimeDetails { get; set; }

    public bool? FldAdminConvicted { get; set; }

    public string? FldAdminDetails { get; set; }

    public bool? FldForceRetire { get; set; }

    public string? FldRetDetails { get; set; }

    public bool? FldCandidate { get; set; }

    public string? FldCandidDetails { get; set; }

    public bool? FldIndigMember { get; set; }

    public string? FldIndigDetails { get; set; }

    public bool FldDisabled { get; set; }

    public string? FldAbleDetails { get; set; }

    public bool? FldSoloParent { get; set; }

    public string? FldSoloDetails { get; set; }

    public string? FldCtcno { get; set; }

    public DateTime? FldCtcdate { get; set; }

    public string? FldCtcplace { get; set; }

    public DateTime? FldLastUpdated { get; set; }

    public bool FldDeleted { get; set; }

    public string? FldReasonDeleted { get; set; }

    public DateTime? FldLatestApp { get; set; }

    public string? FldOperator { get; set; }

    public string? Photo { get; set; }

    public DateTime? FldInitialApp { get; set; }

    public string? FldIdctr { get; set; }

    public string? FldStrId { get; set; }

    public string? FldCsidno { get; set; }

    public string? FldNameExt { get; set; }

    public string? FldSssno { get; set; }

    public string? FldSpouseSurname { get; set; }

    public string? FldSpouseFirstname { get; set; }

    public string? FldSpouseMiddlename { get; set; }

    public string? FldFatherSurname { get; set; }

    public string? FldFatherFirstname { get; set; }

    public string? FldFatherMiddlename { get; set; }

    public string? FldMotherSurname { get; set; }

    public string? FldMotherFirstname { get; set; }

    public string? FldMotherMiddlename { get; set; }

    public string? FldLevel { get; set; }

    public string? FldUsername { get; set; }

    public string? FldPasswordHash { get; set; }

    public string? FldSecurityStamp { get; set; }

    public bool? FldAdministrator { get; set; }

    public bool? FldHeadChief { get; set; }

    public bool? FldAdminOfficer { get; set; }

    public bool? FldRegistered { get; set; }

    public string? FldOfficePrefix { get; set; }

    public bool? FldImmigrant { get; set; }

    public string? FldImmigrantDetail { get; set; }

    public string? FldFrequency { get; set; }

    public string? FldCtcname { get; set; }

    public string? FldElementary1 { get; set; }

    public double? FldEstartYear1 { get; set; }

    public double? FldEendYear1 { get; set; }

    public string? FldEdegreee1 { get; set; }

    public double? FldEyearGrad1 { get; set; }

    public string? FldEunits1 { get; set; }

    public string? FldEhonors1 { get; set; }

    public string? FldSecondary1 { get; set; }

    public double? FldSsyear1 { get; set; }

    public double? FldSeyear1 { get; set; }

    public string? FldSdegree1 { get; set; }

    public double? FldSyearGrad1 { get; set; }

    public string? FldSunits1 { get; set; }

    public string? FldShonors1 { get; set; }

    public string? FldSecondary2 { get; set; }

    public double? FldSsyear2 { get; set; }

    public double? FldSeyear2 { get; set; }

    public string? FldSdegree2 { get; set; }

    public double? FldSyearGrad2 { get; set; }

    public string? FldSunits2 { get; set; }

    public string? FldShonors2 { get; set; }

    public string? FldVocational1 { get; set; }

    public double? FldVsyear1 { get; set; }

    public double? FldVeyear1 { get; set; }

    public string? FldVdegree1 { get; set; }

    public double? FldVyearGrad1 { get; set; }

    public string? FldVunits1 { get; set; }

    public string? FldVhonors1 { get; set; }

    public string? FldCollege1 { get; set; }

    public double? FldCsyear1 { get; set; }

    public double? FldCeyear1 { get; set; }

    public string? FldCdegree1 { get; set; }

    public double? FldCyearGrad1 { get; set; }

    public string? FldCunits1 { get; set; }

    public string? FldChonors1 { get; set; }

    public string? FldCollege2 { get; set; }

    public double? FldCsyear2 { get; set; }

    public double? FldCeyear2 { get; set; }

    public string? FldCdegree2 { get; set; }

    public double? FldCyearGrad2 { get; set; }

    public string? FldCunits2 { get; set; }

    public string? FldChonors2 { get; set; }

    public string? FldGsdiploma1 { get; set; }

    public double? FldGsdsyear1 { get; set; }

    public double? FldGsdeyear1 { get; set; }

    public string? FldGsddegree1 { get; set; }

    public double? FldGsdyearGrad1 { get; set; }

    public string? FldGsdunits1 { get; set; }

    public string? FldGsdhonors1 { get; set; }

    public string? FldGsdiploma2 { get; set; }

    public double? FldGsdsyear2 { get; set; }

    public double? FldGsdeyear2 { get; set; }

    public string? FldGsddegree2 { get; set; }

    public double? FldGsdyearGrad2 { get; set; }

    public string? FldGsdunits2 { get; set; }

    public string? FldGsdhonors2 { get; set; }

    public string? FldGsmaster1 { get; set; }

    public double? FldGsmsyear1 { get; set; }

    public double? FldGsmeyear1 { get; set; }

    public string? FldGsmdegree1 { get; set; }

    public double? FldGsmyearGrad1 { get; set; }

    public string? FldGsmunits1 { get; set; }

    public string? FldGsmhonors1 { get; set; }

    public string? FldGsmaster2 { get; set; }

    public double? FldGsmsyear2 { get; set; }

    public double? FldGsmeyear2 { get; set; }

    public string? FldGsmdegree2 { get; set; }

    public double? FldGsmyearGrad2 { get; set; }

    public string? FldGsmunits2 { get; set; }

    public string? FldGsmhonors2 { get; set; }

    public string? FldGsdoctor1 { get; set; }

    public double? FldGsrmsyear1 { get; set; }

    public double? FldGsreyear1 { get; set; }

    public string? FldGsrdegree1 { get; set; }

    public double? FldGsryearGrad1 { get; set; }

    public string? FldGsrunits1 { get; set; }

    public string? FldGsrhonors1 { get; set; }

    public string? FldGsdoctor2 { get; set; }

    public double? FldGsrmsyear2 { get; set; }

    public double? FldGsreyear2 { get; set; }

    public string? FldGsrdegree2 { get; set; }

    public double? FldGsryearGrad2 { get; set; }

    public string? FldGsrunits2 { get; set; }

    public string? FldGsrhonors2 { get; set; }

    public bool? FldPhrmo { get; set; }

    public bool? FldAdministrator2 { get; set; }

    public bool? FldApproved { get; set; }

    public bool? FldHrstaff { get; set; }

    public bool? FldEndUser { get; set; }

    public bool? FldPersonal { get; set; }

    public bool? FldEducation { get; set; }

    public bool? FldOtherInfo { get; set; }

    public bool? FldPersonalAo { get; set; }

    public bool? FldEducationAo { get; set; }

    public bool? FldOtherInfoAo { get; set; }

    public long? EmpIndex { get; set; }

    public string? FldBioId { get; set; }

    public string? EmpId { get; set; }

    public string? SchedGroupId { get; set; }

    public bool? FldHoliday { get; set; }

    public bool? Flddetailed { get; set; }

    public string? FlddetailedTo { get; set; }

    public DateTime? FlddetailedDte { get; set; }

    public bool? FldDisplay { get; set; }

    public bool? FldResigned { get; set; }

    public string? FldResignedDetail { get; set; }

    public bool? FldRemoved { get; set; }

    public long? FldElcmsId { get; set; }

    public string? FldCountry { get; set; }

    public bool? FldByBirth { get; set; }

    public bool? FldByNaturalization { get; set; }

    public string? FlddetailedToDivision { get; set; }

    public DateTime? FldDateArchived { get; set; }

    public string? FldArchivedBy { get; set; }

    public DateTime? FldDateRestored { get; set; }

    public string? FldRestoredBy { get; set; }

    public DateTime? FldDateCreated { get; set; }
}

using System;
using System.Collections.Generic;
using EPiSv3NetworkFolder.DbModels.HRMIS;
using Microsoft.EntityFrameworkCore;

namespace EPiSv3NetworkFolder.Context;

public partial class HRMISContext : DbContext
{
    public HRMISContext()
    {
    }

    public HRMISContext(DbContextOptions<HRMISContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aoemployee> Aoemployees { get; set; }

    public virtual DbSet<App> Apps { get; set; }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<Barangay> Barangays { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Child> Children { get; set; }

    public virtual DbSet<CivilStatus> CivilStatuses { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CurrentYear> CurrentYears { get; set; }

    public virtual DbSet<Designation> Designations { get; set; }

    public virtual DbSet<Distinction> Distinctions { get; set; }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<DocNo> DocNos { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<Eligibility> Eligibilities { get; set; }

    public virtual DbSet<EmpId> EmpIds { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Level> Levels { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Municipality> Municipalities { get; set; }

    public virtual DbSet<NewEmp> NewEmps { get; set; }

    public virtual DbSet<Office> Offices { get; set; }

    public virtual DbSet<Operator> Operators { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<OtherEducation> OtherEducations { get; set; }

    public virtual DbSet<Prclist> Prclists { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<RecordUpdate> RecordUpdates { get; set; }

    public virtual DbSet<Refbrgy> Refbrgies { get; set; }

    public virtual DbSet<Refcitymun> Refcitymuns { get; set; }

    public virtual DbSet<Reference> References { get; set; }

    public virtual DbSet<Refprovince> Refprovinces { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SalarySchedule> SalarySchedules { get; set; }

    public virtual DbSet<SeparationCause> SeparationCauses { get; set; }

    public virtual DbSet<ServiceRecord> ServiceRecords { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<Sm> Sms { get; set; }

    public virtual DbSet<Srremark> Srremarks { get; set; }

    public virtual DbSet<Srrequest> Srrequests { get; set; }

    public virtual DbSet<Srstation> Srstations { get; set; }

    public virtual DbSet<Srstatus> Srstatuses { get; set; }

    public virtual DbSet<T1> T1s { get; set; }

    public virtual DbSet<T2> T2s { get; set; }

    public virtual DbSet<TblDocPage> TblDocPages { get; set; }

    public virtual DbSet<TblSecurityCode> TblSecurityCodes { get; set; }

    public virtual DbSet<TcpIp> TcpIps { get; set; }

    public virtual DbSet<TempChild> TempChildren { get; set; }

    public virtual DbSet<TempDistinction> TempDistinctions { get; set; }

    public virtual DbSet<TempEligibility> TempEligibilities { get; set; }

    public virtual DbSet<TempEmployee> TempEmployees { get; set; }

    public virtual DbSet<TempOrganization> TempOrganizations { get; set; }

    public virtual DbSet<TempOtherEducation> TempOtherEducations { get; set; }

    public virtual DbSet<TempOtherInfo> TempOtherInfos { get; set; }

    public virtual DbSet<TempReference> TempReferences { get; set; }

    public virtual DbSet<TempServiceRecord> TempServiceRecords { get; set; }

    public virtual DbSet<TempServiceRecordsConsolidated> TempServiceRecordsConsolidateds { get; set; }

    public virtual DbSet<TempSkill> TempSkills { get; set; }

    public virtual DbSet<TempTraining> TempTrainings { get; set; }

    public virtual DbSet<TempVoluntaryWork> TempVoluntaryWorks { get; set; }

    public virtual DbSet<Training> Trainings { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VoluntaryWork> VoluntaryWorks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=172.17.16.14;Database=HRMISV2;User Id=sa;Password=Welcome99;MultipleActiveResultSets=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aoemployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AOEmployees");

            entity.Property(e => e.FldAppointmentStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldAppointmentStatus");
            entity.Property(e => e.FldChargeTo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldChargeTo");
            entity.Property(e => e.FldDivision)
                .HasMaxLength(255)
                .HasColumnName("fldDivision");
            entity.Property(e => e.FldDmsno)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldDMSNo");
            entity.Property(e => e.FldDteIssued1)
                .HasColumnType("datetime")
                .HasColumnName("fldDteIssued1");
            entity.Property(e => e.FldDteIssued2)
                .HasColumnType("datetime")
                .HasColumnName("fldDteIssued2");
            entity.Property(e => e.FldDteReceived)
                .HasColumnType("datetime")
                .HasColumnName("fldDteReceived");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldFirstname)
                .HasMaxLength(255)
                .HasColumnName("fldFirstname");
            entity.Property(e => e.FldFrom)
                .HasColumnType("datetime")
                .HasColumnName("fldFrom");
            entity.Property(e => e.FldGovernor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldGovernor");
            entity.Property(e => e.FldGovernorPostion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Governor")
                .HasColumnName("fldGovernorPostion");
            entity.Property(e => e.FldHrmo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldHRMO");
            entity.Property(e => e.FldHrmopostition)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("Provincial Human Resource Management Officer")
                .HasColumnName("fldHRMOPostition");
            entity.Property(e => e.FldHrmpsb)
                .HasColumnType("datetime")
                .HasColumnName("fldHRMPSB");
            entity.Property(e => e.FldHrmpsb2)
                .HasColumnType("datetime")
                .HasColumnName("fldHRMPSB2");
            entity.Property(e => e.FldHrmpsbdesignate)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldHRMPSBDesignate");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldLastname)
                .HasMaxLength(255)
                .HasColumnName("fldLastname");
            entity.Property(e => e.FldMiddleName)
                .HasMaxLength(255)
                .HasColumnName("fldMIddleName");
            entity.Property(e => e.FldMov1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldMOV1");
            entity.Property(e => e.FldMov2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldMOV2");
            entity.Property(e => e.FldNameEx)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fldNameEx");
            entity.Property(e => e.FldNote)
                .HasComment("Note for the Contract of Service")
                .HasColumnName("fldNote");
            entity.Property(e => e.FldOffice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("fldOffice");
            entity.Property(e => e.FldOfficeId)
                .HasMaxLength(255)
                .HasColumnName("fldOfficeID");
            entity.Property(e => e.FldPage).HasColumnName("fldPage");
            entity.Property(e => e.FldPlace1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldPlace1");
            entity.Property(e => e.FldPlace2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldPlace2");
            entity.Property(e => e.FldPlantillaItemNo).HasColumnName("fldPlantillaItemNo");
            entity.Property(e => e.FldPlantillaNo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldPlantillaNo");
            entity.Property(e => e.FldPosition)
                .HasMaxLength(255)
                .HasColumnName("fldPosition");
            entity.Property(e => e.FldPostedAt)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldPostedAt");
            entity.Property(e => e.FldPostedFrom)
                .HasColumnType("datetime")
                .HasColumnName("fldPostedFrom");
            entity.Property(e => e.FldPostedTo)
                .HasColumnType("datetime")
                .HasColumnName("fldPostedTo");
            entity.Property(e => e.FldPreviousDivision)
                .HasMaxLength(250)
                .HasColumnName("fldPreviousDivision");
            entity.Property(e => e.FldPreviousOfficeId)
                .HasMaxLength(250)
                .HasColumnName("fldPreviousOfficeID");
            entity.Property(e => e.FldPreviousPosition)
                .HasMaxLength(255)
                .HasColumnName("fldPreviousPosition");
            entity.Property(e => e.FldPreviousStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldPreviousStatus");
            entity.Property(e => e.FldProcessed)
                .HasDefaultValue(false)
                .HasColumnName("fldProcessed");
            entity.Property(e => e.FldPublishedAt)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldPublishedAt");
            entity.Property(e => e.FldPublishedFrom)
                .HasColumnType("datetime")
                .HasColumnName("fldPublishedFrom");
            entity.Property(e => e.FldPublishedTo)
                .HasColumnType("datetime")
                .HasColumnName("fldPublishedTo");
            entity.Property(e => e.FldSalary).HasColumnName("fldSalary");
            entity.Property(e => e.FldSalaryGrade).HasColumnName("fldSalaryGrade");
            entity.Property(e => e.FldStatus)
                .HasMaxLength(255)
                .HasColumnName("fldStatus");
            entity.Property(e => e.FldStepInc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("fldStepInc");
            entity.Property(e => e.FldTitle)
                .HasMaxLength(255)
                .HasColumnName("fldTitle");
            entity.Property(e => e.FldTo)
                .HasColumnType("datetime")
                .HasColumnName("fldTo");
        });

        modelBuilder.Entity<App>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AppsIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("Apps_Index");
            entity.Property(e => e.AppsName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Apps_Name");
            entity.Property(e => e.AppsVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Apps_Version");
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldAttachmentId).HasColumnName("fldAttachmentID");
            entity.Property(e => e.FldDescription)
                .HasMaxLength(255)
                .HasColumnName("fldDescription");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldFilePath)
                .HasMaxLength(255)
                .HasColumnName("fldFilePath");
        });

        modelBuilder.Entity<Barangay>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldBarangay)
                .HasMaxLength(50)
                .HasColumnName("fldBarangay");
            entity.Property(e => e.FldBrgyCode)
                .HasMaxLength(9)
                .HasColumnName("fldBrgyCode");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldMunCode)
                .HasMaxLength(9)
                .HasColumnName("fldMunCode");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldBranch)
                .HasMaxLength(100)
                .HasColumnName("fldBranch");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
        });

        modelBuilder.Entity<Child>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved)
                .HasDefaultValue(false)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldApprovedAo)
                .HasDefaultValue(true)
                .HasColumnName("fldApprovedAO");
            entity.Property(e => e.FldBirthday)
                .HasColumnType("datetime")
                .HasColumnName("fldBirthday");
            entity.Property(e => e.FldChildName)
                .HasMaxLength(50)
                .HasColumnName("fldChildName");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
        });

        modelBuilder.Entity<CivilStatus>(entity =>
        {
            entity.HasKey(e => e.FldCivilId);

            entity.ToTable("CivilStatus");

            entity.Property(e => e.FldCivilId).HasColumnName("fldCivilId");
            entity.Property(e => e.FldStatus)
                .HasMaxLength(50)
                .HasColumnName("fldStatus");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Company");

            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldName)
                .HasMaxLength(255)
                .HasColumnName("fldName");
            entity.Property(e => e.FldPosition)
                .HasMaxLength(255)
                .HasColumnName("fldPosition");
            entity.Property(e => e.SetupId).HasColumnName("SetupID");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldCountry)
                .HasMaxLength(255)
                .HasColumnName("fldCountry");
            entity.Property(e => e.FldIndex).HasColumnName("fldIndex");
        });

        modelBuilder.Entity<CurrentYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CurrentYear");

            entity.Property(e => e.FldCurrent).HasColumnName("fldCurrent");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("fldYear");
        });

        modelBuilder.Entity<Designation>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldDesignation)
                .HasMaxLength(255)
                .HasColumnName("fldDesignation");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldLevel)
                .HasMaxLength(5)
                .HasColumnName("fldLevel");
            entity.Property(e => e.FldSequence)
                .HasMaxLength(2)
                .HasColumnName("fldSequence");
            entity.Property(e => e.FldType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldType");
        });

        modelBuilder.Entity<Distinction>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved)
                .HasDefaultValue(true)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldApprovedAo)
                .HasDefaultValue(true)
                .HasColumnName("fldApprovedAO");
            entity.Property(e => e.FldDistinction)
                .HasMaxLength(255)
                .HasColumnName("fldDistinction");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
        });

        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldAoempId).HasColumnName("fldAOEmpID");
            entity.Property(e => e.FldDivision)
                .HasMaxLength(255)
                .HasColumnName("fldDivision");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldOfcAcr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldOfcAcr");
            entity.Property(e => e.FldOfficeId)
                .HasMaxLength(255)
                .HasColumnName("fldOfficeID");
            entity.Property(e => e.FldTelNo)
                .HasMaxLength(255)
                .HasColumnName("fldTelNo");
        });

        modelBuilder.Entity<DocNo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DocNo");

            entity.Property(e => e.Value).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved)
                .HasDefaultValue(true)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldCtrlNo).HasColumnName("fldCtrlNo");
            entity.Property(e => e.FldDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldDescription");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldFilename)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldFilename");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
        });

        modelBuilder.Entity<DocumentType>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldDocType)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldDocType");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
        });

        modelBuilder.Entity<Eligibility>(entity =>
        {
            entity.HasKey(e => e.FldIndex);

            entity.Property(e => e.FldIndex).HasColumnName("fldIndex");
            entity.Property(e => e.FldApproved)
                .HasDefaultValue(false)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldApprovedAo)
                .HasDefaultValue(true)
                .HasColumnName("fldApprovedAO");
            entity.Property(e => e.FldDateExpire)
                .HasColumnType("datetime")
                .HasColumnName("fldDateExpire");
            entity.Property(e => e.FldDateReleased)
                .HasColumnType("datetime")
                .HasColumnName("fldDateReleased");
            entity.Property(e => e.FldEligibility)
                .HasMaxLength(255)
                .HasColumnName("fldEligibility");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldExamDate)
                .HasColumnType("datetime")
                .HasColumnName("fldExamDate");
            entity.Property(e => e.FldExamPlace)
                .HasMaxLength(255)
                .HasColumnName("fldExamPlace");
            entity.Property(e => e.FldExpiry)
                .HasDefaultValue(false)
                .HasColumnName("fldExpiry");
            entity.Property(e => e.FldLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldLevel");
            entity.Property(e => e.FldLicenseNo)
                .HasMaxLength(255)
                .HasColumnName("fldLicenseNo");
            entity.Property(e => e.FldRating)
                .HasDefaultValue(0.0)
                .HasColumnName("fldRating");
        });

        modelBuilder.Entity<EmpId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmpID", tb => tb.HasTrigger("trg_EmpID"));

            entity.Property(e => e.FldCurrent).HasColumnName("fldCurrent");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldYear).HasColumnName("fldYear");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.FldEmpId);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("trg_Insert_Employee");
                    tb.HasTrigger("trg_Update_Employee");
                });

            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.EmpId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.EmpIndex).HasColumnName("Emp_Index");
            entity.Property(e => e.Fld3DegParticulars)
                .HasMaxLength(255)
                .HasColumnName("fld3DegParticulars");
            entity.Property(e => e.FldAbleDetails)
                .HasMaxLength(255)
                .HasColumnName("fldAbleDetails");
            entity.Property(e => e.FldAdminConvicted)
                .HasDefaultValue(false)
                .HasColumnName("fldAdminConvicted");
            entity.Property(e => e.FldAdminDetails)
                .HasMaxLength(255)
                .HasColumnName("fldAdminDetails");
            entity.Property(e => e.FldAdminOfficer)
                .HasDefaultValue(false)
                .HasColumnName("fldAdminOfficer");
            entity.Property(e => e.FldAdministrator)
                .HasDefaultValue(false)
                .HasColumnName("fldAdministrator");
            entity.Property(e => e.FldAdministrator2)
                .HasDefaultValue(false)
                .HasColumnName("fldAdministrator2");
            entity.Property(e => e.FldApproved)
                .HasDefaultValue(true)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldArchivedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldArchivedBy");
            entity.Property(e => e.FldBarangay)
                .HasMaxLength(255)
                .HasColumnName("fldBarangay");
            entity.Property(e => e.FldBarangayCode)
                .HasMaxLength(255)
                .HasColumnName("fldBarangayCode");
            entity.Property(e => e.FldBioId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldBioID");
            entity.Property(e => e.FldBirthDate)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("fldBirthDate");
            entity.Property(e => e.FldBirthPlace)
                .HasMaxLength(255)
                .HasColumnName("fldBirthPlace");
            entity.Property(e => e.FldBloodType)
                .HasMaxLength(255)
                .HasColumnName("fldBloodType");
            entity.Property(e => e.FldByBirth)
                .HasDefaultValue(true)
                .HasColumnName("fldByBirth");
            entity.Property(e => e.FldByNaturalization)
                .HasDefaultValue(false)
                .HasColumnName("fldByNaturalization");
            entity.Property(e => e.FldCandidDetails)
                .HasMaxLength(255)
                .HasColumnName("fldCandidDetails");
            entity.Property(e => e.FldCandidate)
                .HasDefaultValue(false)
                .HasColumnName("fldCandidate");
            entity.Property(e => e.FldCdegree)
                .HasMaxLength(255)
                .HasColumnName("fldCDegree");
            entity.Property(e => e.FldCdegree1)
                .HasMaxLength(250)
                .HasColumnName("fldCDegree1");
            entity.Property(e => e.FldCdegree2)
                .HasMaxLength(250)
                .HasColumnName("fldCDegree2");
            entity.Property(e => e.FldCellNo)
                .HasMaxLength(255)
                .HasColumnName("fldCellNo");
            entity.Property(e => e.FldCeyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCEYear");
            entity.Property(e => e.FldCeyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCEYear1");
            entity.Property(e => e.FldCeyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCEYear2");
            entity.Property(e => e.FldChonors)
                .HasMaxLength(255)
                .HasColumnName("fldCHonors");
            entity.Property(e => e.FldChonors1)
                .HasMaxLength(250)
                .HasColumnName("fldCHonors1");
            entity.Property(e => e.FldChonors2)
                .HasMaxLength(250)
                .HasColumnName("fldCHonors2");
            entity.Property(e => e.FldCitizenship)
                .HasMaxLength(255)
                .HasColumnName("fldCitizenship");
            entity.Property(e => e.FldCivilStatus)
                .HasMaxLength(50)
                .HasColumnName("fldCivilStatus");
            entity.Property(e => e.FldCollege)
                .HasMaxLength(255)
                .HasColumnName("fldCollege");
            entity.Property(e => e.FldCollege1)
                .HasMaxLength(250)
                .HasColumnName("fldCollege1");
            entity.Property(e => e.FldCollege2)
                .HasMaxLength(250)
                .HasColumnName("fldCollege2");
            entity.Property(e => e.FldCountry)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldCountry");
            entity.Property(e => e.FldCrimeConvicted)
                .HasDefaultValue(false)
                .HasColumnName("fldCrimeConvicted");
            entity.Property(e => e.FldCrimeDetails)
                .HasMaxLength(255)
                .HasColumnName("fldCrimeDetails");
            entity.Property(e => e.FldCsidno)
                .HasMaxLength(255)
                .HasColumnName("fldCSIDNo");
            entity.Property(e => e.FldCsyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCSYear");
            entity.Property(e => e.FldCsyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCSYear1");
            entity.Property(e => e.FldCsyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCSYear2");
            entity.Property(e => e.FldCtcdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fldCTCDate");
            entity.Property(e => e.FldCtcname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldCTCName");
            entity.Property(e => e.FldCtcno)
                .HasMaxLength(53)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("fldCTCNo");
            entity.Property(e => e.FldCtcplace)
                .HasMaxLength(255)
                .HasColumnName("fldCTCPlace");
            entity.Property(e => e.FldCunits)
                .HasMaxLength(255)
                .HasColumnName("fldCUnits");
            entity.Property(e => e.FldCunits1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldCUnits1");
            entity.Property(e => e.FldCunits2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldCUnits2");
            entity.Property(e => e.FldCyearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCYearGrad");
            entity.Property(e => e.FldCyearGrad1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCYearGrad1");
            entity.Property(e => e.FldCyearGrad2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCYearGrad2");
            entity.Property(e => e.FldDateArchived)
                .HasColumnType("datetime")
                .HasColumnName("fldDateArchived");
            entity.Property(e => e.FldDateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fldDateCreated");
            entity.Property(e => e.FldDateRestored)
                .HasColumnType("datetime")
                .HasColumnName("fldDateRestored");
            entity.Property(e => e.FldDegParticulars)
                .HasMaxLength(255)
                .HasColumnName("fldDegParticulars");
            entity.Property(e => e.FldDeleted).HasColumnName("fldDeleted");
            entity.Property(e => e.FldDisabled).HasColumnName("fldDisabled");
            entity.Property(e => e.FldDisplay)
                .HasDefaultValue(false)
                .HasColumnName("fldDisplay");
            entity.Property(e => e.FldDivision)
                .HasMaxLength(255)
                .HasColumnName("fldDivision");
            entity.Property(e => e.FldEdegreee)
                .HasMaxLength(255)
                .HasColumnName("fldEDegreee");
            entity.Property(e => e.FldEdegreee1)
                .HasMaxLength(250)
                .HasColumnName("fldEDegreee1");
            entity.Property(e => e.FldEducation)
                .HasDefaultValue(false)
                .HasColumnName("fldEducation");
            entity.Property(e => e.FldEducationAo)
                .HasDefaultValue(true)
                .HasColumnName("fldEducationAO");
            entity.Property(e => e.FldEendYear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldEEndYear");
            entity.Property(e => e.FldEendYear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldEEndYear1");
            entity.Property(e => e.FldEhonors)
                .HasMaxLength(255)
                .HasColumnName("fldEHonors");
            entity.Property(e => e.FldEhonors1)
                .HasMaxLength(250)
                .HasColumnName("fldEHonors1");
            entity.Property(e => e.FldElcmsId).HasColumnName("fldELCMS_ID");
            entity.Property(e => e.FldElementary)
                .HasMaxLength(255)
                .HasColumnName("fldElementary");
            entity.Property(e => e.FldElementary1)
                .HasMaxLength(250)
                .HasColumnName("fldElementary1");
            entity.Property(e => e.FldEmailAdd)
                .HasMaxLength(255)
                .HasColumnName("fldEmailAdd");
            entity.Property(e => e.FldEndUser)
                .HasDefaultValue(true)
                .HasColumnName("fldEndUser");
            entity.Property(e => e.FldEstartYear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldEStartYear");
            entity.Property(e => e.FldEstartYear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldEStartYear1");
            entity.Property(e => e.FldEunits)
                .HasMaxLength(255)
                .HasColumnName("fldEUnits");
            entity.Property(e => e.FldEunits1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldEUnits1");
            entity.Property(e => e.FldEyearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldEYearGrad");
            entity.Property(e => e.FldEyearGrad1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldEYearGrad1");
            entity.Property(e => e.FldFather)
                .HasMaxLength(255)
                .HasColumnName("fldFather");
            entity.Property(e => e.FldFatherFirstname)
                .HasMaxLength(255)
                .HasColumnName("fldFatherFirstname");
            entity.Property(e => e.FldFatherMiddlename)
                .HasMaxLength(255)
                .HasColumnName("fldFatherMiddlename");
            entity.Property(e => e.FldFatherSurname)
                .HasMaxLength(255)
                .HasColumnName("fldFatherSurname");
            entity.Property(e => e.FldFchargeDetails)
                .HasMaxLength(255)
                .HasColumnName("fldFChargeDetails");
            entity.Property(e => e.FldFirstname)
                .HasMaxLength(255)
                .HasColumnName("fldFirstname");
            entity.Property(e => e.FldForceRetire)
                .HasDefaultValue(false)
                .HasColumnName("fldForceRetire");
            entity.Property(e => e.FldFormallyCharged)
                .HasDefaultValue(false)
                .HasColumnName("fldFormallyCharged");
            entity.Property(e => e.FldFourthDeg)
                .HasDefaultValue(false)
                .HasColumnName("fldFourthDeg");
            entity.Property(e => e.FldFrequency)
                .HasMaxLength(50)
                .HasColumnName("fldFrequency");
            entity.Property(e => e.FldGsddegree)
                .HasMaxLength(255)
                .HasColumnName("fldGSDDegree");
            entity.Property(e => e.FldGsddegree1)
                .HasMaxLength(250)
                .HasColumnName("fldGSDDegree1");
            entity.Property(e => e.FldGsddegree2)
                .HasMaxLength(250)
                .HasColumnName("fldGSDDegree2");
            entity.Property(e => e.FldGsdeyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDEYear");
            entity.Property(e => e.FldGsdeyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDEYear1");
            entity.Property(e => e.FldGsdeyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDEYear2");
            entity.Property(e => e.FldGsdhonors)
                .HasMaxLength(255)
                .HasColumnName("fldGSDHonors");
            entity.Property(e => e.FldGsdhonors1)
                .HasMaxLength(250)
                .HasColumnName("fldGSDHonors1");
            entity.Property(e => e.FldGsdhonors2)
                .HasMaxLength(250)
                .HasColumnName("fldGSDHonors2");
            entity.Property(e => e.FldGsdiploma)
                .HasMaxLength(255)
                .HasColumnName("fldGSDiploma");
            entity.Property(e => e.FldGsdiploma1)
                .HasMaxLength(250)
                .HasColumnName("fldGSDiploma1");
            entity.Property(e => e.FldGsdiploma2)
                .HasMaxLength(250)
                .HasColumnName("fldGSDiploma2");
            entity.Property(e => e.FldGsdoctor)
                .HasMaxLength(255)
                .HasColumnName("fldGSDoctor");
            entity.Property(e => e.FldGsdoctor1)
                .HasMaxLength(250)
                .HasColumnName("fldGSDoctor1");
            entity.Property(e => e.FldGsdoctor2)
                .HasMaxLength(250)
                .HasColumnName("fldGSDoctor2");
            entity.Property(e => e.FldGsdsyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDSYear");
            entity.Property(e => e.FldGsdsyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDSYear1");
            entity.Property(e => e.FldGsdsyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDSYear2");
            entity.Property(e => e.FldGsdunits)
                .HasMaxLength(255)
                .HasColumnName("fldGSDUnits");
            entity.Property(e => e.FldGsdunits1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldGSDUnits1");
            entity.Property(e => e.FldGsdunits2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldGSDUnits2");
            entity.Property(e => e.FldGsdyearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDYearGrad");
            entity.Property(e => e.FldGsdyearGrad1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDYearGrad1");
            entity.Property(e => e.FldGsdyearGrad2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDYearGrad2");
            entity.Property(e => e.FldGsisno)
                .HasMaxLength(255)
                .HasColumnName("fldGSISNo");
            entity.Property(e => e.FldGsmaster)
                .HasMaxLength(255)
                .HasColumnName("fldGSMaster");
            entity.Property(e => e.FldGsmaster1)
                .HasMaxLength(250)
                .HasColumnName("fldGSMaster1");
            entity.Property(e => e.FldGsmaster2)
                .HasMaxLength(250)
                .HasColumnName("fldGSMaster2");
            entity.Property(e => e.FldGsmdegree)
                .HasMaxLength(255)
                .HasColumnName("fldGSMDegree");
            entity.Property(e => e.FldGsmdegree1)
                .HasMaxLength(250)
                .HasColumnName("fldGSMDegree1");
            entity.Property(e => e.FldGsmdegree2)
                .HasMaxLength(250)
                .HasColumnName("fldGSMDegree2");
            entity.Property(e => e.FldGsmeyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMEYear");
            entity.Property(e => e.FldGsmeyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMEYear1");
            entity.Property(e => e.FldGsmeyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMEYear2");
            entity.Property(e => e.FldGsmhonors)
                .HasMaxLength(255)
                .HasColumnName("fldGSMHonors");
            entity.Property(e => e.FldGsmhonors1)
                .HasMaxLength(250)
                .HasColumnName("fldGSMHonors1");
            entity.Property(e => e.FldGsmhonors2)
                .HasMaxLength(250)
                .HasColumnName("fldGSMHonors2");
            entity.Property(e => e.FldGsmsyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMSYear");
            entity.Property(e => e.FldGsmsyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMSYear1");
            entity.Property(e => e.FldGsmsyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMSYear2");
            entity.Property(e => e.FldGsmunits)
                .HasMaxLength(255)
                .HasColumnName("fldGSMUnits");
            entity.Property(e => e.FldGsmunits1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldGSMUnits1");
            entity.Property(e => e.FldGsmunits2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldGSMUnits2");
            entity.Property(e => e.FldGsmyearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMYearGrad");
            entity.Property(e => e.FldGsmyearGrad1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMYearGrad1");
            entity.Property(e => e.FldGsmyearGrad2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMYearGrad2");
            entity.Property(e => e.FldGsrdegree)
                .HasMaxLength(255)
                .HasColumnName("fldGSRDegree");
            entity.Property(e => e.FldGsrdegree1)
                .HasMaxLength(250)
                .HasColumnName("fldGSRDegree1");
            entity.Property(e => e.FldGsrdegree2)
                .HasMaxLength(250)
                .HasColumnName("fldGSRDegree2");
            entity.Property(e => e.FldGsreyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSREYear");
            entity.Property(e => e.FldGsreyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSREYear1");
            entity.Property(e => e.FldGsreyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSREYear2");
            entity.Property(e => e.FldGsrhonors)
                .HasMaxLength(255)
                .HasColumnName("fldGSRHonors");
            entity.Property(e => e.FldGsrhonors1)
                .HasMaxLength(250)
                .HasColumnName("fldGSRHonors1");
            entity.Property(e => e.FldGsrhonors2)
                .HasMaxLength(250)
                .HasColumnName("fldGSRHonors2");
            entity.Property(e => e.FldGsrmsyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSRMSYear");
            entity.Property(e => e.FldGsrmsyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSRMSYear1");
            entity.Property(e => e.FldGsrmsyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSRMSYear2");
            entity.Property(e => e.FldGsrunits)
                .HasMaxLength(255)
                .HasColumnName("fldGSRUnits");
            entity.Property(e => e.FldGsrunits1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldGSRUnits1");
            entity.Property(e => e.FldGsrunits2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldGSRUnits2");
            entity.Property(e => e.FldGsryearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSRYearGrad");
            entity.Property(e => e.FldGsryearGrad1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSRYearGrad1");
            entity.Property(e => e.FldGsryearGrad2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSRYearGrad2");
            entity.Property(e => e.FldHeadChief)
                .HasDefaultValue(false)
                .HasColumnName("fldHeadChief");
            entity.Property(e => e.FldHeight)
                .HasDefaultValue(0.0)
                .HasColumnName("fldHeight");
            entity.Property(e => e.FldHoliday)
                .HasDefaultValue(true)
                .HasColumnName("fldHoliday");
            entity.Property(e => e.FldHrstaff)
                .HasDefaultValue(false)
                .HasColumnName("fldHRStaff");
            entity.Property(e => e.FldIdctr)
                .HasMaxLength(50)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("fldIDCtr");
            entity.Property(e => e.FldImmigrant)
                .HasDefaultValue(false)
                .HasColumnName("fldImmigrant");
            entity.Property(e => e.FldImmigrantDetail)
                .HasMaxLength(255)
                .HasColumnName("fldImmigrantDetail");
            entity.Property(e => e.FldIndigDetails)
                .HasMaxLength(255)
                .HasColumnName("fldIndigDetails");
            entity.Property(e => e.FldIndigMember)
                .HasDefaultValue(false)
                .HasColumnName("fldIndigMember");
            entity.Property(e => e.FldInitialApp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("fldInitialApp");
            entity.Property(e => e.FldLastUpdated)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("fldLastUpdated");
            entity.Property(e => e.FldLastname)
                .HasMaxLength(255)
                .HasColumnName("fldLastname");
            entity.Property(e => e.FldLatestApp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fldLatestApp");
            entity.Property(e => e.FldLevel)
                .HasMaxLength(5)
                .HasColumnName("fldLevel");
            entity.Property(e => e.FldMiddleName)
                .HasMaxLength(255)
                .HasColumnName("fldMIddleName");
            entity.Property(e => e.FldMother)
                .HasMaxLength(255)
                .HasColumnName("fldMother");
            entity.Property(e => e.FldMotherFirstname)
                .HasMaxLength(255)
                .HasColumnName("fldMotherFirstname");
            entity.Property(e => e.FldMotherMiddlename)
                .HasMaxLength(255)
                .HasColumnName("fldMotherMiddlename");
            entity.Property(e => e.FldMotherSurname)
                .HasMaxLength(255)
                .HasColumnName("fldMotherSurname");
            entity.Property(e => e.FldMunicipality)
                .HasMaxLength(255)
                .HasColumnName("fldMunicipality");
            entity.Property(e => e.FldMunicipalityCode)
                .HasMaxLength(255)
                .HasColumnName("fldMunicipalityCode");
            entity.Property(e => e.FldNameExt)
                .HasMaxLength(255)
                .HasColumnName("fldNameExt");
            entity.Property(e => e.FldOfficeId)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("fldOfficeID");
            entity.Property(e => e.FldOfficePrefix)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldOfficePrefix");
            entity.Property(e => e.FldOperator)
                .HasMaxLength(255)
                .HasColumnName("fldOperator");
            entity.Property(e => e.FldOtherInfo)
                .HasDefaultValue(false)
                .HasColumnName("fldOtherInfo");
            entity.Property(e => e.FldOtherInfoAo)
                .HasDefaultValue(true)
                .HasColumnName("fldOtherInfoAO");
            entity.Property(e => e.FldPabarangay)
                .HasMaxLength(255)
                .HasColumnName("fldPABarangay");
            entity.Property(e => e.FldPagibigId)
                .HasMaxLength(255)
                .HasColumnName("fldPagibigID");
            entity.Property(e => e.FldPamunicipality)
                .HasMaxLength(255)
                .HasColumnName("fldPAMunicipality");
            entity.Property(e => e.FldPaprovince)
                .HasMaxLength(255)
                .HasColumnName("fldPAProvince");
            entity.Property(e => e.FldParentAdd)
                .HasMaxLength(255)
                .HasColumnName("fldParentAdd");
            entity.Property(e => e.FldPasswordHash).HasColumnName("fldPasswordHash");
            entity.Property(e => e.FldPastreet)
                .HasMaxLength(255)
                .HasColumnName("fldPAStreet");
            entity.Property(e => e.FldPatelNo)
                .HasMaxLength(255)
                .HasColumnName("fldPATelNo");
            entity.Property(e => e.FldPazipCode)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("fldPAZipCode");
            entity.Property(e => e.FldPersonal)
                .HasDefaultValue(false)
                .HasColumnName("fldPersonal");
            entity.Property(e => e.FldPersonalAo)
                .HasDefaultValue(true)
                .HasColumnName("fldPersonalAO");
            entity.Property(e => e.FldPhilHealthNo)
                .HasMaxLength(255)
                .HasColumnName("fldPhilHealthNo");
            entity.Property(e => e.FldPhrmo)
                .HasDefaultValue(false)
                .HasColumnName("fldPHRMO");
            entity.Property(e => e.FldPosition)
                .HasMaxLength(255)
                .HasColumnName("fldPosition");
            entity.Property(e => e.FldProvince)
                .HasMaxLength(255)
                .HasColumnName("fldProvince");
            entity.Property(e => e.FldReasonDeleted)
                .HasMaxLength(255)
                .HasColumnName("fldReasonDeleted");
            entity.Property(e => e.FldRegistered)
                .HasDefaultValue(false)
                .HasColumnName("fldRegistered");
            entity.Property(e => e.FldRemoved)
                .HasDefaultValue(false)
                .HasColumnName("fldRemoved");
            entity.Property(e => e.FldResigned)
                .HasDefaultValue(false)
                .HasColumnName("fldResigned");
            entity.Property(e => e.FldResignedDetail)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldResignedDetail");
            entity.Property(e => e.FldRestoredBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldRestoredBy");
            entity.Property(e => e.FldRetDetails)
                .HasMaxLength(255)
                .HasColumnName("fldRetDetails");
            entity.Property(e => e.FldSalary)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSalary");
            entity.Property(e => e.FldSalaryGrade)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSalaryGrade");
            entity.Property(e => e.FldSdegree)
                .HasMaxLength(255)
                .HasColumnName("fldSDegree");
            entity.Property(e => e.FldSdegree1)
                .HasMaxLength(250)
                .HasColumnName("fldSDegree1");
            entity.Property(e => e.FldSdegree2)
                .HasMaxLength(250)
                .HasColumnName("fldSDegree2");
            entity.Property(e => e.FldSecondary)
                .HasMaxLength(255)
                .HasColumnName("fldSecondary");
            entity.Property(e => e.FldSecondary1)
                .HasMaxLength(250)
                .HasColumnName("fldSecondary1");
            entity.Property(e => e.FldSecondary2)
                .HasMaxLength(250)
                .HasColumnName("fldSecondary2");
            entity.Property(e => e.FldSecurityStamp).HasColumnName("fldSecurityStamp");
            entity.Property(e => e.FldSex)
                .HasMaxLength(50)
                .HasColumnName("fldSex");
            entity.Property(e => e.FldSeyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSEYear");
            entity.Property(e => e.FldSeyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSEYear1");
            entity.Property(e => e.FldSeyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSEYear2");
            entity.Property(e => e.FldShonors)
                .HasMaxLength(255)
                .HasColumnName("fldSHonors");
            entity.Property(e => e.FldShonors1)
                .HasMaxLength(250)
                .HasColumnName("fldSHonors1");
            entity.Property(e => e.FldShonors2)
                .HasMaxLength(250)
                .HasColumnName("fldSHonors2");
            entity.Property(e => e.FldSoloDetails)
                .HasMaxLength(255)
                .HasColumnName("fldSoloDetails");
            entity.Property(e => e.FldSoloParent)
                .HasDefaultValue(false)
                .HasColumnName("fldSoloParent");
            entity.Property(e => e.FldSpouseFirstname)
                .HasMaxLength(255)
                .HasColumnName("fldSpouseFirstname");
            entity.Property(e => e.FldSpouseMiddlename)
                .HasMaxLength(255)
                .HasColumnName("fldSpouseMiddlename");
            entity.Property(e => e.FldSpouseName)
                .HasMaxLength(255)
                .HasColumnName("fldSpouseName");
            entity.Property(e => e.FldSpouseOccup)
                .HasMaxLength(255)
                .HasColumnName("fldSpouseOccup");
            entity.Property(e => e.FldSpouseSurname)
                .HasMaxLength(255)
                .HasColumnName("fldSpouseSurname");
            entity.Property(e => e.FldSpsEmp)
                .HasMaxLength(255)
                .HasColumnName("fldSpsEmp");
            entity.Property(e => e.FldSpsEmpAdd)
                .HasMaxLength(255)
                .HasColumnName("fldSpsEmpAdd");
            entity.Property(e => e.FldSpsEmpTel)
                .HasMaxLength(255)
                .HasColumnName("fldSpsEmpTel");
            entity.Property(e => e.FldSssno)
                .HasMaxLength(255)
                .HasColumnName("fldSSSNo");
            entity.Property(e => e.FldSsyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSSYear");
            entity.Property(e => e.FldSsyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSSYear1");
            entity.Property(e => e.FldSsyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSSYear2");
            entity.Property(e => e.FldStatus)
                .HasMaxLength(255)
                .HasColumnName("fldStatus");
            entity.Property(e => e.FldStepInc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("fldStepInc");
            entity.Property(e => e.FldStrId)
                .HasMaxLength(255)
                .HasColumnName("fldStrID");
            entity.Property(e => e.FldStreet)
                .HasMaxLength(255)
                .HasColumnName("fldStreet");
            entity.Property(e => e.FldSunits)
                .HasMaxLength(255)
                .HasColumnName("fldSUnits");
            entity.Property(e => e.FldSunits1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldSUnits1");
            entity.Property(e => e.FldSunits2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldSUnits2");
            entity.Property(e => e.FldSyearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSYearGrad");
            entity.Property(e => e.FldSyearGrad1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSYearGrad1");
            entity.Property(e => e.FldSyearGrad2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSYearGrad2");
            entity.Property(e => e.FldTelNo)
                .HasMaxLength(255)
                .HasColumnName("fldTelNo");
            entity.Property(e => e.FldThirdDeg)
                .HasDefaultValue(false)
                .HasColumnName("fldThirdDeg");
            entity.Property(e => e.FldTin)
                .HasMaxLength(255)
                .HasColumnName("fldTIN");
            entity.Property(e => e.FldTitle)
                .HasMaxLength(255)
                .HasColumnName("fldTitle");
            entity.Property(e => e.FldUsername)
                .HasMaxLength(100)
                .HasColumnName("fldUsername");
            entity.Property(e => e.FldVdegree)
                .HasMaxLength(255)
                .HasColumnName("fldVDegree");
            entity.Property(e => e.FldVdegree1)
                .HasMaxLength(250)
                .HasColumnName("fldVDegree1");
            entity.Property(e => e.FldVeyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldVEYear");
            entity.Property(e => e.FldVeyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldVEYear1");
            entity.Property(e => e.FldVhonors)
                .HasMaxLength(255)
                .HasColumnName("fldVHonors");
            entity.Property(e => e.FldVhonors1)
                .HasMaxLength(250)
                .HasColumnName("fldVHonors1");
            entity.Property(e => e.FldVocational)
                .HasMaxLength(255)
                .HasColumnName("fldVocational");
            entity.Property(e => e.FldVocational1)
                .HasMaxLength(250)
                .HasColumnName("fldVocational1");
            entity.Property(e => e.FldVsyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldVSYear");
            entity.Property(e => e.FldVsyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldVSYear1");
            entity.Property(e => e.FldVunits)
                .HasMaxLength(255)
                .HasColumnName("fldVUnits");
            entity.Property(e => e.FldVunits1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldVUnits1");
            entity.Property(e => e.FldVyearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldVYearGrad");
            entity.Property(e => e.FldVyearGrad1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldVYearGrad1");
            entity.Property(e => e.FldWeight)
                .HasDefaultValue(0.0)
                .HasColumnName("fldWeight");
            entity.Property(e => e.FldZipCode)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("fldZipCode");
            entity.Property(e => e.Flddetailed)
                .HasDefaultValue(false)
                .HasColumnName("flddetailed");
            entity.Property(e => e.FlddetailedDte)
                .HasColumnType("datetime")
                .HasColumnName("flddetailedDte");
            entity.Property(e => e.FlddetailedTo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("flddetailedTo");
            entity.Property(e => e.FlddetailedToDivision)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("flddetailedToDivision");
            entity.Property(e => e.Photo).HasMaxLength(255);
            entity.Property(e => e.SchedGroupId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("schedGroupID");
        });

        modelBuilder.Entity<Level>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Level");

            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldLevel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldLevel");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldDate)
                .HasColumnType("datetime")
                .HasColumnName("fldDate");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldParticular)
                .HasMaxLength(150)
                .HasColumnName("fldParticular");
            entity.Property(e => e.FldUsername)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldUsername");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldDate)
                .HasColumnType("datetime")
                .HasColumnName("fldDate");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldMessage)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldMessage");
            entity.Property(e => e.FldRead)
                .HasDefaultValue(false)
                .HasColumnName("fldRead");
            entity.Property(e => e.FldSender)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldSender");
            entity.Property(e => e.FldUpdateNo).HasColumnName("fldUpdateNo");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldAction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldAction");
            entity.Property(e => e.FldEndUser)
                .HasDefaultValue(false)
                .HasColumnName("fldEndUser");
            entity.Property(e => e.FldHrstaff)
                .HasDefaultValue(false)
                .HasColumnName("fldHRStaff");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldModule)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldModule");
        });

        modelBuilder.Entity<Municipality>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldMayor)
                .HasMaxLength(255)
                .HasColumnName("fldMayor");
            entity.Property(e => e.FldMho)
                .HasMaxLength(255)
                .HasColumnName("fldMHO");
            entity.Property(e => e.FldMunCode)
                .HasMaxLength(255)
                .HasColumnName("fldMunCode");
            entity.Property(e => e.FldMunicipality)
                .HasMaxLength(255)
                .HasColumnName("fldMunicipality");
            entity.Property(e => e.FldProvCode)
                .HasMaxLength(255)
                .HasColumnName("fldProvCode");
        });

        modelBuilder.Entity<NewEmp>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldBarangay)
                .HasMaxLength(255)
                .HasColumnName("fldBarangay");
            entity.Property(e => e.FldBirthDate)
                .HasColumnType("datetime")
                .HasColumnName("fldBirthDate");
            entity.Property(e => e.FldBirthPlace)
                .HasMaxLength(255)
                .HasColumnName("fldBirthPlace");
            entity.Property(e => e.FldBloodType)
                .HasMaxLength(255)
                .HasColumnName("fldBloodType");
            entity.Property(e => e.FldCellNo)
                .HasMaxLength(255)
                .HasColumnName("fldCellNo");
            entity.Property(e => e.FldCitizenship)
                .HasMaxLength(255)
                .HasColumnName("fldCitizenship");
            entity.Property(e => e.FldCivilStatus)
                .HasMaxLength(50)
                .HasColumnName("fldCivilStatus");
            entity.Property(e => e.FldEmailAdd)
                .HasMaxLength(255)
                .HasColumnName("fldEmailAdd");
            entity.Property(e => e.FldEmpId)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldEmpID");
            entity.Property(e => e.FldFirstname)
                .HasMaxLength(255)
                .HasColumnName("fldFirstname");
            entity.Property(e => e.FldHeight).HasColumnName("fldHeight");
            entity.Property(e => e.FldLastname)
                .HasMaxLength(255)
                .HasColumnName("fldLastname");
            entity.Property(e => e.FldMiddleName)
                .HasMaxLength(255)
                .HasColumnName("fldMIddleName");
            entity.Property(e => e.FldMunicipality)
                .HasMaxLength(255)
                .HasColumnName("fldMunicipality");
            entity.Property(e => e.FldOfficeId)
                .HasMaxLength(255)
                .HasColumnName("fldOfficeID");
            entity.Property(e => e.FldPosition)
                .HasMaxLength(255)
                .HasColumnName("fldPosition");
            entity.Property(e => e.FldProvince)
                .HasMaxLength(255)
                .HasColumnName("fldProvince");
            entity.Property(e => e.FldSex).HasColumnName("fldSex");
            entity.Property(e => e.FldStatus)
                .HasMaxLength(255)
                .HasColumnName("fldStatus");
            entity.Property(e => e.FldStreet)
                .HasMaxLength(255)
                .HasColumnName("fldStreet");
            entity.Property(e => e.FldTelNo)
                .HasMaxLength(255)
                .HasColumnName("fldTelNo");
            entity.Property(e => e.FldWeight).HasColumnName("fldWeight");
        });

        modelBuilder.Entity<Office>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldAoempId).HasColumnName("fldAOEmpID");
            entity.Property(e => e.FldChief)
                .HasMaxLength(255)
                .HasColumnName("fldChief");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldMainOffice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("fldMainOffice");
            entity.Property(e => e.FldOfficeId)
                .HasMaxLength(255)
                .HasColumnName("fldOfficeID");
            entity.Property(e => e.FldOfficeName)
                .HasMaxLength(255)
                .HasColumnName("fldOfficeName");
            entity.Property(e => e.FldOldNew)
                .HasDefaultValue(true)
                .HasColumnName("fldOldNew");
            entity.Property(e => e.FldSequence)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldSequence");
            entity.Property(e => e.FldTelNo)
                .HasMaxLength(255)
                .HasColumnName("fldTelNo");
        });

        modelBuilder.Entity<Operator>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.FldAdd).HasColumnName("fldAdd");
            entity.Property(e => e.FldAdministrator).HasColumnName("fldAdministrator");
            entity.Property(e => e.FldApproveChanges)
                .HasDefaultValue(false)
                .HasColumnName("fldApproveChanges");
            entity.Property(e => e.FldApproveSr)
                .HasDefaultValue(false)
                .HasColumnName("fldApproveSR");
            entity.Property(e => e.FldDelete).HasColumnName("fldDelete");
            entity.Property(e => e.FldEdit).HasColumnName("fldEdit");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.Password).HasMaxLength(25);
            entity.Property(e => e.Username).HasMaxLength(15);
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved)
                .HasDefaultValue(true)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldApprovedAo)
                .HasDefaultValue(true)
                .HasColumnName("fldApprovedAO");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldOrganization)
                .HasMaxLength(255)
                .HasColumnName("fldOrganization");
        });

        modelBuilder.Entity<OtherEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OtherEducation");

            entity.Property(e => e.FldApproved)
                .HasDefaultValue(false)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldDegree)
                .HasMaxLength(255)
                .HasColumnName("fldDegree");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldEndYear).HasColumnName("fldEndYear");
            entity.Property(e => e.FldGraduated)
                .HasDefaultValue(true)
                .HasColumnName("fldGraduated");
            entity.Property(e => e.FldHonors)
                .HasMaxLength(255)
                .HasColumnName("fldHonors");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldLevel).HasColumnName("fldLevel");
            entity.Property(e => e.FldSchool)
                .HasMaxLength(255)
                .HasColumnName("fldSchool");
            entity.Property(e => e.FldStartYear).HasColumnName("fldStartYear");
            entity.Property(e => e.FldUnits)
                .HasMaxLength(255)
                .HasColumnName("fldUnits");
            entity.Property(e => e.FldYearGrad).HasColumnName("fldYearGrad");
        });

        modelBuilder.Entity<Prclist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PRCList");

            entity.Property(e => e.FldEligibility)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldEligibility");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldLevel)
                .HasDefaultValue(0)
                .HasColumnName("fldLevel");
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldProvCode)
                .HasMaxLength(255)
                .HasColumnName("fldProvCode");
            entity.Property(e => e.FldProvince)
                .HasMaxLength(255)
                .HasColumnName("fldProvince");
            entity.Property(e => e.FldRegCode)
                .HasMaxLength(255)
                .HasColumnName("fldRegCode");
        });

        modelBuilder.Entity<RecordUpdate>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved)
                .HasDefaultValue(false)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldApprovedAo)
                .HasDefaultValue(true)
                .HasColumnName("fldApprovedAO");
            entity.Property(e => e.FldApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldApprovedBy");
            entity.Property(e => e.FldApprovedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("fldApprovedDateTime");
            entity.Property(e => e.FldApprovedDateTimeAo)
                .HasDefaultValueSql("((1))")
                .HasColumnType("datetime")
                .HasColumnName("fldApprovedDateTimeAO");
            entity.Property(e => e.FldCompleteDocs)
                .HasDefaultValue(false)
                .HasColumnName("fldCompleteDocs");
            entity.Property(e => e.FldCreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldCreatedBy");
            entity.Property(e => e.FldCtrlNo)
                .HasDefaultValue(0L)
                .HasColumnName("fldCtrlNo");
            entity.Property(e => e.FldDateSubmitted)
                .HasColumnType("datetime")
                .HasColumnName("fldDateSubmitted");
            entity.Property(e => e.FldDateTime)
                .HasColumnType("datetime")
                .HasColumnName("fldDateTime");
            entity.Property(e => e.FldEmpId)
                .HasDefaultValue(0L)
                .HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldParticular)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldParticular");
            entity.Property(e => e.FldRemarks)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldRemarks");
            entity.Property(e => e.FldValidatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldValidatedBy");
        });

        modelBuilder.Entity<Refbrgy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("refbrgy");

            entity.Property(e => e.BrgyCode).HasColumnName("brgyCode");
            entity.Property(e => e.BrgyDesc)
                .HasMaxLength(150)
                .HasColumnName("brgyDesc");
            entity.Property(e => e.CitymunCode).HasColumnName("citymunCode");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
        });

        modelBuilder.Entity<Refcitymun>(entity =>
        {
            entity.ToTable("refcitymun");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.CitymunCode).HasColumnName("citymunCode");
            entity.Property(e => e.CitymunDesc)
                .HasMaxLength(50)
                .HasColumnName("citymunDesc");
            entity.Property(e => e.ProvCode).HasColumnName("provCode");
            entity.Property(e => e.PsgcCode).HasColumnName("psgcCode");
            entity.Property(e => e.RegDesc)
                .HasMaxLength(50)
                .HasColumnName("regDesc");
        });

        modelBuilder.Entity<Reference>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved)
                .HasDefaultValue(false)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldApprovedAo)
                .HasDefaultValue(true)
                .HasColumnName("fldApprovedAO");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldOffice)
                .HasMaxLength(255)
                .HasColumnName("fldOffice");
            entity.Property(e => e.FldRefAddress)
                .HasMaxLength(255)
                .HasColumnName("fldRefAddress");
            entity.Property(e => e.FldRefName)
                .HasMaxLength(255)
                .HasColumnName("fldRefName");
            entity.Property(e => e.FldTelNo)
                .HasMaxLength(255)
                .HasColumnName("fldTelNo");
        });

        modelBuilder.Entity<Refprovince>(entity =>
        {
            entity.ToTable("refprovince");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.ProvCode).HasColumnName("provCode");
            entity.Property(e => e.ProvDesc)
                .HasMaxLength(50)
                .HasColumnName("provDesc");
            entity.Property(e => e.PsgcCode).HasColumnName("psgcCode");
            entity.Property(e => e.RegCode)
                .HasMaxLength(50)
                .HasColumnName("regCode");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldRegCode)
                .HasMaxLength(255)
                .HasColumnName("fldRegCode");
            entity.Property(e => e.FldRegion)
                .HasMaxLength(255)
                .HasColumnName("fldRegion");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldAction)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fldAction");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldModule)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldModule");
            entity.Property(e => e.FldUsername)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fldUsername");
        });

        modelBuilder.Entity<SalarySchedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalarySchedule");

            entity.Property(e => e.Fld1st).HasColumnName("fld1st");
            entity.Property(e => e.Fld2nd).HasColumnName("fld2nd");
            entity.Property(e => e.Fld3rd).HasColumnName("fld3rd");
            entity.Property(e => e.Fld4th).HasColumnName("fld4th");
            entity.Property(e => e.Fld5th).HasColumnName("fld5th");
            entity.Property(e => e.Fld6th).HasColumnName("fld6th");
            entity.Property(e => e.Fld7th).HasColumnName("fld7th");
            entity.Property(e => e.Fld8th).HasColumnName("fld8th");
            entity.Property(e => e.FldCurrentYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("fldCurrentYear");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldSg).HasColumnName("fldSG");
        });

        modelBuilder.Entity<SeparationCause>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldCause)
                .HasMaxLength(255)
                .HasColumnName("fldCause");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
        });

        modelBuilder.Entity<ServiceRecord>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved)
                .HasDefaultValue(false)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldBranch)
                .HasMaxLength(255)
                .HasColumnName("fldBranch");
            entity.Property(e => e.FldCause)
                .HasMaxLength(255)
                .HasColumnName("fldCause");
            entity.Property(e => e.FldDateSep)
                .HasMaxLength(255)
                .HasColumnName("fldDateSep");
            entity.Property(e => e.FldDesignation)
                .HasMaxLength(255)
                .HasColumnName("fldDesignation");
            entity.Property(e => e.FldDivision)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("fldDivision");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldFrequency)
                .HasMaxLength(255)
                .HasColumnName("fldFrequency");
            entity.Property(e => e.FldFrom)
                .HasColumnType("datetime")
                .HasColumnName("fldFrom");
            entity.Property(e => e.FldGovernment)
                .HasDefaultValue(false)
                .HasColumnName("fldGovernment");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldLeaveWoPay).HasColumnName("fldLeaveWoPay");
            entity.Property(e => e.FldRemarks)
                .HasMaxLength(255)
                .HasColumnName("fldRemarks");
            entity.Property(e => e.FldSalary).HasColumnName("fldSalary");
            entity.Property(e => e.FldSalaryGrade)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldSalaryGrade");
            entity.Property(e => e.FldSgnSi)
                .HasMaxLength(255)
                .HasColumnName("fldSGnSI");
            entity.Property(e => e.FldSrid).HasColumnName("fldSRID");
            entity.Property(e => e.FldStation)
                .HasMaxLength(255)
                .HasColumnName("fldStation");
            entity.Property(e => e.FldStatus)
                .HasMaxLength(255)
                .HasColumnName("fldStatus");
            entity.Property(e => e.FldStepInc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("fldStepInc");
            entity.Property(e => e.FldTo)
                .HasColumnType("datetime")
                .HasColumnName("fldTo");
            entity.Property(e => e.FldToPresent)
                .HasDefaultValue(false)
                .HasColumnName("fldToPresent");
            entity.Property(e => e.Fldtemp1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldtemp1");
            entity.Property(e => e.Fldtemp2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldtemp2");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved)
                .HasDefaultValue(true)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldApprovedAo)
                .HasDefaultValue(true)
                .HasColumnName("fldApprovedAO");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldSkill)
                .HasMaxLength(255)
                .HasColumnName("fldSkill");
        });

        modelBuilder.Entity<Sm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMS");

            entity.Property(e => e.SmsCpno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SMS_CPNo");
            entity.Property(e => e.SmsDte)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SMS_dte");
            entity.Property(e => e.SmsEmpId).HasColumnName("SMS_empID");
            entity.Property(e => e.SmsIdx)
                .ValueGeneratedOnAdd()
                .HasColumnName("SMS_idx");
            entity.Property(e => e.SmsMsg)
                .HasMaxLength(160)
                .IsUnicode(false)
                .HasColumnName("SMS_msg");
            entity.Property(e => e.SmsSent)
                .HasDefaultValue(false)
                .HasColumnName("SMS_sent");
        });

        modelBuilder.Entity<Srremark>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SRRemarks");

            entity.Property(e => e.FldSrremarks)
                .HasMaxLength(255)
                .HasColumnName("fldSRRemarks");
            entity.Property(e => e.Srrid).HasColumnName("SRRID");
        });

        modelBuilder.Entity<Srrequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SRRequests");

            entity.Property(e => e.FldAmount)
                .HasDefaultValue(0.0)
                .HasColumnName("fldAmount");
            entity.Property(e => e.FldApproved)
                .HasDefaultValue(false)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldAsOf)
                .HasMaxLength(50)
                .HasColumnName("fldAsOf");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldEnteredBy)
                .HasMaxLength(255)
                .HasColumnName("fldEnteredBy");
            entity.Property(e => e.FldExempted)
                .HasDefaultValue(false)
                .HasColumnName("fldExempted");
            entity.Property(e => e.FldExemption)
                .HasMaxLength(150)
                .HasColumnName("fldExemption");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldNote)
                .HasMaxLength(150)
                .HasColumnName("fldNote");
            entity.Property(e => e.FldOrno).HasColumnName("fldORNo");
            entity.Property(e => e.FldPosition1)
                .HasMaxLength(150)
                .HasColumnName("fldPosition1");
            entity.Property(e => e.FldPosition2)
                .HasMaxLength(150)
                .HasColumnName("fldPosition2");
            entity.Property(e => e.FldPrepared)
                .HasMaxLength(150)
                .HasColumnName("fldPrepared");
            entity.Property(e => e.FldPrinted)
                .HasDefaultValue(false)
                .HasColumnName("fldPrinted");
            entity.Property(e => e.FldPrintedDate)
                .HasMaxLength(255)
                .HasColumnName("fldPrintedDate");
            entity.Property(e => e.FldReviewed)
                .HasMaxLength(150)
                .HasColumnName("fldReviewed");
            entity.Property(e => e.FldSrdate)
                .HasColumnType("datetime")
                .HasColumnName("fldSRDate");
            entity.Property(e => e.FldSridno).HasColumnName("fldSRIDNo");
            entity.Property(e => e.FldStatus)
                .HasMaxLength(50)
                .HasColumnName("fldStatus");
            entity.Property(e => e.FldToDate)
                .HasDefaultValue(false)
                .HasColumnName("fldToDate");
        });

        modelBuilder.Entity<Srstation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SRStations");

            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldStations)
                .HasMaxLength(255)
                .HasColumnName("fldStations");
        });

        modelBuilder.Entity<Srstatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SRStatus");

            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldStatus)
                .HasMaxLength(255)
                .HasColumnName("fldStatus");
        });

        modelBuilder.Entity<T1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t1");

            entity.Property(e => e.C1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("c1");
            entity.Property(e => e.C2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("c2");
            entity.Property(e => e.C3).HasColumnName("c3");
        });

        modelBuilder.Entity<T2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t2");

            entity.Property(e => e.C1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("c1");
            entity.Property(e => e.C2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("c2");
            entity.Property(e => e.C3).HasColumnName("c3");
        });

        modelBuilder.Entity<TblDocPage>(entity =>
        {
            entity.HasKey(e => e.FldDocPageId);

            entity.ToTable("tblDocPage");

            entity.Property(e => e.FldDocPageId).HasColumnName("fldDocPageID");
            entity.Property(e => e.FldCtrlNo)
                .HasDefaultValue(0L)
                .HasColumnName("fldCtrlNo");
            entity.Property(e => e.FldDocActionId).HasColumnName("fldDocActionID");
            entity.Property(e => e.FldDocDeleted)
                .HasDefaultValue(false)
                .HasColumnName("fldDocDeleted");
            entity.Property(e => e.FldDocId).HasColumnName("fldDocID");
            entity.Property(e => e.FldDocImageExt)
                .HasMaxLength(5)
                .HasColumnName("fldDocImageExt");
            entity.Property(e => e.FldDocPageDescription)
                .HasMaxLength(250)
                .HasColumnName("fldDocPageDescription");
            entity.Property(e => e.FldDocPageImage)
                .HasMaxLength(250)
                .HasColumnName("fldDocPageImage");
            entity.Property(e => e.FldDocPageNo).HasColumnName("fldDocPageNo");
            entity.Property(e => e.FldRespCenter)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldRespCenter");
            entity.Property(e => e.FldType)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldType");
        });

        modelBuilder.Entity<TblSecurityCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSecurityCode");

            entity.Property(e => e.FldPassword)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("fldPassword");
        });

        modelBuilder.Entity<TcpIp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TcpIP");

            entity.Property(e => e.Done)
                .HasDefaultValue(false)
                .HasColumnName("done");
            entity.Property(e => e.DteLogin)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dteLogin");
            entity.Property(e => e.DteLogout)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dteLogout");
            entity.Property(e => e.IpList)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Office)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TempChild>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved).HasColumnName("fldApproved");
            entity.Property(e => e.FldBirthday)
                .HasColumnType("datetime")
                .HasColumnName("fldBirthday");
            entity.Property(e => e.FldChildName)
                .HasMaxLength(50)
                .HasColumnName("fldChildName");
            entity.Property(e => e.FldCtrlNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldCtrlNo");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex).HasColumnName("fldIndex");
        });

        modelBuilder.Entity<TempDistinction>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved).HasColumnName("fldApproved");
            entity.Property(e => e.FldCtrlNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldCtrlNo");
            entity.Property(e => e.FldDistinction)
                .HasMaxLength(255)
                .HasColumnName("fldDistinction");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex).HasColumnName("fldIndex");
        });

        modelBuilder.Entity<TempEligibility>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved).HasColumnName("fldApproved");
            entity.Property(e => e.FldCtrlNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldCtrlNo");
            entity.Property(e => e.FldDateExpire)
                .HasColumnType("datetime")
                .HasColumnName("fldDateExpire");
            entity.Property(e => e.FldDateReleased)
                .HasColumnType("datetime")
                .HasColumnName("fldDateReleased");
            entity.Property(e => e.FldEligibility)
                .HasMaxLength(255)
                .HasColumnName("fldEligibility");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldExamDate)
                .HasColumnType("datetime")
                .HasColumnName("fldExamDate");
            entity.Property(e => e.FldExamPlace)
                .HasMaxLength(255)
                .HasColumnName("fldExamPlace");
            entity.Property(e => e.FldExpiry)
                .HasDefaultValue(false)
                .HasColumnName("fldExpiry");
            entity.Property(e => e.FldIndex).HasColumnName("fldIndex");
            entity.Property(e => e.FldLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldLevel");
            entity.Property(e => e.FldLicenseNo)
                .HasMaxLength(255)
                .HasColumnName("fldLicenseNo");
            entity.Property(e => e.FldRating).HasColumnName("fldRating");
        });

        modelBuilder.Entity<TempEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempEmployee");

            entity.Property(e => e.Fld3DegParticulars)
                .HasMaxLength(255)
                .HasColumnName("fld3DegParticulars");
            entity.Property(e => e.FldAbleDetails)
                .HasMaxLength(255)
                .HasColumnName("fldAbleDetails");
            entity.Property(e => e.FldAdminConvicted).HasColumnName("fldAdminConvicted");
            entity.Property(e => e.FldAdminDetails)
                .HasMaxLength(255)
                .HasColumnName("fldAdminDetails");
            entity.Property(e => e.FldAdminOfficer).HasColumnName("fldAdminOfficer");
            entity.Property(e => e.FldAdministrator).HasColumnName("fldAdministrator");
            entity.Property(e => e.FldAdministrator2).HasColumnName("fldAdministrator2");
            entity.Property(e => e.FldApproved).HasColumnName("fldApproved");
            entity.Property(e => e.FldBarangay)
                .HasMaxLength(255)
                .HasColumnName("fldBarangay");
            entity.Property(e => e.FldBarangayCode)
                .HasMaxLength(255)
                .HasColumnName("fldBarangayCode");
            entity.Property(e => e.FldBirthDate)
                .HasColumnType("datetime")
                .HasColumnName("fldBirthDate");
            entity.Property(e => e.FldBirthPlace)
                .HasMaxLength(255)
                .HasColumnName("fldBirthPlace");
            entity.Property(e => e.FldBloodType)
                .HasMaxLength(255)
                .HasColumnName("fldBloodType");
            entity.Property(e => e.FldByBirth)
                .HasDefaultValue(true)
                .HasColumnName("fldByBirth");
            entity.Property(e => e.FldByNaturalization)
                .HasDefaultValue(false)
                .HasColumnName("fldByNaturalization");
            entity.Property(e => e.FldCandidDetails)
                .HasMaxLength(255)
                .HasColumnName("fldCandidDetails");
            entity.Property(e => e.FldCandidate).HasColumnName("fldCandidate");
            entity.Property(e => e.FldCdegree)
                .HasMaxLength(255)
                .HasColumnName("fldCDegree");
            entity.Property(e => e.FldCdegree1)
                .HasMaxLength(250)
                .HasColumnName("fldCDegree1");
            entity.Property(e => e.FldCdegree2)
                .HasMaxLength(250)
                .HasColumnName("fldCDegree2");
            entity.Property(e => e.FldCellNo)
                .HasMaxLength(255)
                .HasColumnName("fldCellNo");
            entity.Property(e => e.FldCeyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCEYear");
            entity.Property(e => e.FldCeyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCEYear1");
            entity.Property(e => e.FldCeyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCEYear2");
            entity.Property(e => e.FldChonors)
                .HasMaxLength(255)
                .HasColumnName("fldCHonors");
            entity.Property(e => e.FldChonors1)
                .HasMaxLength(250)
                .HasColumnName("fldCHonors1");
            entity.Property(e => e.FldChonors2)
                .HasMaxLength(250)
                .HasColumnName("fldCHonors2");
            entity.Property(e => e.FldCitizenship)
                .HasMaxLength(255)
                .HasColumnName("fldCitizenship");
            entity.Property(e => e.FldCivilStatus)
                .HasMaxLength(50)
                .HasColumnName("fldCivilStatus");
            entity.Property(e => e.FldCollege)
                .HasMaxLength(255)
                .HasColumnName("fldCollege");
            entity.Property(e => e.FldCollege1)
                .HasMaxLength(250)
                .HasColumnName("fldCollege1");
            entity.Property(e => e.FldCollege2)
                .HasMaxLength(250)
                .HasColumnName("fldCollege2");
            entity.Property(e => e.FldCountry)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldCountry");
            entity.Property(e => e.FldCrimeConvicted).HasColumnName("fldCrimeConvicted");
            entity.Property(e => e.FldCrimeDetails)
                .HasMaxLength(255)
                .HasColumnName("fldCrimeDetails");
            entity.Property(e => e.FldCsidno)
                .HasMaxLength(255)
                .HasColumnName("fldCSIDNo");
            entity.Property(e => e.FldCsyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCSYear");
            entity.Property(e => e.FldCsyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCSYear1");
            entity.Property(e => e.FldCsyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCSYear2");
            entity.Property(e => e.FldCtcdate)
                .HasColumnType("datetime")
                .HasColumnName("fldCTCDate");
            entity.Property(e => e.FldCtcname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldCTCName");
            entity.Property(e => e.FldCtcno)
                .HasMaxLength(53)
                .HasColumnName("fldCTCNo");
            entity.Property(e => e.FldCtcplace)
                .HasMaxLength(255)
                .HasColumnName("fldCTCPlace");
            entity.Property(e => e.FldCtrlNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldCtrlNo");
            entity.Property(e => e.FldCunits)
                .HasMaxLength(255)
                .HasColumnName("fldCUnits");
            entity.Property(e => e.FldCunits1)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("fldCUnits1");
            entity.Property(e => e.FldCunits2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldCUnits2");
            entity.Property(e => e.FldCyearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCYearGrad");
            entity.Property(e => e.FldCyearGrad1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCYearGrad1");
            entity.Property(e => e.FldCyearGrad2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldCYearGrad2");
            entity.Property(e => e.FldDegParticulars)
                .HasMaxLength(255)
                .HasColumnName("fldDegParticulars");
            entity.Property(e => e.FldDisabled)
                .HasDefaultValue(false)
                .HasColumnName("fldDisabled");
            entity.Property(e => e.FldDivision)
                .HasMaxLength(255)
                .HasColumnName("fldDivision");
            entity.Property(e => e.FldEdegreee)
                .HasMaxLength(255)
                .HasColumnName("fldEDegreee");
            entity.Property(e => e.FldEdegreee1)
                .HasMaxLength(250)
                .HasColumnName("fldEDegreee1");
            entity.Property(e => e.FldEendYear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldEEndYear");
            entity.Property(e => e.FldEendYear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldEEndYear1");
            entity.Property(e => e.FldEhonors)
                .HasMaxLength(255)
                .HasColumnName("fldEHonors");
            entity.Property(e => e.FldEhonors1)
                .HasMaxLength(250)
                .HasColumnName("fldEHonors1");
            entity.Property(e => e.FldElementary)
                .HasMaxLength(255)
                .HasColumnName("fldElementary");
            entity.Property(e => e.FldElementary1)
                .HasMaxLength(250)
                .HasColumnName("fldElementary1");
            entity.Property(e => e.FldEmailAdd)
                .HasMaxLength(255)
                .HasColumnName("fldEmailAdd");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldEstartYear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldEStartYear");
            entity.Property(e => e.FldEstartYear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldEStartYear1");
            entity.Property(e => e.FldEunits)
                .HasMaxLength(255)
                .HasColumnName("fldEUnits");
            entity.Property(e => e.FldEunits1)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("fldEUnits1");
            entity.Property(e => e.FldEyearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldEYearGrad");
            entity.Property(e => e.FldEyearGrad1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldEYearGrad1");
            entity.Property(e => e.FldFather)
                .HasMaxLength(255)
                .HasColumnName("fldFather");
            entity.Property(e => e.FldFatherFirstname)
                .HasMaxLength(255)
                .HasColumnName("fldFatherFirstname");
            entity.Property(e => e.FldFatherMiddlename)
                .HasMaxLength(255)
                .HasColumnName("fldFatherMiddlename");
            entity.Property(e => e.FldFatherSurname)
                .HasMaxLength(255)
                .HasColumnName("fldFatherSurname");
            entity.Property(e => e.FldFchargeDetails)
                .HasMaxLength(255)
                .HasColumnName("fldFChargeDetails");
            entity.Property(e => e.FldFirstname)
                .HasMaxLength(255)
                .HasColumnName("fldFirstname");
            entity.Property(e => e.FldForceRetire).HasColumnName("fldForceRetire");
            entity.Property(e => e.FldFormallyCharged).HasColumnName("fldFormallyCharged");
            entity.Property(e => e.FldFourthDeg).HasColumnName("fldFourthDeg");
            entity.Property(e => e.FldFrequency)
                .HasMaxLength(50)
                .HasColumnName("fldFrequency");
            entity.Property(e => e.FldGsddegree)
                .HasMaxLength(255)
                .HasColumnName("fldGSDDegree");
            entity.Property(e => e.FldGsddegree1)
                .HasMaxLength(250)
                .HasColumnName("fldGSDDegree1");
            entity.Property(e => e.FldGsddegree2)
                .HasMaxLength(250)
                .HasColumnName("fldGSDDegree2");
            entity.Property(e => e.FldGsdeyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDEYear");
            entity.Property(e => e.FldGsdeyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDEYear1");
            entity.Property(e => e.FldGsdeyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDEYear2");
            entity.Property(e => e.FldGsdhonors)
                .HasMaxLength(255)
                .HasColumnName("fldGSDHonors");
            entity.Property(e => e.FldGsdhonors1)
                .HasMaxLength(250)
                .HasColumnName("fldGSDHonors1");
            entity.Property(e => e.FldGsdhonors2)
                .HasMaxLength(250)
                .HasColumnName("fldGSDHonors2");
            entity.Property(e => e.FldGsdiploma)
                .HasMaxLength(255)
                .HasColumnName("fldGSDiploma");
            entity.Property(e => e.FldGsdiploma1)
                .HasMaxLength(250)
                .HasColumnName("fldGSDiploma1");
            entity.Property(e => e.FldGsdiploma2)
                .HasMaxLength(250)
                .HasColumnName("fldGSDiploma2");
            entity.Property(e => e.FldGsdoctor)
                .HasMaxLength(255)
                .HasColumnName("fldGSDoctor");
            entity.Property(e => e.FldGsdoctor1)
                .HasMaxLength(250)
                .HasColumnName("fldGSDoctor1");
            entity.Property(e => e.FldGsdoctor2)
                .HasMaxLength(250)
                .HasColumnName("fldGSDoctor2");
            entity.Property(e => e.FldGsdsyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDSYear");
            entity.Property(e => e.FldGsdsyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDSYear1");
            entity.Property(e => e.FldGsdsyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDSYear2");
            entity.Property(e => e.FldGsdunits)
                .HasMaxLength(255)
                .HasColumnName("fldGSDUnits");
            entity.Property(e => e.FldGsdunits1)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("fldGSDUnits1");
            entity.Property(e => e.FldGsdunits2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldGSDUnits2");
            entity.Property(e => e.FldGsdyearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDYearGrad");
            entity.Property(e => e.FldGsdyearGrad1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDYearGrad1");
            entity.Property(e => e.FldGsdyearGrad2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSDYearGrad2");
            entity.Property(e => e.FldGsisno)
                .HasMaxLength(255)
                .HasColumnName("fldGSISNo");
            entity.Property(e => e.FldGsmaster)
                .HasMaxLength(255)
                .HasColumnName("fldGSMaster");
            entity.Property(e => e.FldGsmaster1)
                .HasMaxLength(250)
                .HasColumnName("fldGSMaster1");
            entity.Property(e => e.FldGsmaster2)
                .HasMaxLength(250)
                .HasColumnName("fldGSMaster2");
            entity.Property(e => e.FldGsmdegree)
                .HasMaxLength(255)
                .HasColumnName("fldGSMDegree");
            entity.Property(e => e.FldGsmdegree1)
                .HasMaxLength(250)
                .HasColumnName("fldGSMDegree1");
            entity.Property(e => e.FldGsmdegree2)
                .HasMaxLength(250)
                .HasColumnName("fldGSMDegree2");
            entity.Property(e => e.FldGsmeyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMEYear");
            entity.Property(e => e.FldGsmeyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMEYear1");
            entity.Property(e => e.FldGsmeyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMEYear2");
            entity.Property(e => e.FldGsmhonors)
                .HasMaxLength(255)
                .HasColumnName("fldGSMHonors");
            entity.Property(e => e.FldGsmhonors1)
                .HasMaxLength(250)
                .HasColumnName("fldGSMHonors1");
            entity.Property(e => e.FldGsmhonors2)
                .HasMaxLength(250)
                .HasColumnName("fldGSMHonors2");
            entity.Property(e => e.FldGsmsyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMSYear");
            entity.Property(e => e.FldGsmsyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMSYear1");
            entity.Property(e => e.FldGsmsyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMSYear2");
            entity.Property(e => e.FldGsmunits)
                .HasMaxLength(255)
                .HasColumnName("fldGSMUnits");
            entity.Property(e => e.FldGsmunits1)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("fldGSMUnits1");
            entity.Property(e => e.FldGsmunits2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldGSMUnits2");
            entity.Property(e => e.FldGsmyearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMYearGrad");
            entity.Property(e => e.FldGsmyearGrad1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMYearGrad1");
            entity.Property(e => e.FldGsmyearGrad2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSMYearGrad2");
            entity.Property(e => e.FldGsrdegree)
                .HasMaxLength(255)
                .HasColumnName("fldGSRDegree");
            entity.Property(e => e.FldGsrdegree1)
                .HasMaxLength(250)
                .HasColumnName("fldGSRDegree1");
            entity.Property(e => e.FldGsrdegree2)
                .HasMaxLength(250)
                .HasColumnName("fldGSRDegree2");
            entity.Property(e => e.FldGsreyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSREYear");
            entity.Property(e => e.FldGsreyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSREYear1");
            entity.Property(e => e.FldGsreyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSREYear2");
            entity.Property(e => e.FldGsrhonors)
                .HasMaxLength(255)
                .HasColumnName("fldGSRHonors");
            entity.Property(e => e.FldGsrhonors1)
                .HasMaxLength(250)
                .HasColumnName("fldGSRHonors1");
            entity.Property(e => e.FldGsrhonors2)
                .HasMaxLength(250)
                .HasColumnName("fldGSRHonors2");
            entity.Property(e => e.FldGsrmsyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSRMSYear");
            entity.Property(e => e.FldGsrmsyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSRMSYear1");
            entity.Property(e => e.FldGsrmsyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSRMSYear2");
            entity.Property(e => e.FldGsrunits)
                .HasMaxLength(255)
                .HasColumnName("fldGSRUnits");
            entity.Property(e => e.FldGsrunits1)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("fldGSRUnits1");
            entity.Property(e => e.FldGsrunits2)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("fldGSRUnits2");
            entity.Property(e => e.FldGsryearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSRYearGrad");
            entity.Property(e => e.FldGsryearGrad1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSRYearGrad1");
            entity.Property(e => e.FldGsryearGrad2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldGSRYearGrad2");
            entity.Property(e => e.FldHeadChief).HasColumnName("fldHeadChief");
            entity.Property(e => e.FldHeight).HasColumnName("fldHeight");
            entity.Property(e => e.FldIdctr)
                .HasMaxLength(50)
                .HasColumnName("fldIDCtr");
            entity.Property(e => e.FldImmigrant).HasColumnName("fldImmigrant");
            entity.Property(e => e.FldImmigrantDetail)
                .HasMaxLength(255)
                .HasColumnName("fldImmigrantDetail");
            entity.Property(e => e.FldIndigDetails)
                .HasMaxLength(255)
                .HasColumnName("fldIndigDetails");
            entity.Property(e => e.FldIndigMember).HasColumnName("fldIndigMember");
            entity.Property(e => e.FldInitialApp)
                .HasColumnType("datetime")
                .HasColumnName("fldInitialApp");
            entity.Property(e => e.FldLastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("fldLastUpdated");
            entity.Property(e => e.FldLastname)
                .HasMaxLength(255)
                .HasColumnName("fldLastname");
            entity.Property(e => e.FldLatestApp)
                .HasColumnType("datetime")
                .HasColumnName("fldLatestApp");
            entity.Property(e => e.FldLevel)
                .HasMaxLength(5)
                .HasColumnName("fldLevel");
            entity.Property(e => e.FldMiddleName)
                .HasMaxLength(255)
                .HasColumnName("fldMIddleName");
            entity.Property(e => e.FldMother)
                .HasMaxLength(255)
                .HasColumnName("fldMother");
            entity.Property(e => e.FldMotherFirstname)
                .HasMaxLength(255)
                .HasColumnName("fldMotherFirstname");
            entity.Property(e => e.FldMotherMiddlename)
                .HasMaxLength(255)
                .HasColumnName("fldMotherMiddlename");
            entity.Property(e => e.FldMotherSurname)
                .HasMaxLength(255)
                .HasColumnName("fldMotherSurname");
            entity.Property(e => e.FldMunicipality)
                .HasMaxLength(255)
                .HasColumnName("fldMunicipality");
            entity.Property(e => e.FldMunicipalityCode)
                .HasMaxLength(255)
                .HasColumnName("fldMunicipalityCode");
            entity.Property(e => e.FldNameExt)
                .HasMaxLength(255)
                .HasColumnName("fldNameExt");
            entity.Property(e => e.FldOfficeId)
                .HasMaxLength(255)
                .HasColumnName("fldOfficeID");
            entity.Property(e => e.FldOfficePrefix)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fldOfficePrefix");
            entity.Property(e => e.FldOperator)
                .HasMaxLength(255)
                .HasColumnName("fldOperator");
            entity.Property(e => e.FldPabarangay)
                .HasMaxLength(255)
                .HasColumnName("fldPABarangay");
            entity.Property(e => e.FldPagibigId)
                .HasMaxLength(255)
                .HasColumnName("fldPagibigID");
            entity.Property(e => e.FldPamunicipality)
                .HasMaxLength(255)
                .HasColumnName("fldPAMunicipality");
            entity.Property(e => e.FldPaprovince)
                .HasMaxLength(255)
                .HasColumnName("fldPAProvince");
            entity.Property(e => e.FldParentAdd)
                .HasMaxLength(255)
                .HasColumnName("fldParentAdd");
            entity.Property(e => e.FldPasswordHash).HasColumnName("fldPasswordHash");
            entity.Property(e => e.FldPastreet)
                .HasMaxLength(255)
                .HasColumnName("fldPAStreet");
            entity.Property(e => e.FldPatelNo)
                .HasMaxLength(255)
                .HasColumnName("fldPATelNo");
            entity.Property(e => e.FldPazipCode)
                .HasMaxLength(50)
                .HasColumnName("fldPAZipCode");
            entity.Property(e => e.FldPhilHealthNo)
                .HasMaxLength(255)
                .HasColumnName("fldPhilHealthNo");
            entity.Property(e => e.FldPhrmo).HasColumnName("fldPHRMO");
            entity.Property(e => e.FldPosition)
                .HasMaxLength(255)
                .HasColumnName("fldPosition");
            entity.Property(e => e.FldProvince)
                .HasMaxLength(255)
                .HasColumnName("fldProvince");
            entity.Property(e => e.FldReasonDeleted)
                .HasMaxLength(255)
                .HasColumnName("fldReasonDeleted");
            entity.Property(e => e.FldRegistered).HasColumnName("fldRegistered");
            entity.Property(e => e.FldResigned)
                .HasDefaultValue(false)
                .HasColumnName("fldResigned");
            entity.Property(e => e.FldResignedDetail)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fldResignedDetail");
            entity.Property(e => e.FldRetDetails)
                .HasMaxLength(255)
                .HasColumnName("fldRetDetails");
            entity.Property(e => e.FldSalary).HasColumnName("fldSalary");
            entity.Property(e => e.FldSalaryGrade).HasColumnName("fldSalaryGrade");
            entity.Property(e => e.FldSdegree)
                .HasMaxLength(255)
                .HasColumnName("fldSDegree");
            entity.Property(e => e.FldSdegree1)
                .HasMaxLength(250)
                .HasColumnName("fldSDegree1");
            entity.Property(e => e.FldSdegree2)
                .HasMaxLength(250)
                .HasColumnName("fldSDegree2");
            entity.Property(e => e.FldSecondary)
                .HasMaxLength(255)
                .HasColumnName("fldSecondary");
            entity.Property(e => e.FldSecondary1)
                .HasMaxLength(250)
                .HasColumnName("fldSecondary1");
            entity.Property(e => e.FldSecondary2)
                .HasMaxLength(250)
                .HasColumnName("fldSecondary2");
            entity.Property(e => e.FldSecurityStamp).HasColumnName("fldSecurityStamp");
            entity.Property(e => e.FldSex)
                .HasMaxLength(50)
                .HasColumnName("fldSex");
            entity.Property(e => e.FldSeyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSEYear");
            entity.Property(e => e.FldSeyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSEYear1");
            entity.Property(e => e.FldSeyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSEYear2");
            entity.Property(e => e.FldShonors)
                .HasMaxLength(255)
                .HasColumnName("fldSHonors");
            entity.Property(e => e.FldShonors1)
                .HasMaxLength(250)
                .HasColumnName("fldSHonors1");
            entity.Property(e => e.FldShonors2)
                .HasMaxLength(250)
                .HasColumnName("fldSHonors2");
            entity.Property(e => e.FldSoloDetails)
                .HasMaxLength(255)
                .HasColumnName("fldSoloDetails");
            entity.Property(e => e.FldSoloParent).HasColumnName("fldSoloParent");
            entity.Property(e => e.FldSpouseFirstname)
                .HasMaxLength(255)
                .HasColumnName("fldSpouseFirstname");
            entity.Property(e => e.FldSpouseMiddlename)
                .HasMaxLength(255)
                .HasColumnName("fldSpouseMiddlename");
            entity.Property(e => e.FldSpouseName)
                .HasMaxLength(255)
                .HasColumnName("fldSpouseName");
            entity.Property(e => e.FldSpouseOccup)
                .HasMaxLength(255)
                .HasColumnName("fldSpouseOccup");
            entity.Property(e => e.FldSpouseSurname)
                .HasMaxLength(255)
                .HasColumnName("fldSpouseSurname");
            entity.Property(e => e.FldSpsEmp)
                .HasMaxLength(255)
                .HasColumnName("fldSpsEmp");
            entity.Property(e => e.FldSpsEmpAdd)
                .HasMaxLength(255)
                .HasColumnName("fldSpsEmpAdd");
            entity.Property(e => e.FldSpsEmpTel)
                .HasMaxLength(255)
                .HasColumnName("fldSpsEmpTel");
            entity.Property(e => e.FldSssno)
                .HasMaxLength(255)
                .HasColumnName("fldSSSNo");
            entity.Property(e => e.FldSsyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSSYear");
            entity.Property(e => e.FldSsyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSSYear1");
            entity.Property(e => e.FldSsyear2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSSYear2");
            entity.Property(e => e.FldStatus)
                .HasMaxLength(255)
                .HasColumnName("fldStatus");
            entity.Property(e => e.FldStepInc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("fldStepInc");
            entity.Property(e => e.FldStrId)
                .HasMaxLength(255)
                .HasColumnName("fldStrID");
            entity.Property(e => e.FldStreet)
                .HasMaxLength(255)
                .HasColumnName("fldStreet");
            entity.Property(e => e.FldSunits)
                .HasMaxLength(255)
                .HasColumnName("fldSUnits");
            entity.Property(e => e.FldSunits1)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("fldSUnits1");
            entity.Property(e => e.FldSunits2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldSUnits2");
            entity.Property(e => e.FldSyearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSYearGrad");
            entity.Property(e => e.FldSyearGrad1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSYearGrad1");
            entity.Property(e => e.FldSyearGrad2)
                .HasDefaultValue(0.0)
                .HasColumnName("fldSYearGrad2");
            entity.Property(e => e.FldTelNo)
                .HasMaxLength(255)
                .HasColumnName("fldTelNo");
            entity.Property(e => e.FldThirdDeg).HasColumnName("fldThirdDeg");
            entity.Property(e => e.FldTin)
                .HasMaxLength(255)
                .HasColumnName("fldTIN");
            entity.Property(e => e.FldTitle)
                .HasMaxLength(255)
                .HasColumnName("fldTitle");
            entity.Property(e => e.FldTransactionType)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldTransactionType");
            entity.Property(e => e.FldUsername)
                .HasMaxLength(100)
                .HasColumnName("fldUsername");
            entity.Property(e => e.FldVdegree)
                .HasMaxLength(255)
                .HasColumnName("fldVDegree");
            entity.Property(e => e.FldVdegree1)
                .HasMaxLength(250)
                .HasColumnName("fldVDegree1");
            entity.Property(e => e.FldVeyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldVEYear");
            entity.Property(e => e.FldVeyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldVEYear1");
            entity.Property(e => e.FldVhonors)
                .HasMaxLength(255)
                .HasColumnName("fldVHonors");
            entity.Property(e => e.FldVhonors1)
                .HasMaxLength(250)
                .HasColumnName("fldVHonors1");
            entity.Property(e => e.FldVocational)
                .HasMaxLength(255)
                .HasColumnName("fldVocational");
            entity.Property(e => e.FldVocational1)
                .HasMaxLength(250)
                .HasColumnName("fldVocational1");
            entity.Property(e => e.FldVsyear)
                .HasDefaultValue(0.0)
                .HasColumnName("fldVSYear");
            entity.Property(e => e.FldVsyear1)
                .HasDefaultValue(0.0)
                .HasColumnName("fldVSYear1");
            entity.Property(e => e.FldVunits)
                .HasMaxLength(255)
                .HasColumnName("fldVUnits");
            entity.Property(e => e.FldVunits1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldVUnits1");
            entity.Property(e => e.FldVyearGrad)
                .HasDefaultValue(0.0)
                .HasColumnName("fldVYearGrad");
            entity.Property(e => e.FldVyearGrad1).HasColumnName("fldVYearGrad1");
            entity.Property(e => e.FldWeight).HasColumnName("fldWeight");
            entity.Property(e => e.FldZipCode)
                .HasMaxLength(50)
                .HasColumnName("fldZipCode");
            entity.Property(e => e.Photo).HasMaxLength(255);
        });

        modelBuilder.Entity<TempOrganization>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved).HasColumnName("fldApproved");
            entity.Property(e => e.FldCtrlNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldCtrlNo");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex).HasColumnName("fldIndex");
            entity.Property(e => e.FldOrganization)
                .HasMaxLength(255)
                .HasColumnName("fldOrganization");
        });

        modelBuilder.Entity<TempOtherEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempOtherEducation");

            entity.Property(e => e.FldApproved)
                .HasDefaultValue(false)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldDegree)
                .HasMaxLength(255)
                .HasColumnName("fldDegree");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldEndYear).HasColumnName("fldEndYear");
            entity.Property(e => e.FldGraduated).HasColumnName("fldGraduated");
            entity.Property(e => e.FldHonors)
                .HasMaxLength(255)
                .HasColumnName("fldHonors");
            entity.Property(e => e.FldIndex).HasColumnName("fldIndex");
            entity.Property(e => e.FldIndex2)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex2");
            entity.Property(e => e.FldLevel).HasColumnName("fldLevel");
            entity.Property(e => e.FldSchool)
                .HasMaxLength(255)
                .HasColumnName("fldSchool");
            entity.Property(e => e.FldStartYear).HasColumnName("fldStartYear");
            entity.Property(e => e.FldUnits)
                .HasMaxLength(255)
                .HasColumnName("fldUnits");
            entity.Property(e => e.FldYearGrad).HasColumnName("fldYearGrad");
        });

        modelBuilder.Entity<TempOtherInfo>(entity =>
        {
            entity.HasKey(e => e.Index);

            entity.ToTable("TempOtherInfo");

            entity.Property(e => e.Index).HasColumnName("_Index");
            entity.Property(e => e.FldDistinction)
                .IsUnicode(false)
                .HasColumnName("fldDistinction");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex).HasColumnName("fldIndex");
            entity.Property(e => e.FldOrganization)
                .IsUnicode(false)
                .HasColumnName("fldOrganization");
            entity.Property(e => e.FldSkill)
                .IsUnicode(false)
                .HasColumnName("fldSkill");
        });

        modelBuilder.Entity<TempReference>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved).HasColumnName("fldApproved");
            entity.Property(e => e.FldCtrlNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldCtrlNo");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex).HasColumnName("fldIndex");
            entity.Property(e => e.FldOffice)
                .HasMaxLength(255)
                .HasColumnName("fldOffice");
            entity.Property(e => e.FldRefAddress)
                .HasMaxLength(255)
                .HasColumnName("fldRefAddress");
            entity.Property(e => e.FldRefName)
                .HasMaxLength(255)
                .HasColumnName("fldRefName");
            entity.Property(e => e.FldTelNo)
                .HasMaxLength(255)
                .HasColumnName("fldTelNo");
        });

        modelBuilder.Entity<TempServiceRecord>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldBranch)
                .HasMaxLength(255)
                .HasColumnName("fldBranch");
            entity.Property(e => e.FldCause)
                .HasMaxLength(255)
                .HasColumnName("fldCause");
            entity.Property(e => e.FldDateSep)
                .HasMaxLength(255)
                .HasColumnName("fldDateSep");
            entity.Property(e => e.FldDesignation)
                .HasMaxLength(255)
                .HasColumnName("fldDesignation");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldFrequency)
                .HasMaxLength(255)
                .HasColumnName("fldFrequency");
            entity.Property(e => e.FldFrom)
                .HasColumnType("datetime")
                .HasColumnName("fldFrom");
            entity.Property(e => e.FldGovernment).HasColumnName("fldGovernment");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldLeaveWoPay).HasColumnName("fldLeaveWoPay");
            entity.Property(e => e.FldRemarks)
                .HasMaxLength(255)
                .HasColumnName("fldRemarks");
            entity.Property(e => e.FldSalary).HasColumnName("fldSalary");
            entity.Property(e => e.FldSgnSi)
                .HasMaxLength(255)
                .HasColumnName("fldSGnSI");
            entity.Property(e => e.FldSrid).HasColumnName("fldSRID");
            entity.Property(e => e.FldStation)
                .HasMaxLength(255)
                .HasColumnName("fldStation");
            entity.Property(e => e.FldStatus)
                .HasMaxLength(255)
                .HasColumnName("fldStatus");
            entity.Property(e => e.FldTo)
                .HasColumnType("datetime")
                .HasColumnName("fldTo");
        });

        modelBuilder.Entity<TempServiceRecordsConsolidated>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempServiceRecordsConsolidated");

            entity.Property(e => e.FldBranch)
                .HasMaxLength(255)
                .HasColumnName("fldBranch");
            entity.Property(e => e.FldCause)
                .HasMaxLength(255)
                .HasColumnName("fldCause");
            entity.Property(e => e.FldDateSep)
                .HasMaxLength(255)
                .HasColumnName("fldDateSep");
            entity.Property(e => e.FldDesignation)
                .HasMaxLength(255)
                .HasColumnName("fldDesignation");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldFirstname)
                .HasMaxLength(250)
                .HasColumnName("fldFirstname");
            entity.Property(e => e.FldFrequency)
                .HasMaxLength(255)
                .HasColumnName("fldFrequency");
            entity.Property(e => e.FldFrom)
                .HasColumnType("datetime")
                .HasColumnName("fldFrom");
            entity.Property(e => e.FldGovernment)
                .HasDefaultValue(true)
                .HasColumnName("fldGovernment");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldLastname)
                .HasMaxLength(250)
                .HasColumnName("fldLastname");
            entity.Property(e => e.FldLeaveWoPay).HasColumnName("fldLeaveWoPay");
            entity.Property(e => e.FldMiddlename)
                .HasMaxLength(250)
                .HasColumnName("fldMiddlename");
            entity.Property(e => e.FldRemarks)
                .HasMaxLength(255)
                .HasColumnName("fldRemarks");
            entity.Property(e => e.FldSalary).HasColumnName("fldSalary");
            entity.Property(e => e.FldSgnSi)
                .HasMaxLength(255)
                .HasColumnName("fldSGnSI");
            entity.Property(e => e.FldSrid).HasColumnName("fldSRID");
            entity.Property(e => e.FldStation)
                .HasMaxLength(255)
                .HasColumnName("fldStation");
            entity.Property(e => e.FldStatus)
                .HasMaxLength(255)
                .HasColumnName("fldStatus");
            entity.Property(e => e.FldTo)
                .HasColumnType("datetime")
                .HasColumnName("fldTo");
        });

        modelBuilder.Entity<TempSkill>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved).HasColumnName("fldApproved");
            entity.Property(e => e.FldCtrlNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldCtrlNo");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldIndex).HasColumnName("fldIndex");
            entity.Property(e => e.FldSkill)
                .HasMaxLength(255)
                .HasColumnName("fldSkill");
        });

        modelBuilder.Entity<TempTraining>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved).HasColumnName("fldApproved");
            entity.Property(e => e.FldCtrlNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldCtrlNo");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldFrom)
                .HasColumnType("datetime")
                .HasColumnName("fldFrom");
            entity.Property(e => e.FldHost)
                .HasMaxLength(255)
                .HasColumnName("fldHost");
            entity.Property(e => e.FldHours).HasColumnName("fldHours");
            entity.Property(e => e.FldIndex).HasColumnName("fldIndex");
            entity.Property(e => e.FldTo)
                .HasColumnType("datetime")
                .HasColumnName("fldTo");
            entity.Property(e => e.FldTraining)
                .HasMaxLength(255)
                .HasColumnName("fldTraining");
            entity.Property(e => e.FldType)
                .HasMaxLength(70)
                .HasColumnName("fldType");
        });

        modelBuilder.Entity<TempVoluntaryWork>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved).HasColumnName("fldApproved");
            entity.Property(e => e.FldCtrlNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldCtrlNo");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldFrom)
                .HasColumnType("datetime")
                .HasColumnName("fldFrom");
            entity.Property(e => e.FldHours).HasColumnName("fldHours");
            entity.Property(e => e.FldIndex).HasColumnName("fldIndex");
            entity.Property(e => e.FldOrgNameAdress)
                .HasMaxLength(255)
                .HasColumnName("fldOrgNameAdress");
            entity.Property(e => e.FldPosition)
                .HasMaxLength(255)
                .HasColumnName("fldPosition");
            entity.Property(e => e.FldTo)
                .HasColumnType("datetime")
                .HasColumnName("fldTo");
        });

        modelBuilder.Entity<Training>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved)
                .HasDefaultValue(true)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldApprovedAo)
                .HasDefaultValue(true)
                .HasColumnName("fldApprovedAO");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldFrom)
                .HasColumnType("datetime")
                .HasColumnName("fldFrom");
            entity.Property(e => e.FldHidden)
                .HasDefaultValue(false)
                .HasColumnName("fldHidden");
            entity.Property(e => e.FldHost)
                .HasMaxLength(255)
                .HasColumnName("fldHost");
            entity.Property(e => e.FldHours).HasColumnName("fldHours");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldTo)
                .HasColumnType("datetime")
                .HasColumnName("fldTo");
            entity.Property(e => e.FldTraining)
                .HasMaxLength(255)
                .HasColumnName("fldTraining");
            entity.Property(e => e.FldType)
                .HasMaxLength(70)
                .HasColumnName("fldType");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.UserFirstName).HasMaxLength(255);
            entity.Property(e => e.UserLastName).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(255);
        });

        modelBuilder.Entity<VoluntaryWork>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FldApproved)
                .HasDefaultValue(true)
                .HasColumnName("fldApproved");
            entity.Property(e => e.FldApprovedAo)
                .HasDefaultValue(true)
                .HasColumnName("fldApprovedAO");
            entity.Property(e => e.FldEmpId).HasColumnName("fldEmpID");
            entity.Property(e => e.FldFrom)
                .HasColumnType("datetime")
                .HasColumnName("fldFrom");
            entity.Property(e => e.FldHours).HasColumnName("fldHours");
            entity.Property(e => e.FldIndex)
                .ValueGeneratedOnAdd()
                .HasColumnName("fldIndex");
            entity.Property(e => e.FldOrgNameAdress)
                .HasMaxLength(255)
                .HasColumnName("fldOrgNameAdress");
            entity.Property(e => e.FldPosition)
                .HasMaxLength(255)
                .HasColumnName("fldPosition");
            entity.Property(e => e.FldTo)
                .HasColumnType("datetime")
                .HasColumnName("fldTo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

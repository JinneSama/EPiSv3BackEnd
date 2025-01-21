using System;
using System.Collections.Generic;
using EPiSv3NetworkFolder.DbModels.OFMIS;
using Microsoft.EntityFrameworkCore;
using Action = EPiSv3NetworkFolder.DbModels.OFMIS.Action;
using File = EPiSv3NetworkFolder.DbModels.OFMIS.File;

namespace EPiSv3NetworkFolder.Context;

public partial class OFMISContext : DbContext
{
    public OFMISContext()
    {
    }

    public OFMISContext(DbContextOptions<OFMISContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DbModels.OFMIS.Action> Actions { get; set; }

    public virtual DbSet<ActionTaken> ActionTakens { get; set; }

    public virtual DbSet<Airdetail> Airdetails { get; set; }

    public virtual DbSet<Aireport> Aireports { get; set; }

    public virtual DbSet<Allotment> Allotments { get; set; }

    public virtual DbSet<AllotmentLetter> AllotmentLetters { get; set; }

    public virtual DbSet<Aoq> Aoqs { get; set; }

    public virtual DbSet<Aoqdetail> Aoqdetails { get; set; }

    public virtual DbSet<Appropriation> Appropriations { get; set; }

    public virtual DbSet<Apr> Aprs { get; set; }

    public virtual DbSet<Aprdetail> Aprdetails { get; set; }

    public virtual DbSet<Bacmember> Bacmembers { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<ColumnTitle> ColumnTitles { get; set; }

    public virtual DbSet<ComputerSupply> ComputerSupplies { get; set; }

    public virtual DbSet<Contribution> Contributions { get; set; }

    public virtual DbSet<ControlNumber> ControlNumbers { get; set; }

    public virtual DbSet<DefaultAccount> DefaultAccounts { get; set; }

    public virtual DbSet<DefaultSetting> DefaultSettings { get; set; }

    public virtual DbSet<DocumentAction> DocumentActions { get; set; }

    public virtual DbSet<Dvparticular> Dvparticulars { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeStatus> EmployeeStatuses { get; set; }

    public virtual DbSet<File> Files { get; set; }

    public virtual DbSet<Function> Functions { get; set; }

    public virtual DbSet<FundType> FundTypes { get; set; }

    public virtual DbSet<GasSlip> GasSlips { get; set; }

    public virtual DbSet<HazardPercentage> HazardPercentages { get; set; }

    public virtual DbSet<Ic> Ics { get; set; }

    public virtual DbSet<Icsdetail> Icsdetails { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItenaryDetail> ItenaryDetails { get; set; }

    public virtual DbSet<ItenaryofTravel> ItenaryofTravels { get; set; }

    public virtual DbSet<Jim> Jims { get; set; }

    public virtual DbSet<LbacOffice> LbacOffices { get; set; }

    public virtual DbSet<LbacSetting> LbacSettings { get; set; }

    public virtual DbSet<LbacUserRole> LbacUserRoles { get; set; }

    public virtual DbSet<Letter> Letters { get; set; }

    public virtual DbSet<Liquidation> Liquidations { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Lrdetail> Lrdetails { get; set; }

    public virtual DbSet<NewUserFromHrmi> NewUserFromHrmis { get; set; }

    public virtual DbSet<NutObr> NutObrs { get; set; }

    public virtual DbSet<Obligation> Obligations { get; set; }

    public virtual DbSet<ObligationsDv> ObligationsDvs { get; set; }

    public virtual DbSet<ObligationsDvadditional> ObligationsDvadditionals { get; set; }

    public virtual DbSet<Office> Offices { get; set; }

    public virtual DbSet<OnlineUser> OnlineUsers { get; set; }

    public virtual DbSet<Ordetail> Ordetails { get; set; }

    public virtual DbSet<Par> Pars { get; set; }

    public virtual DbSet<Pardetail> Pardetails { get; set; }

    public virtual DbSet<Payee> Payees { get; set; }

    public virtual DbSet<Payroll> Payrolls { get; set; }

    public virtual DbSet<PayrollDetail> PayrollDetails { get; set; }

    public virtual DbSet<PayrollDifferential> PayrollDifferentials { get; set; }

    public virtual DbSet<PayrollDifferentialDetail> PayrollDifferentialDetails { get; set; }

    public virtual DbSet<PayrollHazard> PayrollHazards { get; set; }

    public virtual DbSet<PayrollHazardDetail> PayrollHazardDetails { get; set; }

    public virtual DbSet<PayrollOt> PayrollOts { get; set; }

    public virtual DbSet<PayrollOtdetail> PayrollOtdetails { get; set; }

    public virtual DbSet<PayrollSpe> PayrollSpes { get; set; }

    public virtual DbSet<PayrollSpesdetail> PayrollSpesdetails { get; set; }

    public virtual DbSet<PayrollWage> PayrollWages { get; set; }

    public virtual DbSet<PayrollWageDetail> PayrollWageDetails { get; set; }

    public virtual DbSet<PayrollWagesPermanent> PayrollWagesPermanents { get; set; }

    public virtual DbSet<PayrollWagesPermanentDetail> PayrollWagesPermanentDetails { get; set; }

    public virtual DbSet<PayrollWagesPermanentDetailsEnd> PayrollWagesPermanentDetailsEnds { get; set; }

    public virtual DbSet<PayrollWagesPermanentEnd> PayrollWagesPermanentEnds { get; set; }

    public virtual DbSet<Pi> Pis { get; set; }

    public virtual DbSet<Pisdetail> Pisdetails { get; set; }

    public virtual DbSet<Podetail> Podetails { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Pqdetail> Pqdetails { get; set; }

    public virtual DbSet<Prdetail> Prdetails { get; set; }

    public virtual DbSet<PriceQuotation> PriceQuotations { get; set; }

    public virtual DbSet<ProjectApproAllotment> ProjectApproAllotments { get; set; }

    public virtual DbSet<ProjectApproRealignment> ProjectApproRealignments { get; set; }

    public virtual DbSet<ProjectName> ProjectNames { get; set; }

    public virtual DbSet<ProjectNameApp> ProjectNameApps { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }

    public virtual DbSet<PurchaseRequest> PurchaseRequests { get; set; }

    public virtual DbSet<ReAlignment> ReAlignments { get; set; }

    public virtual DbSet<Risdetail> Risdetails { get; set; }

    public virtual DbSet<Risheader> Risheaders { get; set; }

    public virtual DbSet<SalarySchedule> SalarySchedules { get; set; }

    public virtual DbSet<Signatory> Signatories { get; set; }

    public virtual DbSet<Spespercentage> Spespercentages { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<TblYear> TblYears { get; set; }

    public virtual DbSet<Template> Templates { get; set; }

    public virtual DbSet<Town> Towns { get; set; }

    public virtual DbSet<TrashBin> TrashBins { get; set; }

    public virtual DbSet<TripTicket> TripTickets { get; set; }

    public virtual DbSet<TripTicketPassenger> TripTicketPassengers { get; set; }

    public virtual DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserClaim> UserClaims { get; set; }

    public virtual DbSet<UserLogin> UserLogins { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserWithRole> UserWithRoles { get; set; }

    public virtual DbSet<VehicleDetail> VehicleDetails { get; set; }

    public virtual DbSet<VlEmployee> VlEmployees { get; set; }

    public virtual DbSet<VlObr> VlObrs { get; set; }

    public virtual DbSet<VlYear> VlYears { get; set; }

    public virtual DbSet<WasteCategory> WasteCategories { get; set; }

    public virtual DbSet<WasteMaterial> WasteMaterials { get; set; }

    public virtual DbSet<WasteMaterialDetail> WasteMaterialDetails { get; set; }

    public virtual DbSet<Year> Years { get; set; }

    public virtual DbSet<_1> _1s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=172.17.16.14;Database=OFMIS;User Id=sa;Password=Welcome99;MultipleActiveResultSets=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Action>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Actions_1");

            entity.Property(e => e.Category).HasMaxLength(50);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_Actions_Actions");
        });

        modelBuilder.Entity<ActionTaken>(entity =>
        {
            entity.Property(e => e.ActionTaken1)
                .HasMaxLength(128)
                .HasColumnName("ActionTaken");
            entity.Property(e => e.TableName).HasMaxLength(128);
        });

        modelBuilder.Entity<Airdetail>(entity =>
        {
            entity.ToTable("AIRDetails");

            entity.Property(e => e.AireportId).HasColumnName("AIReportId");
            entity.Property(e => e.Category).HasMaxLength(256);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.Uom)
                .HasMaxLength(128)
                .HasColumnName("UOM");

            entity.HasOne(d => d.Aireport).WithMany(p => p.Airdetails)
                .HasForeignKey(d => d.AireportId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AIRDetails_AIReports");
        });

        modelBuilder.Entity<Aireport>(entity =>
        {
            entity.ToTable("AIReports");

            entity.Property(e => e.Airdate).HasColumnName("AIRDate");
            entity.Property(e => e.Airno)
                .HasMaxLength(128)
                .HasColumnName("AIRNo");
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.InvoiceDate).HasMaxLength(1028);
            entity.Property(e => e.InvoiceDateStr).HasMaxLength(128);
            entity.Property(e => e.InvoiceNo).HasMaxLength(528);
            entity.Property(e => e.Pgsofficer).HasColumnName("PGSOfficer");
            entity.Property(e => e.PgsofficerPosition).HasColumnName("PGSOfficerPosition");
            entity.Property(e => e.Podate)
                .HasMaxLength(128)
                .HasColumnName("PODate");
            entity.Property(e => e.PodateStr)
                .HasMaxLength(128)
                .HasColumnName("PODateStr");
            entity.Property(e => e.Poid).HasColumnName("POId");
            entity.Property(e => e.Pono)
                .HasMaxLength(128)
                .HasColumnName("PONo");
            entity.Property(e => e.PreparedBy).HasMaxLength(128);
            entity.Property(e => e.Prid).HasColumnName("PRId");
            entity.Property(e => e.Risdate).HasColumnName("RISDate");
            entity.Property(e => e.Risno).HasColumnName("RISNo");

            entity.HasOne(d => d.PreparedByNavigation).WithMany(p => p.Aireports)
                .HasForeignKey(d => d.PreparedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_AIReports_Users");

            entity.HasOne(d => d.Pr).WithMany(p => p.Aireports)
                .HasForeignKey(d => d.Prid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_AIReports_PurchaseRequests");
        });

        modelBuilder.Entity<Allotment>(entity =>
        {
            entity.Property(e => e.AllotmentAmount).HasColumnType("money");
            entity.Property(e => e.CreatedB).HasMaxLength(128);

            entity.HasOne(d => d.Appropriation).WithMany(p => p.Allotments)
                .HasForeignKey(d => d.AppropriationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Allotments_Appropriations");
        });

        modelBuilder.Entity<AllotmentLetter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Letters");

            entity.ToTable("AllotmentLetter");

            entity.Property(e => e.HeadofDivisionPos).HasColumnName("HeadofDivisionPOS");
            entity.Property(e => e.Pbo).HasColumnName("PBO");
            entity.Property(e => e.Pbopos).HasColumnName("PBOPos");
            entity.Property(e => e.Prid).HasColumnName("PRId");

            entity.HasOne(d => d.Appropriation).WithMany(p => p.AllotmentLetters)
                .HasForeignKey(d => d.AppropriationId)
                .HasConstraintName("FK_AllotmentLetter_Appropriations");

            entity.HasOne(d => d.Pr).WithMany(p => p.AllotmentLetters)
                .HasForeignKey(d => d.Prid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AllotmentLetter_PurchaseRequests");
        });

        modelBuilder.Entity<Aoq>(entity =>
        {
            entity.ToTable("AOQ");

            entity.Property(e => e.Abc)
                .HasColumnType("money")
                .HasColumnName("ABC");
            entity.Property(e => e.Bacchairperson).HasColumnName("BACChairperson");
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.CreatedById).HasMaxLength(128);
            entity.Property(e => e.Prid).HasColumnName("PRId");
            entity.Property(e => e.Rfqno).HasColumnName("RFQNo");

            entity.HasOne(d => d.BacchairpersonNavigation).WithMany(p => p.Aoqs)
                .HasForeignKey(d => d.Bacchairperson)
                .HasConstraintName("FK_AOQ_Signatories");

            entity.HasOne(d => d.Office).WithMany(p => p.Aoqs)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AOQ_Offices");

            entity.HasOne(d => d.Pr).WithMany(p => p.Aoqs)
                .HasForeignKey(d => d.Prid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AOQ_PurchaseRequests");

            entity.HasMany(d => d.Bacs).WithMany(p => p.AoqsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "BacinAoq",
                    r => r.HasOne<Signatory>().WithMany()
                        .HasForeignKey("Bacid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_BACInAOQ_Signatories"),
                    l => l.HasOne<Aoq>().WithMany()
                        .HasForeignKey("Aoqid")
                        .HasConstraintName("FK_BACInAOQ_AOQ"),
                    j =>
                    {
                        j.HasKey("Aoqid", "Bacid");
                        j.ToTable("BACInAOQ");
                        j.IndexerProperty<int>("Aoqid").HasColumnName("AOQId");
                        j.IndexerProperty<int>("Bacid").HasColumnName("BACId");
                    });
        });

        modelBuilder.Entity<Aoqdetail>(entity =>
        {
            entity.ToTable("AOQDetails");

            entity.Property(e => e.Aoqid).HasColumnName("AOQId");
            entity.Property(e => e.Category).HasMaxLength(256);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedById).HasMaxLength(255);
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.Uom)
                .HasMaxLength(128)
                .HasColumnName("UOM");

            entity.HasOne(d => d.Aoq).WithMany(p => p.Aoqdetails)
                .HasForeignKey(d => d.Aoqid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AOQDetails_AOQ");
        });

        modelBuilder.Entity<Appropriation>(entity =>
        {
            entity.Property(e => e.AccountCode).HasMaxLength(128);
            entity.Property(e => e.AccountCodeText).HasMaxLength(128);
            entity.Property(e => e.AccountName).HasMaxLength(128);
            entity.Property(e => e.Appropriation1)
                .HasColumnType("money")
                .HasColumnName("Appropriation");
            entity.Property(e => e.Createdby).HasMaxLength(128);
            entity.Property(e => e.Ft)
                .HasMaxLength(10)
                .HasColumnName("FT");
            entity.Property(e => e.FundType).HasMaxLength(50);

            entity.HasOne(d => d.FundTypeNavigation).WithMany(p => p.Appropriations)
                .HasForeignKey(d => d.FundTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Appropriations_FundTypes");
        });

        modelBuilder.Entity<Apr>(entity =>
        {
            entity.ToTable("APRs");

            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);
            entity.Property(e => e.Pgsoid).HasColumnName("PGSOId");
            entity.Property(e => e.Prid).HasColumnName("PRId");

            entity.HasOne(d => d.Pr).WithMany(p => p.Aprs)
                .HasForeignKey(d => d.Prid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_APRs_PurchaseRequests");
        });

        modelBuilder.Entity<Aprdetail>(entity =>
        {
            entity.ToTable("APRDetails");

            entity.Property(e => e.Aprid).HasColumnName("APRId");
            entity.Property(e => e.Category).HasMaxLength(256);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.Uom)
                .HasMaxLength(128)
                .HasColumnName("UOM");

            entity.HasOne(d => d.Apr).WithMany(p => p.Aprdetails)
                .HasForeignKey(d => d.Aprid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_APRDetails_APRs");
        });

        modelBuilder.Entity<Bacmember>(entity =>
        {
            entity.ToTable("BACMembers");

            entity.Property(e => e.FirstName).HasMaxLength(128);
            entity.Property(e => e.LastName).HasMaxLength(128);
            entity.Property(e => e.MiddleName).HasMaxLength(128);
            entity.Property(e => e.OffcAcr).HasMaxLength(128);
            entity.Property(e => e.OfficeName).HasMaxLength(128);
            entity.Property(e => e.Position).HasMaxLength(128);

            entity.HasOne(d => d.Employee).WithMany(p => p.Bacmembers)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_BACMembers_Employees");

            entity.HasOne(d => d.Office).WithMany(p => p.Bacmembers)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_BACMembers_Offices");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Category1)
                .HasMaxLength(128)
                .HasColumnName("Category");
        });

        modelBuilder.Entity<ColumnTitle>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AccountType).HasMaxLength(20);
        });

        modelBuilder.Entity<ComputerSupply>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("computer supplies");

            entity.Property(e => e.Category).HasMaxLength(128);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Item).HasMaxLength(255);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.Qty)
                .HasColumnType("money")
                .HasColumnName("QTY");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("UOM");
        });

        modelBuilder.Entity<Contribution>(entity =>
        {
            entity.Property(e => e.ContributionTo).HasMaxLength(125);
            entity.Property(e => e.DPsgs).HasColumnName("dPSGS");
            entity.Property(e => e.MonthlyPremiumMax).HasColumnType("money");
            entity.Property(e => e.MontlyPremiumMin).HasColumnType("money");
            entity.Property(e => e.SalBasic).HasColumnType("money");
            entity.Property(e => e.SalBasic1).HasColumnType("money");
            entity.Property(e => e.SalBasic2).HasColumnType("money");
            entity.Property(e => e.SalBasic3).HasColumnType("money");
            entity.Property(e => e.Status)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.XPercent)
                .HasColumnType("money")
                .HasColumnName("xPercent");
            entity.Property(e => e.Xdays)
                .HasColumnType("money")
                .HasColumnName("xdays");
        });

        modelBuilder.Entity<ControlNumber>(entity =>
        {
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.TableName).HasMaxLength(128);

            entity.HasOne(d => d.Office).WithMany(p => p.ControlNumbers)
                .HasForeignKey(d => d.OfficeId)
                .HasConstraintName("FK_ControlNumbers_Offices");
        });

        modelBuilder.Entity<DefaultAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Accounts");

            entity.Property(e => e.AccountCode).HasMaxLength(128);
            entity.Property(e => e.AccountCodeText).HasMaxLength(128);
            entity.Property(e => e.Ft)
                .HasMaxLength(20)
                .HasColumnName("FT");
            entity.Property(e => e.FundType).HasMaxLength(128);

            entity.HasOne(d => d.FundTypeNavigation).WithMany(p => p.DefaultAccounts)
                .HasForeignKey(d => d.FundTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_DefaultAccounts_FundTypes");
        });

        modelBuilder.Entity<DocumentAction>(entity =>
        {
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.Description).HasComputedColumnSql("([dbo].[sp_get_description]([Id]))", false);
            entity.Property(e => e.EndorsedTo).HasMaxLength(128);
            entity.Property(e => e.IsDone).HasColumnName("isDone");
            entity.Property(e => e.IsSaved).HasColumnName("isSaved");
            entity.Property(e => e.ObRPrNo)
                .HasMaxLength(128)
                .HasColumnName("ObR_PR_No");
            entity.Property(e => e.Status).HasMaxLength(128);
            entity.Property(e => e.TableName).HasMaxLength(128);
            entity.Property(e => e.Year).HasComputedColumnSql("([dbo].[sp_get_year]([Id]))", false);

            entity.HasOne(d => d.Action).WithMany(p => p.InverseAction)
                .HasForeignKey(d => d.ActionId)
                .HasConstraintName("FK_DocumentActions_DocumentActions1");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.DocumentActions)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_DocumentActions_Users");

            entity.HasOne(d => d.RoutedToOffice).WithMany(p => p.DocumentActions)
                .HasForeignKey(d => d.RoutedToOfficeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_DocumentActions_Offices");

            entity.HasMany(d => d.Users).WithMany(p => p.DocActs)
                .UsingEntity<Dictionary<string, object>>(
                    "UsersInDocumentAction",
                    r => r.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_UsersInDocumentActions_Users"),
                    l => l.HasOne<DocumentAction>().WithMany()
                        .HasForeignKey("DocActId")
                        .HasConstraintName("FK_UsersInDocumentActions_DocumentActions"),
                    j =>
                    {
                        j.HasKey("DocActId", "UserId").HasName("PK_UsersInDocumentActions_1");
                        j.ToTable("UsersInDocumentActions");
                        j.IndexerProperty<string>("UserId").HasMaxLength(128);
                    });
        });

        modelBuilder.Entity<Dvparticular>(entity =>
        {
            entity.ToTable("DVParticulars");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Category).HasMaxLength(128);
            entity.Property(e => e.Dnumber)
                .HasColumnType("money")
                .HasColumnName("DNumber");
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.Xnumber)
                .HasColumnType("money")
                .HasColumnName("XNumber");
            entity.Property(e => e.Xpercent)
                .HasColumnType("money")
                .HasColumnName("XPercent");
            entity.Property(e => e.Xpercent1)
                .HasColumnType("money")
                .HasColumnName("XPercent1");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.DailySalary).HasColumnType("money");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(386)
                .HasComputedColumnSql("(concat([FirstName],' ',[MiddleName],' ',[LastName]))", true);
            entity.Property(e => e.EmployeeNameByLastName)
                .HasMaxLength(387)
                .HasComputedColumnSql("(concat([LastName],', ',[FirstName],' ',[MiddleName]))", true);
            entity.Property(e => e.ExtName).HasMaxLength(5);
            entity.Property(e => e.FirstName).HasMaxLength(128);
            entity.Property(e => e.Gsis)
                .HasMaxLength(20)
                .HasColumnName("GSIS");
            entity.Property(e => e.LastName).HasMaxLength(128);
            entity.Property(e => e.Lbpaccount)
                .HasMaxLength(128)
                .HasColumnName("LBPAccount");
            entity.Property(e => e.MiddleName).HasMaxLength(128);
            entity.Property(e => e.MonthlySalary).HasColumnType("money");
            entity.Property(e => e.Note).HasMaxLength(128);
            entity.Property(e => e.OffcAcr).HasMaxLength(128);
            entity.Property(e => e.OfficeName).HasMaxLength(128);
            entity.Property(e => e.PagIbig).HasMaxLength(128);
            entity.Property(e => e.PhilHealth).HasMaxLength(128);
            entity.Property(e => e.Position).HasMaxLength(128);
            entity.Property(e => e.SalaryGrade).HasMaxLength(20);
            entity.Property(e => e.Salutation).HasMaxLength(20);
            entity.Property(e => e.Sg)
                .HasMaxLength(20)
                .HasColumnName("SG");
            entity.Property(e => e.Sss)
                .HasMaxLength(128)
                .HasColumnName("SSS");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Steps).HasMaxLength(20);
            entity.Property(e => e.Tin)
                .HasMaxLength(128)
                .HasColumnName("TIN");

            entity.HasOne(d => d.Office).WithMany(p => p.Employees)
                .HasForeignKey(d => d.OfficeId)
                .HasConstraintName("FK_Employees_Offices");

            entity.HasMany(d => d.Payees).WithMany(p => p.Employees)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeesInPayee",
                    r => r.HasOne<Payee>().WithMany()
                        .HasForeignKey("PayeeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeesInPayee_Payees"),
                    l => l.HasOne<Employee>().WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeesInPayee_Employees"),
                    j =>
                    {
                        j.HasKey("EmployeeId", "PayeeId");
                        j.ToTable("EmployeesInPayee");
                    });
        });

        modelBuilder.Entity<EmployeeStatus>(entity =>
        {
            entity.ToTable("EmployeeStatus");

            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<File>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.OriginalFileName).HasMaxLength(255);
            entity.Property(e => e.Path).HasMaxLength(50);
            entity.Property(e => e.RootFolder).HasMaxLength(50);
            entity.Property(e => e.TableName).HasMaxLength(50);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Files)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_Files_Users");
        });

        modelBuilder.Entity<Function>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Actions");

            entity.Property(e => e.Action).HasMaxLength(255);

            entity.HasMany(d => d.Roles).WithMany(p => p.Functions)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRolesInFunction",
                    r => r.HasOne<UserRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserRolesInFunctions_UserRoles"),
                    l => l.HasOne<Function>().WithMany()
                        .HasForeignKey("FunctionId")
                        .HasConstraintName("FK_UserRolesInFunctions_Functions"),
                    j =>
                    {
                        j.HasKey("FunctionId", "RoleId");
                        j.ToTable("UserRolesInFunctions");
                        j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                    });
        });

        modelBuilder.Entity<FundType>(entity =>
        {
            entity.Property(e => e.FundType1)
                .HasMaxLength(50)
                .HasColumnName("FundType");
        });

        modelBuilder.Entity<GasSlip>(entity =>
        {
            entity.ToTable("GasSlip");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Charge).HasMaxLength(128);
            entity.Property(e => e.Chief).HasMaxLength(150);
            entity.Property(e => e.ChiefPos).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateOfOperation).HasMaxLength(150);
            entity.Property(e => e.Diesel).HasMaxLength(50);
            entity.Property(e => e.Discount).HasMaxLength(50);
            entity.Property(e => e.Equipment).HasMaxLength(250);
            entity.Property(e => e.Ft)
                .HasMaxLength(50)
                .HasColumnName("FT");
            entity.Property(e => e.Inspector).HasMaxLength(150);
            entity.Property(e => e.InspectorPos).HasMaxLength(150);
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(250);
            entity.Property(e => e.Oil).HasMaxLength(50);
            entity.Property(e => e.Others).HasMaxLength(50);
            entity.Property(e => e.Premium).HasMaxLength(50);
            entity.Property(e => e.PriceOthers).HasMaxLength(50);
            entity.Property(e => e.PricePerLiterDiesel).HasMaxLength(50);
            entity.Property(e => e.PricePerLiterOil).HasMaxLength(50);
            entity.Property(e => e.PricePerLiterPremium).HasMaxLength(50);
            entity.Property(e => e.PricePerLiterRegular).HasMaxLength(50);
            entity.Property(e => e.Regular).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Total).HasMaxLength(50);
            entity.Property(e => e.TotalPriceDiesel).HasMaxLength(50);
            entity.Property(e => e.TotalPriceOil).HasMaxLength(50);
            entity.Property(e => e.TotalPriceOthers).HasMaxLength(50);
            entity.Property(e => e.TotalPricePremium).HasMaxLength(50);
            entity.Property(e => e.TotalPriceRegular).HasMaxLength(50);

            entity.HasOne(d => d.PlateNoNavigation).WithMany(p => p.GasSlips)
                .HasForeignKey(d => d.PlateNo)
                .HasConstraintName("FK_GasSlip_VehicleDetails");

            entity.HasOne(d => d.ToPayeesNavigation).WithMany(p => p.GasSlips)
                .HasForeignKey(d => d.ToPayees)
                .HasConstraintName("FK_GasSlip_Payees");

            entity.HasOne(d => d.TripTicket).WithMany(p => p.GasSlips)
                .HasForeignKey(d => d.TripTicketId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_GasSlip_TripTicket");
        });

        modelBuilder.Entity<HazardPercentage>(entity =>
        {
            entity.ToTable("HazardPercentage");

            entity.Property(e => e.HazardFor).HasMaxLength(50);
            entity.Property(e => e.HazardPayPercent).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Ic>(entity =>
        {
            entity.ToTable("ICS");

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.Pgso).HasColumnName("PGSO");
            entity.Property(e => e.Pgsopos).HasColumnName("PGSOPos");
            entity.Property(e => e.Prid).HasColumnName("PRId");

            entity.HasOne(d => d.Pr).WithMany(p => p.Ics)
                .HasForeignKey(d => d.Prid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ICS_PurchaseRequests");
        });

        modelBuilder.Entity<Icsdetail>(entity =>
        {
            entity.ToTable("ICSDetails");

            entity.Property(e => e.Category).HasMaxLength(256);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Icsid).HasColumnName("ICSId");
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.Uom)
                .HasMaxLength(128)
                .HasColumnName("UOM");

            entity.HasOne(d => d.Ics).WithMany(p => p.Icsdetails)
                .HasForeignKey(d => d.Icsid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ICSDetails_ICS");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.Property(e => e.Category).HasMaxLength(128);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Item1)
                .HasMaxLength(255)
                .HasColumnName("Item");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.Qty)
                .HasColumnType("money")
                .HasColumnName("QTY");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("UOM");
        });

        modelBuilder.Entity<ItenaryDetail>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.DailyAllowance).HasColumnType("money");
            entity.Property(e => e.DateCreated).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.InclusiveTime).HasMaxLength(128);
            entity.Property(e => e.Iotid).HasColumnName("IOTId");
            entity.Property(e => e.MeansOfTransportation).HasMaxLength(128);
            entity.Property(e => e.PerDiems).HasColumnType("money");
            entity.Property(e => e.TotalAmount)
                .HasComputedColumnSql("((coalesce([TransportationFee],(0))+coalesce([PerDiems],(0)))+coalesce([DailyAllowance],(0)))", false)
                .HasColumnType("money");
            entity.Property(e => e.TransportationFee).HasColumnType("money");

            entity.HasOne(d => d.Iot).WithMany(p => p.ItenaryDetails)
                .HasForeignKey(d => d.Iotid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ItenaryDetails_ItenaryofTravels");
        });

        modelBuilder.Entity<ItenaryofTravel>(entity =>
        {
            entity.Property(e => e.ApprovedByPos).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.Obrid).HasColumnName("OBRId");
            entity.Property(e => e.OfficialAddress).HasMaxLength(128);
            entity.Property(e => e.Paid).HasColumnName("PAId");
            entity.Property(e => e.Position).HasMaxLength(128);
            entity.Property(e => e.PreparedByPos).HasMaxLength(128);
            entity.Property(e => e.SupervisorPos).HasMaxLength(128);

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.ItenaryofTravelApprovedByNavigations)
                .HasForeignKey(d => d.ApprovedBy)
                .HasConstraintName("FK_ItenaryofTravels_ApprovedBy");

            entity.HasOne(d => d.Employee).WithMany(p => p.ItenaryofTravelEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ItenaryofTravels_Employees");

            entity.HasOne(d => d.Obr).WithMany(p => p.ItenaryofTravels)
                .HasForeignKey(d => d.Obrid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ItenaryofTravels_Obligations");
        });

        modelBuilder.Entity<Jim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("jim");

            entity.Property(e => e.ExtName).HasMaxLength(5);
            entity.Property(e => e.FirstName).HasMaxLength(128);
            entity.Property(e => e.Gsis)
                .HasMaxLength(20)
                .HasColumnName("GSIS");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LastName).HasMaxLength(128);
            entity.Property(e => e.MiddleName).HasMaxLength(128);
            entity.Property(e => e.OffcAcr).HasMaxLength(128);
            entity.Property(e => e.OfficeName).HasMaxLength(128);
            entity.Property(e => e.PagIbig).HasMaxLength(128);
            entity.Property(e => e.PhilHealth).HasMaxLength(128);
            entity.Property(e => e.Position).HasMaxLength(128);
            entity.Property(e => e.SalaryGrade).HasMaxLength(20);
            entity.Property(e => e.Salutation).HasMaxLength(20);
            entity.Property(e => e.Sg)
                .HasMaxLength(20)
                .HasColumnName("SG");
            entity.Property(e => e.Sss)
                .HasMaxLength(128)
                .HasColumnName("SSS");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Steps).HasMaxLength(20);
            entity.Property(e => e.Tin)
                .HasMaxLength(128)
                .HasColumnName("TIN");
        });

        modelBuilder.Entity<LbacOffice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LbacOffices");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NewName)
                .HasMaxLength(56)
                .IsUnicode(false);
            entity.Property(e => e.RStatus).HasColumnName("rStatus");
            entity.Property(e => e.Rctext).HasColumnName("RCText");
        });

        modelBuilder.Entity<LbacSetting>(entity =>
        {
            entity.Property(e => e.AllowTargetCreation)
                .HasDefaultValue(true)
                .HasColumnName("Allow_TargetCreation");
            entity.Property(e => e.DateYear)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.OfficeId).HasColumnName("Office_Id");
            entity.Property(e => e.Q1Status).HasColumnName("q1_status");
            entity.Property(e => e.Q2Status).HasColumnName("q2_status");
            entity.Property(e => e.Q3Status).HasColumnName("q3_status");
            entity.Property(e => e.Q4Status).HasColumnName("q4_status");
        });

        modelBuilder.Entity<LbacUserRole>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Description)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<Letter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Letters_1");

            entity.Property(e => e.Cc)
                .HasMaxLength(128)
                .HasColumnName("CC");
            entity.Property(e => e.Closing).HasMaxLength(128);
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.Salutation).HasMaxLength(10);
            entity.Property(e => e.Signatories).HasMaxLength(128);
            entity.Property(e => e.SignatoriesPosition).HasMaxLength(128);
            entity.Property(e => e.TableName).HasMaxLength(128);
            entity.Property(e => e.Template).HasMaxLength(128);
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.Type).HasMaxLength(128);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Letters)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Letters_Users");

            entity.HasOne(d => d.Office).WithMany(p => p.Letters)
                .HasForeignKey(d => d.OfficeId)
                .HasConstraintName("FK_Letters_Offices");
        });

        modelBuilder.Entity<Liquidation>(entity =>
        {
            entity.Property(e => e.AccountantName).HasMaxLength(128);
            entity.Property(e => e.AccountantPosition).HasMaxLength(128);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AmountPerDv)
                .HasColumnType("money")
                .HasColumnName("AmountPerDV");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.HeadName).HasMaxLength(128);
            entity.Property(e => e.HeadPosition).HasMaxLength(128);
            entity.Property(e => e.ObRid).HasColumnName("ObRId");
            entity.Property(e => e.Paid).HasColumnName("PAId");

            entity.HasOne(d => d.Employee).WithMany(p => p.Liquidations)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Liquidations_Employees");

            entity.HasOne(d => d.HeadOfDepNavigation).WithMany(p => p.LiquidationHeadOfDepNavigations)
                .HasForeignKey(d => d.HeadOfDep)
                .HasConstraintName("FK_Liquidations_Head");

            entity.HasOne(d => d.ObR).WithMany(p => p.Liquidations)
                .HasForeignKey(d => d.ObRid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Liquidations_Obligations");

            entity.HasOne(d => d.Pa).WithMany(p => p.LiquidationPas)
                .HasForeignKey(d => d.Paid)
                .HasConstraintName("FK_Liquidations_Accountant");

            entity.HasOne(d => d.Payee).WithMany(p => p.Liquidations)
                .HasForeignKey(d => d.PayeeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Liquidations_Payees");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasIndex(e => e.CreatedBy, "IX_FK_Logs_Users");

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Logs)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_Logs_Users");
        });

        modelBuilder.Entity<Lrdetail>(entity =>
        {
            entity.ToTable("LRDetails");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Lrid).HasColumnName("LRId");

            entity.HasOne(d => d.Lr).WithMany(p => p.Lrdetails)
                .HasForeignKey(d => d.Lrid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_LRDetails_Liquidations");
        });

        modelBuilder.Entity<NewUserFromHrmi>(entity =>
        {
            entity.ToTable("NewUserFromHRMIS");

            entity.Property(e => e.FirstName).HasMaxLength(128);
            entity.Property(e => e.LastName).HasMaxLength(128);
            entity.Property(e => e.MiddleName).HasMaxLength(128);
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.Position).HasMaxLength(128);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserRole).HasMaxLength(128);
        });

        modelBuilder.Entity<NutObr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("nut_obr");

            entity.Property(e => e.AccountCode).HasMaxLength(128);
            entity.Property(e => e.AdjustedAmount).HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ControlNo).HasMaxLength(100);
        });

        modelBuilder.Entity<Obligation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Obligations$PrimaryKey");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.Date).HasPrecision(0);
            entity.Property(e => e.DateClosed).HasPrecision(0);
            entity.Property(e => e.Dmsno).HasColumnName("DMSNo");
            entity.Property(e => e.Dvamount)
                .HasColumnType("money")
                .HasColumnName("DVAmount");
            entity.Property(e => e.DvapprovedBy).HasColumnName("DVApprovedBy");
            entity.Property(e => e.DvapprovedByPosition).HasColumnName("DVApprovedByPosition");
            entity.Property(e => e.Dvnote).HasColumnName("DVNote");
            entity.Property(e => e.Dvparticular).HasColumnName("DVParticular");
            entity.Property(e => e.Ft)
                .HasMaxLength(25)
                .HasColumnName("FT");
            entity.Property(e => e.LessDiscount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);
            entity.Property(e => e.ObrapprovedBy).HasColumnName("OBRApprovedBy");
            entity.Property(e => e.ObrapprovedByNote).HasColumnName("OBRApprovedByNote");
            entity.Property(e => e.ObrapprovedByPos).HasColumnName("OBRApprovedByPos");
            entity.Property(e => e.Pbo).HasColumnName("PBO");
            entity.Property(e => e.Pbopos).HasColumnName("PBOPos");
            entity.Property(e => e.Poid).HasColumnName("POId");
            entity.Property(e => e.Prno).HasColumnName("PRNo");
            entity.Property(e => e.Rctext).HasColumnName("RCText");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.TotalAdjustedAmount).HasColumnType("money");
            entity.Property(e => e.WarrantySecurityAmount).HasColumnType("money");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Obligations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Obligations_Users");

            entity.HasOne(d => d.Office).WithMany(p => p.Obligations)
                .HasForeignKey(d => d.OfficeId)
                .HasConstraintName("FK_Obligations_Offices");

            entity.HasOne(d => d.Payee).WithMany(p => p.Obligations)
                .HasForeignKey(d => d.PayeeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Obligations_Payees");

            entity.HasOne(d => d.Po).WithMany(p => p.Obligations)
                .HasForeignKey(d => d.Poid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Obligations_PurchaseOrders");

            entity.HasMany(d => d.Letters).WithMany(p => p.Obrs)
                .UsingEntity<Dictionary<string, object>>(
                    "ObrinLetter",
                    r => r.HasOne<Letter>().WithMany()
                        .HasForeignKey("LetterId")
                        .HasConstraintName("FK_OBRInLetters_Letters"),
                    l => l.HasOne<Obligation>().WithMany()
                        .HasForeignKey("ObrId")
                        .HasConstraintName("FK_OBRInLetters_Obligations"),
                    j =>
                    {
                        j.HasKey("ObrId", "LetterId");
                        j.ToTable("OBRInLetters");
                    });
        });

        modelBuilder.Entity<ObligationsDv>(entity =>
        {
            entity.ToTable("ObligationsDV");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Electric).HasColumnType("money");
            entity.Property(e => e.Goods).HasColumnType("money");
            entity.Property(e => e.LiquidatedDamages).HasColumnType("money");
            entity.Property(e => e.Mobilization).HasColumnType("money");
            entity.Property(e => e.Mqcbilling)
                .HasColumnType("money")
                .HasColumnName("MQCBilling");
            entity.Property(e => e.NonVatGoods).HasColumnType("money");
            entity.Property(e => e.NonVatService).HasColumnType("money");
            entity.Property(e => e.OrigContractCost).HasColumnType("money");
            entity.Property(e => e.PrevCollection).HasColumnType("money");
            entity.Property(e => e.Retention).HasColumnType("money");
            entity.Property(e => e.RevisedContractAmt).HasColumnType("money");
            entity.Property(e => e.Service).HasColumnType("money");
            entity.Property(e => e.ServiceFive).HasColumnType("money");
            entity.Property(e => e.ServiceTwo).HasColumnType("money");
            entity.Property(e => e.Total).HasColumnType("money");
            entity.Property(e => e.TotalAmtDue).HasColumnType("money");
            entity.Property(e => e.TotalValueOfWorkThisBil).HasColumnType("money");
            entity.Property(e => e.TotalValueofWorkToDate).HasColumnType("money");
            entity.Property(e => e.WarrantySecurity).HasColumnType("money");
            entity.Property(e => e.WithHoldingTax).HasColumnType("money");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ObligationsDv)
                .HasForeignKey<ObligationsDv>(d => d.Id)
                .HasConstraintName("FK_ObligationsDV_Obligations");
        });

        modelBuilder.Entity<ObligationsDvadditional>(entity =>
        {
            entity.ToTable("ObligationsDVAdditional");

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.Dvamount)
                .HasColumnType("money")
                .HasColumnName("DVAmount");
            entity.Property(e => e.DvapprovedBy).HasColumnName("DVApprovedBy");
            entity.Property(e => e.DvapprovedByPosition).HasColumnName("DVApprovedByPosition");
            entity.Property(e => e.Dvnote).HasColumnName("DVNote");
            entity.Property(e => e.Electric).HasColumnType("money");
            entity.Property(e => e.Goods).HasColumnType("money");
            entity.Property(e => e.LiquidatedDamages).HasColumnType("money");
            entity.Property(e => e.Mobilization).HasColumnType("money");
            entity.Property(e => e.Mqcbilling)
                .HasColumnType("money")
                .HasColumnName("MQCBilling");
            entity.Property(e => e.NonVatGoods).HasColumnType("money");
            entity.Property(e => e.NonVatService).HasColumnType("money");
            entity.Property(e => e.ObRid).HasColumnName("ObRId");
            entity.Property(e => e.OrigContractCost).HasColumnType("money");
            entity.Property(e => e.PrevCollection).HasColumnType("money");
            entity.Property(e => e.Retention).HasColumnType("money");
            entity.Property(e => e.RevisedContractAmt).HasColumnType("money");
            entity.Property(e => e.Service).HasColumnType("money");
            entity.Property(e => e.ServiceFive).HasColumnType("money");
            entity.Property(e => e.ServiceTwo).HasColumnType("money");
            entity.Property(e => e.Total).HasColumnType("money");
            entity.Property(e => e.TotalAdjustedAmount).HasColumnType("money");
            entity.Property(e => e.TotalAmtDue).HasColumnType("money");
            entity.Property(e => e.TotalValueOfWorkThisBil).HasColumnType("money");
            entity.Property(e => e.TotalValueofWorkToDate).HasColumnType("money");
            entity.Property(e => e.WithHoldingTax).HasColumnType("money");

            entity.HasOne(d => d.ObR).WithMany(p => p.ObligationsDvadditionals)
                .HasForeignKey(d => d.ObRid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ObligationsDVAdditional_Obligations");
        });

        modelBuilder.Entity<Office>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.RStatus).HasColumnName("rStatus");
            entity.Property(e => e.Rctext).HasColumnName("RCText");
            entity.Property(e => e.Website).HasMaxLength(250);

            entity.HasOne(d => d.Employee).WithMany(p => p.Offices)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Offices_Employees");

            entity.HasOne(d => d.UnderOfNavigation).WithMany(p => p.InverseUnderOfNavigation)
                .HasForeignKey(d => d.UnderOf)
                .HasConstraintName("FK_Offices_Offices");
        });

        modelBuilder.Entity<OnlineUser>(entity =>
        {
            entity.HasKey(e => e.OnlineId);

            entity.ToTable("OnlineUser");

            entity.Property(e => e.OnlineId).HasColumnName("online_id");
            entity.Property(e => e.Employeename)
                .HasMaxLength(128)
                .HasColumnName("employeename");
            entity.Property(e => e.Ip)
                .HasMaxLength(128)
                .HasColumnName("ip");
            entity.Property(e => e.Officename)
                .HasMaxLength(128)
                .HasColumnName("officename");
        });

        modelBuilder.Entity<Ordetail>(entity =>
        {
            entity.ToTable("ORDetails");

            entity.Property(e => e.AccountCodeText).HasMaxLength(100);
            entity.Property(e => e.AdjustedAmount).HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");

            entity.HasOne(d => d.Appropriation).WithMany(p => p.Ordetails)
                .HasForeignKey(d => d.AppropriationId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ORDetails_Appropriations");

            entity.HasOne(d => d.Obligation).WithMany(p => p.Ordetails)
                .HasForeignKey(d => d.ObligationId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ORDetails_Obligations");
        });

        modelBuilder.Entity<Par>(entity =>
        {
            entity.ToTable("PAR");

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.FundCluster).HasMaxLength(128);
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);
            entity.Property(e => e.Pgso).HasColumnName("PGSO");
            entity.Property(e => e.Pgsoid).HasColumnName("PGSOId");
            entity.Property(e => e.Pgsoposition).HasColumnName("PGSOPosition");
            entity.Property(e => e.Prid).HasColumnName("PRId");
            entity.Property(e => e.Remarks).HasMaxLength(450);

            entity.HasOne(d => d.Pr).WithMany(p => p.Pars)
                .HasForeignKey(d => d.Prid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PAR_PurchaseRequests");
        });

        modelBuilder.Entity<Pardetail>(entity =>
        {
            entity.ToTable("PARDetails");

            entity.Property(e => e.Category).HasMaxLength(256);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.DateAcquired).HasMaxLength(128);
            entity.Property(e => e.Parid).HasColumnName("PARId");
            entity.Property(e => e.PropertyNumber).HasMaxLength(128);
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.Uom)
                .HasMaxLength(128)
                .HasColumnName("UOM");

            entity.HasOne(d => d.Par).WithMany(p => p.Pardetails)
                .HasForeignKey(d => d.Parid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PARDetails_PAR");
        });

        modelBuilder.Entity<Payee>(entity =>
        {
            entity.Property(e => e.Address).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.Note).HasMaxLength(128);
            entity.Property(e => e.Office).HasMaxLength(128);

            entity.HasOne(d => d.OfficeNavigation).WithMany(p => p.Payees)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Payees_Offices");
        });

        modelBuilder.Entity<Payroll>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Payroll");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Accountant).HasMaxLength(128);
            entity.Property(e => e.AccountantPos).HasMaxLength(128);
            entity.Property(e => e.ApprovedBy).HasMaxLength(128);
            entity.Property(e => e.ApprovedByPos).HasMaxLength(128);
            entity.Property(e => e.ChiefOfOffice).HasMaxLength(128);
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.DeptHead).HasMaxLength(128);
            entity.Property(e => e.DeptHeadPos).HasMaxLength(128);
            entity.Property(e => e.Position).HasMaxLength(128);
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.Treasurer).HasMaxLength(128);
            entity.Property(e => e.TreasurerPos).HasMaxLength(128);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Payroll)
                .HasForeignKey<Payroll>(d => d.Id)
                .HasConstraintName("FK_Payrolls_Obligations");
        });

        modelBuilder.Entity<PayrollDetail>(entity =>
        {
            entity.Property(e => e.ColumnTitle1).HasColumnType("money");
            entity.Property(e => e.ColumnTitle2).HasColumnType("money");
            entity.Property(e => e.Lbpaccount)
                .HasMaxLength(128)
                .HasColumnName("LBPAccount");
            entity.Property(e => e.Total).HasColumnType("decimal(19, 2)");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollDetails)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PayrollDetails_Employees");

            entity.HasOne(d => d.Payroll).WithMany(p => p.PayrollDetails)
                .HasForeignKey(d => d.PayrollId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollDetails_Payrolls");
        });

        modelBuilder.Entity<PayrollDifferential>(entity =>
        {
            entity.Property(e => e.Accountant).HasMaxLength(128);
            entity.Property(e => e.AccountantPos).HasMaxLength(128);
            entity.Property(e => e.ApprovedBy).HasMaxLength(128);
            entity.Property(e => e.ApprovedByPos).HasMaxLength(128);
            entity.Property(e => e.ChiefOfOffice).HasMaxLength(128);
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.DeptHead).HasMaxLength(128);
            entity.Property(e => e.DeptHeadPos).HasMaxLength(128);
            entity.Property(e => e.Position).HasMaxLength(128);
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.Treasurer).HasMaxLength(128);
            entity.Property(e => e.TreasurerPos).HasMaxLength(128);

            entity.HasOne(d => d.Ob).WithMany(p => p.PayrollDifferentials)
                .HasForeignKey(d => d.ObId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollDifferentials_Obligations");
        });

        modelBuilder.Entity<PayrollDifferentialDetail>(entity =>
        {
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Designation).HasMaxLength(128);
            entity.Property(e => e.DiffBonus).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.DiffMidYearBonus).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.EmployeeName).HasMaxLength(128);
            entity.Property(e => e.Gsisgs)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("GSISGS");
            entity.Property(e => e.Gsisps)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("GSISPS");
            entity.Property(e => e.Hazard).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Month).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.NewRate).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.OldRate).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Phgs)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PHGS");
            entity.Property(e => e.Phps)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PHPS");
            entity.Property(e => e.Pigs)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PIGS");
            entity.Property(e => e.Pips)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PIPS");
            entity.Property(e => e.SalaryGrade).HasMaxLength(128);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(19, 2)");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollDifferentialDetails)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PayrollDifferentialDetails_Employees");

            entity.HasOne(d => d.PayrollDiffential).WithMany(p => p.PayrollDifferentialDetails)
                .HasForeignKey(d => d.PayrollDiffentialId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollDifferentialDetails_PayrollDifferentials");
        });

        modelBuilder.Entity<PayrollHazard>(entity =>
        {
            entity.ToTable("PayrollHazard");

            entity.Property(e => e.Accountant).HasMaxLength(128);
            entity.Property(e => e.AccountantPos).HasMaxLength(128);
            entity.Property(e => e.ApprovedBy).HasMaxLength(128);
            entity.Property(e => e.ApprovedByPos).HasMaxLength(128);
            entity.Property(e => e.ChiefOfOffice).HasMaxLength(128);
            entity.Property(e => e.ChiefOfOfficePos).HasMaxLength(128);
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DeptHead).HasMaxLength(128);
            entity.Property(e => e.DeptHeadPos).HasMaxLength(128);
            entity.Property(e => e.ObRid).HasColumnName("ObRId");
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.Treasurer).HasMaxLength(128);
            entity.Property(e => e.TreasurerPos).HasMaxLength(128);

            entity.HasOne(d => d.ObR).WithMany(p => p.PayrollHazards)
                .HasForeignKey(d => d.ObRid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollHazard_Obligations");
        });

        modelBuilder.Entity<PayrollHazardDetail>(entity =>
        {
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.HazardPay).HasColumnType("money");
            entity.Property(e => e.HazardWt)
                .HasColumnType("money")
                .HasColumnName("HazardWT");
            entity.Property(e => e.Laundry).HasColumnType("money");
            entity.Property(e => e.NoOfDays).HasColumnType("money");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Position)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.RiskAssessment).HasMaxLength(50);
            entity.Property(e => e.SalaryBasis).HasColumnType("money");
            entity.Property(e => e.SalaryGrade).HasMaxLength(50);
            entity.Property(e => e.Subsistence).HasColumnType("money");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollHazardDetails)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollHazardDetails_Employees");

            entity.HasOne(d => d.PayrollHazard).WithMany(p => p.PayrollHazardDetails)
                .HasForeignKey(d => d.PayrollHazardId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollHazardDetails_PayrollHazard");
        });

        modelBuilder.Entity<PayrollOt>(entity =>
        {
            entity.ToTable("PayrollOT");

            entity.Property(e => e.ApprovedPosition).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.HeadPosition).HasMaxLength(128);
            entity.Property(e => e.ObRid).HasColumnName("ObRId");
            entity.Property(e => e.Paid).HasColumnName("PAId");
            entity.Property(e => e.Paposition)
                .HasMaxLength(128)
                .HasColumnName("PAPosition");
            entity.Property(e => e.Ptid).HasColumnName("PTId");
            entity.Property(e => e.Ptposition)
                .HasMaxLength(128)
                .HasColumnName("PTPosition");
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.ObR).WithMany(p => p.PayrollOts)
                .HasForeignKey(d => d.ObRid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PayrollOT_Obligations");
        });

        modelBuilder.Entity<PayrollOtdetail>(entity =>
        {
            entity.ToTable("PayrollOTDetails");

            entity.Property(e => e.PayrollOtid).HasColumnName("PayrollOTId");
            entity.Property(e => e.RatePerDay).HasColumnType("money");
            entity.Property(e => e.RatePerHr).HasColumnType("money");
            entity.Property(e => e.RatePerMonth).HasColumnType("money");
            entity.Property(e => e.SubTotal).HasColumnType("money");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.UnderPay).HasColumnType("money");
            entity.Property(e => e.WeekDayNoHrs).HasColumnType("money");
            entity.Property(e => e.WeekDayTimes).HasColumnType("money");
            entity.Property(e => e.WeekEndNoHrs).HasColumnType("money");
            entity.Property(e => e.WeekEndTimes).HasColumnType("money");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollOtdetails)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollOTDetails_Employees");

            entity.HasOne(d => d.PayrollOt).WithMany(p => p.PayrollOtdetails)
                .HasForeignKey(d => d.PayrollOtid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollOTDetails_PayrollOT");
        });

        modelBuilder.Entity<PayrollSpe>(entity =>
        {
            entity.ToTable("PayrollSPES");

            entity.Property(e => e.Accountant).HasMaxLength(128);
            entity.Property(e => e.AccountantPos).HasMaxLength(128);
            entity.Property(e => e.ApprovedBy).HasMaxLength(128);
            entity.Property(e => e.ApprovedByPos).HasMaxLength(128);
            entity.Property(e => e.ChiefOfOffice).HasMaxLength(128);
            entity.Property(e => e.ChiefOfOfficePos).HasMaxLength(128);
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DeptHead).HasMaxLength(128);
            entity.Property(e => e.DeptHeadPos).HasMaxLength(128);
            entity.Property(e => e.ObRid).HasColumnName("ObRId");
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.Treasurer).HasMaxLength(128);
            entity.Property(e => e.TreasurerPos).HasMaxLength(128);

            entity.HasOne(d => d.ObR).WithMany(p => p.PayrollSpes)
                .HasForeignKey(d => d.ObRid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollSPES_Obligations");
        });

        modelBuilder.Entity<PayrollSpesdetail>(entity =>
        {
            entity.ToTable("PayrollSPESDetails");

            entity.Property(e => e.NetAmtPaid).HasColumnType("money");
            entity.Property(e => e.NoOfDays).HasColumnType("money");
            entity.Property(e => e.PayrollSpesid).HasColumnName("PayrollSPESId");
            entity.Property(e => e.Percentage).HasColumnType("money");
            entity.Property(e => e.Position)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.RatePerDay).HasColumnType("money");
            entity.Property(e => e.Total).HasColumnType("money");
            entity.Property(e => e.UnderTime).HasColumnType("money");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollSpesdetails)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollSPESDetails_Employees");

            entity.HasOne(d => d.PayrollSpes).WithMany(p => p.PayrollSpesdetails)
                .HasForeignKey(d => d.PayrollSpesid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollSPESDetails_PayrollSPES");
        });

        modelBuilder.Entity<PayrollWage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PayrollWage");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Accountant).HasMaxLength(128);
            entity.Property(e => e.AccountantPos).HasMaxLength(128);
            entity.Property(e => e.ApprovedBy).HasMaxLength(128);
            entity.Property(e => e.ApprovedByPa)
                .HasMaxLength(128)
                .HasColumnName("ApprovedByPA");
            entity.Property(e => e.ApprovedByPaid).HasColumnName("ApprovedByPAId");
            entity.Property(e => e.ApprovedByPapos)
                .HasMaxLength(128)
                .HasColumnName("ApprovedByPAPos");
            entity.Property(e => e.ApprovedByPos).HasMaxLength(128);
            entity.Property(e => e.ChiefOfOffice).HasMaxLength(128);
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.Position).HasMaxLength(128);
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.Treasurer).HasMaxLength(128);
            entity.Property(e => e.TreasurerPos).HasMaxLength(128);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.PayrollWage)
                .HasForeignKey<PayrollWage>(d => d.Id)
                .HasConstraintName("FK_PayrollWage_Obligations");
        });

        modelBuilder.Entity<PayrollWageDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PayrollWages");

            entity.Property(e => e.Birwh)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("BIRWH");
            entity.Property(e => e.Dbp)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("DBP");
            entity.Property(e => e.GrossAmount).HasColumnType("decimal(19, 3)");
            entity.Property(e => e.Gsisconsol)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("GSISConsol");
            entity.Property(e => e.Gsispolicy)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("GSISPolicy");
            entity.Property(e => e.HazardPay).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Laundry).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Lbp)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("LBP");
            entity.Property(e => e.Mpl)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("MPL");
            entity.Property(e => e.NoOfdays).HasColumnType("decimal(19, 3)");
            entity.Property(e => e.Nvpea)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("NVPEA");
            entity.Property(e => e.Ot)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("OT");
            entity.Property(e => e.Pera)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PERA");
            entity.Property(e => e.Phgs)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PHGS");
            entity.Property(e => e.Phps)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PHPS");
            entity.Property(e => e.PifcalLoan)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PIFCalLoan");
            entity.Property(e => e.Pigs)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PIGS");
            entity.Property(e => e.Pimp)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PIMP");
            entity.Property(e => e.Pips)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("PIPS");
            entity.Property(e => e.RatePerDay).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.SalaryGrade).HasMaxLength(128);
            entity.Property(e => e.Sssloan)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("SSSLoan");
            entity.Property(e => e.Sssps)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("SSSPS");
            entity.Property(e => e.Subsistence).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(19, 2)");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollWageDetails)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PayrollWages_Employees");

            entity.HasOne(d => d.PayrollWage).WithMany(p => p.PayrollWageDetails)
                .HasForeignKey(d => d.PayrollWageId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollWageDetails_PayrollWages");
        });

        modelBuilder.Entity<PayrollWagesPermanent>(entity =>
        {
            entity.ToTable("PayrollWagesPermanent");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Accountant).HasMaxLength(128);
            entity.Property(e => e.AccountantPos).HasMaxLength(128);
            entity.Property(e => e.ApprovedBy).HasMaxLength(128);
            entity.Property(e => e.ApprovedByPos).HasMaxLength(128);
            entity.Property(e => e.ChiefOfOffice).HasMaxLength(128);
            entity.Property(e => e.ChiefOfOfficePos).HasMaxLength(128);
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DeptHead).HasMaxLength(128);
            entity.Property(e => e.DeptHeadPos).HasMaxLength(128);
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.Treasurer).HasMaxLength(128);
            entity.Property(e => e.TreasurerPos).HasMaxLength(128);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.PayrollWagesPermanent)
                .HasForeignKey<PayrollWagesPermanent>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollWagesPermanent_Obligations");
        });

        modelBuilder.Entity<PayrollWagesPermanentDetail>(entity =>
        {
            entity.Property(e => e.AddtInsurance).HasColumnType("money");
            entity.Property(e => e.AmountAccrued).HasColumnType("money");
            entity.Property(e => e.AmountPaid).HasColumnType("money");
            entity.Property(e => e.Ceap)
                .HasColumnType("money")
                .HasColumnName("CEAP");
            entity.Property(e => e.Dbploan)
                .HasColumnType("money")
                .HasColumnName("DBPLoan");
            entity.Property(e => e.Ecard)
                .HasColumnType("money")
                .HasColumnName("ECARD");
            entity.Property(e => e.Gfal)
                .HasColumnType("money")
                .HasColumnName("GFAL");
            entity.Property(e => e.Gsisarrears)
                .HasColumnType("money")
                .HasColumnName("GSISArrears");
            entity.Property(e => e.Gsiseduc)
                .HasColumnType("money")
                .HasColumnName("GSISEduc");
            entity.Property(e => e.Gsislricgs)
                .HasColumnType("money")
                .HasColumnName("GSISLRICGS");
            entity.Property(e => e.Gsislricps)
                .HasColumnType("money")
                .HasColumnName("GSISLRICPS");
            entity.Property(e => e.Hip)
                .HasColumnType("money")
                .HasColumnName("HIP");
            entity.Property(e => e.Hrrploan)
                .HasColumnType("money")
                .HasColumnName("HRRPLoan");
            entity.Property(e => e.InsularLife).HasColumnType("money");
            entity.Property(e => e.Lbploan)
                .HasColumnType("money")
                .HasColumnName("LBPLoan");
            entity.Property(e => e.Miscellaneous).HasColumnType("money");
            entity.Property(e => e.Nvgempc)
                .HasColumnType("money")
                .HasColumnName("NVGEMPC");
            entity.Property(e => e.Nvpea)
                .HasColumnType("money")
                .HasColumnName("NVPEA");
            entity.Property(e => e.OptInsurance).HasColumnType("money");
            entity.Property(e => e.Phgs)
                .HasColumnType("money")
                .HasColumnName("PHGS");
            entity.Property(e => e.Phps)
                .HasColumnType("money")
                .HasColumnName("PHPS");
            entity.Property(e => e.Pigs)
                .HasColumnType("money")
                .HasColumnName("PIGS");
            entity.Property(e => e.Pimp2)
                .HasColumnType("money")
                .HasColumnName("PIMP2");
            entity.Property(e => e.Pips)
                .HasColumnType("money")
                .HasColumnName("PIPS");
            entity.Property(e => e.Rel)
                .HasColumnType("money")
                .HasColumnName("REL");
            entity.Property(e => e.StateIns).HasColumnType("money");
            entity.Property(e => e.WithHoldingTax).HasColumnType("money");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollWagesPermanentDetails)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollWagesPermanentDetails_Employees");

            entity.HasOne(d => d.PayrollPermanent).WithMany(p => p.PayrollWagesPermanentDetails)
                .HasForeignKey(d => d.PayrollPermanentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollWagesPermanentDetails_PayrollWagesPermanent");
        });

        modelBuilder.Entity<PayrollWagesPermanentDetailsEnd>(entity =>
        {
            entity.ToTable("PayrollWagesPermanentDetailsEnd");

            entity.Property(e => e.AmountAccrued).HasColumnType("money");
            entity.Property(e => e.AmountPaid).HasColumnType("money");
            entity.Property(e => e.CashAdv).HasColumnType("money");
            entity.Property(e => e.Dbp)
                .HasColumnType("money")
                .HasColumnName("DBP");
            entity.Property(e => e.Disallowance).HasColumnType("money");
            entity.Property(e => e.Gsisarrearages)
                .HasColumnType("money")
                .HasColumnName("GSISArrearages");
            entity.Property(e => e.GsisconsolLoan)
                .HasColumnType("money")
                .HasColumnName("GSISConsolLoan");
            entity.Property(e => e.Gsiscpl)
                .HasColumnType("money")
                .HasColumnName("GSISCPL");
            entity.Property(e => e.GsisemergencyLoan)
                .HasColumnType("money")
                .HasColumnName("GSISEmergencyLoan");
            entity.Property(e => e.Gsisgfal)
                .HasColumnType("money")
                .HasColumnName("GSISGFAL");
            entity.Property(e => e.Gsismpl)
                .HasColumnType("money")
                .HasColumnName("GSISMPL");
            entity.Property(e => e.GsisoptionalLoan)
                .HasColumnType("money")
                .HasColumnName("GSISOptionalLoan");
            entity.Property(e => e.GsispolicyLoan)
                .HasColumnType("money")
                .HasColumnName("GSISPolicyLoan");
            entity.Property(e => e.Gsisrel)
                .HasColumnType("money")
                .HasColumnName("GSISREL");
            entity.Property(e => e.InsularLife).HasColumnType("money");
            entity.Property(e => e.Lbp)
                .HasColumnType("money")
                .HasColumnName("LBP");
            entity.Property(e => e.Nvgempci)
                .HasColumnType("money")
                .HasColumnName("NVGEMPCI");
            entity.Property(e => e.Nvpealoan)
                .HasColumnType("money")
                .HasColumnName("NVPEALoan");
            entity.Property(e => e.Pera)
                .HasColumnType("money")
                .HasColumnName("PERA");
            entity.Property(e => e.Philam)
                .HasColumnType("money")
                .HasColumnName("PHILAM");
            entity.Property(e => e.Picalamity)
                .HasColumnType("money")
                .HasColumnName("PICalamity");
            entity.Property(e => e.PihousingLoan)
                .HasColumnType("money")
                .HasColumnName("PIHousingLoan");
            entity.Property(e => e.Pimpl)
                .HasColumnType("money")
                .HasColumnName("PIMPL");
            entity.Property(e => e.PrepaidTax).HasColumnType("money");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollWagesPermanentDetailsEnds)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollWagesPermanentDetailsEnd_Employees");

            entity.HasOne(d => d.PayrollPermanent).WithMany(p => p.PayrollWagesPermanentDetailsEnds)
                .HasForeignKey(d => d.PayrollPermanentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PayrollWagesPermanentDetailsEnd_PayrollWagesPermanentEnd");
        });

        modelBuilder.Entity<PayrollWagesPermanentEnd>(entity =>
        {
            entity.ToTable("PayrollWagesPermanentEnd");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Accountant).HasMaxLength(128);
            entity.Property(e => e.AccountantPos).HasMaxLength(128);
            entity.Property(e => e.ApprovedBy).HasMaxLength(128);
            entity.Property(e => e.ApprovedByPos).HasMaxLength(128);
            entity.Property(e => e.ChiefOfOffice).HasMaxLength(128);
            entity.Property(e => e.ChiefOfOfficePos).HasMaxLength(128);
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DeptHead).HasMaxLength(128);
            entity.Property(e => e.DeptHeadPos).HasMaxLength(128);
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.Treasurer).HasMaxLength(128);
            entity.Property(e => e.TreasurerPos).HasMaxLength(128);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.PayrollWagesPermanentEnd)
                .HasForeignKey<PayrollWagesPermanentEnd>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollWagesPermanentEnd_Obligations");
        });

        modelBuilder.Entity<Pi>(entity =>
        {
            entity.ToTable("PIS");

            entity.Property(e => e.PreparedBy).HasMaxLength(128);
            entity.Property(e => e.PreparedByPos).HasMaxLength(128);
            entity.Property(e => e.Prid).HasColumnName("PRId");

            entity.HasOne(d => d.PreparedByNavigation).WithMany(p => p.Pis)
                .HasForeignKey(d => d.PreparedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PIS_Users");

            entity.HasOne(d => d.Pr).WithMany(p => p.Pis)
                .HasForeignKey(d => d.Prid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PIS_PurchaseRequests");
        });

        modelBuilder.Entity<Pisdetail>(entity =>
        {
            entity.ToTable("PISDetails");

            entity.Property(e => e.Category).HasMaxLength(256);
            entity.Property(e => e.ClassNumber).HasMaxLength(128);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Pisid).HasColumnName("PISId");
            entity.Property(e => e.PropertyNumber).HasMaxLength(128);
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.Uom)
                .HasMaxLength(128)
                .HasColumnName("UOM");

            entity.HasOne(d => d.Pis).WithMany(p => p.Pisdetails)
                .HasForeignKey(d => d.Pisid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PISDetails_PIS");
        });

        modelBuilder.Entity<Podetail>(entity =>
        {
            entity.ToTable("PODetails");

            entity.Property(e => e.Category).HasMaxLength(256);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Poid).HasColumnName("POId");
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.Uom)
                .HasMaxLength(128)
                .HasColumnName("UOM");

            entity.HasOne(d => d.Po).WithMany(p => p.Podetails)
                .HasForeignKey(d => d.Poid)
                .HasConstraintName("FK_PODetails_PurchaseOrders");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.Property(e => e.Description).HasMaxLength(128);
            entity.Property(e => e.Position1)
                .HasMaxLength(128)
                .HasColumnName("Position");
        });

        modelBuilder.Entity<Pqdetail>(entity =>
        {
            entity.ToTable("PQDetails");

            entity.Property(e => e.Category).HasMaxLength(256);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Pqid).HasColumnName("PQId");
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.Uom)
                .HasMaxLength(128)
                .HasColumnName("UOM");

            entity.HasOne(d => d.Pq).WithMany(p => p.Pqdetails)
                .HasForeignKey(d => d.Pqid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PQDetails_PurchaseQuotations");
        });

        modelBuilder.Entity<Prdetail>(entity =>
        {
            entity.ToTable("PRDetails");

            entity.HasIndex(e => e.Id, "IX_PRDetails").IsUnique();

            entity.Property(e => e.Category).HasMaxLength(256);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Prid).HasColumnName("PRId");
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.TableName).HasMaxLength(128);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.Uom)
                .HasMaxLength(128)
                .HasColumnName("UOM");

            entity.HasOne(d => d.ItemNavigation).WithMany(p => p.Prdetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PRDetails_Items");

            entity.HasOne(d => d.Pr).WithMany(p => p.Prdetails)
                .HasForeignKey(d => d.Prid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PRDetails_PurchaseRequests");
        });

        modelBuilder.Entity<PriceQuotation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PurchaseQuotations");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.Pgsofficer).HasColumnName("PGSOfficer");
            entity.Property(e => e.Prid).HasColumnName("PRId");
            entity.Property(e => e.TotalAmount).HasColumnType("money");

            entity.HasOne(d => d.Pr).WithMany(p => p.PriceQuotations)
                .HasForeignKey(d => d.Prid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PurchaseQuotations_PurchaseRequests");
        });

        modelBuilder.Entity<ProjectApproAllotment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProjectApproAlignment");

            entity.ToTable("ProjectApproAllotment");

            entity.Property(e => e.AllotmentAmount).HasColumnType("money");
            entity.Property(e => e.AllotmentDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.HasOne(d => d.ProjectNameApp).WithMany(p => p.ProjectApproAllotments)
                .HasForeignKey(d => d.ProjectNameAppId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProjectApproAlignment_ProjectNameApp");
        });

        modelBuilder.Entity<ProjectApproRealignment>(entity =>
        {
            entity.ToTable("ProjectApproRealignment");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateRealignment).HasColumnType("datetime");

            entity.HasOne(d => d.SourceProjAppro).WithMany(p => p.ProjectApproRealignmentSourceProjAppros)
                .HasForeignKey(d => d.SourceProjApproId)
                .HasConstraintName("FK_ProjectApproRealignment_ProjectApproRealignment");

            entity.HasOne(d => d.TargetProjAppro).WithMany(p => p.ProjectApproRealignmentTargetProjAppros)
                .HasForeignKey(d => d.TargetProjApproId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProjectApproRealignment_ProjectNameApp");
        });

        modelBuilder.Entity<ProjectName>(entity =>
        {
            entity.ToTable("ProjectName");

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Fpp)
                .HasMaxLength(50)
                .HasColumnName("FPP");
            entity.Property(e => e.Ft)
                .HasMaxLength(50)
                .HasColumnName("FT");
            entity.Property(e => e.Project).IsUnicode(false);
            entity.Property(e => e.Rc)
                .HasMaxLength(50)
                .HasColumnName("RC");
            entity.Property(e => e.SourceOfFund).HasMaxLength(128);
        });

        modelBuilder.Entity<ProjectNameApp>(entity =>
        {
            entity.ToTable("ProjectNameApp");

            entity.Property(e => e.AccountCode).HasMaxLength(128);
            entity.Property(e => e.AccountCodeText).HasMaxLength(128);
            entity.Property(e => e.Appropriation).HasColumnType("money");
            entity.Property(e => e.Createdby).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Ft)
                .HasMaxLength(20)
                .HasColumnName("FT");
            entity.Property(e => e.FundType).HasMaxLength(128);

            entity.HasOne(d => d.FundTypeNavigation).WithMany(p => p.ProjectNameApps)
                .HasForeignKey(d => d.FundTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_ProjectNameApp_FundTypes");

            entity.HasOne(d => d.ProjectName).WithMany(p => p.ProjectNameApps)
                .HasForeignKey(d => d.ProjectNameId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProjectNameApp_ProjectName");
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.SortOrder)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.DateOfDelivery).HasMaxLength(128);
            entity.Property(e => e.DeliveryTerm).HasMaxLength(128);
            entity.Property(e => e.LessDiscount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.ModeOfProcurement).HasMaxLength(128);
            entity.Property(e => e.PaymentTerm).HasMaxLength(128);
            entity.Property(e => e.Pgsofficer).HasColumnName("PGSOfficer");
            entity.Property(e => e.PlaceOfDelivery).HasMaxLength(128);
            entity.Property(e => e.Podate).HasColumnName("PODate");
            entity.Property(e => e.PodateText).HasColumnName("PODateText");
            entity.Property(e => e.Pono)
                .HasMaxLength(128)
                .HasColumnName("PONo");
            entity.Property(e => e.Prid).HasColumnName("PRId");
            entity.Property(e => e.Prno)
                .HasMaxLength(128)
                .HasColumnName("PRNo");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(19, 2)");

            entity.HasOne(d => d.Pr).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.Prid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PurchaseOrders_PurchaseRequests");
        });

        modelBuilder.Entity<PurchaseRequest>(entity =>
        {
            entity.Property(e => e.BudgetControlNo).HasMaxLength(128);
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.Ft)
                .HasMaxLength(25)
                .HasColumnName("FT");
            entity.Property(e => e.Pa).HasColumnName("PA");
            entity.Property(e => e.Papos).HasColumnName("PAPos");
            entity.Property(e => e.Sai)
                .HasMaxLength(128)
                .HasColumnName("SAI");
            entity.Property(e => e.Saidate).HasColumnName("SAIDate");
            entity.Property(e => e.TableName).HasMaxLength(128);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
        });

        modelBuilder.Entity<ReAlignment>(entity =>
        {
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);

            entity.HasOne(d => d.SourceAppropriation).WithMany(p => p.ReAlignmentSourceAppropriations)
                .HasForeignKey(d => d.SourceAppropriationId)
                .HasConstraintName("FK_ReAlignments_Appropriations");

            entity.HasOne(d => d.TargetAppropriation).WithMany(p => p.ReAlignmentTargetAppropriations)
                .HasForeignKey(d => d.TargetAppropriationId)
                .HasConstraintName("FK_ReAlignments_TargetSource");
        });

        modelBuilder.Entity<Risdetail>(entity =>
        {
            entity.ToTable("RISDetails");

            entity.Property(e => e.Category).HasMaxLength(256);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.Risid).HasColumnName("RISId");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.Uom)
                .HasMaxLength(128)
                .HasColumnName("UOM");

            entity.HasOne(d => d.Ris).WithMany(p => p.Risdetails)
                .HasForeignKey(d => d.Risid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RISDetails_RISHeader");
        });

        modelBuilder.Entity<Risheader>(entity =>
        {
            entity.ToTable("RISHeader");

            entity.Property(e => e.ApprovedBy).HasMaxLength(128);
            entity.Property(e => e.ApprovedByPos).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.IssuedBy).HasMaxLength(128);
            entity.Property(e => e.IssuedByPos).HasMaxLength(128);
            entity.Property(e => e.Prid).HasColumnName("PRId");
            entity.Property(e => e.ReceivedBy).HasMaxLength(128);
            entity.Property(e => e.ReceivedByPos).HasMaxLength(128);
            entity.Property(e => e.RequestedBy).HasMaxLength(128);
            entity.Property(e => e.RequestedByPos).HasMaxLength(128);
            entity.Property(e => e.Risdate).HasColumnName("RISDate");
            entity.Property(e => e.Risno)
                .HasMaxLength(50)
                .HasColumnName("RISNo");
            entity.Property(e => e.Sai)
                .HasMaxLength(50)
                .HasColumnName("SAI");
            entity.Property(e => e.Saidate).HasColumnName("SAIDate");

            entity.HasOne(d => d.Office).WithMany(p => p.Risheaders)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_RISHeader_Offices");

            entity.HasOne(d => d.Pr).WithMany(p => p.Risheaders)
                .HasForeignKey(d => d.Prid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RISHeader_PurchaseRequests");
        });

        modelBuilder.Entity<SalarySchedule>(entity =>
        {
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Sg)
                .HasMaxLength(50)
                .HasColumnName("SG");
        });

        modelBuilder.Entity<Signatory>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.Signatories)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Signatories_Employees");
        });

        modelBuilder.Entity<Spespercentage>(entity =>
        {
            entity.ToTable("SPESPercentage");

            entity.Property(e => e.Percentage).HasColumnType("money");
        });

        modelBuilder.Entity<TblYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblYear");

            entity.Property(e => e.FldYear).HasColumnName("fldYear");
        });

        modelBuilder.Entity<Town>(entity =>
        {
            entity.HasIndex(e => e.ProvinceId, "IX_FK_Towns_Towns");

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Province).WithMany(p => p.Towns)
                .HasForeignKey(d => d.ProvinceId)
                .HasConstraintName("FK_Towns_Towns");
        });

        modelBuilder.Entity<TrashBin>(entity =>
        {
            entity.ToTable("TrashBin");

            entity.Property(e => e.DeletedBy).HasMaxLength(128);
            entity.Property(e => e.TableName).HasMaxLength(50);

            entity.HasOne(d => d.Office).WithMany(p => p.TrashBins)
                .HasForeignKey(d => d.OfficeId)
                .HasConstraintName("FK_TrashBin_Offices");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_TrashBin_TrashBin");
        });

        modelBuilder.Entity<TripTicket>(entity =>
        {
            entity.ToTable("TripTicket");

            entity.Property(e => e.AddPurchase).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApproximateDistance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AtTheBeginning).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AtTheEndTrip).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BalanceInTank).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BalanceInTankAtTheEnd).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Chief).HasMaxLength(150);
            entity.Property(e => e.ChiefPos).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateOfArrival).HasMaxLength(150);
            entity.Property(e => e.DateOfArrivalAtGarageOffice).HasMaxLength(150);
            entity.Property(e => e.DateOfDeparture).HasMaxLength(150);
            entity.Property(e => e.DateOfDepartureFromDestination).HasMaxLength(150);
            entity.Property(e => e.Deduct).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DistanceTravelled).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ft)
                .HasMaxLength(50)
                .HasColumnName("FT");
            entity.Property(e => e.GearOil).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.GreaseIssued).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.IsDefectiveOdo).HasColumnName("IsDefectiveODO");
            entity.Property(e => e.IssuedByOffice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LubOil).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Others).HasMaxLength(150);
            entity.Property(e => e.PlaceToVisit).HasMaxLength(250);
            entity.Property(e => e.Purpose).HasMaxLength(250);
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TimeOfArrival).HasMaxLength(150);
            entity.Property(e => e.TimeOfArrivalAtGarageOffice).HasMaxLength(50);
            entity.Property(e => e.TimeOfDeparture).HasMaxLength(50);
            entity.Property(e => e.TimeOfDepartureFromDestination).HasMaxLength(50);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.DriverNavigation).WithMany(p => p.TripTickets)
                .HasForeignKey(d => d.Driver)
                .HasConstraintName("FK_TripTicket_Employees");

            entity.HasOne(d => d.Office).WithMany(p => p.TripTickets)
                .HasForeignKey(d => d.OfficeId)
                .HasConstraintName("FK_TripTicket_Offices");

            entity.HasOne(d => d.PlateNoNavigation).WithMany(p => p.TripTickets)
                .HasForeignKey(d => d.PlateNo)
                .HasConstraintName("FK_TripTicket_VehicleDetails");
        });

        modelBuilder.Entity<TripTicketPassenger>(entity =>
        {
            entity.ToTable("TripTicketPassenger");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.Office).HasMaxLength(150);
            entity.Property(e => e.Passenger).HasMaxLength(150);
            entity.Property(e => e.PassengerPos).HasMaxLength(150);

            entity.HasOne(d => d.TripTicket).WithMany(p => p.TripTicketPassengers)
                .HasForeignKey(d => d.TripTicketId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TripTicketPassenger_TripTicket");
        });

        modelBuilder.Entity<UnitOfMeasurement>(entity =>
        {
            entity.ToTable("UnitOfMeasurement");

            entity.Property(e => e.UnitOfMeasurement1)
                .HasMaxLength(128)
                .HasColumnName("UnitOfMeasurement");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.UserName, "IX_Users").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Cellular).HasMaxLength(25);
            entity.Property(e => e.Citizenship).HasMaxLength(50);
            entity.Property(e => e.CivilStatus).HasMaxLength(12);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dmsadmin).HasColumnName("DMSAdmin");
            entity.Property(e => e.DmsviewPaps).HasColumnName("DMSViewPAPs");
            entity.Property(e => e.Email).HasMaxLength(128);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.FldDms)
                .HasDefaultValue(true)
                .HasColumnName("fldDMS");
            entity.Property(e => e.Gender).HasMaxLength(6);
            entity.Property(e => e.Height).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsHead).HasColumnName("isHead");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(150);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.NewUserFromHrmis).HasColumnName("NewUserFromHRMIS");
            entity.Property(e => e.PhoneNumber).HasMaxLength(25);
            entity.Property(e => e.Religion).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.Weight).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Office).WithMany(p => p.Users)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Users_Offices");
        });

        modelBuilder.Entity<UserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_FK_UserClaims_Users");

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.UserClaims)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserClaims_Users");
        });

        modelBuilder.Entity<UserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId });

            entity.HasIndex(e => e.UserId, "IX_FK_UserLogins_Users");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.UserLogins)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserLogins_Users");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasMany(d => d.Users).WithMany(p => p.UserRoles)
                .UsingEntity<Dictionary<string, object>>(
                    "UsersInRole",
                    r => r.HasOne<User>().WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UsersInRoles_Users"),
                    l => l.HasOne<UserRole>().WithMany()
                        .HasForeignKey("UserRolesId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UsersInRoles_UserRoles"),
                    j =>
                    {
                        j.HasKey("UserRolesId", "UsersId");
                        j.ToTable("UsersInRoles");
                        j.HasIndex(new[] { "UsersId" }, "IX_FK_UsersInRoles_Users");
                        j.IndexerProperty<string>("UserRolesId")
                            .HasMaxLength(128)
                            .HasColumnName("UserRoles_Id");
                        j.IndexerProperty<string>("UsersId")
                            .HasMaxLength(128)
                            .HasColumnName("Users_Id");
                    });
        });

        modelBuilder.Entity<UserWithRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UserWithRoles");

            entity.Property(e => e.Description)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<VehicleDetail>(entity =>
        {
            entity.Property(e => e.AverageFuelCon).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BodyNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BodyType)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Crdate)
                .HasColumnType("datetime")
                .HasColumnName("CRDate");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Crno)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CRNo");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Denomination)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.EngineNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Fuel)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Make)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Mvfile)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("MVFile");
            entity.Property(e => e.Owner)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OwnersAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PlateNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Series)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TransmissionType).HasMaxLength(50);

            entity.HasOne(d => d.DriverNavigation).WithMany(p => p.VehicleDetails)
                .HasForeignKey(d => d.Driver)
                .HasConstraintName("FK_VehicleDetails_Employees");

            entity.HasOne(d => d.Office).WithMany(p => p.VehicleDetails)
                .HasForeignKey(d => d.OfficeId)
                .HasConstraintName("FK_VehicleDetails_Offices");
        });

        modelBuilder.Entity<VlEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vl_employees");

            entity.Property(e => e.EmployeeName).HasMaxLength(260);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VlObr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vl_obr");

            entity.Property(e => e.BudgetControlNo).HasMaxLength(128);
            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Pa).HasColumnName("PA");
            entity.Property(e => e.Papos).HasColumnName("PAPos");
            entity.Property(e => e.TableName).HasMaxLength(128);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
        });

        modelBuilder.Entity<VlYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vl_year");

            entity.Property(e => e.Accountant).HasMaxLength(128);
            entity.Property(e => e.AccountantPos).HasMaxLength(128);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BudgetControlNo).HasMaxLength(100);
            entity.Property(e => e.Chief).HasMaxLength(100);
            entity.Property(e => e.ChiefPosition).HasMaxLength(255);
            entity.Property(e => e.ControlNo).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.Date).HasPrecision(0);
            entity.Property(e => e.DateClosed).HasPrecision(0);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Dmsno)
                .HasMaxLength(100)
                .HasColumnName("DMSNo");
            entity.Property(e => e.Dvamount)
                .HasColumnType("money")
                .HasColumnName("DVAmount");
            entity.Property(e => e.DvapprovedBy)
                .HasMaxLength(100)
                .HasColumnName("DVApprovedBy");
            entity.Property(e => e.DvapprovedByPosition)
                .HasMaxLength(100)
                .HasColumnName("DVApprovedByPosition");
            entity.Property(e => e.Dvnote)
                .HasMaxLength(255)
                .HasColumnName("DVNote");
            entity.Property(e => e.Dvparticular).HasColumnName("DVParticular");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);
            entity.Property(e => e.ObrapprovedBy)
                .HasMaxLength(128)
                .HasColumnName("OBRApprovedBy");
            entity.Property(e => e.ObrapprovedByPos)
                .HasMaxLength(128)
                .HasColumnName("OBRApprovedByPos");
            entity.Property(e => e.PayeeAddress).HasMaxLength(255);
            entity.Property(e => e.PayeeOffice).HasMaxLength(255);
            entity.Property(e => e.Pbo)
                .HasMaxLength(100)
                .HasColumnName("PBO");
            entity.Property(e => e.Pbopos)
                .HasMaxLength(100)
                .HasColumnName("PBOPos");
            entity.Property(e => e.Poid).HasColumnName("POId");
            entity.Property(e => e.Prno).HasColumnName("PRNo");
            entity.Property(e => e.ResponsibilityCenter).HasMaxLength(50);
            entity.Property(e => e.ResponsibilityCenterCode).HasMaxLength(50);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.TotalAdjustedAmount).HasColumnType("money");
            entity.Property(e => e.Treasurer).HasMaxLength(128);
            entity.Property(e => e.TreasurerPos).HasMaxLength(128);
        });

        modelBuilder.Entity<WasteCategory>(entity =>
        {
            entity.ToTable("WasteCategory");

            entity.Property(e => e.Category).HasMaxLength(128);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<WasteMaterial>(entity =>
        {
            entity.ToTable("WasteMaterial");

            entity.Property(e => e.ControlNo).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Ft)
                .HasMaxLength(50)
                .HasColumnName("FT");
            entity.Property(e => e.Fund).HasMaxLength(128);
            entity.Property(e => e.PgsocertifiedId).HasColumnName("PGSOCertifiedId");
            entity.Property(e => e.PlaceOfStorage).HasMaxLength(256);
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.Approved).WithMany(p => p.WasteMaterials)
                .HasForeignKey(d => d.ApprovedId)
                .HasConstraintName("FK_WasteMaterial_Signatories");

            entity.HasOne(d => d.Certified).WithMany(p => p.WasteMaterialCertifieds)
                .HasForeignKey(d => d.CertifiedId)
                .HasConstraintName("FK_WasteMaterial_Employees");

            entity.HasOne(d => d.Office).WithMany(p => p.WasteMaterials)
                .HasForeignKey(d => d.OfficeId)
                .HasConstraintName("FK_WasteMaterial_Offices");

            entity.HasOne(d => d.Pgsocertified).WithMany(p => p.WasteMaterialPgsocertifieds)
                .HasForeignKey(d => d.PgsocertifiedId)
                .HasConstraintName("FK_WasteMaterial_WasteMaterial");
        });

        modelBuilder.Entity<WasteMaterialDetail>(entity =>
        {
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Category).HasMaxLength(128);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.No).HasMaxLength(128);
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(50);

            entity.HasOne(d => d.WasteMaterial).WithMany(p => p.WasteMaterialDetails)
                .HasForeignKey(d => d.WasteMaterialId)
                .HasConstraintName("FK_WasteMaterialDetails_WasteMaterial");
        });

        modelBuilder.Entity<Year>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Year");

            entity.HasIndex(e => new { e.Year1, e.OfficeId }, "Years").IsUnique();

            entity.Property(e => e.Year1).HasColumnName("Year");

            entity.HasOne(d => d.Office).WithMany(p => p.Years)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Years_Offices");
        });

        modelBuilder.Entity<_1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("1");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

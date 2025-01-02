using System;
using System.Collections.Generic;
using EPiSv3NetworkFolder.DbModels;
using Microsoft.EntityFrameworkCore;
using Action = EPiSv3NetworkFolder.DbModels.Action;

namespace EPiSv3NetworkFolder.Context;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Action> Actions { get; set; }

    public virtual DbSet<ActionTaken> ActionTakens { get; set; }

    public virtual DbSet<ActionsDropdown> ActionsDropdowns { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<ChangeLog> ChangeLogs { get; set; }

    public virtual DbSet<ComparisonReport> ComparisonReports { get; set; }

    public virtual DbSet<ComparisonReportSpec> ComparisonReportSpecs { get; set; }

    public virtual DbSet<ComparisonReportSpecsDetail> ComparisonReportSpecsDetails { get; set; }

    public virtual DbSet<CustomerActionSheet> CustomerActionSheets { get; set; }

    public virtual DbSet<DeliveriesSpec> DeliveriesSpecs { get; set; }

    public virtual DbSet<DeliveriesSpecsDetail> DeliveriesSpecsDetails { get; set; }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<Equipment> Equipments { get; set; }

    public virtual DbSet<EquipmentSpec> EquipmentSpecs { get; set; }

    public virtual DbSet<EquipmentSpecsDetail> EquipmentSpecsDetails { get; set; }

    public virtual DbSet<Itstaff> Itstaffs { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<Moaccount> Moaccounts { get; set; }

    public virtual DbSet<MoaccountUser> MoaccountUsers { get; set; }

    public virtual DbSet<Model> Models { get; set; }

    public virtual DbSet<Pgnaccount> Pgnaccounts { get; set; }

    public virtual DbSet<Pgndocument> Pgndocuments { get; set; }

    public virtual DbSet<PgngroupOffice> PgngroupOffices { get; set; }

    public virtual DbSet<PgnmacAddress> PgnmacAddresses { get; set; }

    public virtual DbSet<PgnnonEmployee> PgnnonEmployees { get; set; }

    public virtual DbSet<Pgnrequest> Pgnrequests { get; set; }

    public virtual DbSet<Ppe> Ppes { get; set; }

    public virtual DbSet<PpesSpec> PpesSpecs { get; set; }

    public virtual DbSet<PpesSpecsDetail> PpesSpecsDetails { get; set; }

    public virtual DbSet<PrstandardPrspec> PrstandardPrspecs { get; set; }

    public virtual DbSet<PurchaseRequest> PurchaseRequests { get; set; }

    public virtual DbSet<Repair> Repairs { get; set; }

    public virtual DbSet<RoleDesignation> RoleDesignations { get; set; }

    public virtual DbSet<StandardPrspec> StandardPrspecs { get; set; }

    public virtual DbSet<StandardPrspecsDetail> StandardPrspecsDetails { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<TechSpec> TechSpecs { get; set; }

    public virtual DbSet<TechSpecsBasis> TechSpecsBases { get; set; }

    public virtual DbSet<TechSpecsIctspec> TechSpecsIctspecs { get; set; }

    public virtual DbSet<TechSpecsIctspecsDetail> TechSpecsIctspecsDetails { get; set; }

    public virtual DbSet<TicketRequest> TicketRequests { get; set; }

    public virtual DbSet<TicketRequestStatus> TicketRequestStatuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Server=172.17.16.14;Database=ICTV3;User Id=sa;Password=Welcome99;MultipleActiveResultSets=true;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Action>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Actions");

            entity.HasIndex(e => e.ActionsDropdownsId, "IX_ActionsDropdowns_Id");

            entity.HasIndex(e => e.ActionsDropdownsId1, "IX_ActionsDropdowns_Id1");

            entity.HasIndex(e => e.ActionsDropdownsId2, "IX_ActionsDropdowns_Id2");

            entity.HasIndex(e => e.ActionsDropdownsId3, "IX_ActionsDropdowns_Id3");

            entity.HasIndex(e => e.ActivityId, "IX_ActivityId");

            entity.HasIndex(e => e.CreatedById, "IX_CreatedById");

            entity.HasIndex(e => e.CustomerActionSheetId, "IX_CustomerActionSheetId");

            entity.HasIndex(e => e.DeliveriesId, "IX_DeliveriesId");

            entity.HasIndex(e => e.MoaccountUserId, "IX_MOAccountUserId");

            entity.HasIndex(e => e.MainActId, "IX_MainActId");

            entity.HasIndex(e => e.PgnrequestId, "IX_PGNRequestId");

            entity.HasIndex(e => e.ProgramId, "IX_ProgramId");

            entity.HasIndex(e => e.PurchaseRequestId, "IX_PurchaseRequestId");

            entity.HasIndex(e => e.RepairId, "IX_RepairId");

            entity.HasIndex(e => e.SubActivityId, "IX_SubActivityId");

            entity.HasIndex(e => e.TechSpecsId, "IX_TechSpecsId");

            entity.Property(e => e.ActionDate).HasColumnType("datetime");
            entity.Property(e => e.ActionsDropdownsId).HasColumnName("ActionsDropdowns_Id");
            entity.Property(e => e.ActionsDropdownsId1).HasColumnName("ActionsDropdowns_Id1");
            entity.Property(e => e.ActionsDropdownsId2).HasColumnName("ActionsDropdowns_Id2");
            entity.Property(e => e.ActionsDropdownsId3).HasColumnName("ActionsDropdowns_Id3");
            entity.Property(e => e.CreatedById).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.MoaccountUserId).HasColumnName("MOAccountUserId");
            entity.Property(e => e.PgnrequestId).HasColumnName("PGNRequestId");

            entity.HasOne(d => d.ActionsDropdowns).WithMany(p => p.ActionActionsDropdowns)
                .HasForeignKey(d => d.ActionsDropdownsId)
                .HasConstraintName("FK_dbo.Actions_dbo.ActionsDropdowns_ActionsDropdowns_Id");

            entity.HasOne(d => d.ActionsDropdownsId1Navigation).WithMany(p => p.ActionActionsDropdownsId1Navigations)
                .HasForeignKey(d => d.ActionsDropdownsId1)
                .HasConstraintName("FK_dbo.Actions_dbo.ActionsDropdowns_ActionsDropdowns_Id1");

            entity.HasOne(d => d.ActionsDropdownsId2Navigation).WithMany(p => p.ActionActionsDropdownsId2Navigations)
                .HasForeignKey(d => d.ActionsDropdownsId2)
                .HasConstraintName("FK_dbo.Actions_dbo.ActionsDropdowns_ActionsDropdowns_Id2");

            entity.HasOne(d => d.ActionsDropdownsId3Navigation).WithMany(p => p.ActionActionsDropdownsId3Navigations)
                .HasForeignKey(d => d.ActionsDropdownsId3)
                .HasConstraintName("FK_dbo.Actions_dbo.ActionsDropdowns_ActionsDropdowns_Id3");

            entity.HasOne(d => d.Activity).WithMany(p => p.ActionActivities)
                .HasForeignKey(d => d.ActivityId)
                .HasConstraintName("FK_dbo.Actions_dbo.ActionsDropdowns_ActivityId");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.Actions)
                .HasForeignKey(d => d.CreatedById)
                .HasConstraintName("FK_dbo.Actions_dbo.AspNetUsers_CreatedById");

            entity.HasOne(d => d.CustomerActionSheet).WithMany(p => p.Actions)
                .HasForeignKey(d => d.CustomerActionSheetId)
                .HasConstraintName("FK_dbo.Actions_dbo.CustomerActionSheets_CustomerActionSheetId");

            entity.HasOne(d => d.Deliveries).WithMany(p => p.Actions)
                .HasForeignKey(d => d.DeliveriesId)
                .HasConstraintName("FK_dbo.Actions_dbo.Deliveries_DeliveriesId");

            entity.HasOne(d => d.MainAct).WithMany(p => p.ActionMainActs)
                .HasForeignKey(d => d.MainActId)
                .HasConstraintName("FK_dbo.Actions_dbo.ActionsDropdowns_MainActId");

            entity.HasOne(d => d.MoaccountUser).WithMany(p => p.Actions)
                .HasForeignKey(d => d.MoaccountUserId)
                .HasConstraintName("FK_dbo.Actions_dbo.MOAccountUsers_MOAccountUserId");

            entity.HasOne(d => d.Pgnrequest).WithMany(p => p.Actions)
                .HasForeignKey(d => d.PgnrequestId)
                .HasConstraintName("FK_dbo.Actions_dbo.PGNRequests_PGNRequestId");

            entity.HasOne(d => d.Program).WithMany(p => p.ActionPrograms)
                .HasForeignKey(d => d.ProgramId)
                .HasConstraintName("FK_dbo.Actions_dbo.ActionsDropdowns_ProgramId");

            entity.HasOne(d => d.PurchaseRequest).WithMany(p => p.Actions)
                .HasForeignKey(d => d.PurchaseRequestId)
                .HasConstraintName("FK_dbo.Actions_dbo.PurchaseRequests_PurchaseRequestId");

            entity.HasOne(d => d.Repair).WithMany(p => p.Actions)
                .HasForeignKey(d => d.RepairId)
                .HasConstraintName("FK_dbo.Actions_dbo.Repairs_RepairId");

            entity.HasOne(d => d.SubActivity).WithMany(p => p.ActionSubActivities)
                .HasForeignKey(d => d.SubActivityId)
                .HasConstraintName("FK_dbo.Actions_dbo.ActionsDropdowns_SubActivityId");

            entity.HasOne(d => d.TechSpecs).WithMany(p => p.Actions)
                .HasForeignKey(d => d.TechSpecsId)
                .HasConstraintName("FK_dbo.Actions_dbo.TechSpecs_TechSpecsId");
        });

        modelBuilder.Entity<ActionTaken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ActionTakens");

            entity.Property(e => e.DateAdded).HasColumnType("datetime");
        });

        modelBuilder.Entity<ActionsDropdown>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ActionsDropdowns");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

            entity.HasIndex(e => e.Name, "RoleNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Discriminator).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.HasIndex(e => e.UserName, "UserNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.ActionsNavigation).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UsersAction",
                    r => r.HasOne<Action>().WithMany()
                        .HasForeignKey("ActionsId")
                        .HasConstraintName("FK_dbo.UsersActions_dbo.Actions_Actions_Id"),
                    l => l.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UsersId")
                        .HasConstraintName("FK_dbo.UsersActions_dbo.AspNetUsers_Users_Id"),
                    j =>
                    {
                        j.HasKey("UsersId", "ActionsId").HasName("PK_dbo.UsersActions");
                        j.ToTable("UsersActions");
                        j.HasIndex(new[] { "ActionsId" }, "IX_Actions_Id");
                        j.HasIndex(new[] { "UsersId" }, "IX_Users_Id");
                        j.IndexerProperty<string>("UsersId")
                            .HasMaxLength(128)
                            .HasColumnName("Users_Id");
                        j.IndexerProperty<int>("ActionsId").HasColumnName("Actions_Id");
                    });

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_RoleId");
                        j.HasIndex(new[] { "UserId" }, "IX_UserId");
                        j.IndexerProperty<string>("UserId").HasMaxLength(128);
                        j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Brands");

            entity.HasIndex(e => e.EquipmenSpecsId, "IX_EquipmenSpecsId");

            entity.HasOne(d => d.EquipmenSpecs).WithMany(p => p.Brands)
                .HasForeignKey(d => d.EquipmenSpecsId)
                .HasConstraintName("FK_dbo.Brands_dbo.EquipmentSpecs_EquipmenSpecsId");
        });

        modelBuilder.Entity<ChangeLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ChangeLogs");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.ChangeLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.ChangeLogs_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<ComparisonReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ComparisonReports");

            entity.HasIndex(e => e.DeliveryId, "IX_DeliveryId");

            entity.HasIndex(e => e.NotedById, "IX_NotedById");

            entity.HasIndex(e => e.PreparedById, "IX_PreparedById");

            entity.HasIndex(e => e.ReviewedById, "IX_ReviewedById");

            entity.HasIndex(e => e.UsersId, "IX_Users_Id");

            entity.HasIndex(e => e.UsersId1, "IX_Users_Id1");

            entity.HasIndex(e => e.UsersId2, "IX_Users_Id2");

            entity.Property(e => e.NotedById).HasMaxLength(128);
            entity.Property(e => e.PreparedById).HasMaxLength(128);
            entity.Property(e => e.ReviewedById).HasMaxLength(128);
            entity.Property(e => e.UsersId)
                .HasMaxLength(128)
                .HasColumnName("Users_Id");
            entity.Property(e => e.UsersId1)
                .HasMaxLength(128)
                .HasColumnName("Users_Id1");
            entity.Property(e => e.UsersId2)
                .HasMaxLength(128)
                .HasColumnName("Users_Id2");

            entity.HasOne(d => d.Delivery).WithMany(p => p.ComparisonReports)
                .HasForeignKey(d => d.DeliveryId)
                .HasConstraintName("FK_dbo.ComparisonReports_dbo.Deliveries_DeliveryId");

            entity.HasOne(d => d.NotedBy).WithMany(p => p.ComparisonReportNotedBies)
                .HasForeignKey(d => d.NotedById)
                .HasConstraintName("FK_dbo.ComparisonReports_dbo.AspNetUsers_NotedById");

            entity.HasOne(d => d.PreparedBy).WithMany(p => p.ComparisonReportPreparedBies)
                .HasForeignKey(d => d.PreparedById)
                .HasConstraintName("FK_dbo.ComparisonReports_dbo.AspNetUsers_PreparedById");

            entity.HasOne(d => d.ReviewedBy).WithMany(p => p.ComparisonReportReviewedBies)
                .HasForeignKey(d => d.ReviewedById)
                .HasConstraintName("FK_dbo.ComparisonReports_dbo.AspNetUsers_ReviewedById");

            entity.HasOne(d => d.Users).WithMany(p => p.ComparisonReportUsers)
                .HasForeignKey(d => d.UsersId)
                .HasConstraintName("FK_dbo.ComparisonReports_dbo.AspNetUsers_Users_Id");

            entity.HasOne(d => d.UsersId1Navigation).WithMany(p => p.ComparisonReportUsersId1Navigations)
                .HasForeignKey(d => d.UsersId1)
                .HasConstraintName("FK_dbo.ComparisonReports_dbo.AspNetUsers_Users_Id1");

            entity.HasOne(d => d.UsersId2Navigation).WithMany(p => p.ComparisonReportUsersId2Navigations)
                .HasForeignKey(d => d.UsersId2)
                .HasConstraintName("FK_dbo.ComparisonReports_dbo.AspNetUsers_Users_Id2");
        });

        modelBuilder.Entity<ComparisonReportSpec>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ComparisonReportSpecs");

            entity.HasIndex(e => e.ComparisonReportId, "IX_ComparisonReportId");

            entity.Property(e => e.Po).HasColumnName("PO");
            entity.Property(e => e.Pr).HasColumnName("PR");

            entity.HasOne(d => d.ComparisonReport).WithMany(p => p.ComparisonReportSpecs)
                .HasForeignKey(d => d.ComparisonReportId)
                .HasConstraintName("FK_dbo.ComparisonReportSpecs_dbo.ComparisonReports_ComparisonReportId");
        });

        modelBuilder.Entity<ComparisonReportSpecsDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ComparisonReportSpecsDetails");

            entity.HasIndex(e => e.ComparisonReportSpecsId, "IX_ComparisonReportSpecsId");

            entity.Property(e => e.Po).HasColumnName("PO");
            entity.Property(e => e.Pr).HasColumnName("PR");

            entity.HasOne(d => d.ComparisonReportSpecs).WithMany(p => p.ComparisonReportSpecsDetails)
                .HasForeignKey(d => d.ComparisonReportSpecsId)
                .HasConstraintName("FK_dbo.ComparisonReportSpecsDetails_dbo.ComparisonReportSpecs_ComparisonReportSpecsId");
        });

        modelBuilder.Entity<CustomerActionSheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CustomerActionSheets");

            entity.HasIndex(e => e.AssistedById, "IX_AssistedById");

            entity.Property(e => e.AssistedById).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.HasOne(d => d.AssistedBy).WithMany(p => p.CustomerActionSheets)
                .HasForeignKey(d => d.AssistedById)
                .HasConstraintName("FK_dbo.CustomerActionSheets_dbo.AspNetUsers_AssistedById");
        });

        modelBuilder.Entity<DeliveriesSpec>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.DeliveriesSpecs");

            entity.HasIndex(e => e.DeliveriesId, "IX_DeliveriesId");

            entity.HasIndex(e => e.ModelId, "IX_ModelId");

            entity.HasOne(d => d.Deliveries).WithMany(p => p.DeliveriesSpecs)
                .HasForeignKey(d => d.DeliveriesId)
                .HasConstraintName("FK_dbo.DeliveriesSpecs_dbo.Deliveries_DeliveriesId");

            entity.HasOne(d => d.Model).WithMany(p => p.DeliveriesSpecs)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("FK_dbo.DeliveriesSpecs_dbo.Models_ModelId");
        });

        modelBuilder.Entity<DeliveriesSpecsDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.DeliveriesSpecsDetails");

            entity.HasIndex(e => e.DeliveriesSpecsId, "IX_DeliveriesSpecsId");

            entity.HasOne(d => d.DeliveriesSpecs).WithMany(p => p.DeliveriesSpecsDetails)
                .HasForeignKey(d => d.DeliveriesSpecsId)
                .HasConstraintName("FK_dbo.DeliveriesSpecsDetails_dbo.DeliveriesSpecs_DeliveriesSpecsId");
        });

        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Deliveries");

            entity.HasIndex(e => e.Id, "IX_Id");

            entity.HasIndex(e => e.SupplierId, "IX_SupplierId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateRequested).HasColumnType("datetime");
            entity.Property(e => e.DeliveredDate).HasColumnType("datetime");
            entity.Property(e => e.Pono).HasColumnName("PONo");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Delivery)
                .HasForeignKey<Delivery>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Deliveries_dbo.TicketRequests_Id");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_dbo.Deliveries_dbo.Suppliers_SupplierId");
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Equipments");
        });

        modelBuilder.Entity<EquipmentSpec>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.EquipmentSpecs");

            entity.HasIndex(e => e.EquipmentId, "IX_EquipmentId");

            entity.HasOne(d => d.Equipment).WithMany(p => p.EquipmentSpecs)
                .HasForeignKey(d => d.EquipmentId)
                .HasConstraintName("FK_dbo.EquipmentSpecs_dbo.Equipments_EquipmentId");
        });

        modelBuilder.Entity<EquipmentSpecsDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.EquipmentSpecsDetails");

            entity.HasIndex(e => e.EquipmentSpecsId, "IX_EquipmentSpecsId");

            entity.HasOne(d => d.EquipmentSpecs).WithMany(p => p.EquipmentSpecsDetails)
                .HasForeignKey(d => d.EquipmentSpecsId)
                .HasConstraintName("FK_dbo.EquipmentSpecsDetails_dbo.EquipmentSpecs_EquipmentSpecsId");
        });

        modelBuilder.Entity<Itstaff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ITStaffs");

            entity.ToTable("ITStaffs");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.Itstaffs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.ITStaffs_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Moaccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.MOAccounts");

            entity.ToTable("MOAccounts");

            entity.HasIndex(e => e.CreatedById, "IX_CreatedById");

            entity.HasIndex(e => e.OfficeId, "IX_OfficeId");

            entity.Property(e => e.CreatedById).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.Moaccounts)
                .HasForeignKey(d => d.CreatedById)
                .HasConstraintName("FK_dbo.MOAccounts_dbo.AspNetUsers_CreatedById");

            entity.HasOne(d => d.Office).WithMany(p => p.Moaccounts)
                .HasForeignKey(d => d.OfficeId)
                .HasConstraintName("FK_dbo.MOAccounts_dbo.PGNGroupOffices_OfficeId");
        });

        modelBuilder.Entity<MoaccountUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.MOAccountUsers");

            entity.ToTable("MOAccountUsers");

            entity.HasIndex(e => e.CreatedById, "IX_CreatedById");

            entity.HasIndex(e => e.MoaccountId, "IX_MOAccountId");

            entity.HasIndex(e => e.Ppeid, "IX_PPEId");

            entity.Property(e => e.CreatedById).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateOfInstallation).HasColumnType("datetime");
            entity.Property(e => e.MoaccountId).HasColumnName("MOAccountId");
            entity.Property(e => e.Ppeid).HasColumnName("PPEId");
            entity.Property(e => e.ProcuredDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.MoaccountUsers)
                .HasForeignKey(d => d.CreatedById)
                .HasConstraintName("FK_dbo.MOAccountUsers_dbo.AspNetUsers_CreatedById");

            entity.HasOne(d => d.Moaccount).WithMany(p => p.MoaccountUsers)
                .HasForeignKey(d => d.MoaccountId)
                .HasConstraintName("FK_dbo.MOAccountUsers_dbo.MOAccounts_MOAccountId");

            entity.HasOne(d => d.Ppe).WithMany(p => p.MoaccountUsers)
                .HasForeignKey(d => d.Ppeid)
                .HasConstraintName("FK_dbo.MOAccountUsers_dbo.PPEs_PPEId");
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Models");

            entity.HasIndex(e => e.BrandId, "IX_BrandId");

            entity.HasOne(d => d.Brand).WithMany(p => p.Models)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK_dbo.Models_dbo.Brands_BrandId");
        });

        modelBuilder.Entity<Pgnaccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PGNAccounts");

            entity.ToTable("PGNAccounts");

            entity.HasIndex(e => e.PgngroupOfficesId, "IX_PGNGroupOfficesId");

            entity.HasIndex(e => e.PgnnonEmployeeId, "IX_PGNNonEmployeeId");

            entity.HasIndex(e => e.PgnrequestId, "IX_PGNRequestId");

            entity.Property(e => e.HrmisempId).HasColumnName("HRMISEmpId");
            entity.Property(e => e.PgngroupOfficesId).HasColumnName("PGNGroupOfficesId");
            entity.Property(e => e.PgnnonEmployeeId).HasColumnName("PGNNonEmployeeId");
            entity.Property(e => e.PgnrequestId).HasColumnName("PGNRequestId");

            entity.HasOne(d => d.PgngroupOffices).WithMany(p => p.Pgnaccounts)
                .HasForeignKey(d => d.PgngroupOfficesId)
                .HasConstraintName("FK_dbo.PGNAccounts_dbo.PGNGroupOffices_PGNGroupOfficesId");

            entity.HasOne(d => d.PgnnonEmployee).WithMany(p => p.Pgnaccounts)
                .HasForeignKey(d => d.PgnnonEmployeeId)
                .HasConstraintName("FK_dbo.PGNAccounts_dbo.PGNNonEmployees_PGNNonEmployeeId");

            entity.HasOne(d => d.Pgnrequest).WithMany(p => p.Pgnaccounts)
                .HasForeignKey(d => d.PgnrequestId)
                .HasConstraintName("FK_dbo.PGNAccounts_dbo.PGNRequests_PGNRequestId");
        });

        modelBuilder.Entity<Pgndocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PGNDocuments");

            entity.ToTable("PGNDocuments");

            entity.HasIndex(e => e.PgnrequestId, "IX_PGNRequestId");

            entity.Property(e => e.PgnrequestId).HasColumnName("PGNRequestId");

            entity.HasOne(d => d.Pgnrequest).WithMany(p => p.Pgndocuments)
                .HasForeignKey(d => d.PgnrequestId)
                .HasConstraintName("FK_dbo.PGNDocuments_dbo.PGNRequests_PGNRequestId");
        });

        modelBuilder.Entity<PgngroupOffice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PGNGroupOffices");

            entity.ToTable("PGNGroupOffices");
        });

        modelBuilder.Entity<PgnmacAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PGNMacAddresses");

            entity.ToTable("PGNMacAddresses");

            entity.HasIndex(e => e.PgnaccountId, "IX_PGNAccountId");

            entity.Property(e => e.PgnaccountId).HasColumnName("PGNAccountId");

            entity.HasOne(d => d.Pgnaccount).WithMany(p => p.PgnmacAddresses)
                .HasForeignKey(d => d.PgnaccountId)
                .HasConstraintName("FK_dbo.PGNMacAddresses_dbo.PGNAccounts_PGNAccountId");
        });

        modelBuilder.Entity<PgnnonEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PGNNonEmployees");

            entity.ToTable("PGNNonEmployees");
        });

        modelBuilder.Entity<Pgnrequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PGNRequests");

            entity.ToTable("PGNRequests");

            entity.HasIndex(e => e.CreatedById, "IX_CreatedById");

            entity.Property(e => e.CreatedById).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.Pgnrequests)
                .HasForeignKey(d => d.CreatedById)
                .HasConstraintName("FK_dbo.PGNRequests_dbo.AspNetUsers_CreatedById");
        });

        modelBuilder.Entity<Ppe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PPEs");

            entity.ToTable("PPEs");

            entity.Property(e => e.AquisitionDate).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
        });

        modelBuilder.Entity<PpesSpec>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PPEsSpecs");

            entity.ToTable("PPEsSpecs");

            entity.HasIndex(e => e.ModelId, "IX_ModelId");

            entity.HasIndex(e => e.PpesId, "IX_PPEsId");

            entity.Property(e => e.PpesId).HasColumnName("PPEsId");

            entity.HasOne(d => d.Model).WithMany(p => p.PpesSpecs)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("FK_dbo.PPEsSpecs_dbo.Models_ModelId");

            entity.HasOne(d => d.Ppes).WithMany(p => p.PpesSpecs)
                .HasForeignKey(d => d.PpesId)
                .HasConstraintName("FK_dbo.PPEsSpecs_dbo.PPEs_PPEsId");
        });

        modelBuilder.Entity<PpesSpecsDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PPEsSpecsDetails");

            entity.ToTable("PPEsSpecsDetails");

            entity.HasIndex(e => e.PpesSpecsId, "IX_PPEsSpecsId");

            entity.Property(e => e.PpesSpecsId).HasColumnName("PPEsSpecsId");

            entity.HasOne(d => d.PpesSpecs).WithMany(p => p.PpesSpecsDetails)
                .HasForeignKey(d => d.PpesSpecsId)
                .HasConstraintName("FK_dbo.PPEsSpecsDetails_dbo.PPEsSpecs_PPEsSpecsId");
        });

        modelBuilder.Entity<PrstandardPrspec>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PRStandardPRSpecs");

            entity.ToTable("PRStandardPRSpecs");

            entity.HasIndex(e => e.PurchaseRequestId, "IX_PurchaseRequestId");

            entity.HasIndex(e => e.StandardPrspecsId, "IX_StandardPRSpecsId");

            entity.Property(e => e.StandardPrspecsId).HasColumnName("StandardPRSpecsId");

            entity.HasOne(d => d.PurchaseRequest).WithMany(p => p.PrstandardPrspecs)
                .HasForeignKey(d => d.PurchaseRequestId)
                .HasConstraintName("FK_dbo.PRStandardPRSpecs_dbo.PurchaseRequests_PurchaseRequestId");

            entity.HasOne(d => d.StandardPrspecs).WithMany(p => p.PrstandardPrspecs)
                .HasForeignKey(d => d.StandardPrspecsId)
                .HasConstraintName("FK_dbo.PRStandardPRSpecs_dbo.StandardPRSpecs_StandardPRSpecsId");
        });

        modelBuilder.Entity<PurchaseRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PurchaseRequests");

            entity.HasIndex(e => e.CreatedById, "IX_CreatedById");

            entity.HasIndex(e => e.TechSpecsId, "IX_TechSpecsId");

            entity.Property(e => e.CreatedById).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Prno).HasColumnName("PRNo");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.PurchaseRequests)
                .HasForeignKey(d => d.CreatedById)
                .HasConstraintName("FK_dbo.PurchaseRequests_dbo.AspNetUsers_CreatedById");

            entity.HasOne(d => d.TechSpecs).WithMany(p => p.PurchaseRequests)
                .HasForeignKey(d => d.TechSpecsId)
                .HasConstraintName("FK_dbo.PurchaseRequests_dbo.TechSpecs_TechSpecsId");
        });

        modelBuilder.Entity<Repair>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Repairs");

            entity.HasIndex(e => e.Id, "IX_Id");

            entity.HasIndex(e => e.NotedById, "IX_NotedById");

            entity.HasIndex(e => e.PpespecsId, "IX_PPESpecsId");

            entity.HasIndex(e => e.PpesId, "IX_PPEsId");

            entity.HasIndex(e => e.PreparedById, "IX_PreparedById");

            entity.HasIndex(e => e.ReviewedById, "IX_ReviewedById");

            entity.HasIndex(e => e.TechSpecsId, "IX_TechSpecsId");

            entity.HasIndex(e => e.UsersId, "IX_Users_Id");

            entity.HasIndex(e => e.UsersId1, "IX_Users_Id1");

            entity.HasIndex(e => e.UsersId2, "IX_Users_Id2");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDelivered).HasColumnType("datetime");
            entity.Property(e => e.NotedById).HasMaxLength(128);
            entity.Property(e => e.PpesId).HasColumnName("PPEsId");
            entity.Property(e => e.PpespecsId).HasColumnName("PPESpecsId");
            entity.Property(e => e.PreparedById).HasMaxLength(128);
            entity.Property(e => e.ReviewedById).HasMaxLength(128);
            entity.Property(e => e.UsersId)
                .HasMaxLength(128)
                .HasColumnName("Users_Id");
            entity.Property(e => e.UsersId1)
                .HasMaxLength(128)
                .HasColumnName("Users_Id1");
            entity.Property(e => e.UsersId2)
                .HasMaxLength(128)
                .HasColumnName("Users_Id2");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Repair)
                .HasForeignKey<Repair>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Repairs_dbo.TicketRequests_Id");

            entity.HasOne(d => d.NotedBy).WithMany(p => p.RepairNotedBies)
                .HasForeignKey(d => d.NotedById)
                .HasConstraintName("FK_dbo.Repairs_dbo.AspNetUsers_NotedById");

            entity.HasOne(d => d.Ppes).WithMany(p => p.Repairs)
                .HasForeignKey(d => d.PpesId)
                .HasConstraintName("FK_dbo.Repairs_dbo.PPEs_PPEsId");

            entity.HasOne(d => d.Ppespecs).WithMany(p => p.Repairs)
                .HasForeignKey(d => d.PpespecsId)
                .HasConstraintName("FK_dbo.Repairs_dbo.PPEsSpecs_PPESpecsId");

            entity.HasOne(d => d.PreparedBy).WithMany(p => p.RepairPreparedBies)
                .HasForeignKey(d => d.PreparedById)
                .HasConstraintName("FK_dbo.Repairs_dbo.AspNetUsers_PreparedById");

            entity.HasOne(d => d.ReviewedBy).WithMany(p => p.RepairReviewedBies)
                .HasForeignKey(d => d.ReviewedById)
                .HasConstraintName("FK_dbo.Repairs_dbo.AspNetUsers_ReviewedById");

            entity.HasOne(d => d.TechSpecs).WithMany(p => p.Repairs)
                .HasForeignKey(d => d.TechSpecsId)
                .HasConstraintName("FK_dbo.Repairs_dbo.TechSpecs_TechSpecsId");

            entity.HasOne(d => d.Users).WithMany(p => p.RepairUsers)
                .HasForeignKey(d => d.UsersId)
                .HasConstraintName("FK_dbo.Repairs_dbo.AspNetUsers_Users_Id");

            entity.HasOne(d => d.UsersId1Navigation).WithMany(p => p.RepairUsersId1Navigations)
                .HasForeignKey(d => d.UsersId1)
                .HasConstraintName("FK_dbo.Repairs_dbo.AspNetUsers_Users_Id1");

            entity.HasOne(d => d.UsersId2Navigation).WithMany(p => p.RepairUsersId2Navigations)
                .HasForeignKey(d => d.UsersId2)
                .HasConstraintName("FK_dbo.Repairs_dbo.AspNetUsers_Users_Id2");
        });

        modelBuilder.Entity<RoleDesignation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RoleDesignations");

            entity.HasIndex(e => e.RoleId, "IX_RoleId");

            entity.Property(e => e.RoleId).HasMaxLength(128);

            entity.HasOne(d => d.Role).WithMany(p => p.RoleDesignations)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_dbo.RoleDesignations_dbo.AspNetRoles_RoleId");
        });

        modelBuilder.Entity<StandardPrspec>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.StandardPRSpecs");

            entity.ToTable("StandardPRSpecs");

            entity.HasIndex(e => e.EquipmentSpecsId, "IX_EquipmentSpecsId");

            entity.HasOne(d => d.EquipmentSpecs).WithMany(p => p.StandardPrspecs)
                .HasForeignKey(d => d.EquipmentSpecsId)
                .HasConstraintName("FK_dbo.StandardPRSpecs_dbo.EquipmentSpecs_EquipmentSpecsId");
        });

        modelBuilder.Entity<StandardPrspecsDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.StandardPRSpecsDetails");

            entity.ToTable("StandardPRSpecsDetails");

            entity.HasIndex(e => e.StandardPrspecsId, "IX_StandardPRSpecsId");

            entity.Property(e => e.StandardPrspecsId).HasColumnName("StandardPRSpecsId");

            entity.HasOne(d => d.StandardPrspecs).WithMany(p => p.StandardPrspecsDetails)
                .HasForeignKey(d => d.StandardPrspecsId)
                .HasConstraintName("FK_dbo.StandardPRSpecsDetails_dbo.StandardPRSpecs_StandardPRSpecsId");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Suppliers");
        });

        modelBuilder.Entity<TechSpec>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TechSpecs");

            entity.HasIndex(e => e.Id, "IX_Id");

            entity.HasIndex(e => e.NotedById, "IX_NotedById");

            entity.HasIndex(e => e.PreparedById, "IX_PreparedById");

            entity.HasIndex(e => e.ReviewedById, "IX_ReviewedById");

            entity.HasIndex(e => e.UsersId, "IX_Users_Id");

            entity.HasIndex(e => e.UsersId1, "IX_Users_Id1");

            entity.HasIndex(e => e.UsersId2, "IX_Users_Id2");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateAccepted).HasColumnType("datetime");
            entity.Property(e => e.DateRequested).HasColumnType("datetime");
            entity.Property(e => e.NotedById).HasMaxLength(128);
            entity.Property(e => e.PreparedById).HasMaxLength(128);
            entity.Property(e => e.RequestBasedApprovedAip).HasColumnName("RequestBasedApprovedAIP");
            entity.Property(e => e.RequestBasedApprovedApp).HasColumnName("RequestBasedApprovedAPP");
            entity.Property(e => e.RequestBasedApprovedPpmp).HasColumnName("RequestBasedApprovedPPMP");
            entity.Property(e => e.RequestBasedApprovedPr).HasColumnName("RequestBasedApprovedPR");
            entity.Property(e => e.ReviewedById).HasMaxLength(128);
            entity.Property(e => e.UsersId)
                .HasMaxLength(128)
                .HasColumnName("Users_Id");
            entity.Property(e => e.UsersId1)
                .HasMaxLength(128)
                .HasColumnName("Users_Id1");
            entity.Property(e => e.UsersId2)
                .HasMaxLength(128)
                .HasColumnName("Users_Id2");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.TechSpec)
                .HasForeignKey<TechSpec>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.TechSpecs_dbo.TicketRequests_Id");

            entity.HasOne(d => d.NotedBy).WithMany(p => p.TechSpecNotedBies)
                .HasForeignKey(d => d.NotedById)
                .HasConstraintName("FK_dbo.TechSpecs_dbo.AspNetUsers_NotedById");

            entity.HasOne(d => d.PreparedBy).WithMany(p => p.TechSpecPreparedBies)
                .HasForeignKey(d => d.PreparedById)
                .HasConstraintName("FK_dbo.TechSpecs_dbo.AspNetUsers_PreparedById");

            entity.HasOne(d => d.ReviewedBy).WithMany(p => p.TechSpecReviewedBies)
                .HasForeignKey(d => d.ReviewedById)
                .HasConstraintName("FK_dbo.TechSpecs_dbo.AspNetUsers_ReviewedById");

            entity.HasOne(d => d.Users).WithMany(p => p.TechSpecUsers)
                .HasForeignKey(d => d.UsersId)
                .HasConstraintName("FK_dbo.TechSpecs_dbo.AspNetUsers_Users_Id");

            entity.HasOne(d => d.UsersId1Navigation).WithMany(p => p.TechSpecUsersId1Navigations)
                .HasForeignKey(d => d.UsersId1)
                .HasConstraintName("FK_dbo.TechSpecs_dbo.AspNetUsers_Users_Id1");

            entity.HasOne(d => d.UsersId2Navigation).WithMany(p => p.TechSpecUsersId2Navigations)
                .HasForeignKey(d => d.UsersId2)
                .HasConstraintName("FK_dbo.TechSpecs_dbo.AspNetUsers_Users_Id2");
        });

        modelBuilder.Entity<TechSpecsBasis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TechSpecsBasis");

            entity.ToTable("TechSpecsBasis");

            entity.HasIndex(e => e.EquipmentSpecsId, "IX_EquipmentSpecsId");

            entity.Property(e => e.PriceDate).HasColumnType("datetime");
            entity.Property(e => e.Urlbasis).HasColumnName("URLBasis");

            entity.HasOne(d => d.EquipmentSpecs).WithMany(p => p.TechSpecsBases)
                .HasForeignKey(d => d.EquipmentSpecsId)
                .HasConstraintName("FK_dbo.TechSpecsBasis_dbo.EquipmentSpecs_EquipmentSpecsId");
        });

        modelBuilder.Entity<TechSpecsIctspec>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TechSpecsICTSpecs");

            entity.ToTable("TechSpecsICTSpecs");

            entity.HasIndex(e => e.EquipmentSpecsId, "IX_EquipmentSpecsId");

            entity.HasIndex(e => e.TechSpecsId, "IX_TechSpecsId");

            entity.Property(e => e.TechSpecsIctspecsDetailsId).HasColumnName("TechSpecsICTSpecsDetailsId");

            entity.HasOne(d => d.EquipmentSpecs).WithMany(p => p.TechSpecsIctspecs)
                .HasForeignKey(d => d.EquipmentSpecsId)
                .HasConstraintName("FK_dbo.TechSpecsICTSpecs_dbo.EquipmentSpecs_EquipmentSpecsId");

            entity.HasOne(d => d.TechSpecs).WithMany(p => p.TechSpecsIctspecs)
                .HasForeignKey(d => d.TechSpecsId)
                .HasConstraintName("FK_dbo.TechSpecsICTSpecs_dbo.TechSpecs_TechSpecsId");
        });

        modelBuilder.Entity<TechSpecsIctspecsDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TechSpecsICTSpecsDetails");

            entity.ToTable("TechSpecsICTSpecsDetails");

            entity.HasIndex(e => e.TechSpecsIctspecsId, "IX_TechSpecsICTSpecsId");

            entity.Property(e => e.TechSpecsIctspecsId).HasColumnName("TechSpecsICTSpecsId");

            entity.HasOne(d => d.TechSpecsIctspecs).WithMany(p => p.TechSpecsIctspecsDetails)
                .HasForeignKey(d => d.TechSpecsIctspecsId)
                .HasConstraintName("FK_dbo.TechSpecsICTSpecsDetails_dbo.TechSpecsICTSpecs_TechSpecsICTSpecsId");
        });

        modelBuilder.Entity<TicketRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TicketRequests");

            entity.HasIndex(e => e.CreatedBy, "IX_CreatedBy");

            entity.HasIndex(e => e.StaffId, "IX_StaffId");

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TicketRequests)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_dbo.TicketRequests_dbo.AspNetUsers_CreatedBy");

            entity.HasOne(d => d.Staff).WithMany(p => p.TicketRequests)
                .HasForeignKey(d => d.StaffId)
                .HasConstraintName("FK_dbo.TicketRequests_dbo.ITStaffs_StaffId");
        });

        modelBuilder.Entity<TicketRequestStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TicketRequestStatus");

            entity.ToTable("TicketRequestStatus");

            entity.HasIndex(e => e.ChangedByUserId, "IX_ChangedByUserId");

            entity.HasIndex(e => e.TicketRequestId, "IX_TicketRequestId");

            entity.Property(e => e.ChangedByUserId).HasMaxLength(128);
            entity.Property(e => e.DateStatusChanged).HasColumnType("datetime");

            entity.HasOne(d => d.ChangedByUser).WithMany(p => p.TicketRequestStatuses)
                .HasForeignKey(d => d.ChangedByUserId)
                .HasConstraintName("FK_dbo.TicketRequestStatus_dbo.AspNetUsers_ChangedByUserId");

            entity.HasOne(d => d.TicketRequest).WithMany(p => p.TicketRequestStatuses)
                .HasForeignKey(d => d.TicketRequestId)
                .HasConstraintName("FK_dbo.TicketRequestStatus_dbo.TicketRequests_TicketRequestId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

namespace VerifyNG.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActiveWorkers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        VerifiedAge = c.String(),
                        VerifiedWorkStartDate = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        Gender = c.String(),
                        Nationality = c.String(),
                        DOB = c.DateTime(nullable: false),
                        TelephoneNumber = c.String(),
                        MMaidenName = c.String(),
                        MaritalStatus = c.String(),
                        Address = c.String(),
                        bankVerificationNumber = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                        ActiveWorker_id = c.Int(),
                        BankAccount_id = c.Int(),
                        PersonEducation_id = c.Int(),
                        RetiredWorker_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.ActiveWorkers", t => t.ActiveWorker_id)
                .ForeignKey("dbo.BankAccounts", t => t.BankAccount_id)
                .ForeignKey("dbo.PersonEducations", t => t.PersonEducation_id)
                .ForeignKey("dbo.RetiredWorkers", t => t.RetiredWorker_id)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.ActiveWorker_id)
                .Index(t => t.BankAccount_id)
                .Index(t => t.PersonEducation_id)
                .Index(t => t.RetiredWorker_id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.BankAccounts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        BankName = c.String(),
                        NubanNumber = c.Int(nullable: false),
                        BVNLinked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PersonEducations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        YearStarted = c.DateTime(nullable: false),
                        YearCompleted = c.DateTime(nullable: false),
                        Institution = c.String(),
                        Qualification = c.String(),
                        DegreeTitle = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PersonWorkExperiences",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        JobTitle = c.String(),
                        Function = c.String(),
                        EmploymentType = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.RetiredWorkers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        VerifiedAge = c.String(),
                        VerifiedWorkStartDate = c.String(),
                        VerifiedWorkEndDate = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.People", "RetiredWorker_id", "dbo.RetiredWorkers");
            DropForeignKey("dbo.People", "PersonEducation_id", "dbo.PersonEducations");
            DropForeignKey("dbo.People", "BankAccount_id", "dbo.BankAccounts");
            DropForeignKey("dbo.People", "ActiveWorker_id", "dbo.ActiveWorkers");
            DropForeignKey("dbo.People", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.People", new[] { "RetiredWorker_id" });
            DropIndex("dbo.People", new[] { "PersonEducation_id" });
            DropIndex("dbo.People", new[] { "BankAccount_id" });
            DropIndex("dbo.People", new[] { "ActiveWorker_id" });
            DropIndex("dbo.People", new[] { "ApplicationUser_Id" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.RetiredWorkers");
            DropTable("dbo.PersonWorkExperiences");
            DropTable("dbo.PersonEducations");
            DropTable("dbo.BankAccounts");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.People");
            DropTable("dbo.ActiveWorkers");
        }
    }
}

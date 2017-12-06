namespace VerifyNG.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
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
                        ActiveWorker_id = c.Int(),
                        BankAccount_id = c.Int(),
                        PersonEducation_id = c.Int(),
                        RetiredWorker_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ActiveWorkers", t => t.ActiveWorker_id)
                .ForeignKey("dbo.BankAccounts", t => t.BankAccount_id)
                .ForeignKey("dbo.PersonEducations", t => t.PersonEducation_id)
                .ForeignKey("dbo.RetiredWorkers", t => t.RetiredWorker_id)
                .Index(t => t.ActiveWorker_id)
                .Index(t => t.BankAccount_id)
                .Index(t => t.PersonEducation_id)
                .Index(t => t.RetiredWorker_id);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "RetiredWorker_id", "dbo.RetiredWorkers");
            DropForeignKey("dbo.People", "PersonEducation_id", "dbo.PersonEducations");
            DropForeignKey("dbo.People", "BankAccount_id", "dbo.BankAccounts");
            DropForeignKey("dbo.People", "ActiveWorker_id", "dbo.ActiveWorkers");
            DropIndex("dbo.People", new[] { "RetiredWorker_id" });
            DropIndex("dbo.People", new[] { "PersonEducation_id" });
            DropIndex("dbo.People", new[] { "BankAccount_id" });
            DropIndex("dbo.People", new[] { "ActiveWorker_id" });
            DropTable("dbo.RetiredWorkers");
            DropTable("dbo.PersonWorkExperiences");
            DropTable("dbo.PersonEducations");
            DropTable("dbo.BankAccounts");
            DropTable("dbo.People");
            DropTable("dbo.ActiveWorkers");
        }
    }
}

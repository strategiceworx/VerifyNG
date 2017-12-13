namespace VerifyNG.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "PersonTitle", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "PersonTitle", c => c.Int(nullable: false));
        }
    }
}

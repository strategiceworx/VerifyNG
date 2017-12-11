namespace VerifyNG.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "PersonTitle", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "PersonTitle");
        }
    }
}

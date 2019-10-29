namespace VidlyNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class anypending : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Birthdata", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthdata", c => c.DateTime(nullable: false));
        }
    }
}

namespace VidlyNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthdateInCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdata", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdata");
        }
    }
}

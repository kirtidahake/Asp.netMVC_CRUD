namespace Asp.netMVC_CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneNumberToEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "PhoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "PhoneNumber");
        }
    }
}

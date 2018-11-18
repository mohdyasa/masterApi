namespace masterApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeinmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FirstName", c => c.String());
            AddColumn("dbo.Users", "LastName", c => c.String());
            AddColumn("dbo.Users", "Address", c => c.String());
            AddColumn("dbo.Users", "DOB", c => c.String());
            AddColumn("dbo.Users", "Gender", c => c.String());
            AddColumn("dbo.Users", "Country", c => c.String());
            AddColumn("dbo.Users", "State", c => c.String());
            AddColumn("dbo.Users", "City", c => c.String());
            DropColumn("dbo.Users", "Name");
            DropColumn("dbo.Users", "Mobile");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Mobile", c => c.String());
            AddColumn("dbo.Users", "Name", c => c.String());
            DropColumn("dbo.Users", "City");
            DropColumn("dbo.Users", "State");
            DropColumn("dbo.Users", "Country");
            DropColumn("dbo.Users", "Gender");
            DropColumn("dbo.Users", "DOB");
            DropColumn("dbo.Users", "Address");
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "FirstName");
        }
    }
}

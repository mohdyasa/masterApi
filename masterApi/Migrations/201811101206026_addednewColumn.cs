namespace masterApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addednewColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "isDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "isDeleted");
        }
    }
}

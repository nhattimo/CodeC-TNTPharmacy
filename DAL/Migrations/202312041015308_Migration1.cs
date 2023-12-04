namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.USERS", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.USERS", "Point", c => c.String(maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.USERS", "Point");
            DropColumn("dbo.USERS", "DateOfBirth");
        }
    }
}

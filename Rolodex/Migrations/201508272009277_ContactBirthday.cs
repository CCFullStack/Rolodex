namespace Rolodex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactBirthday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "Birthday", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "Birthday");
        }
    }
}

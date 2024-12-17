namespace Food1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoleToUserRole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserRoles", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserRoles", "Role");
        }
    }
}

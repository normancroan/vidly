namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE MembershipTypes Add Name varchar DEFAULT 'Plan'");

        }
        
        public override void Down()
        {
        }
    }
}

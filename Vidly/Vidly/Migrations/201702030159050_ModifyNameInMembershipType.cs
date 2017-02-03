namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyNameInMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE MembershipTypes DROP CONSTRAINT DF__Membership__Name__6E01572D");
            Sql("ALTER TABLE MembershipTypes ALTER COLUMN Name nvarchar(255)");
        }
        
        public override void Down()
        {
        }
    }
}

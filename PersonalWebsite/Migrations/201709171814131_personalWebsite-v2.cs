namespace PersonalWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personalWebsitev2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProjectModels", "projectTitle", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProjectModels", "projectTitle", c => c.String());
        }
    }
}

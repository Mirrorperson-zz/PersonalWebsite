namespace PersonalWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectIconModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectModels", "ProjectIcon", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProjectModels", "ProjectIcon");
        }
    }
}

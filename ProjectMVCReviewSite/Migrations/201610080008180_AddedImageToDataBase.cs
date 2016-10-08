namespace ProjectMVCReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImageToDataBase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Image");
        }
    }
}

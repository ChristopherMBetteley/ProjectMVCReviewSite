namespace ProjectMVCReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageUpload : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reviews", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Image", c => c.Binary());
        }
    }
}

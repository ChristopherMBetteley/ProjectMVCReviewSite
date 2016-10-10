namespace ProjectMVCReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageByteArray : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Image", c => c.Binary());
            DropColumn("dbo.Reviews", "ImageURL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "ImageURL", c => c.String());
            DropColumn("dbo.Reviews", "Image");
        }
    }
}

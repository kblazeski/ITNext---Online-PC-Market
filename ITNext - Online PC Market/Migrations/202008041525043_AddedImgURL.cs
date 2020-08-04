namespace ITNext___Online_PC_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImgURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "ImgURL", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "ImgURL");
        }
    }
}

namespace ITNext___Online_PC_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstShoppingCart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Items", "ApplicationUser_Id");
            AddForeignKey("dbo.Items", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Items", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Items", "ApplicationUser_Id");
        }
    }
}

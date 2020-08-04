namespace ITNext___Online_PC_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedItemsNCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Desc = c.String(nullable: false),
                        Stock = c.Int(nullable: false),
                        TipId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tips", t => t.TipId, cascadeDelete: true)
                .Index(t => t.TipId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "TipId", "dbo.Tips");
            DropIndex("dbo.Items", new[] { "TipId" });
            DropTable("dbo.Items");
            DropTable("dbo.Tips");
        }
    }
}

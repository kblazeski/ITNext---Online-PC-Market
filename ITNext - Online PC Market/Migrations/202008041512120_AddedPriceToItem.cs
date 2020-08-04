namespace ITNext___Online_PC_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPriceToItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Price");
        }
    }
}

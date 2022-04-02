namespace THi_PIIT_DANGVANTIEN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BitCoinDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BitCoins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        baseAsset = c.String(nullable: false),
                        quoteAsset = c.String(nullable: false),
                        lastPrice = c.Double(nullable: false),
                        volumn24h = c.Double(nullable: false),
                        marketId = c.Int(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        updatedAt = c.DateTime(nullable: false),
                        status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        description = c.String(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        updatedAd = c.DateTime(nullable: false),
                        status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Markets");
            DropTable("dbo.BitCoins");
        }
    }
}

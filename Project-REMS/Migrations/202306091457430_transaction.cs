namespace Project_REMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class transaction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        PropertyId = c.Int(nullable: false),
                        AgentId = c.Int(nullable: false),
                        BuyerInfo = c.String(),
                        TransactionType = c.String(),
                        TransactionDate = c.DateTime(nullable: false),
                        TransactionAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.TransactionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transactions");
        }
    }
}

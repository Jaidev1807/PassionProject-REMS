namespace Project_REMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class transactionproperty1m : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "PropertyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Transactions", "PropertyId");
            AddForeignKey("dbo.Transactions", "PropertyId", "dbo.Properties", "PropertyId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "PropertyId", "dbo.Properties");
            DropIndex("dbo.Transactions", new[] { "PropertyId" });
            DropColumn("dbo.Transactions", "PropertyId");
        }
    }
}

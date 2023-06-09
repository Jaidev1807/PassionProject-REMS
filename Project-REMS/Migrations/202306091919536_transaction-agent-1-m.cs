namespace Project_REMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class transactionagent1m : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Transactions", "AgentId");
            AddForeignKey("dbo.Transactions", "AgentId", "dbo.Agents", "AgentId", cascadeDelete: true);
            DropColumn("dbo.Transactions", "PropertyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "PropertyId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Transactions", "AgentId", "dbo.Agents");
            DropIndex("dbo.Transactions", new[] { "AgentId" });
        }
    }
}

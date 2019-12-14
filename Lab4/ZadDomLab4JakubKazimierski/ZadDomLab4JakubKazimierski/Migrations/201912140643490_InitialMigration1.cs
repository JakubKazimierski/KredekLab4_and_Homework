namespace ZadDomLab4JakubKazimierski.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FBIagentsUndercovers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 250),
                        LastName = c.String(nullable: false),
                        AgentCriminalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FBIcriminalsLists", t => t.AgentCriminalId, cascadeDelete: true)
                .Index(t => t.AgentCriminalId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FBIagentsUndercovers", "AgentCriminalId", "dbo.FBIcriminalsLists");
            DropIndex("dbo.FBIagentsUndercovers", new[] { "AgentCriminalId" });
            DropTable("dbo.FBIagentsUndercovers");
        }
    }
}

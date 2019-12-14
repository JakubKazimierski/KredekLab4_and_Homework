namespace ZadDomLab4JakubKazimierski.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FBIagentsLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 250),
                        LastName = c.String(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        AgentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FBIagentsTypes", t => t.AgentTypeId, cascadeDelete: true)
                .Index(t => t.AgentTypeId);
            
            CreateTable(
                "dbo.FBIagentsTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rank = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FBIcriminalsLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 250),
                        LastName = c.String(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        CriminalTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FBIcriminalsTypes", t => t.CriminalTypeId, cascadeDelete: true)
                .Index(t => t.CriminalTypeId);
            
            CreateTable(
                "dbo.FBIcriminalsTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rank = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FBIcriminalsLists", "CriminalTypeId", "dbo.FBIcriminalsTypes");
            DropForeignKey("dbo.FBIagentsLists", "AgentTypeId", "dbo.FBIagentsTypes");
            DropIndex("dbo.FBIcriminalsLists", new[] { "CriminalTypeId" });
            DropIndex("dbo.FBIagentsLists", new[] { "AgentTypeId" });
            DropTable("dbo.FBIcriminalsTypes");
            DropTable("dbo.FBIcriminalsLists");
            DropTable("dbo.FBIagentsTypes");
            DropTable("dbo.FBIagentsLists");
        }
    }
}

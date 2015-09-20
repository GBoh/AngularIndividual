namespace MFTWebFormAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class group : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "Group_Id", "dbo.Groups");
            DropIndex("dbo.AspNetUsers", new[] { "Group_Id" });
            CreateTable(
                "dbo.ApplicationUserGroups",
                c => new
                    {
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                        Group_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ApplicationUser_Id, t.Group_Id })
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.Group_Id, cascadeDelete: true)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.Group_Id);
            
            DropColumn("dbo.AspNetUsers", "Group_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Group_Id", c => c.Int());
            DropForeignKey("dbo.ApplicationUserGroups", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.ApplicationUserGroups", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ApplicationUserGroups", new[] { "Group_Id" });
            DropIndex("dbo.ApplicationUserGroups", new[] { "ApplicationUser_Id" });
            DropTable("dbo.ApplicationUserGroups");
            CreateIndex("dbo.AspNetUsers", "Group_Id");
            AddForeignKey("dbo.AspNetUsers", "Group_Id", "dbo.Groups", "Id");
        }
    }
}

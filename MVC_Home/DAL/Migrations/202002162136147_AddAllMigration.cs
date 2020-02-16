namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAllMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TagArtiсle",
                c => new
                    {
                        Tag_Id = c.Int(nullable: false),
                        Artiсle_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_Id, t.Artiсle_Id })
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .ForeignKey("dbo.Artiсle", t => t.Artiсle_Id, cascadeDelete: true)
                .Index(t => t.Tag_Id)
                .Index(t => t.Artiсle_Id);
        }
        
        public override void Down()
        {
            
            DropForeignKey("dbo.TagArtiсle", "Artiсle_Id", "dbo.Artiсle");
            DropIndex("dbo.TagArtiсle", new[] { "Artiсle_Id" });
            DropIndex("dbo.TagArtiсle", new[] { "Tag_Id" });
            DropTable("dbo.TagArtiсle");
        }
    }
}

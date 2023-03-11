namespace Nguyễn_Hùng_Cường_2011060110.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LecturerID = c.String(),
                        Place = c.String(nullable: false, maxLength: 255),
                        DateTime = c.DateTime(nullable: false),
                        CategoryID = c.Byte(nullable: false),
                        GiangVien_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.GiangVien_Id)
                .Index(t => t.CategoryID)
                .Index(t => t.GiangVien_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "GiangVien_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "GiangVien_Id" });
            DropIndex("dbo.Courses", new[] { "CategoryID" });
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}

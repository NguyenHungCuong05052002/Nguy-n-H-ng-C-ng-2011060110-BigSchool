namespace Nguyễn_Hùng_Cường_2011060110.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES(1,'IT')");
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES(2,'Du Lịch')");
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES(3,'Ô Tô')");
        }
        
        public override void Down()
        {
        }
    }
}

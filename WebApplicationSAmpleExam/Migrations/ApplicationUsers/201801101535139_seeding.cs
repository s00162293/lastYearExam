namespace WebApplicationSAmpleExam.Migrations.ApplicationUsers
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seeding : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "studentId", c => c.String());
            AddColumn("dbo.AspNetUsers", "lecturerId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "lecturerId");
            DropColumn("dbo.AspNetUsers", "studentId");
        }
    }
}

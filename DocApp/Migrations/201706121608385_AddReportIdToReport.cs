namespace DocApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReportIdToReport : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "ReportId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reports", "ReportId");
        }
    }
}

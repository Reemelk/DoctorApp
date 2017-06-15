namespace DocApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 255),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Disease = c.String(nullable: false, maxLength: 150),
                        Treatment = c.String(nullable: false, maxLength: 255),
                        PatientRefId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientRefId, cascadeDelete: true)
                .Index(t => t.PatientRefId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Civility = c.String(maxLength: 3),
                        Lastname = c.String(nullable: false, maxLength: 100),
                        Firstname = c.String(nullable: false, maxLength: 100),
                        DOB = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReportMedicines",
                c => new
                    {
                        Report_Id = c.Int(nullable: false),
                        Medicine_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Report_Id, t.Medicine_Id })
                .ForeignKey("dbo.Reports", t => t.Report_Id, cascadeDelete: true)
                .ForeignKey("dbo.Medicines", t => t.Medicine_Id, cascadeDelete: true)
                .Index(t => t.Report_Id)
                .Index(t => t.Medicine_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reports", "PatientRefId", "dbo.Patients");
            DropForeignKey("dbo.ReportMedicines", "Medicine_Id", "dbo.Medicines");
            DropForeignKey("dbo.ReportMedicines", "Report_Id", "dbo.Reports");
            DropIndex("dbo.ReportMedicines", new[] { "Medicine_Id" });
            DropIndex("dbo.ReportMedicines", new[] { "Report_Id" });
            DropIndex("dbo.Reports", new[] { "PatientRefId" });
            DropTable("dbo.ReportMedicines");
            DropTable("dbo.Patients");
            DropTable("dbo.Reports");
            DropTable("dbo.Medicines");
        }
    }
}

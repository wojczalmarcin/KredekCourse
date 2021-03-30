namespace MarcinWojczalUniveristyFacultyEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(nullable: false, maxLength: 50),
                        City = c.String(nullable: false, maxLength: 50),
                        PostCode = c.String(maxLength: 15),
                        Street = c.String(maxLength: 50),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FieldOfStudies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatronWorkerId = c.Int(),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Workers", t => t.PatronWorkerId)
                .Index(t => t.PatronWorkerId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Sindex = c.Int(nullable: false),
                        FieldOfStudyId = c.Int(nullable: false),
                        StudyVintageIndex = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        BirthDate = c.DateTime(nullable: false),
                        Pesel = c.String(nullable: false, maxLength: 11),
                        AddressId = c.Int(nullable: false),
                        ECTSDeficit = c.Short(nullable: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 15),
                        EMail = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Sindex)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.FieldOfStudies", t => t.FieldOfStudyId, cascadeDelete: true)
                .ForeignKey("dbo.StudyVintages", t => t.StudyVintageIndex, cascadeDelete: true)
                .Index(t => t.FieldOfStudyId)
                .Index(t => t.StudyVintageIndex)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.StudyVintages",
                c => new
                    {
                        VIndex = c.Int(nullable: false),
                        YearPatronSIndex = c.Int(),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VIndex)
                .ForeignKey("dbo.Students", t => t.YearPatronSIndex)
                .Index(t => t.YearPatronSIndex);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FieldOfStudyId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Term = c.Short(nullable: false),
                        ECTS = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FieldOfStudies", t => t.FieldOfStudyId, cascadeDelete: true)
                .Index(t => t.FieldOfStudyId);
            
            CreateTable(
                "dbo.SubjectGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        WorkerId = c.Int(nullable: false),
                        DayOfWeek = c.String(nullable: false, maxLength: 20),
                        Hour = c.String(nullable: false, maxLength: 6),
                        StudentsNumber = c.Int(nullable: false),
                        MaxStudentsNumber = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => t.WorkerId);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        WorkPlaceId = c.Int(nullable: false),
                        Degree = c.String(maxLength: 50),
                        Salary = c.Int(nullable: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 15),
                        EMail = c.String(maxLength: 50),
                        AddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.Workplaces", t => t.WorkPlaceId, cascadeDelete: true)
                .Index(t => t.WorkPlaceId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Workplaces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        BaseSalary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FieldOfStudies", "PatronWorkerId", "dbo.Workers");
            DropForeignKey("dbo.Workers", "WorkPlaceId", "dbo.Workplaces");
            DropForeignKey("dbo.SubjectGroups", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.Workers", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.SubjectGroups", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Subjects", "FieldOfStudyId", "dbo.FieldOfStudies");
            DropForeignKey("dbo.Students", "StudyVintageIndex", "dbo.StudyVintages");
            DropForeignKey("dbo.StudyVintages", "YearPatronSIndex", "dbo.Students");
            DropForeignKey("dbo.Students", "FieldOfStudyId", "dbo.FieldOfStudies");
            DropForeignKey("dbo.Students", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Workers", new[] { "AddressId" });
            DropIndex("dbo.Workers", new[] { "WorkPlaceId" });
            DropIndex("dbo.SubjectGroups", new[] { "WorkerId" });
            DropIndex("dbo.SubjectGroups", new[] { "SubjectId" });
            DropIndex("dbo.Subjects", new[] { "FieldOfStudyId" });
            DropIndex("dbo.StudyVintages", new[] { "YearPatronSIndex" });
            DropIndex("dbo.Students", new[] { "AddressId" });
            DropIndex("dbo.Students", new[] { "StudyVintageIndex" });
            DropIndex("dbo.Students", new[] { "FieldOfStudyId" });
            DropIndex("dbo.FieldOfStudies", new[] { "PatronWorkerId" });
            DropTable("dbo.Users");
            DropTable("dbo.Workplaces");
            DropTable("dbo.Workers");
            DropTable("dbo.SubjectGroups");
            DropTable("dbo.Subjects");
            DropTable("dbo.StudyVintages");
            DropTable("dbo.Students");
            DropTable("dbo.FieldOfStudies");
            DropTable("dbo.Addresses");
        }
    }
}

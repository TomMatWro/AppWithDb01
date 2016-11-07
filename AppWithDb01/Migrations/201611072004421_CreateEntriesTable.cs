namespace AppWithDb01.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateEntriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entries",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    DateTime = c.DateTime(nullable: false),
                    Glucose = c.Int(nullable: false),
                    Note = c.String(),
                    TimeOfMeasurement_Id = c.Byte(),
                    User_Id = c.String(maxLength: 128),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TimeOfMeasurements", t => t.TimeOfMeasurement_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.TimeOfMeasurement_Id)
                .Index(t => t.User_Id);

            CreateTable(
                "dbo.TimeOfMeasurements",
                c => new
                {
                    Id = c.Byte(nullable: false),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Entries", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Entries", "TimeOfMeasurement_Id", "dbo.TimeOfMeasurements");
            DropIndex("dbo.Entries", new[] { "User_Id" });
            DropIndex("dbo.Entries", new[] { "TimeOfMeasurement_Id" });
            DropTable("dbo.TimeOfMeasurements");
            DropTable("dbo.Entries");
        }
    }
}

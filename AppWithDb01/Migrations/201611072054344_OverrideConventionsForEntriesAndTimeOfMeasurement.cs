namespace AppWithDb01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForEntriesAndTimeOfMeasurement : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Entries", "TimeOfMeasurement_Id", "dbo.TimeOfMeasurements");
            DropForeignKey("dbo.Entries", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Entries", new[] { "TimeOfMeasurement_Id" });
            DropIndex("dbo.Entries", new[] { "User_Id" });
            AlterColumn("dbo.Entries", "TimeOfMeasurement_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Entries", "User_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.TimeOfMeasurements", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Entries", "TimeOfMeasurement_Id");
            CreateIndex("dbo.Entries", "User_Id");
            AddForeignKey("dbo.Entries", "TimeOfMeasurement_Id", "dbo.TimeOfMeasurements", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Entries", "User_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entries", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Entries", "TimeOfMeasurement_Id", "dbo.TimeOfMeasurements");
            DropIndex("dbo.Entries", new[] { "User_Id" });
            DropIndex("dbo.Entries", new[] { "TimeOfMeasurement_Id" });
            AlterColumn("dbo.TimeOfMeasurements", "Name", c => c.String());
            AlterColumn("dbo.Entries", "User_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Entries", "TimeOfMeasurement_Id", c => c.Byte());
            CreateIndex("dbo.Entries", "User_Id");
            CreateIndex("dbo.Entries", "TimeOfMeasurement_Id");
            AddForeignKey("dbo.Entries", "User_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Entries", "TimeOfMeasurement_Id", "dbo.TimeOfMeasurements", "Id");
        }
    }
}

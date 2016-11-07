namespace AppWithDb01.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateTimeOfMeasurement : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TimeOfMeasurements (Id,Name) VALUES (1, 'Na czczo')");
            Sql("INSERT INTO TimeOfMeasurements (Id,Name) VALUES (2, 'Po 1 œniadaniu')");
            Sql("INSERT INTO TimeOfMeasurements (Id,Name) VALUES (3, 'Po 2 œniadaniu')");
            Sql("INSERT INTO TimeOfMeasurements (Id,Name) VALUES (4, 'Po obiedzie')");
            Sql("INSERT INTO TimeOfMeasurements (Id,Name) VALUES (5, 'Po obiado-kolacji')");
            Sql("INSERT INTO TimeOfMeasurements (Id,Name) VALUES (6, 'Po kolacji')");
        }

        public override void Down()
        {
            Sql("DELETE FROM TimeOfMeasurements WHERE Id IN (1,2,3,4,5,6)");
        }
    }
}

namespace VidlyNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDataInMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
                "VALUES ('Hangover', 'Comedy', '2015-01-02', '2016-01-02', 5)");

            //Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
            //    "VALUES (2, 'Die Hard', 'Action', '2018-05-07 03:45:00 AM', '2016-01-02 12:00:00 AM', 1)");

            //Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
            //    "VALUES (3, 'The Terminator', 'Action', '2002-04-09 05:00:00 PM', '2016-01-02 12:00:00 AM', 3)");
        }
        
        public override void Down()
        {
        }
    }
}

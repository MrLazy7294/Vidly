namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Name) VALUES ('Comedy')");
            Sql("Insert into Genres (Name) VALUES ('Action')");
            Sql("Insert into Genres (Name) VALUES ('Family')");
            Sql("Insert into Genres (Name) VALUES ('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}

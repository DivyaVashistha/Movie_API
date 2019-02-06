namespace MovieAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres(Name) values('Action')");
            Sql("insert into Genres(Name) values('Comedy')");
            Sql("insert into Genres(Name) values('Crime')");
            Sql("insert into Genres(Name) values('Drama')");
            Sql("insert into Genres(Name) values('Fantasy')");
            Sql("insert into Genres(Name) values('Historical')");
            Sql("insert into Genres(Name) values('Horror')");
            Sql("insert into Genres(Name) values('Mystery')");
            Sql("insert into Genres(Name) values('Philosophical')");
            Sql("insert into Genres(Name) values('Political')");
            Sql("insert into Genres(Name) values('Romance')");
            Sql("insert into Genres(Name) values('Science fiction')");
            Sql("insert into Genres(Name) values('Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}

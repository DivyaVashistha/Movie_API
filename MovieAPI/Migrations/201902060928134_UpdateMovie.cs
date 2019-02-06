namespace MovieAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovie : DbMigration
    {
        public override void Up()
        {

            Sql("insert into Movies(Name,GenreId,DateReleased,Description,Rating,Genre_Id) values('Hitman Bodygaurd',1,'2000-03-11','Action movies',5,1)");
            Sql("insert into Movies(Name,GenreId,DateReleased,Description,Rating,Genre_Id) values('Why him',2,'2018-04-21','comedy movies',2,2)");
            Sql("insert into Movies(Name,GenreId,DateReleased,Description,Rating,Genre_Id) values('Twilight',11,'2000-05-11','Romantic movies',3,11)");
            Sql("insert into Movies(Name,GenreId,DateReleased,Description,Rating,Genre_Id) values('Harry Potter',5,'2020-06-11','Fantasy movies',5,5)");
            Sql("insert into Movies(Name,GenreId,DateReleased,Description,Rating,Genre_Id) values('Intersteller',12,'2010-07-11','science fiction movies',4,12)");
            Sql("insert into Movies(Name,GenreId,DateReleased,Description,Rating,Genre_Id) values('Mission impossible',13,'2007-08-11','Thriller movies',4,13)");
            Sql("insert into Movies(Name,GenreId,DateReleased,Description,Rating,Genre_Id) values('Gandhi',10,'2008-09-11','political movies',4,10)");
            Sql("insert into Movies(Name,GenreId,DateReleased,Description,Rating,Genre_Id) values('conjuring',7,'2009-02-11','Horror movies',4,7)");
            Sql("insert into Movies(Name,GenreId,DateReleased,Description,Rating,Genre_Id) values('Black Panther',12,'2000-01-11','sci-fi movies',4,12)");

        }
        
        public override void Down()
        {
        }
    }
}

namespace MovieAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieDetails : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Movies(Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Why Him',2,'2016-05-01','comedy movies',2,2)");
            Sql("insert into Movies(Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Harry Potter',3,'1999-12-10','fantasy movies',3,3)");
            Sql("insert into Movies(Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Thor',4,'2015-03-11','Science Fiction movies',5,4)");
            Sql("insert into Movies(Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Twilight',11,'2008-03-05','Romance movies',3,11)");
            Sql("insert into Movies(Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Thakre',10,'2019-03-01','political movies',4,10)");
            Sql("insert into Movies(Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Conjuring',7,'2006-01-09','horror movies',4,7)");
            Sql("insert into Movies(Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Maleficient',5,'2016-05-08','Fantasy movies',2,5)");
            Sql("insert into Movies(Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Intersteller',12,'2002-09-04','science fiction movies',4,12)");
            Sql("insert into Movies(Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Mission Impossible',13,'2018-03-10','Thriller movies',4,13)");

        }

        public override void Down()
        {
        }
    }
}

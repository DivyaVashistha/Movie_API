namespace MovieAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovie : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Movies(Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Hitman Bodygaurd',1,'2000-03-11','Action movies',4,1)");
           
        }
        
        public override void Down()
        {
        }
    }
}

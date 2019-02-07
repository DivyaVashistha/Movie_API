namespace MovieAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropCol : DbMigration
    {
        public override void Up()
        {
            Sql("Alter table Movies drop column Genreid");
        }
        
        public override void Down()
        {
        }
    }
}

namespace UMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Genre");
        }
    }
}

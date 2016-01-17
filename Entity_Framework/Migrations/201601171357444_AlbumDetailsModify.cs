namespace Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlbumDetailsModify : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "MusicDB.AlbumDetails", newSchema: "dbo");
        }
        
        public override void Down()
        {
            MoveTable(name: "dbo.AlbumDetails", newSchema: "MusicDB");
        }
    }
}

namespace Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlbumModify : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "MusicDB.Album", newName: "AlbumInfo");
            MoveTable(name: "MusicDB.AlbumInfo", newSchema: "dbo");
            RenameColumn(table: "dbo.AlbumInfo", name: "Title", newName: "Album.Title");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.AlbumInfo", name: "Album.Title", newName: "Title");
            MoveTable(name: "dbo.AlbumInfo", newSchema: "MusicDB");
            RenameTable(name: "MusicDB.AlbumInfo", newName: "Album");
            DropTable("dbo.Album");
            DropTable("dbo.__MigrationHistory");
        }
    }
}

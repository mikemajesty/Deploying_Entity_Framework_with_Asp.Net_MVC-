namespace Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlbumDetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "MusicDB.AlbumDetails",
                c => new
                    {
                        AlbumID = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AlbumID)
                .ForeignKey("MusicDB.Album", t => t.AlbumID)
                .Index(t => t.AlbumID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("MusicDB.AlbumDetails", "AlbumID", "MusicDB.Album");
            DropIndex("MusicDB.AlbumDetails", new[] { "AlbumID" });
            DropTable("MusicDB.AlbumDetails");
        }
    }
}

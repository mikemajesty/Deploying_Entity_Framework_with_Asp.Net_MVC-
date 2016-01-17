namespace Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fullTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "MusicDB.Album",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Title = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.AlbumID);
            
        }
        
        public override void Down()
        {
            DropTable("MusicDB.Album");
        }
    }
}

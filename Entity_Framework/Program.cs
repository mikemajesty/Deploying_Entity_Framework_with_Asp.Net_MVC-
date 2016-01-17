using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using static System.Console;
using System.Data.Entity;
namespace Entity_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MusicContext())
            {
                var count = context.Album.Count();

                WriteLine(count);
                WriteLine(context.Database.Connection.ConnectionString);
                context.Album.Add(new Album
                {
                    Price = 9.99m,
                     Title = "Wish"
                });               
                context.SaveChanges();
                var newCount = context.Album.Count();
                WriteLine(newCount);
                var album = context.Album.Where(c=>c.Title == "Wish");
                ReadKey();
            }
        }

     

    }
    [Table(nameof(Album))]
    public class Album
    {
        public int AlbumID { get; set; }
        public decimal Price { get; set; }
        //Varchar(100)
        public String Title { get; set; }
        public AlbumDetails AlbumDetails { get; set; }
    }

    public class AlbumDetails
    {
        public string Description { get; set; }
        public int AlbumID { get; set; }
        public Album Album { get; set; }
    }

    public class MusicContext : DbContext
    {
        public DbSet<Album> Album { get; set; }

        public MusicContext()
        {
            Database.SetInitializer<MusicContext>(new DropCreateDatabaseAlways<MusicContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema(schema: "MusicDB");
            //modelBuilder.Entity<Album>().HasKey(c => new { c.AlbumID,c.Title });MUltiple keys
            modelBuilder.Entity<Album>().HasKey(c =>c.AlbumID);
            modelBuilder.Entity<Album>().Property(c => c.Title).IsUnicode(false);
            //modelBuilder.Entity<Album>().Property(c=>c.AlbumID)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None); Don't genarete identity in primaty key.

            modelBuilder.Entity<AlbumDetails>().HasKey(c => c.AlbumID);
            modelBuilder.Entity<Album>().HasOptional(c => c.AlbumDetails)
                .WithRequired(c => c.Album);
          
            modelBuilder.Entity<Album>().ToTable("AlbumInfo","dbo");
            modelBuilder.Entity<AlbumDetails>().ToTable("AlbumDetails", "dbo");
            modelBuilder.Entity<Album>().Property(c => c.Title).HasColumnName("Album.Title");
            base.OnModelCreating(modelBuilder);
        }
    }
}

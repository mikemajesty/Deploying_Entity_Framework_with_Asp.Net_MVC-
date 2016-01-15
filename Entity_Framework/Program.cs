using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using static System.Console;

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
        public String Title { get; set; }
    }
    public class MusicContext : DbContext
    {
        public DbSet<Album> Album { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Diagnostics;

namespace DeployingEntityFramework.Controllers
{
    [Table(nameof(Album))]
    public class Album
    {
        public int AlbumID { get; set; }
        public decimal Price { get; set; }
        public String Title { get; set; }
    }
    public class MusicContext : DbContext
    {
        public MusicContext()
        {
            Database.Log = s => Debug.WriteLine(s);
        }
        public DbSet<Album> Album { get; set; }
    }
}
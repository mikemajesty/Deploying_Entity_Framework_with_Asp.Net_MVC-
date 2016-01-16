using System.Data.Entity;
using DeployingEntityFramework.Models;

namespace DeployingEntityFramework.Initializer
{
    public class MusicContextInitializer : DropCreateDatabaseAlways<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            Artist artist = new Artist
            {
                 Name = "Jhon Lenon"
            };
            context.Artist.Add(artist);
            context.Album.Add(new Album { Price = 19, Title = "Wish" });
            context.SaveChanges();
        }
    }
}
using System.Data.Entity;
using DeployingEntityFramework.Models;
using System.Collections.Generic;

namespace DeployingEntityFramework.Initializer
{
    public class MusicContextInitializer : DropCreateDatabaseAlways<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            Artist artirt = new Artist
            {
                Name = "Avantasia"
            };
            Album album = new Album
            {
                Price = 1.99m,
                Title = "NeverMind",
                Artist = new Artist
                {
                    Name = "Jhon Lenon"
                }
            };
            context.Artist.Add(new SoloArtist { Name="David Bowie", Instrument = "Guitar", Album  = new List<Album> { new Album { Price = 1.99m, Title = "Pink" } }, ArtistDetails = new ArtistDetails { Bio = "BioLoco" } });
            context.Album.Add(new Album { Price = 19, Title = "Wish", Artist = artirt });
            context.SaveChanges();
        }
    }
}
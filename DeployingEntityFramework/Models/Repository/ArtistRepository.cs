using System.Collections.Generic;
using System.Linq;

namespace DeployingEntityFramework.Models.Repository
{
    public class ArtistRepository : Repository<Artist>
    {
        public List<Artist> GetByName(string name)
        {
            return dbSet.Where(c => c.Name == name).ToList();
        }
        public List<SoloArtist> GetSoloArtist()
        {
            return dbSet.OfType<SoloArtist>().ToList();
        }
    }
}
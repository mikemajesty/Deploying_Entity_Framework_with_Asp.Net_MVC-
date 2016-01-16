using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeployingEntityFramework.Models
{
    [Table(nameof(Artist))]
    public class Artist
    {
        public int ArtistID { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "{0} out of the range")]
        public string Name { get; set; }
        public virtual ArtistDetails ArtistDetails { get; set; }
        public virtual List<Album> Album { get; set; }
       
    }
}
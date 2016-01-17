using System.ComponentModel.DataAnnotations;

namespace DeployingEntityFramework.Models
{
    public class AlbumEditViewModel
    {
        public int AlbumID { get; set; }
        public int GenreID { get; set; }
        public  int  ArtistID { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(1024)]
        public string AlbumUrl { get; set; }
    }
}
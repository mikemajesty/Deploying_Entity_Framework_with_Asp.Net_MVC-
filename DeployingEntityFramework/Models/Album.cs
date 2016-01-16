using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeployingEntityFramework.Models
{
    [Table(nameof(Album))]
    public class Album
    {
        public int AlbumID { get; set; }
        public decimal Price { get; set; }
        public String Title { get; set; }
    }
}
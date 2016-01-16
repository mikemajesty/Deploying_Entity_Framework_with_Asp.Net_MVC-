using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeployingEntityFramework.Models
{
    [Table(nameof(Album))]
    public class Album
    {
        public int AlbumID { get; set; }
        [Required(ErrorMessage ="{0} is required")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100,MinimumLength =2,ErrorMessage ="{0} out of the range")]
        public String Title { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual List<Rewiewer> Rewiewers { get; set; }
    }
}
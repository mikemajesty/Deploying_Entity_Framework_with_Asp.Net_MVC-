﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeployingEntityFramework.Models
{
    [Table(nameof(Artist))]
    public class Artist
    {
        public int ArtistID { get; set; }
        [Required()]
        [StringLength(100,MinimumLength = 2)]
        public string Name { get; set; }
    }
}
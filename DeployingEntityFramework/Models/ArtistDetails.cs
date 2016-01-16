﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DeployingEntityFramework.Models
{
    public class ArtistDetails
    {
        [Key]
        [ForeignKey(nameof(Artist))]
        public int ArtistID { get; set; }
        public string Bio { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
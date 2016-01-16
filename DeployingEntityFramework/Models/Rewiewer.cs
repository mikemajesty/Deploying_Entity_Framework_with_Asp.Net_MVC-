using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeployingEntityFramework.Models
{
    public class Rewiewer
    {
        public int RewiewerID { get; set; }
        public string Name { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeployingEntityFramework.Models.Repository
{
    public class ArtistRepository : Repository<Artist>
    {
        public List<Artist> GetByName(string name)
        {
            return dbSet.Where(c => c.Name == name).ToList();
        }
    }
}
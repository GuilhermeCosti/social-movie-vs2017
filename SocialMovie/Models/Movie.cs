﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MediaURL { get; set; }
        public string Description { get; set; }
        public string ThumbnailURL { get; set; }
    }
}

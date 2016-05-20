﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Models
{
    public class IndividualPiece
    {
        public int IndividualPieceId { get; set; }
        public int ArtWorkId { get; set; }
        public string Image { get; set; }
        public DateTime DateCreated { get; set; }
        public float Cost { get; set; }
        public float Price { get; set; }
        public bool Sold { get; set; }
        public string Location { get; set; }
        public int EditionNumber { get; set; }
    }
}

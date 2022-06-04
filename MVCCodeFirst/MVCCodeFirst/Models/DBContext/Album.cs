using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCCodeFirst.Models.DBContext
{
    public class Album
    {
        public int AlbumId { get; set; } // Scalar Property
        public string Title { get; set; }// Scalar Property
        public decimal Price { get; set; }// Scalar Property
        public string AlbumArtUrl { get; set; }// Scalar Property
        public Artist Artist { get; set; } // Navigation Property
        public int ArtistId { get; set; }
        [ForeignKey("ArtistId")]
        public Genre Genre { get; set; } // Navigation Property
        public int GenreId { get; set; }
        //[ForeignKey("GenreId")]
      
    }
}
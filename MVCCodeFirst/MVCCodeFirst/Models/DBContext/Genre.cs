using MVCCodeFirst.Models.DBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCCodeFirst.Models
{
    [Table("TblGenre")] // Changing Table Name
    public class Genre
    {
        public int GenreId { get; set; } // Scalar Property
        //[Display(Name = "Genre")]
        public string Name { get; set; } // Scalar Property
        public string Description { get; set; } // Scalar Property
        public List<Album> Albums { get; set; } // Navigation Property
    }



}
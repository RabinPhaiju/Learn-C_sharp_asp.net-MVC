using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCodeFirst.Models.DBContext
{
    public class Artist
    {
        public int ArtistId { get; set; }
        //[Display(Name = "Artist")]
        [Column("Artist_Name)]")] //Change column name
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
    }
}
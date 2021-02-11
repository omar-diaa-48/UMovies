using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UMovies.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        [Display(Name="Movie Name")]
        public string Name { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }


        [DataType(DataType.Date)]
        public DateTime? DateAdded { get; set; }


        public short NumberInStock { get; set; }

        public GenreName Genre { get; set; }

    }
}
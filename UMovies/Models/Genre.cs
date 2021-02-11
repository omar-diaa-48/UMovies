using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UMovies.Models
{
    public class Genre
    {
        public GenreName GenreType { get; set; }
    }

    public enum GenreName
    {
        Comedy,
        Action,
        Family,
        Romance,
        Kids
    }
}
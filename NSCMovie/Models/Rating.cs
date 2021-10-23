using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NSCMovie.Models
{
    public class Rank
    {
        public int Id { get; set; }
        public string Rating { get; set; }

        public List<Movie> Movies { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace NSCMovie.Models
{
    public class Rank
    {
        public int Id { get; set; }
        public string Rating { get; set; }

        public virtual List<Movie> Movies { get; set; }
    }
}

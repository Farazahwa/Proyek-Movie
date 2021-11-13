using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace NSCMovie.Models
{
    public class TimeSchedule
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}
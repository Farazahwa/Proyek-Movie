using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NSCMovie.Models
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }
        [Display(Name = "Time Schedule")]        
        public List<TimeSchedule> TimeSchedule { get; set; }
    }
}
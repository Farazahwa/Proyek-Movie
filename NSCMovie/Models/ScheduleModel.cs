using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NSCMovie.Models
{
    public class Schedule
    {
        public List<MovieListViewModel> MovieLists { get; set; }
        public List<Movie> Movies { get; set; }
        public SelectList Days { get; set; }
        public string MovieDays { get; set; }
        public string SearchString { get; set; }
    }
}
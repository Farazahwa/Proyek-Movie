using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace NSCMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public Rank RatingId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Schedule { get; set; }
        public int Room { get; set; }
        
        public List<TranksaksiMovie> MovieId { get; set; }    
    }
}
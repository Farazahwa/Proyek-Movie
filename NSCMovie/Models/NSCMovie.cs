using System;
using System.ComponentModel.DataAnnotations;

namespace NSCMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int RatingId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Schedule { get; set; }
        public int Room { get; set; }
        
    }
}
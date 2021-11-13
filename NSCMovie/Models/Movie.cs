using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NSCMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Title { get; set; }

        [Range(10000,50000)]
        [DataType (DataType.Currency)]
        [Column (TypeName = "decimal(18,2)")]   
        public int Price { get; set; }


        public int RatingId{ get; set; }
        public virtual Rank Rating { get; set; }
        
        public int TimeScheduleId { get; set; }
        public TimeSchedule TimeSchedule { get; set; }

        [Required]
        public int Room { get; set; }

        [Required]
        public string Days { get; set; }

        [Required]
        public string Definition { get; set; }

        [Required]
        public string Image { get; set; }
        public virtual List<TranksaksiMovie> TranksaksiMovies { get; set; }
    }
}
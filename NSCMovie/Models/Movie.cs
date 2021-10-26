using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NSCMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType (DataType.Currency)]
        [Column (TypeName = "decimal(18,2)")]   
        public int Price { get; set; }
        public int RatingId{ get; set; }
        public virtual Rank Rating { get; set; }
        
        [DataType(DataType.Time)]
        public DateTime Schedule { get; set; }
        public int Room { get; set; }
        
        public List<TranksaksiMovie> MovieId { get; set; }    
    }
}
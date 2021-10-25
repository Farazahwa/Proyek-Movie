using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD:NSCMovie/Models/NSCMovie.cs
using Microsoft.AspNetCore.Mvc.Rendering;
=======
>>>>>>> c2a6a548f094e656c07bcace38908e4a2a0db2f8:NSCMovie/Models/Movie.cs
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
        public Rank RatingId { get; set; }
        
        [DataType(DataType.Time)]
        public DateTime Schedule { get; set; }
        public int Room { get; set; }
        
        public List<TranksaksiMovie> MovieId { get; set; }    
    }
}
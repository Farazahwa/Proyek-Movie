using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace NSCMovie.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string PenggunaId { get; set; }
        public virtual Buyer Pengguna { get; set; }
        public DateTime Date { get; set; }
        public string Payment { get; set; }

        public virtual List<TranksaksiMovie> TranksaksiMovies { get; set; }
    }
}
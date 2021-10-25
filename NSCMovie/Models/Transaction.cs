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
        public int PenggunaId { get; set; }
        public Buyer Pengguna { get; set; }
        public DateTime Date { get; set; }
        public string Payment { get; set; }

        public List<TranksaksiMovie> TransactionId { get; set; }
    }
}
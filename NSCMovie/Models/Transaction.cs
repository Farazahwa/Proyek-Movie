using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NSCMovie.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Buyer PenggunaId { get; set; }
        public DateTime Date { get; set; }
        public string Payment { get; set; }

        public List<TranksaksiMovie> TransactionId { get; set; }
    }
}
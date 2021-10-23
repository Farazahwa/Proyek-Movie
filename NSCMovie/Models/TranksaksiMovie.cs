using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NSCMovie.Models
{
    public class TranksaksiMovie
    {
        public int Id { get; set; }
        public Movie MovieId { get; set; }
        public Transaction TransactionId { get; set; }
        public int TicketAmount { get; set; }
        public decimal Price { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace NSCMovie.Models

{
    public class TranksaksiMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int TransactionId { get; set; }
        public int TicketAmount { get; set; }
        public decimal Price { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
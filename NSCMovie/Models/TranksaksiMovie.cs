using System;
using System.ComponentModel.DataAnnotations;

namespace TranksaksiMovie.Models
{
    public class TranksaksiMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int TicketAmount { get; set; }
        public decimal Price { get; set; }
    }
}
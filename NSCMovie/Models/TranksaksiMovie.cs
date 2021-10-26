using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace NSCMovie.Models
{
    public class TranksaksiMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public int TransactionId { get; set; }
        public virtual Transaction Transaction { get; set; }
        public int TicketAmount { get; set; }
        public decimal Price { get; set; }
        public DateTime TransactionDate { get; set; }
        public List<TranksaksiMovie> Transactions { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace NSCMovie.Models
{
    public class AddTransactionViewModel
    {
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        public string Payment { get; set; }
        public int TicketAmount { get; set; }
    }
}
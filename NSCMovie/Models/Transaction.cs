using System;
using System.ComponentModel.DataAnnotations;

namespace Transaction.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int PenggunaId { get; set; }
        public DateTime Date { get; set; }
        public string Payment { get; set; }
    }
}
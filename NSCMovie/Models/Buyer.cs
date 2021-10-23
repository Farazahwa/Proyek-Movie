using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NSCMovie.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public int Username { get; set; }
        public int Password { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
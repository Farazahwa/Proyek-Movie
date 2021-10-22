using System;
using System.ComponentModel.DataAnnotations;

namespace Buyer.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public int Username { get; set; }
        public int Password { get; set; }
    }
}
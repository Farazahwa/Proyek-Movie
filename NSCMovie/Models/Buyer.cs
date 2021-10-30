using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace NSCMovie.Models
{
    public class Buyer : IdentityUser
    {
        public string Avatar { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
    }
}
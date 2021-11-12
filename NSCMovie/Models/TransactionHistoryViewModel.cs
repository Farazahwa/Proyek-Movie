using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NSCMovie.Models
{
    public class TransactionHistoryViewModel
    {
        public List<TranksaksiMovie> MovieTransaction { get; set; }        
    }
}
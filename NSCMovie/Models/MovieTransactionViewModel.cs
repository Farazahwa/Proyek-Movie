using System;

namespace NSCMovie.Models
{
    public class MovieTransactionViewModel
    {
        public virtual Movie Movie { get; set; }
        public virtual AddTransactionViewModel TranksaksiMovie { get; set; }                
    }
}
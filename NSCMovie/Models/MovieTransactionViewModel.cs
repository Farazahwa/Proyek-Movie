using System;

namespace NSCMovie.Models
{
    public class MovieTransactionViewModel
    {
        public virtual Movie Movie { get; set; }
        public virtual TranksaksiMovie TranksaksiMovie { get; set; }
    }
}
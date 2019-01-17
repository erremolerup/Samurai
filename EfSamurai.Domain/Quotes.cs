using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class Quotes
    {
        public int Id { get; set; }
        //public string Quote { get; set; }
        //public string TypeId { get; set; }

        public List<QuoteType> QuoteTypes { get; set; }
    }
    
}

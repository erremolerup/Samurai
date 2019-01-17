﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public int Sword { get; set; }

        public List<Quotes> SamuraiQuotes { get; set; }
        //public int QuoteId { get; set; }
        //public string Quote { get; set; }
    }
}

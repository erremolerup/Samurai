using System;
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

        public List<Hairdo> Hairdos { get; set; }

        public int SecretIdentityId { get; set; }
        public SecretIdentity SecretIdentity { get; set; }

        public List<SamuraiBattle> SamuraiBattle { get; set; }
    }
}

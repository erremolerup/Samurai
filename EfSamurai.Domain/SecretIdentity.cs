using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSamurai.Domain
{
    public class SecretIdentity
    {
        public int Id { get; set; }

        public virtual Samurai Samurai { get; set; }
    }
}

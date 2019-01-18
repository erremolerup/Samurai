using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSamurai.Domain
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Brutal { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<SamuraiBattle> SamuraiBattle { get; set; }

        public int BattleLogId { get; set; }
        public BattleLog BattleLog { get; set; }
    }
}

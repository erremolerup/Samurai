using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSamurai.Domain
{
    public class BattleEvent
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Sum { get; set; }
        public DateTime TimeOfEvent { get; set; }

        public BattleLog BattleLog { get; set; }

    }
}

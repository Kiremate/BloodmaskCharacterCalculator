using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodmaskCharacterCalculator.Stats.Special
{
    public class Radiation_Affinity : Stat
    {
        public Radiation_Affinity(int value) : base("Radiation Affinity", "Indicates the player's natural resistance or susceptibility to radiation. A higher value may even imply the ability to harness radiation for beneficial effects.", value) { }
    }
}

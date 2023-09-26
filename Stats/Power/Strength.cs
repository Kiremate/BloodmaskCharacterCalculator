using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodmaskCharacterCalculator.Stats.Power
{
    public class Strength : Stat
    {
        public Strength(int value) : base("Strength", "Represents physical prowess, affecting melee damage output and the ability to perform physically demanding tasks.", value) { }
    }
}

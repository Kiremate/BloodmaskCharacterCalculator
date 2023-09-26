using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodmaskCharacterCalculator.Stats.Special
{
    public class Endurance : Stat
    {
        public Endurance(int value) : base("Endurance", "Measures the player's ability to withstand physical and mental strain over extended periods. Governs resistance to fatigue and other status ailments.", value) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodmaskCharacterCalculator.Stats.Common
{
    public class Vigor : Stat
    {
        public Vigor(int value) : base("Vigor", "A measure of the entity's stamina or energy levels. This stat governs the ability to perform actions that consume stamina or energy, such as running or using certain abilities", value) { }
    }
}

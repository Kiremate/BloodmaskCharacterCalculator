using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodmaskCharacterCalculator.Stats
{
    public class Health : Stat
    {
        public Health(int value) : base("Health", "Represents the overall vitality of a character or object. When Health reaches zero, the entity is incapacitated or destroyed.", value) { }

    }
}

using BloodmaskCharacterCalculator.Stats.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodmaskCharacterCalculator.Stats.Special
{
    public class Endurance : Stat
    {
        // Optional variables for NPC's and Objects - Mandatory if used in Characters
        private Vigor _relatedVigorStat;
        private float _vigorPercentIncrease;
        public Endurance (int value, Vigor relatedVigorStat = null) : base ("Endurance", "Measures the player's ability to withstand physical and mental strain over extended periods. Governs resistance to fatigue and other status ailments.", value)
        { 
            _relatedVigorStat = relatedVigorStat;
            _vigorPercentIncrease = 0.1f; // Default increase
        }

        public void SetRelatedVigor(Vigor relatedVigorIn)
        {
            _relatedVigorStat = relatedVigorIn;
        }
        // If two stats are related and affects values calculates the Increase by x percent
        public override void CalculateDerivedStat()
        {
            base.CalculateDerivedStat();
            _relatedVigorStat?.IncreaseValueByPercentage(_vigorPercentIncrease);
        }
    }
}

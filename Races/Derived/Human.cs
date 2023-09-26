using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodmaskCharacterCalculator.Races.Derived
{
    public  class Human : Race
    {
        #region Constructors
        public Human() : base("Human", "Enhanced Intelligence, Environmental Adaptability", "Humans in the Bloodmask universe possess a natural affinity for complex problem-solving, which grants them a bonus to Intelligence stats. Their uncanny ability to adapt technologies to different biomes gives them a bonus to Endurance when facing environmental challenges.") { }
        #endregion
    }
}

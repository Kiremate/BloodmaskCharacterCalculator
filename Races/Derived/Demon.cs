﻿using BloodmaskCharacterCalculator.Stats;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodmaskCharacterCalculator.Races.Derived
{
    public class Demon : Race
    {
        [JsonConstructor]
        public Demon(string name, E_Races type, string perks, string backgroundStory, List<Stat> defaultStats) : base(name, type, perks, backgroundStory, defaultStats) { }
    }
}

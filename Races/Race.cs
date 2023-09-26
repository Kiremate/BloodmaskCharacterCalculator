using BloodmaskCharacterCalculator.Races.Derived;
using BloodmaskCharacterCalculator.Stats;
using BloodmaskCharacterCalculator.Stats.Common;
using BloodmaskCharacterCalculator.Stats.Power;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodmaskCharacterCalculator.Races
{
    /// <summary>
    /// Will contain all the information related to race as well as the default stats
    /// </summary>
    public enum E_Races { Human, Demon, Lurker, Undead, Primordial, Colossus, Nordic };
    public class Race
    {
        protected string _name;
        protected string _perks;
        protected string _backgroundStory;
        protected E_Races _type;
        protected List<Stat> _defaultStats;
        #region Getters & Setters
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Perks 
        {
            get { return _perks;}
            set { _perks = value; }
        }
        public string BackgroundStory
        {
            get { return _backgroundStory; }
            set { _backgroundStory = value; }
        }
        public E_Races Type { get { return _type; } }
        public List<Stat> DefaultStats
        {
            get { return _defaultStats; }
            set { _defaultStats = value; }
        }
        #endregion
        #region Constructors
        // Empty Constructor
        public Race()
        {
            _defaultStats = new List<Stat>();
            InitializateDefaultStats();
        }
        // Parameterized Constructor
        public Race(string name, E_Races type, string perks, string backgroundStory, List<Stat> defaultStats)
        {
            // Data Validation
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(perks) || string.IsNullOrEmpty(backgroundStory) || defaultStats == null)
            {
                throw new ArgumentException("Missing required attributes");
            }
            _name = name;
            _type = type;
            _perks = perks;
            _backgroundStory = backgroundStory;
            _defaultStats = defaultStats;
            InitializateDefaultStats();
        }
        #endregion 
        // This function will be called each time a Race is initializated
        protected virtual void InitializateDefaultStats()
        {
            // Since all the Races will have Common and Power stats we initialize those
            #region Common Stats
            // Values may change through the dev process
            _defaultStats.Add(new Health(42)); // We give 42 default hp in honor to the Mottled Boar in WoW
            _defaultStats.Add(new Vigor(100)); // We give 100 default energy in honor to the Rogue class in WoW
            #endregion
            #region Power Stats
            // We give 15 as is the minimum power stat in WoW 
            _defaultStats.Add(new Strength(15)); 
            _defaultStats.Add(new Dexterity(15));
            _defaultStats.Add(new Intelligence(15));
            #endregion
        }
        // Factory Pattern
        public static Race CreateRaceFromJson(string json)
        {
            var race = JsonConvert.DeserializeObject<Race>(json);
            // This will create a certain Race depending on it's type
            switch (race.Type)
            {
                case E_Races.Human:
                    return JsonConvert.DeserializeObject<Human>(json);
                case E_Races.Demon:
                    return JsonConvert.DeserializeObject<Demon>(json);
                case E_Races.Lurker:
                    return JsonConvert.DeserializeObject<Lurker>(json);
                case E_Races.Undead:
                    return JsonConvert.DeserializeObject<Undead>(json);
                case E_Races.Primordial:
                    return JsonConvert.DeserializeObject<Primordial>(json);
                case E_Races.Colossus:
                    return JsonConvert.DeserializeObject<Colossus>(json);
                case E_Races.Nordic:
                    return JsonConvert.DeserializeObject<Nordic>(json);
                // TODO Check this
                default: // This would be a weird case perhaps throw an exception?
                    return race;
            }
        }
    }
}

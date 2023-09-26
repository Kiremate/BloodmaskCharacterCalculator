using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodmaskCharacterCalculator.Stats
{
    /// <summary>
    /// This class will determine the base behaviour for all stats in the calculator
    /// The following sub-stats will inherit from this class
    /// Common Stats -- Stats present in almost all objects & characters
    /// Power Stats -- Stats present only in objects & characters that can use abilities
    /// Special Stats -- Stats present only in Players
    /// </summary>
    public class Stat
    {
        protected string _name;
        protected string _description;
        protected int _value;

        #region Getters & Setters
        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            protected set { _description = value; }
        }
        public int Value
        {
            get { return _value; }
            protected set { _value = value; }
        }
        #endregion

        #region Constructors
        // Empty Constructor
        public Stat()
        {
            _value = 0;
            _name = string.Empty;
            _description = string.Empty;
        }
        // Parameterized Constructor
        public Stat(string name, string description, int value)
        {
            _name = name;
            _description = description;
            _value = value;
        }
        #endregion

    }
}

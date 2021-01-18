using System;
using System.Collections.Generic;
using System.Text;

namespace XeoCrawler.Spells.Healing
{
    class BasicHeal : Spell
    {

        // attributes
        private int bhValue;

        // constructor
        public BasicHeal(string splName, string splType, int splLevel, int bhValue)
        {
            // parent requirements:
            this.Name = splName;
            this.Type = splType;
            this.Level = splLevel;

            // class specific attribute setting:
            this.Value = bhValue;
        }

        // get & set

        public int Value
        {
            get { return this.bhValue; }
            set
            {
                if (value > 0)
                {
                    this.bhValue = value;
                } else
                {
                    this.bhValue = 1;
                }
            }
        }

        // methods

        public int Cast()
        {
            // generate random chance of crit & crit multiplier;
            var rnd = new Random();

            double critChance = ((rnd.Next(11) / 100) * this.Level);

            int critMultiplier = rnd.Next(26);

            if (critChance > 25.00)
            {
                return (this.bhValue * critMultiplier);
            } else
            {
                return this.bhValue;
            }
        }

    }
}

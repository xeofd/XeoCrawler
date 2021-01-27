using System;
using System.Collections.Generic;
using System.Text;

namespace XeoCrawler.Spells.Damage
{
    class BasicDamage : Spell
    {
        // attributes
        private int dmgBase;

        // constructor
        public BasicDamage(string splName, string splType, int splLevel, int dmgBase)
        {
            // parent
            this.Name = splName;
            this.Type = splType;
            this.Level = splLevel;

            // child
            this.Damage = dmgBase;
        }

        // get & set
        public int Damage
        {
            get { return this.dmgBase; }
            set
            {
                if (value > 0)
                {
                    this.dmgBase = value;
                }
                else
                {
                    this.dmgBase = 1;
                }
            }
        }

        // methods
        public int Use()
        {
            // set random generator
            var rnd = new Random();

            // set random crit chance and multiplier
            double _critChance = rnd.Next(1) * 100;
            int _critMulti = Convert.ToInt32(rnd.Next(2) * 100);

            // set random miss chance
            double _missChance = rnd.Next(1) * 100;

            // return hit
            if (_missChance > 75)
            {
                return 0;
            } else
            {
                // check for the crit chance
                if (_critChance > 60)
                {
                    return this.Damage * _critMulti;
                }
                else
                {
                    return this.Damage;
                }
            }

        }
    }
}

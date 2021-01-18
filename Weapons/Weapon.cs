using System;
using System.Collections.Generic;
using System.Text;

namespace XeoCrawler.Weapons
{
    class Weapon
    {

        // attributes
        private string wpnName;
        private int wpnDamage;
        private int wpnDurability;

        // constructor
        public Weapon(string wpnName, int wpnDamage)
        {
            this.Name = wpnName;
            this.Damage = wpnDamage;
            this.Durability = 100;
        }

        // get & set

        public string Name
        {
            get { return this.wpnName; }
            set
            {
                if (value != "" && value != " ")
                {
                    this.wpnName = value;
                } else
                {
                    this.wpnName = "{no name}";
                }
            }
        }

        public int Damage
        {
            get { return this.wpnDamage; }
            set
            {
                if (value > 0)
                {
                    this.wpnDamage = value;
                } else
                {
                    this.wpnDamage = 1;
                }
            }
        }

        public int Durability
        {
            get { return this.wpnDurability; }
            set
            {
                if (value > -1)
                {
                    this.wpnDurability = value;
                } else
                {
                    this.wpnDurability = 0;
                }
            }
        }

        // methods

        public void Repair(int repairValue)
        {
            if (repairValue > 0)
            {
                this.Durability = (this.Durability + repairValue);
            }
        }

        public bool IsBroken()
        {
            if (this.Durability == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}

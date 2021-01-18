using System;
using System.Collections.Generic;
using System.Text;

namespace XeoCrawler.Weapons
{
    class Weapon
    {

        // attributes
        public string wpnName;
        public int wpnDamage;

        // constructor
        public Weapon(string wpnName, int wpnDamage)
        {
            this.wpnName = wpnName;
            this.wpnDamage = wpnDamage;
        }
    }
}

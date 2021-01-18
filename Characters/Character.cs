using System;
using System.Collections.Generic;
using System.Text;

namespace XeoCrawler.Characters
{
    class Character
    {

        // attributes
        private string chrName;
        private int chrHp;
        private int chrPower;
        private int chrLevel;

        // constructor
        public Character(string chrName, int chrHp, int chrPower, int chrLevel)
        {
            this.Name = chrName;
            this.Health = chrHp;
            this.Attack = chrPower;
        }

        // get & set

        public string Name
        {
            get { return this.chrName; }
            set
            {
                if (value != "" && value != " ")
                {
                    this.chrName = value;
                } else
                {
                    this.chrName = "n/a";
                }
            }
        }

        public int Health
        {
            get { return this.chrHp; }
            set
            {
                if (value > 1)
                {
                    this.chrHp = value;
                } else
                {
                    this.chrHp = 1;
                }
            }
        }

        public int Attack
        {
            get { return this.chrPower; }
            set
            {
                if (value > 1)
                {
                    this.chrPower = value;
                } else
                {
                    this.chrPower = 1;
                }
            }
        }

        public int Level
        {
            get { return this.chrLevel; }
            set
            {
                if (value > 0)
                {
                    this.chrLevel = value;
                } else
                {
                    this.chrLevel = 1;
                }
            }
        }

        // methods

        // health based methods

        public void RecieveHeal(int healValue, int healMultiplier)
        {
            this.Health = this.Health + (healValue * healMultiplier);
        }

        public void TakeDamage(int dmgValue, int dmgMultiplier)
        {
            this.Health = Convert.ToInt32(this.Health - (dmgValue * dmgMultiplier) / this.BlockChance());
        }

        private double BlockChance()
        {
            // Generate the random block percentage
            var rnd = new Random();

            double _blockPercentage = rnd.Next(3);

            return (this.Level * (_blockPercentage * 10)) / 100;
        }

        // attack based methods

        public int BaseAttack(Weapons.Weapon atkWeapon, int atkMultiplier)
        {
            return ((this.Attack + atkWeapon.Damage) * atkMultiplier);
        }
    }
}

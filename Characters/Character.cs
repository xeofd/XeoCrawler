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


    }
}

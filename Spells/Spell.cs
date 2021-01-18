using System;
using System.Collections.Generic;
using System.Text;

namespace XeoCrawler.Spells
{
    abstract class Spell
    {

        // attributes
        private string splName;
        private string splType;
        private int splLevel;

        // constructors

        // default
        public Spell()
        {
            this.Name = "";
            this.Type = "";
            this.Level = 1;
        }

        // standard
        public Spell(string splName, string splType, int splLevel)
        {
            this.Name = splName;
            this.Type = splType;
            this.Level = splLevel;
        }

        // get & set

        public string Name
        {
            get { return this.splName; }
            set
            {
                if (value != "" && value != " ")
                {
                    this.splName = value;
                } else
                {
                    this.splName = "{no name}";
                }
            }
        }

        public string Type
        {
            get { return this.splType; }
            set
            {
                if (value == "_heal" || value == "_damage" || value == "_enhance")
                {
                    this.splType = value;
                } else
                {
                    this.splType = "_damage";
                }
            }
        }

        public int Level
        {
            get { return this.splLevel; }
            set
            {
                if (value > 0)
                {
                    this.splLevel = value;
                } else
                {
                    this.splLevel = 1;
                }
            }
        }

        // methods

    }
}

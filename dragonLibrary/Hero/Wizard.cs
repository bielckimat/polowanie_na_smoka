using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dragonLibrary.Hero
{
    public class Wizard : Character
    {
        private int mana;

        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        private int maxMana;

      

        public int MaxMana
        {
            get { return maxMana; }
            set { maxMana = value; }
        }

        public Wizard(string name) : base(name)
        {
            this.Name = name;
            this.Mana = 100;
            this.MaxMana = 100;
            this.Agility = 5;
            this.Exp = 0;
            this.Damege = 50;
            this.Defense = 3;
            this.Health = 50;
            this.MaxHealth = 50;
            this.Strength = 3;
            this.Lvl = 1;
            this.Intelligence = 10;

        }

        public override string ToString()
        {
            return base.ToString()+ $"MaxMana: {maxMana}";
        }

        public override void NextLvl()
        {
            base.NextLvl();
            Intelligence++;
            Mana = Mana + 10;
            MaxMana = MaxMana + 10;
        }
    }
}

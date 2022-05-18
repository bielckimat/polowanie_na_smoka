using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dragonLibrary.Hero
{
    public class Warrior : Character
    {
        private int attacksPerRound;

        public Warrior(string name) : base(name)
        {
            this.Lvl = 1;
            this.Name = name;
            this.Strength = 10;
            this.Exp = 0;
            this.MaxHealth = 100;
            this.Health = 100;
            this.Agility = 5;
            this.Damege = 20;
            this.AttacksPerRound = 2;
            this.Defense = 15;
            this.Intelligence = 2;
            
        }
        public override int DamagePerRound => base.DamagePerRound*attacksPerRound;

        public int AttacksPerRound
        {
            get { return attacksPerRound; }
            set { attacksPerRound = value; }
        }

        public override string ToString()
        {
            return base.ToString()+ $"Ilosc ataków na rónde: {AttacksPerRound}";
        }

        public override void NextLvl()
        {
            base.NextLvl();
            Strength++;
            AttacksPerRound++;
            MaxHealth = MaxHealth + 10;
            Health = Health + 10;
        }

    }
}

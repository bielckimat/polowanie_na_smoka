using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dragonLibrary.Hero
{
    public class Archer : Character
    {
        private int chanceToDodge;

        Random roller = new Random();
        public Archer(string name) : base(name)
        {
            this.Name = name;
            this.Lvl = 1;
            this.MaxHealth = 90;
            this.Health = 90;
            this.Exp = 0;
            this.Damege = 17;
            this.Defense = 10;
            this.Agility = 10;
            this.ChanceToDodge = 3;
            this.Strength = 5;
            this.Intelligence = 8;
        }

        public int ChanceToDodge
        {
            get { return chanceToDodge; }
            set { chanceToDodge = value; }
        }

        public override string ToString()
        {
            return base.ToString()+ $" Szansa na unik: {ChanceToDodge}%";
        }

        public override void DamageForHero(int Damage)
        {
            Console.WriteLine("Rolowanie");
            if(chanceToDodge<roller.Next(1,10))
            base.DamageForHero(Damage);
            else
            {}    
        }
        public override void NextLvl()
        {
            base.NextLvl();
            chanceToDodge++;
            Agility++;
        }
    }
}

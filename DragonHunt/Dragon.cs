using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dragonLibrary;
using dragonLibrary.Hero;

namespace DragonHunt
{
    public class Dragon : Character
    {
        public event dele Fire;
        public int BreathingFire()
        {
            Fire?.Invoke(Intelligence * Strength * Damege / 1000);
            Console.WriteLine($"Smok {Name} zionie ogniem o sile {Intelligence*Strength*Damege/100}");
            return Intelligence * Strength * Damege / 1000;
        }
    }
}

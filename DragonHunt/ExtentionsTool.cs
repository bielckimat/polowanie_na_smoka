using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dragonLibrary;
using dragonLibrary.Hero;

namespace DragonHunt
{
    public delegate void dele(int x);
    public static class ExtentionsTool
    {
        public static void DringBigRedPotion(this Character hero)
        {
            hero.Health = hero.MaxHealth;
        }

        public static Boolean IsHeAlive(this Character hero)
        {
            return hero.Health > 0;
        }

        public static void Exping(this Character hero,int exp)
        {
            hero.Exp+=exp;

            if (hero.Exp > ((hero.Lvl * 1000)+1000))
            {
                hero.Exp = 0;
                hero.NextLvl();
            }
        }

        public static void RegenerationMana(this Wizard hero, int manaPot) 
        {
            if (hero.Mana + manaPot > hero.MaxMana)
            {
                hero.Mana = hero.MaxMana;
            }
            else
                hero.Mana=hero.Mana+manaPot;
        }

        public static void TakingOffArmor(this Character hero,int def)
        {
            if (hero.Defense - def < 0)
                hero.Defense = 0;
            else
                hero.Defense=hero.Defense-def;
        }

        public static void TakingOffWeapon(this Character hero,int damage)
        {
            if (hero.Damege - damage < 0)
                hero.Damege = 0;
            else
                hero.Damege=hero.Damege-damage;
        }

        public static void round(List<Character> L, Dragon S)
        {
            foreach (Character item in L)
            {
                S.DamageForHero(item.Damege);
            }
            S.BreathingFire();
        }

        public static void HPInfo(List<Character> L, Dragon S)
        {
            foreach (Character item in L)
            {
                Console.WriteLine(item.Name+"  "+item.Health);
            }
            Console.WriteLine(S.Name + "  " + S.Health);
        }



    }
}

namespace dragonLibrary
{
    public abstract class Character : IComparable<Character>
    {
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private int lvl;

        public int Lvl
        {
            get { return lvl; }
            set { lvl = value; }
        }

        private int exp;

        public int Exp
        {
            get { return exp; }
            set { exp = value; }
        }

        private int strnegt;

        public int Strength
        {
            get { return strnegt; }
            set { strnegt = value; }
        }

        private int agility;

        public int Agility
        {
            get { return agility; }
            set { agility = value; }
        }

        private int intelligence;

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        private int health;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        private int maxHealth;

        public int MaxHealth
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }

        private int damege;

        public int Damege
        {
            get { return damege; }
            set { damege = value; }
        }

        private int defense;

        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }

        private readonly int damagePerRound;

        public virtual int DamagePerRound
        {
            get { return damagePerRound; }
        }


        public Character(string name, int lvl, int exp, int strnegt, int agility, int intelligence, int health, int maxHealth, int damege, int defense,int damagePerRound)
        {
            this.name = name;
            this.lvl = lvl;
            this.exp = exp;
            this.strnegt = strnegt;
            this.agility = agility;
            this.intelligence = intelligence;
            this.health = health;
            this.maxHealth = maxHealth;
            this.damege = damege;
            this.defense = defense;
            this.damagePerRound = damagePerRound;
        }

        public Character(){}

        protected Character(string name) 
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"imie :{name} Poziom: {lvl} Doświadczenie: {exp} Siła:{strnegt} Zręczność: {agility} " +
                $"Intelięcja: {Intelligence} MaxHP: {MaxHealth} HP:{Health} Obrona: {Defense} Obrażenia: {Damege}";
        }

        public void NewArmor(int Armor)
        {
            defense = defense + Armor;
        }

        public void NewWeapon(int WeaponDamage)
        {
            damege = damege + WeaponDamage;
        }

        public virtual void DamageForHero(int Damage)
        {
            health = (health+Defense) - Damage;
        }

        public virtual void NextLvl()
        {

            lvl++;
            if(lvl %5 == 0)
            {
                NewWeapon(10);
                NewArmor(10);
            }
            
        }

      

      
        public int CompareTo(Character? other)
        {
                
            if(lvl.CompareTo(other.lvl) < 0)
                return -1;
            if (lvl.CompareTo(other.lvl) > 0)
                return 1;
            else return 0;
        }
    }
}
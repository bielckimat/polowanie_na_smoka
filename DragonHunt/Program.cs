using dragonLibrary;
using dragonLibrary.Hero;
using DragonHunt;
{

    Wizard Mateusz = new Wizard("Mateusz");
    Warrior Geralt = new Warrior("Geralt");
    Archer Legolas = new Archer("Legolas");
    List < Character> HeroList = new List<Character>();
    HeroList.Add(Legolas);
    HeroList.Add(Geralt);
    HeroList.Add(Mateusz);
    
    Dragon Smaug = new Dragon { Name = "Smaug", Intelligence = 50, Lvl = 10, Strength = 20,Damege=30,Health=2500,MaxHealth=2500};
    Smaug.Fire += e =>
    {
        foreach (Character item in HeroList)
        {
            item.DamageForHero(e);
        }
    };

    Mateusz.Exping(2500);
    Geralt.Exping(2500);
    Legolas.Exping(2500);
    
    
    
    


   
    char input = '7';
    while (input!='0')
    {
        Console.WriteLine("1: EXPIENIE\n2:WALKA ZE SMOKIEM\n3:Informacje o drużynie\n9:CHACKI");
        input = Console.ReadKey().KeyChar;
        Console.Clear();
        switch (input)
        {
            case '1':
                {
                    foreach (Character item in HeroList)
                        item.Exping(5000);
                    Console.WriteLine("Expimy...");
                        Thread.Sleep(2000);
                    Console.WriteLine("Dalej:7\n0:EXIT");
                    input = Console.ReadKey().KeyChar;
                    Console.Clear();
                }
                break;
            case '2': 
                {
                    while ((Mateusz.IsHeAlive() || Legolas.IsHeAlive() || Geralt.IsHeAlive()) && Smaug.IsHeAlive())
                    {
                        ExtentionsTool.round(HeroList, Smaug);
                        ExtentionsTool.HPInfo(HeroList, Smaug);
                        if ((Mateusz.IsHeAlive() || Legolas.IsHeAlive() || Geralt.IsHeAlive()))
                            Console.WriteLine("Drużyna Pokonała Smoka");
                        else
                            Console.WriteLine("Smok Wygrał");
                        input = '0';
                    }
                }
                break;
            case '9':
                {
                    for(int i = 0; i < 150; i++)
                    foreach (Character item in HeroList)
                        item.Exping(100000);
                    Console.WriteLine("NIE ŁADNIE CHULATAJU OSZUKIWAĆ !!!!!! ");
                    Console.WriteLine("Dalej:7\n0:EXIT");
                    input = Console.ReadKey().KeyChar;
                    Console.Clear();
                }
                break;
            case '3':
                {
                    foreach (Character item in HeroList)
                    {
                        Console.WriteLine(item.ToString());
                    }

                    Console.WriteLine("Dalej:7\n0:EXIT");
                    input = Console.ReadKey().KeyChar;
                    Console.Clear();
                }
                break;


        }
    }
    
}
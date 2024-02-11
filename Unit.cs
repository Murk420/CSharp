// ---- C# II (Dor Ben Dor) ----
// Mark Kaplan
// -----------------------------    

abstract class Unit
{
    //Giving the unit a name to easily identify him from the other Units
    public string Name { get; protected set; }
    public void GiveName()
    {
        // Generate a random index based on the number of items in the enum
        int rnd = new Random().Next(Enum.GetValues(typeof(Names)).Length);
        // Use the random index to get a name from the enum
        Name = ((Names)rnd).ToString();
    }
    //Health
    protected int hp;
    protected int maxHp;
    public int HP
    {
        get { return hp; }
        protected set
        {
            if (value <= 0)
            {
                hp = 0;
                isdead = true;
            }
            if (hp > maxHp)
            {
                hp = maxHp;
            }
            hp = value;
        }
    }
    //When the Unit's HP drops to 0 he isdead
    public bool isdead = false;
    //Resources
    protected int res;
    public int Res
    {
        get { return res; }
        protected set
        {
            if (res > caca)
            {
                res = caca;
            }
            res = value;
        }
    }
    //Resource Carrying Capacity
    protected int caca;
    //General Interface that generates the Units Damage
    protected virtual IRandomProvider Dmg { get; set; }
    //Provides the Damage Dealt in a readble way other Units can see
    public int dmgDealt;
    //Method for setting the Units Stats
    public Race Racist { get; protected set; }
    public abstract void Attack(Unit EnemyUnit);
    public abstract void Defend(Unit EnemyUnit);
    public void Heal()
    {
        if (hp < (maxHp / 2))
        {

            if (Racist == Race.Vampire || Racist == Race.Werewolf)
            {
                HP += (dmgDealt / 4);
                Console.WriteLine(this + "Regenerated!");
            }
            else
            {
                HP += 3;
                Console.WriteLine(this + "Healed!");
            }
        }
    }

    //Method for different Weather effects on different Races
    protected int weatherModifier = 0;
    public void WeatherEffect(Weather weather, Race race)
    {
        switch (weather, race)
        {
            case (Weather.Heatwave, Race.Human):
                weatherModifier = -2;
                break;
            case (Weather.Heatwave, Race.Vampire):
                weatherModifier = -2;
                break;
            case (Weather.Heatwave, Race.Werewolf):
                weatherModifier = -2;
                break;

            case (Weather.Warm, Race.Human):
                weatherModifier = 0;
                break;
            case (Weather.Warm, Race.Vampire):
                weatherModifier = -1;
                break;
            case (Weather.Warm, Race.Werewolf):
                weatherModifier = -1;
                break;

            case (Weather.Nice, Race.Human):
                weatherModifier = 2;
                break;
            case (Weather.Nice, Race.Vampire):
                weatherModifier = 1;
                break;
            case (Weather.Nice, Race.Werewolf):
                weatherModifier = 1;
                break;

            case (Weather.Cold, Race.Human):
                weatherModifier = 0;
                break;
            case (Weather.Cold, Race.Vampire):
                weatherModifier = 2;
                break;
            case (Weather.Cold, Race.Werewolf):
                weatherModifier = 1;
                break;

            case (Weather.Freezing, Race.Human):
                weatherModifier = -2;
                break;
            case (Weather.Freezing, Race.Vampire):
                weatherModifier = 1;
                break;
            case (Weather.Freezing, Race.Werewolf):
                weatherModifier = 2;
                break;
        }

    }

    public void Loot(Unit EnemyUnit)
    {
        Res += EnemyUnit.Res;
    }
}
public enum Race
{
    Human,
    Vampire,
    Werewolf
}
public enum Weather
{
    Heatwave,
    Warm,
    Nice,
    Cold,
    Freezing
}
public enum Names
{
    Kyle,
    Randy,
    Jeff,
    Stan,
    Alex,
    Kristoff,
    Edward,
    Nicolaj,
    Benjamin,
    Elijah,
    Lorenzo,
    Fredrick,
    Marcus,
    DorBenDor,
    Bingus,
    Patrick,
    David,
    Phineas,
}














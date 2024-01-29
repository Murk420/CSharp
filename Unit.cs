// ---- C# II (Dor Ben Dor) ----
// Mark Kaplan
// -----------------------------    

abstract class Unit
{
    public bool isdead = false;
    public Unit()
    {
        SetStats();
    }


    public Dice ChanceDice = new(2, 6, 0);
    public Dice DmgDice = new(1, 10, 0);
    //Health
    protected int hp;
    //Resources
    protected int res;
    //Carrying Capacity
    protected int caca;   
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
   
    protected virtual void SetStats()
    {
        hp = 100;
        res = 7;
        caca = 21;
    }
    public virtual int HP
    {
        get { return hp; }
        protected set
        {
            if (value <= 0)
            {
                hp = 0;
                isdead = true;
            }
            hp = value;
        }
    }
    public Race Racist { get; set; }
    public abstract void Attack(Unit EnemyUnit);
    public abstract void Defend(Unit EnemyUnit);
    //Amount of Resources Looted
    public int ResLooted = 0;
    public void Loot(Unit EnemyUnit)
    {
        //Resources before loot
        int lootb4 = Res;
        Res += EnemyUnit.Res;
        ResLooted += (Res - lootb4);
    }
    int WeatherModifier = 0;
    //Method for different Weather effects on different Races
    public void WeatherEffect(Weather weather, Race race)
    {
        switch (weather, race)
        {
            case (Weather.Heatwave, Race.Human):
                WeatherModifier = -2;
                break;
            case (Weather.Heatwave, Race.Vampire):
                WeatherModifier = -2;
                break;
            case (Weather.Heatwave, Race.Werewolf):
                WeatherModifier = -2;
                break;

            case (Weather.Warm, Race.Human):
                WeatherModifier = 0;
                break;
            case (Weather.Warm, Race.Vampire):
                WeatherModifier = -1;
                break;
            case (Weather.Warm, Race.Werewolf):
                WeatherModifier = -1;
                break;

            case (Weather.Nice, Race.Human):
                WeatherModifier = 2;
                break;
            case (Weather.Nice, Race.Vampire):
                WeatherModifier = 1;
                break;
            case (Weather.Nice, Race.Werewolf):
                WeatherModifier = 1;
                break;

            case (Weather.Cold, Race.Human):
                WeatherModifier = 0;
                break;
            case (Weather.Cold, Race.Vampire):
                WeatherModifier = 2;
                break;
            case (Weather.Cold, Race.Werewolf):
                WeatherModifier = 1;
                break;

            case (Weather.Freezing, Race.Human):
                WeatherModifier = -2;
                break;
            case (Weather.Freezing, Race.Vampire):
                WeatherModifier = 1;
                break;
            case (Weather.Freezing, Race.Werewolf):
                WeatherModifier = 2;
                break;
        }
        DmgDice.Modifier = WeatherModifier;
        ChanceDice.Modifier = WeatherModifier;
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














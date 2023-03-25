Spell Snakebite = new Spell(20, "Нанесение урона по области действия.", "Snakebite");
Spell VipersNest = new Spell(100, " УЛЬТААААААА !!!! Создается ядовитое облако, которое покрывает огромную территорию.", "VipersNest");
Magician Viper = new Magician("Viper", 100);

Viper.CastSpell(Snakebite);//удалить для того чтобы хватило манны
Viper.CastSpell(VipersNest);
Console.ReadKey(true);
class Spell
{
    public int Mana { get; private set; }
    private string Effect { get; set; }
    public string Spellname { get; set; }
    public Spell(int mana, string effect,string spellname)
    {
        Mana = mana;
        Effect = effect;
        Spellname = spellname;
    }
    public void Use() { Console.WriteLine(Effect); }
}
class Magician
{
    public string Name { get; private set; }
    public int Mana { get; private set; }
    public Magician(string name, int mana)
    {
        Name = name;
        Mana = mana;
    }
    public void CastSpell(Spell spell)
    {
        if (Mana >= spell.Mana)
        {
            Console.WriteLine(Name + " Использует способность!");
            spell.Use(); Mana -= spell.Mana;
        }
        else
        {
            
            Console.WriteLine("Для испольования " + "заклинания " + spell.Spellname + " не хватает " + (Math.Abs(spell.Mana - Mana)) + " единиц маны." +
            " Хлебните зелья!");
        }
    }
}





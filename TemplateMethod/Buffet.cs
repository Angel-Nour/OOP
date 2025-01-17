namespace TemplateMethod;

public abstract class Buffet
{
    public void Cook()
    {
        BoilWater();
        Ingredient();
        IsSugar();
        AddSugar();
        Adds();
    }
    
    private static void BoilWater()
    {
        Console.WriteLine("Вскипитим воду");
    }

    protected abstract void Ingredient();

    private static void IsSugar()
    {
        Console.WriteLine("Сахар? (да - 1, нет - 0");
        var isSugar = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(isSugar == 1 ? "Сахарок значит добавим" : "Как можно пить без сахара?");
    }

    private static void AddSugar()
    {
        Console.WriteLine("Добавляем сахар");
    }

    protected abstract void Adds();
}
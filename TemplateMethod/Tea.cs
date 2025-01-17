namespace TemplateMethod;

public class Tea : Buffet
{
    protected override void Ingredient()
    {
        Console.WriteLine("Чаек");
    }

    protected override void Adds()
    {
        Console.WriteLine("Лимон в чай");
    }
}
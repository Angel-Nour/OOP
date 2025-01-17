namespace TemplateMethod;

public class Coffee : Buffet
{
    protected override void Ingredient()
    {
        Console.WriteLine("Кофеек");
    }

    protected override void Adds()
    {
        Console.WriteLine("Молоко в кофе");
    }
}
namespace AbstractFactory;

public abstract class SweetsCreator
{
    protected abstract ICaramel CreateCaramel();
    protected abstract IChocolate CreateChocolate();
    protected abstract ILollipops CreateLollipops();
    public string CreateCaramelSweets() 
    {
        Console.WriteLine("Caramel");
        var caramel = CreateCaramel();
        return caramel.Try();
    }
    public string CreateChocolateSweets()
    {
        Console.WriteLine("Chocolate");
        var chocolate = CreateChocolate();
        return chocolate.Try();
    }
    public string CreateLollipopsSweets() 
    {
        Console.WriteLine("Lollipops");
        var lollipops = CreateLollipops();
        return lollipops.Try();
    }
}
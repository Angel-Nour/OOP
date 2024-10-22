namespace AbstractFactory;

public class BucuriaCreator : SweetsCreator
{
    protected override ICaramel CreateCaramel()
    {
        return new BucuriaCaramel();
    }
    
    protected override IChocolate CreateChocolate()
    {
        return new BucuriaChocolate();
    }
    
    protected override ILollipops CreateLollipops()
    {
        return new BucuriaLollipops();
    }
}
namespace AbstractFactory;

public class RoshenCreator : SweetsCreator
{
    protected override ICaramel CreateCaramel()
    {
        return new RoshenCaramel();
    }
    
    protected override IChocolate CreateChocolate()
    {
        return new RoshenChocolate();
    }
    
    protected override ILollipops CreateLollipops()
    {
        return new RoshenLollipops();
    }
}
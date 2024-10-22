namespace AbstractFactory;

public class SlavyankaCreator : SweetsCreator
{
    protected override ICaramel CreateCaramel()
    {
        return new SlavyankaCaramel();
    }
    
    protected override IChocolate CreateChocolate()
    {
        return new SlavyankaChocolate();
    }
    
    protected override ILollipops CreateLollipops()
    {
        return new SlavyankaLollipops();
    }
}
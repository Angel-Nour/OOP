namespace Strategy.Ducks;

public class OrdinaryDuck : Duck
{
    public OrdinaryDuck() : base(new OrdinaryFly(), new DoSwim(), new DoCrack())
    {
    }
}
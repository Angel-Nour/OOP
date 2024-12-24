namespace Strategy.Ducks;

public class ArtificialDuck : Duck
{
    public ArtificialDuck() : base(new ArtificialFly(), new DoSwim(), new DoCrack())
    {
    }
}
namespace Strategy.Ducks;

public class RubberDuck : Duck
{
    public RubberDuck() : base(new NoFly(), new DoSwim(), new PeepCrack())
    {
    }
}
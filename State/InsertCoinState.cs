namespace State;

public class InsertCoinState : IState
{
    public IState InsertCoin()
    {
        Console.WriteLine("Монетка уже вставлена.");
        return this;
    }

    public IState EjectCoin()
    {
        Console.WriteLine("Монета возвращена.");
        return new EjectCoinState();
    }

    public IState TurnCrank()
    {
        Console.WriteLine("Вы повернули рычаг.");
        return new TurnCrankState();
    }

    public IState Dispense()
    {
        Console.WriteLine("Сначала вставьте монетку.");
        return this;
    }
}
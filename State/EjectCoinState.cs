namespace State;

public class EjectCoinState : IState
{
    public IState InsertCoin()
    {
        Console.WriteLine("Монета вставлена.");
        return new InsertCoinState();
    }

    public IState EjectCoin()
    {
        Console.WriteLine("Монета уже возвращена.");
        return this;
    }

    public IState TurnCrank()
    {
        Console.WriteLine("Вы не можете повернуть рычаг, монета была возвращена.");
        return this;
    }

    public IState Dispense()
    {
        Console.WriteLine("Монета была возвращена, жвачка не может быть выдана.");
        return this;
    }
}
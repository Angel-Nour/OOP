namespace State;

public class DispenseState : IState
{
    public IState InsertCoin()
    {
        Console.WriteLine("Подождите, идет выдача жвачки.");
        return this;
    }

    public IState EjectCoin()
    {
        Console.WriteLine("Жвачка выдается, монетка не может быть возвращена.");
        return this;
    }

    public IState TurnCrank()
    {
        Console.WriteLine("Вы уже повернули рычаг.");
        return this;
    }

    public IState Dispense()
    {
        Console.WriteLine("Жвачка выдана.");
        return new InsertCoinState();
    }
}
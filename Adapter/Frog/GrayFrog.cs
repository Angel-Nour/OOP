namespace Adapter;

public class GrayFrog : IFrog
{
    public string Jump()
    {
        return "Лягушечка прыгает по кувшинкам";
    }

    public string Eat()
    {
        return "Лягушечка ловит комаров";
    }
}
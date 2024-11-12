namespace Adapter;

public class BigFrog : IFrog
{
    public string Jump()
    {
        return "Лягушечка прыгает по кувшинкам";
    }

    public string Croaks()
    {
        return "Лягушечка квакает";
    }
}
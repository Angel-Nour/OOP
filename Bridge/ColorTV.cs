namespace Bridge;

public class ColorTV : ITV
{
    public string OnOff(bool f)
    {
        if (f)
            return "Включили цветной телевизор";
        else
            return "Выключили цветной телевизор";
    }

    public int GetChannel()
    {
        return 99;
    }

    public string Set(int c)
    {
        return $"Переключаем цветной телевизор на {c} канал";
    }
}
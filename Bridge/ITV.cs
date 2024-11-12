namespace Bridge;

public interface ITV
{
    string OnOff(bool f);
    string Set(int c);
    int GetChannel();
}
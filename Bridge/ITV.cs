namespace Bridge;

public interface ITV
{
    string OnOff(bool status);
    string Set(int channel);
}
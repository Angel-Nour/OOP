namespace Proxy;

public interface IMyFile
{
    string GetPuth();
    byte[] ReadAll();
    long Size();
}
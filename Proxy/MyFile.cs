namespace Proxy;

public class MyFile : IMyFile
{
    private string _path;
    public MyFile(string path)
    {
        _path = path;
    }

    public string GetPuth()
    {
        return _path;
    }

    public byte[] ReadAll()
    {
        using (FileStream file = File.OpenRead(_path))
        {
            byte[] bytes = new byte[file.Length];
            file.Read(bytes, 0, bytes.Length);
            return bytes;
        }
    }

    public long Size()
    {
        using (FileStream file = new FileStream(_path, FileMode.Open, FileAccess.Read))
        {
            return file.Length;
        }
    }
}
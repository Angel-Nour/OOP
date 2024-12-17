namespace Proxy;

public class FileProxy : IMyFile
{
    private MyFile? _myFile;
    private string _path;
    public FileProxy(string path)
    {
        _path = path;
    }
    
    public string GetPuth()
    {
        return _path;
    }

    public byte[] ReadAll()
    {
        if (_myFile == null)
        {
            _myFile = new MyFile(_path);
        }
        return _myFile.ReadAll();
    }

    public long Size()
    {
        if (_myFile == null)
        {
            FileInfo file = new FileInfo(_path);
            return file.Length;
        }
        else
        {
            return _myFile.Size();
        }
    }
}
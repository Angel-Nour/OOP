namespace CoR;

public interface IWorker
{
    void SetNext(IWorker worker);
    string HandleTask(string task, int level);
}
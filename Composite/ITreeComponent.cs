namespace Composite;

public interface ITreeComponent : IEnumerable<int>
{
    int Value { get; }
    void Add(ITreeComponent _child);
}
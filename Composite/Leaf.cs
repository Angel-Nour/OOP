using System.Collections;

namespace Composite;

public class Leaf : ITreeComponent
{
    public int Value { get; private set; }

    public Leaf(int value)
    {
        Value = value;
    }
    public IEnumerator<int> GetEnumerator()
    {
        yield return Value;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    public void Add(ITreeComponent _child)
    {
        throw new InvalidOperationException("Нельзя к листу что-то добавить");
    }
}
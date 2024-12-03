using System.Collections;

namespace Composite;

public class Node : ITreeComponent
{
    public int Value { get; private set; }
    private List<ITreeComponent> _children = new List<ITreeComponent>();
    public Node(int value)
    {
        Value = value;
    }
    public IEnumerator<int> GetEnumerator()
    {
        yield return Value;

        foreach (var child in _children)
        {
            foreach (var value in child)
            {
                yield return value;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    public void Add(ITreeComponent _child)
    {
        _children.Add(_child);
    }
}
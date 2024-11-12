using System.Collections;

namespace Composite;

public class Node : ITreeComponent
{
    public int Value { get; private set; }
    private List<ITreeComponent> _children = new List<ITreeComponent>();
    public Node(int val)
    {
        Value = val;
    }
    public IEnumerator<int> GetEnumerator()
    {
        yield return Value;

        foreach (var child in _children)
        {
            foreach (var val in child)
            {
                yield return val;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    public void Add(ITreeComponent _comp)
    {
        _children.Add(_comp);
    }
}
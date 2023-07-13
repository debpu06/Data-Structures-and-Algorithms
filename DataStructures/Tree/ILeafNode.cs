using System.Collections.Generic;

namespace Structures.Tree
{
    public interface ILeafNode<T>
    {
        bool HasChildren();
        IEnumerable<ILeafNode<T>> GetChildren();
        T GetValue();
    }
}
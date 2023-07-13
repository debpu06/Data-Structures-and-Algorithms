using System.Collections.Generic;

namespace Structures.Tree
{
    public interface ITree<T>
    {
        bool IsEmpty();
        bool IsRoot(T leaf);
        T GetParent(T leaf);
        T GetRoot();
    }
}
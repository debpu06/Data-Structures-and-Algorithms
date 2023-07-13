using System.Collections.Generic;
using System.Linq;
using Structures.Tree;

namespace Tests.Tree {
    public class Tree : ITree<Leaf>
    {
        private Leaf Root{ get; set; }
        public Leaf GetParent(Leaf leaf)
        {
            throw new System.NotImplementedException();
        }

        public Leaf GetRoot()
        {
            return Root;
        }

        public bool IsEmpty()
        {
            return Root == null;
        }

        public bool IsRoot(Leaf leaf)
        {
            return leaf == Root;
        }
    }
}
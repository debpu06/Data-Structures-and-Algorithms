

namespace Structures.Tree {
    public class BinaryTree : ITree<BinaryLeafNode>
    {
        private BinaryLeafNode Root { get; set; }
        public BinaryLeafNode GetParent(BinaryLeafNode leaf)
        {
            throw new System.NotImplementedException();
        }

        public BinaryLeafNode GetRoot()
        {
            return Root;
        }

        public BinaryLeafNode Insert(string value)
        {
            return Root;
        }

        public bool IsEmpty()
        {
            return Root == null;
        }

        public bool IsRoot(BinaryLeafNode leaf)
        {
            return leaf == Root;
        }
    }
}
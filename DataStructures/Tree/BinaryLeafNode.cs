
using System.Collections.Generic;

namespace Structures.Tree {
    public class BinaryLeafNode : ILeafNode<string>
    {
        private string Value { get; set; }
        private ILeafNode<string> LeftNode { get; set; }
        private ILeafNode<string> RightNode { get; set; }
        private ILeafNode<string> Parent { get; set; }

        public BinaryLeafNode() {

        }

        public BinaryLeafNode(string value, ILeafNode<string> parent) {
            this.Value = value;
            this.Parent = parent;
        }

        public IEnumerable<ILeafNode<string>> GetChildren()
        {
            return new List<ILeafNode<string>>() { LeftNode, RightNode };
        }

        public void InsertLeft(string value)
        {
            if(LeftNode != null)
                throw new System.Exception();

            LeftNode = new BinaryLeafNode(value, this);
        }

        public void InsertRight(string value)
        {
            if(RightNode != null)
                throw new System.Exception();

            RightNode = new BinaryLeafNode(value, this);
        }

        public ILeafNode<string> GetParent()
        {
            return Parent;
        }

        public string GetValue()
        {
            return Value;
        }

        public bool HasChildren()
        {
            return (RightNode != null || LeftNode != null);
        }
    }
}
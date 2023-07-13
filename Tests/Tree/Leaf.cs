
using System.Collections.Generic;
using System.Linq;
using Structures.Tree;

namespace Tests.Tree
{
    public class Leaf : ILeafNode<string>
    {
        private IEnumerable<Leaf> Children{ get; set; }
        private string Value { get; set; }
        public IEnumerable<ILeafNode<string>> GetChildren()
        {
            return Children;
        }

        public string GetValue()
        {
            return Value;
        }

        public bool HasChildren()
        {
            return Children != null && Children.Any();
        }
    }
}
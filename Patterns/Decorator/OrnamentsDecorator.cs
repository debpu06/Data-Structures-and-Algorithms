namespace Patterns.Decorator
{
    public class OrnamentsDecorator : TreeDecorator
    {
        private Tree _tree;

        public OrnamentsDecorator(Tree tree)
        {
            _tree = tree;
        }

        public override string GetDescription()
        {
            return $"{_tree.GetDescription()}, with ornaments";
        }
    }
}
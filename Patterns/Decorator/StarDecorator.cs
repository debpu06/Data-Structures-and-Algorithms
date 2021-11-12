namespace Patterns.Decorator
{
    public class StarDecorator : TreeDecorator
    {
        private Tree _tree;

        public StarDecorator(Tree tree)
        {
            _tree = tree;
        }

        public override string GetDescription()
        {
            return $"{_tree.GetDescription()}, with a star";
        }
    }
}
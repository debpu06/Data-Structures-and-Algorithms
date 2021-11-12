namespace Patterns.Decorator
{
    public class LightsDecorator : TreeDecorator
    {
        private Tree _tree;

        public LightsDecorator(Tree tree)
        {
            _tree = tree;
        }

        public override string GetDescription()
        {
            return $"{_tree.GetDescription()}, with lights";
        }
    }
}
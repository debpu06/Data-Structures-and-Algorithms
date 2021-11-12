using System;
using Patterns.Decorator;

public class DecoratorTest
{
    public void Test()
    {
        Tree tree = new Tree();
        tree = new LightsDecorator(tree);
        tree = new OrnamentsDecorator(tree);
        tree = new StarDecorator(tree);

        Console.WriteLine(tree.GetDescription());
    }    
}
using System;
using Patterns.Decorator;

public class DecoratorTest : ITest
{
    public void Run()
    {
        Tree tree = new Tree();
        tree = new LightsDecorator(tree);
        tree = new OrnamentsDecorator(tree);
        tree = new StarDecorator(tree);

        Console.WriteLine(tree.GetDescription());
    }    
}
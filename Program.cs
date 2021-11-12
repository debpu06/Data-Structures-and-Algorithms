using System;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest test;
            test = new StackTest();
            test.Run();
            test = new ObserverPatternTest();
            test.Run();
            test = new DecoratorTest();
            test.Run();
        }
    }
}

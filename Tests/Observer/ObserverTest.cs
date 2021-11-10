
using Patterns.Observer;
using System;

public class ObserverPatternTest
{
    public void Test()
    {
        var observer1 = new TestObserver() { Name = "Observer 1" };
        var observer2 = new TestObserver() { Name = "Observer 2" };

        var subject = new TestSubject();

        subject.AddObserver(observer1);
        subject.AddObserver(observer2);

        subject.DoSomething();
    }
}

public class TestObserver : IObserver
{
    public string Name { get;set; }
    public void Update(Object data)
    {
        Console.WriteLine("{0} Received Data: {1}", Name, data);
    }
}

public class TestSubject : Subject
{
    public void DoSomething()
    {
        var testData = new { item1 = "test 1" };

        NotifyObservers(testData);
    }
}
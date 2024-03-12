namespace Assemblies_ConsoleApp;

interface IMyInterface
{
    void Foo();
}


internal class MyClass : IMyInterface
{
    public void Foo()
    {
        throw new NotImplementedException();
    }
}

public static class Test
{
    public static void Foo(MyClass obj)
    {
        
    }
}
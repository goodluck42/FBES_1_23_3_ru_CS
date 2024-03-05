namespace Assemblies_MathLibrary;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    protected internal int Subtract(int a, int b)
    {
        return a - b;
    }

    internal int Mult(int a, int b)
    {
        return a * b;
    }

    private protected int Div(int a, int b)
    {
        return a / b;
    }
    
}

public class CalculatorWrapper : Calculator
{
    public CalculatorWrapper()
    {
        this.Div(10, 3);
    }
}
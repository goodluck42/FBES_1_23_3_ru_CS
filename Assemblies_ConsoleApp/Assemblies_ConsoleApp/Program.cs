using Assemblies_MathLibrary;

var calc = new Calculator();

calc.Add(5, 1);
calc.Subtract(10, 3);
calc.Mult(10, 3);
calc.Div(10, 3);

Console.WriteLine(calc.Add(10, 5));

public class MyCalcutor : Calculator
{
    public MyCalcutor()
    {
        this.Subtract(10, 20);
        this.Div(10, 3);
    }
} 
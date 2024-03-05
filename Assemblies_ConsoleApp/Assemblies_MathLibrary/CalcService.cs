namespace Assemblies_MathLibrary;

internal class CalcService
{
    public CalcService()
    {
        var calc = new Calculator();

        calc.Mult(10, 3);
        calc.Subtract(10, 20);
    }
}
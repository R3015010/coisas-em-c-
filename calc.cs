using System;
double n1 = 5;
double n2 = 10;
Calc c1 = new Calc();
Console.WriteLine($"soma: {c1.Somar(n1, n2):F2}");
public class Calc
{
    public double Somar(double a, double b) { return a + b; }
    public double Subtrair(double a, double b) { return a - b; }
    public double Multiplicar(double a, double b) { return a * b; }
}



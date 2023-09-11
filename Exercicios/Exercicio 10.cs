using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor: ");
        double valor3 = Convert.ToDouble(Console.ReadLine());

        // a. Média Aritmética
        double mediaAritmetica = (valor1 + valor2 + valor3) / 3;

        // b. Média Harmônica
        double mediaHarmônica = 3 / ((1 / valor1) + (1 / valor2) + (1 / valor3));

        // c. Média Geométrica
        double mediaGeometrica = Math.Pow((valor1 * valor2 * valor3), 1.0 / 3);

        Console.WriteLine("Média Aritmética: " + mediaAritmetica);
        Console.WriteLine("Média Harmônica: " + mediaHarmônica);
        Console.WriteLine("Média Geométrica: " + mediaGeometrica);
    }
}
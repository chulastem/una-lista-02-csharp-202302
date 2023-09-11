using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o número para o qual deseja calcular o logaritmo: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a base do logaritmo: ");
        double baseLogaritmo = Convert.ToDouble(Console.ReadLine());

        if (numero > 0 && baseLogaritmo > 0 && baseLogaritmo != 1)
        {
            double resultado = Math.Log(numero, baseLogaritmo);
            Console.WriteLine("O logaritmo de " + numero + " na base " + baseLogaritmo + " é: " + resultado.ToString("F4"));
        }
        else
        {
            Console.WriteLine("Os números devem ser maiores que zero e a base não pode ser 1.");
        }
    }
}
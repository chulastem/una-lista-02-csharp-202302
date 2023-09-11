using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite o valor do capital a ser aplicado: ");
        double capital = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o prazo de aplicação em meses: ");
        int prazoMeses = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a taxa de juros mensal (em decimal): ");
        double taxaJurosMensal = Convert.ToDouble(Console.ReadLine());

        double montante = capital * Math.Pow(1 + taxaJurosMensal, prazoMeses);

        Console.WriteLine("O montante a ser recebido é: " + montante.ToString("F2"));
	}
}
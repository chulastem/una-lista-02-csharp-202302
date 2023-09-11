using System;
public class Program
{
	public static void Main()
	{
		double produto, produto10;

		Console.WriteLine("Digite o valor do produto: ");
		produto = Convert.ToDouble(Console.ReadLine());
		produto10 = produto*0.10;
		Console.WriteLine("Novo valor do produto: "+ (produto10 + produto));
	}
}
using System;

public class Program
{
	public static void Main()
	{
		double n1, n2, media;

		Console.WriteLine("Digite o primeiro nº: ");
		n1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Digite o segundo nº: ");
		n2 = Convert.ToDouble(Console.ReadLine());

		media = (n1+n2)/2;

		Console.WriteLine("A media aritmetica dos números digitados é " + media);
	}
}
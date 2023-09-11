using System;
public class Program
{
	public static void Main()
	{
		double f, c;
		Console.WriteLine("Digite a teputeratura em F°: ");
		f = Convert.ToDouble(Console.ReadLine());
		c = (f - 32)/ 1.8;
		Console.WriteLine("Temperatura em C°: "+ c);
	}
}
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o salario fixo do vendedor: ");
        double salario = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite valor total das vendas que ele realizou no mês: ");
        double vendas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o percentual que ele ganha sobre o total das vendas mensais:(Em decimal)");
        double percent = Convert.ToDouble(Console.ReadLine());

        double total = (vendas * percent) + salario;

        Console.WriteLine("O salário final do vendedor é: " + total);

    }
}
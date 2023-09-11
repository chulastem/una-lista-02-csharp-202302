using System;

public class Program
{
    public static void Main()
    {
        // a. Número de horas que o funcionário trabalhou no mês.
        Console.WriteLine("Informe o número de horas trabalhadas no mês: ");
        int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

        // b. Valor recebido por hora de trabalho.
        Console.WriteLine("Informe o valor recebido por hora de trabalho: ");
        double valorPorHora = Convert.ToDouble(Console.ReadLine());

        // c. Valor do salário família.
        Console.WriteLine("Informe o valor do salário família: ");
        double salarioFamilia = Convert.ToDouble(Console.ReadLine());

        // d. Número de filhos com idade menor que 14 anos
        Console.WriteLine("Informe o número de filhos com idade menor que 14 anos: ");
        int numeroFilhos = Convert.ToInt32(Console.ReadLine());

        double salarioBruto = horasTrabalhadas * valorPorHora + salarioFamilia * numeroFilhos;

        Console.WriteLine("O salário bruto a ser recebido é: " + salarioBruto.ToString("F2"));
    }
}
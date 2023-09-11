using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe o total de veículos no estacionamento: ");
        int totalVeiculos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o total de rodas no estacionamento: ");
        int totalRodas = Convert.ToInt32(Console.ReadLine());

        int numeroCarros = 0;
        int numeroMotos = 0;

        for (int i = 0; i <= totalVeiculos; i++)
        {
            int rodasRestantes = totalRodas - (i * 4);
            if (rodasRestantes >= 0 && rodasRestantes % 2 == 0)
            {
                numeroCarros = i;
                numeroMotos = rodasRestantes / 2;
            }
        }

        Console.WriteLine("Há " + numeroCarros + " carros e " + numeroMotos + " motos no estacionamento.");

    }
}
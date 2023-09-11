using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o número de segundos: ");
        int totalSegundos = Convert.ToInt32(Console.ReadLine());

        int horas = totalSegundos / 3600;
        int minutos = (totalSegundos % 3600) / 60;
        int segundos = totalSegundos % 60;
        Console.WriteLine("Horas: " + horas + ", Minutos: " + minutos + ", Segundos: " + segundos);

    }
}
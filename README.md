# una-lista-02-csharp-202302
Pedro Antonio Esteves Silva - RA: 622122907

# Lista de Exercícios II: Estrutura Sequencia

## UC - Estrutura de dados e análise de algoritmos

1 - Escreva um algoritmo que leia dois números informados pelo usuário a partir
do teclado e que apresente o resultado da média aritmética dos dois números
informados.

```csharp
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
```

2-Escreva um algoritmo que leia o preço de um produto a partir do teclado e
apresente na tela o valor do produto acrescido de 10% de seu valor original.
Exemplo:
Informe o valor do produto: 50.00
Novo valor do produto: 55.00

```csharp
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
```

3-Escreva um algoritmo que leia uma temperatura fornecida pelo usuário a partir
do teclado em graus Fahrenheit e a converta para o seu equivalente em graus
centígrados.
OBS.: °C = (°F − 32) / 1,8

```csharp
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
```

4-Escreva um algoritmo para calcular os juros compostos de uma aplicação
financeira. O algoritmo deve ler o valor do capital a ser aplicado, o prazo de
aplicação em meses, a taxa de juros mensal e apresentar na tela o montante a
ser recebido.
OBS: M = C × (1 + i) n
, em que M é o montante a ser recebido, C é o capital
aplicado, i é a taxa de juros e n é o prazo da aplicação.

```csharp
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
```

5-Escreva um algoritmo para calcular e imprimir o salário bruto a ser recebido
por um funcionário em um mês.
O programa deverá utilizar os seguintes dados:
a. Número de horas que o funcionário trabalhou no mês.
b. Valor recebido por hora de trabalho.
c. Valor do salário família.
d. Número de filhos com idade menor que 14 anos, para calcular o salário
família.

```csharp
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
```

6-Escreva um algoritmo que receba dois números a partir do teclado. O
algoritmo deve imprimir o logaritmo do primeiro número na base
representada pelo segundo número.

```csharp
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
```

7-Escreva um algoritmo que leia o salário fixo de um vendedor, o valor total das
vendas que ele realizou no mês e o percentual que ele ganha sobre o total das
vendas mensais. O algoritmo deve calcular o salário total do vendedor e
apresentá-lo na tela.

```csharp
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
		
		double total = (vendas * percent)+salario;
		
		Console.WriteLine("O salário final do vendedor é: "+ total);
        
	}
}
```

8-Em um estacionamento há carros e motos. Escreva um algoritmo que solicite
ao usuário o total de veículos e o total de rodas.
O algoritmo deve determinar quantos carros e quantas motos há no
estacionamento. O resultado deve ser apresentado na tela para o usuário.

```csharp
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
```

9-Escreva um algoritmo que receba um número inteiro de segundos a partir do
teclado e imprima na tela a quantidade correspondente em horas, minutos e
segundos.

```csharp
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite o número de segundos: ");
        int totalSegundos = Convert.ToInt32(Console.ReadLine());

        int horas = totalSegundos / 3600; // 3600 segundos em uma hora
        int minutos = (totalSegundos % 3600) / 60; // Restante dos segundos convertidos para minutos
        int segundos = totalSegundos % 60; // Restante dos segundos

        Console.WriteLine("Horas: " + horas + ", Minutos: " + minutos + ", Segundos: " + segundos);
        
	}
}
```

10-Escreva um algoritmo que, dados três valores, calcule e imprima as médias
aritmética, harmônica e geométrica destes valores.
OBS.:
a. Média aritmética:
b. Média harmônica:
c. Média geométrica:

```csharp
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
```

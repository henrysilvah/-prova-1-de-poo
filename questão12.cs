using System;


class Program
{
    static void Main()
    {
       
        Console.Write("Digite o número máximo para gerar a sequência de Fibonacci: ");
        string entrada = Console.ReadLine();
        int limite;
       
       
        if (!int.TryParse(entrada, out limite) || limite <= 0)
        {
            Console.WriteLine("Número inválido. Por favor, insira um número inteiro positivo.");
            return;
        }
       
       
        int a = 0, b = 1;
       
       
        Console.WriteLine("Sequência de Fibonacci:");
       
        while (a <= limite)
        {
            Console.WriteLine(a);
           
            int proximo = a + b;
            a = b;
            b = proximo;
        }
    }
}

using System;


class Program
{
    static void Main()
    {
       
        Console.Write("Digite o primeiro número: ");
        float numero1 = float.Parse(Console.ReadLine());


        Console.Write("Digite o segundo número: ");
        float numero2 = float.Parse(Console.ReadLine());


        Console.Write("Digite o terceiro número: ");
        float numero3 = float.Parse(Console.ReadLine());


       
        float maior = numero1;
        float menor = numero1;


       
        if (numero2 > maior)
        {
            maior = numero2;
        }
        if (numero3 > maior)
        {
            maior = numero3;
        }


       
        if (numero2 < menor)
        {
            menor = numero2;
        }
        if (numero3 < menor)
        {
            menor = numero3;
        }


       
        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");
    }
}

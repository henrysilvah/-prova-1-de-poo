using System;


class Program
{
    static void Main()
    {
     
        Console.Write("Digite o número de nomes: ");
        string entrada = Console.ReadLine();
        int quantidade;
       
       
        if (!int.TryParse(entrada, out quantidade) || quantidade <= 0)
        {
            Console.WriteLine("Número inválido. Por favor, insira um número inteiro positivo.");
            return;
        }
       
       
        string[] nomes = new string[quantidade];
       
       
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Digite o nome {i + 1}: ");
            nomes[i] = Console.ReadLine();
        }
       
       
        BubbleSort(nomes);
       
       
        Console.WriteLine("Lista de nomes ordenada:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }


   
    static void BubbleSort(string[] array)
    {
        int n = array.Leng

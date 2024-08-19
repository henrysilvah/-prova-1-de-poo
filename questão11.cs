class Program
{
    static void Main()
    {
       
        Console.Write("Digite um número inteiro: ");
       
       
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            try
            {
               
                long resultado = CalcularFatorial(numero);
                Console.WriteLine($"O fatorial de {numero} é {resultado}.");
            }
            catch (ArgumentOutOfRangeException e)
            {
               
                Console.WriteLine(e.Message);
            }
        }
        else
        {
           
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }


    static long CalcularFatorial(int n)
    {
       
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(n), "O fatorial não está definido para números negativos.");
        }


       
        if (n == 0)
        {
            return 1;
        }


       
        return n * CalcularFatorial(n - 1);
    }
}

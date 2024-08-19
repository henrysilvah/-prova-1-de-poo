int soma = 0;
        int numero;


       
        do
        {
            Console.Write("Digite um número (ou 0 para encerrar): ");
           
            bool sucesso = int.TryParse(Console.ReadLine(), out numero);


           
            if (sucesso)
            {
               
                if (numero != 0)
                {
                    soma += numero;
                }
            }
            else
            {
               
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }


        } while (numero != 0);


       
        Console.WriteLine($"A soma de todos os números digitados é: {soma}");

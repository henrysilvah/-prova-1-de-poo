    
        string entrada = Console.ReadLine();
        int numero;


       
        if (int.TryParse(entrada, out numero))
        {
           
            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }
        }
        else
       
           
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");

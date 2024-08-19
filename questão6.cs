Console.Write("Digite a sua idade: ");
        string entrada = Console.ReadLine();
        int idade;


       
        if (int.TryParse(entrada, out idade))
        {
           
            if (idade >= 0)
            {
               
                if (idade >= 18)
                {
                    Console.WriteLine("Você é maior de idade.");
                    Console.WriteLine("Você está apto(a) a votar.");
                    Console.WriteLine("Você está apto(a) a dirigir.");
                }
                else
                {
                    Console.WriteLine("Você é menor de idade.");
                    Console.WriteLine("Você não está apto(a) a votar.");
                    Console.WriteLine("Você não está apto(a) a dirigir.");
                }
            }
            else
            {
               
                Console.WriteLine("Idade inválida. Por favor, digite uma idade positiva.");
            }
        }
        else
       
           
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");

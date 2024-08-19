Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
       
        int idade;
        while (true)
        {
            Console.Write("Digite sua idade: ");
            string entrada = Console.ReadLine();
           
            if (int.TryParse(entrada, out idade))
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número para sua idade.");
            }
        }
       
        Console.WriteLine($"Olá, {nome}, você tem {idade} anos.");

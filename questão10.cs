Console.Write("Digite o valor em reais: ");
        string valorReaisInput = Console.ReadLine();
        double valorReais;
       
       
        if (!double.TryParse(valorReaisInput, out valorReais))
        {
            Console.WriteLine("Valor em reais inválido.");
            return;
        }
       
       
        Console.Write("Digite a taxa de câmbio (reais por dólar): ");
        string taxaCambioInput = Console.ReadLine();
        double taxaCambio;
       
       
        if (!double.TryParse(taxaCambioInput, out taxaCambio) || taxaCambio <= 0)
        {
            Console.WriteLine("Taxa de câmbio inválida.");
            return;
        }
       
       
        double valorDolares = valorReais / taxaCambio;
       
       
        Console.WriteLine($"O valor em dólares é: ${valorDolares:F2}");
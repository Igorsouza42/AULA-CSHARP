
        // Solicita ao usuário que insira um número
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        // Gera e exibe a tabuada de 1 a 10
        Console.WriteLine($"Tabuada de {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    


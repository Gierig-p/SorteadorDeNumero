using System;
using System.Collections.Generic;

class program
{
static void Main()
{
    List<int> numeros = new List<int>();
    for (int i = 0; i <= 10 ; i++)
    {
        numeros.Add(i);
    }
    Random rand = new Random();

    int numeroAleatorio = rand.Next(0, numeros.Count);

    int numeroSelecionado = numeros[numeroAleatorio];
    bool rodar = true;

    while(rodar)
    {
    Console.WriteLine("Chute um numero: ");
    int numeroChutado = int.Parse(Console.ReadLine());
    
    if(numeroChutado == numeroSelecionado )
    {
        Console.WriteLine("Parabens você acertou no numero.");
        rodar = false;
    }
    else if (numeroChutado > numeroSelecionado)
    {
        Console.WriteLine($"Seu numero e menor que {numeroChutado}. Tente novamente");
        Console.ReadLine(); 
    }
    else if (numeroChutado < numeroSelecionado)
    {
        Console.WriteLine($"Seu numero e maior que {numeroChutado}. Tente novamente");
        Console.ReadLine(); 
    }
    else
    {
        Console.WriteLine("O número precisa estar entre 0 e 10. Tente novamente");
        Console.ReadLine(); 
    }
    }
}
}

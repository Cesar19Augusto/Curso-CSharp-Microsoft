//Sorteando uma pessoa do grupo por numero ao invés do nome
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Quantos sao os participantes do sorteio ?:");
        string input1 = Console.ReadLine();
        int valor1 = int.Parse(input1);
        
        Random sorteio = new Random ();
        int numeroDoSorteio = sorteio.Next(valor1 +1);
        
        Console.WriteLine("O sorteado e: " + numeroDoSorteio);
    }
};

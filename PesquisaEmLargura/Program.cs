using System;
using System.Collections.Generic;

public class Grafo
{
    private string pessoa;
    private Dictionary<string, List<string>> conhecidos;

    public Grafo(string pessoaInserida)
    {
        pessoa = pessoaInserida;
        conhecidos = new Dictionary<string, List<string>>();
    }

    public void AdicionarAresta(string pessoa1, string pessoa2)
    {
        if (!conhecidos.ContainsKey(pessoa1))
            conhecidos[pessoa1] = new List<string>();

        if (!conhecidos.ContainsKey(pessoa2))
            conhecidos[pessoa2] = new List<string>();

        conhecidos[pessoa1].Add(pessoa2);
        conhecidos[pessoa2].Add(pessoa1);
    }

    public void ImprimirGrafo()
    {
        foreach (var pessoa in conhecidos.Keys)
        {
            Console.Write($"A pessoa {pessoa} tem os conhecidos: ");
            foreach (var conhecido in conhecidos[pessoa])
            {
                Console.Write($"{conhecido}, ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    public static void Main()
    {
        Grafo grafo = new Grafo("Alice");

        grafo.AdicionarAresta("Alice", "Bob");
        grafo.AdicionarAresta("Alice", "Charlie");
        grafo.AdicionarAresta("Bob", "David");

        grafo.ImprimirGrafo();
    }
}


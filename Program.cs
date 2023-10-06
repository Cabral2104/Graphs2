using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un grafo con tres vértices (0, 1, 2)
            int numVertices = 3;
            List<int>[] grafo = new List<int>[numVertices];

            for (int i = 0; i < numVertices; i++)
            {
                grafo[i] = new List<int>();
            }

            // Agregar aristas
            grafo[0].Add(1); // Arista de 0 a 1
            grafo[1].Add(2); // Arista de 1 a 2

            // Mostrar el grafo
            for (int i = 0; i < numVertices; i++)
            {
                Console.Write($"Vértice {i} está conectado a: ");
                foreach (var vecino in grafo[i])
                {
                    Console.Write($"{vecino} ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}

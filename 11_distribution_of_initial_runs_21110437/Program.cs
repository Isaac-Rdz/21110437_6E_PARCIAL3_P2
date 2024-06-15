// See https://aka.ms/new-console-template for more information
//21110437
//EMMANUEL ISAAC RODRIGUEZ MENDEZ
//EJERCICIOS DE PRACTICA 2 Métodos de Ordenamiento.
//6E_ING_MECATRONICA
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt"; // Archivo de entrada
        string outputFilePath = "output.txt"; // Archivo de salida

        // Leer el archivo de entrada y dividirlo en bloques
        List<List<int>> blocks = ReadInputFile(inputFilePath);

        // Ordenar cada bloque en memoria (puedes usar Quicksort u otro algoritmo)
        foreach (var block in blocks)
        {
            block.Sort();
        }

        // Mezclar los bloques y escribir el resultado en el archivo de salida
        MergeBlocks(blocks, outputFilePath);

        Console.WriteLine("Ordenamiento Distribution of Initial Runs completado.");
    }

    static List<List<int>> ReadInputFile(string filePath)
    {
        // Leer el archivo y dividirlo en bloques (cada bloque es una lista de enteros)
        // Aquí puedes implementar la lógica para leer los datos del archivo
        // y dividirlos en bloques según el tamaño de la memoria disponible.
        // Devuelve una lista de bloques.
        // ...

        // Ejemplo: Crear bloques de prueba
        List<List<int>> blocks = new List<List<int>>
        {
            new List<int> { 5, 2, 9 },
            new List<int> { 1, 5, 6 },
            // ...
        };

        return blocks;
    }

    static void MergeBlocks(List<List<int>> blocks, string outputFilePath)
    {
        // Mezclar los bloques intercaladamente y escribir el resultado en el archivo de salida
        // Aquí puedes implementar la lógica de mezcla intercalada.
        // ...

        // Ejemplo: Mezclar los bloques en orden
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            foreach (var block in blocks)
            {
                foreach (var item in block)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
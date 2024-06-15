// See https://aka.ms/new-console-template for more information

//21110437
//EMMANUEL ISAAC RODRIGUEZ MENDEZ
//EJERCICIOS DE PRACTICA 2 Métodos de Ordenamiento.
//6E_ING_MECATRONICA
using System;

class Program
{
    static void Main()
    {
        int[] array = { 12, 11, 13, 5, 6 };
        Console.WriteLine("Array original:");
        PrintArray(array);

        InsertionSort(array);

        Console.WriteLine("Array ordenado:");
        PrintArray(array);
    }

    // Método para ordenar un array usando Insertion Sort
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            // Mueve los elementos del array que son mayores que la clave
            // una posición hacia adelante para hacer espacio para la clave
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    // Método para imprimir un array
    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
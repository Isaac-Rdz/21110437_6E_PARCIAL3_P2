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
        int[] arr = { 110, 1, 21, 53, 8, 98, 26, 163, 38, 897 };
        Console.WriteLine("Arreglo original:");
        PrintArray(arr);

        RadixSort(arr, arr.Length);

        Console.WriteLine("\nArreglo ordenado:");
        PrintArray(arr);
    }

    // Función principal de Radix Sort
    static void RadixSort(int[] array, int size)
    {
        var maxVal = GetMaxVal(array, size);

        // Iteramos por cada posición de los dígitos
        for (int exponent = 1; maxVal / exponent > 0; exponent *= 10)
        {
            CountingSort(array, size, exponent);
        }
    }

    // Función para obtener el valor máximo en el arreglo
    static int GetMaxVal(int[] array, int size)
    {
        var maxVal = array[0];
        for (int i = 1; i < size; i++)
        {
            if (array[i] > maxVal)
            {
                maxVal = array[i];
            }
        }
        return maxVal;
    }

    // Función para ordenar usando Counting Sort
    static void CountingSort(int[] array, int size, int exponent)
    {
        int[] output = new int[size];
        int[] count = new int[10]; // 10 dígitos posibles (0-9)

        // Inicializamos el arreglo de conteo
        for (int i = 0; i < 10; i++)
        {
            count[i] = 0;
        }

        // Contamos la frecuencia de cada dígito
        for (int i = 0; i < size; i++)
        {
            int digit = (array[i] / exponent) % 10;
            count[digit]++;
        }

        // Actualizamos el conteo para obtener las posiciones finales
        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        // Construimos el arreglo ordenado
        for (int i = size - 1; i >= 0; i--)
        {
            int digit = (array[i] / exponent) % 10;
            output[count[digit] - 1] = array[i];
            count[digit]--;
        }

        // Copiamos el arreglo ordenado al original
        for (int i = 0; i < size; i++)
        {
            array[i] = output[i];
        }
    }

    // Función para imprimir el arreglo
    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

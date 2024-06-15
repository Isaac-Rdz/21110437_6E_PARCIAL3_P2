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
        int[] arr = { 2, 4, 6, 8, 10, 1, 3, 5, 7, 9 }; // Vector desordenado
        Console.WriteLine("+--------------------------+");
        Console.WriteLine("| EL VECTOR SIN ORDENAR ES |");
        Console.WriteLine("+--------------------------+\n");
        PrintArray(arr);

        MergeSort(arr, 0, arr.Length - 1);

        Console.WriteLine("\n+----------------------------------+");
        Console.WriteLine("| EL VECTOR ORDENADO POR MERGESORT |");
        Console.WriteLine("+----------------------------------+\n");
        PrintArray(arr);

        Console.ReadLine();
    }

    // Función principal de MergeSort
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid); // Ordenar la primera mitad
            MergeSort(arr, mid + 1, right); // Ordenar la segunda mitad
            Merge(arr, left, mid, right); // Combinar las mitades ordenadas
        }
    }

    // Función para combinar dos subarreglos ordenados
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        // Copiar datos a los subarreglos temporales
        for (int i = 0; i < n1; i++)
            leftArr[i] = arr[left + i];
        for (int j = 0; j < n2; j++)
            rightArr[j] = arr[mid + 1 + j];

        // Combinar los subarreglos en uno solo
        int k = left;
        int p = 0, q = 0;
        while (p < n1 && q < n2)
        {
            if (leftArr[p] <= rightArr[q])
            {
                arr[k] = leftArr[p];
                p++;
            }
            else
            {
                arr[k] = rightArr[q];
                q++;
            }
            k++;
        }

        // Copiar los elementos restantes si los hay
        while (p < n1)
        {
            arr[k] = leftArr[p];
            p++;
            k++;
        }
        while (q < n2)
        {
            arr[k] = rightArr[q];
            q++;
            k++;
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

// See https://aka.ms/new-console-template for more information
//21110437
//EMMANUEL ISAAC RODRIGUEZ MENDEZ
//EJERCICIOS DE PRACTICA 2 Métodos de Ordenamiento.
//6E_ING_MECATRONICA
using System;
using Microsoft.VisualBasic;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumeros = new int[5];
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                Console.WriteLine("Ingresa el valor del elemento " + (i + 1));
                listaNumeros[i] = int.Parse(Console.ReadLine());
            }
            int menor = 0;
            int pos = 0;
            int tem = 0;
            for (int i = 0; i < listaNumeros.Length - 1; i++)
            {
                menor = listaNumeros[i];
                pos = i;
                for (int j = i + 1; j < listaNumeros.Length; j++)
                {
                    if (listaNumeros[j] < menor)
                    {
                        menor = listaNumeros[j];
                        pos = j;
                    }
                }
                if (pos != i)
                {
                    tem = listaNumeros[i];
                    listaNumeros[i] = listaNumeros[pos];
                    listaNumeros[pos] = tem;
                }
            }
            Console.WriteLine("Aqui esta tu lista ordenada de forma acendente:");
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                Console.WriteLine(listaNumeros[i]);
            }
            Console.WriteLine("Aqui esta tu lista ordenada de forma decendente");
            for (int i = listaNumeros.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(listaNumeros[i]);
            }

            Console.Read();
        }
    }
}


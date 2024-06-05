using System;
using System.Collections.Generic;

class Program {
    public static void Main (string[] args) {
        List<int> listaNumeros = new List<int>() {1,2,3,4,100,6,7,10,15};

        int logLista = listaNumeros.Count;

        if (logLista % 2 != 0)
        {
            int mitad = (logLista - 1) / 2;

            Console.WriteLine($"\nElemento Medio: {listaNumeros[mitad]}");
        }
        else
        {
            Console.WriteLine("La lista es par");
        }
    }
}
using System;
using System.Collections.Generic;

class Program {
    public static void Main (string[] args) {
        List<int> listaNumeros = new List<int>() {7,1,2,2,1,6,6,6,10,10};

        int logLista = listaNumeros.Count;
        bool repite = false;
        int respuesta = 0;

        for (int i = 0; i < logLista; i++)
        {
            for (int j = 0; j < logLista ; j++)
            {
                if (i != j)
                {
                    if (listaNumeros[i] == listaNumeros[j])
                    {
                        repite = true;
                        break;
                    }
                }
            }

            if (repite != true)
            {
                respuesta = listaNumeros[i];
                break;
            }

            repite = false;
        }

        Console.WriteLine(respuesta);
    }
}
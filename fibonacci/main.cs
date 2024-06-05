using System;
using System.Collections.Generic;
using System.Numerics;

class Program {
  public static void Main (string[] args) {
    int posicion;
    string dataUser = String.Empty;
    List<BigInteger> lista = new List<BigInteger>();
    bool bucle = false;

    while(!bucle){
      Console.Write("Ingresa la posición de la lista fibonacci: ");
      dataUser = Console.ReadLine();

      if(int.TryParse(dataUser, out posicion)){
        lista = funcionFibonacci(posicion - 3);
        foreach(BigInteger i in lista){
          Console.WriteLine(i);
          bucle = true;
        }
      }else{
        Console.WriteLine("El número no es correcto.");
      }
    }
    Console.ReadKey();
  }

  private static List<BigInteger> funcionFibonacci(int numero){
    List<BigInteger> lista = new List<BigInteger>(){0,1};
    BigInteger suma;
    BigInteger previo;
    BigInteger actual;

    for(int i = 0; i <= numero; i++){
      previo = lista[i];
      actual = lista[i + 1];
      suma = previo + actual;
      lista.Add(suma);
    }
    return lista;
  }
}
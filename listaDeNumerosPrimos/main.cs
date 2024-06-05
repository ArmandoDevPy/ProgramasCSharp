using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    bool bucle = false;
    string dataUser = String.Empty;
    int numero;
    int [] array;

    while(!bucle){
      Console.Write("Ingrese hasta donde desea la lista de números primos: ");
      dataUser = Console.ReadLine();

      if(int.TryParse(dataUser, out numero)){
        bucle = true;
        array = funcionListaNumPrimos(numero);
        
        foreach(int i in array){
          Console.Write(i+" ");
        }
      }else{
        Console.WriteLine("El dato no es un número correcto.");
      }
    }
    
    Console.ReadKey();
  }

  private static int[] funcionListaNumPrimos(int numero){
    List<int> lista = new List<int>();
    int cont = 0;

    for(int i = 1; i <= numero; i++){

      for(int j = 1; j <= i; j++){
        if(i % j == 0){
          cont++;
        }
      }

      if(cont == 2){
        lista.Add(i);
      }
      cont = 0;
    }
    
    return lista.ToArray();
  }
}
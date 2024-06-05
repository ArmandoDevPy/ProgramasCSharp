using System;

class Program {
  public static void Main (string[] args) {
    int numMayor;
    int numMenor;
    int [] array = {58,63,85,16,96,35,62,1,10000,-10000};

    foreach(int i in array){
      Console.Write(i+" ");
    }

    Console.WriteLine();

    numMayor = funcionNumMayor(array);
    Console.WriteLine($"El número mayor de la lista es: {numMayor}");
    numMenor = funcionNumMenor(array);
    Console.WriteLine($"El número menor de la lista es: {numMenor}");

    Console.ReadKey();
  }

  private static int funcionNumMayor(int[] array){
    int numInicial = array[0];

    for(int i = 1; i < array.Length;i++){
      if(array[i] >= numInicial){
        numInicial = array[i];
      }
    }

    return numInicial;
  }

  private static int funcionNumMenor(int[] array){
    int numInicial = array[0];

    for(int i= 1; i < array.Length; i++){
      if(array[i] <= numInicial){
        numInicial = array[i];
      }
    }

    return numInicial;
  }
}
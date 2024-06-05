using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {

    string userDate = String.Empty;
    bool bucle = false;
    int respuesta;

    while(!bucle){
      
      Console.WriteLine("Ingrese palabra: ");
      userDate = Console.ReadLine();

      if(Regex.IsMatch(userDate, @"^[a-zA-Z]+$")){
        respuesta = funcionContarVocales(userDate);
        Console.WriteLine(respuesta);
        bucle = true;
      }else{
        Console.WriteLine("No es una palabra");
      }
    }

    Console.ReadKey();
  }

  private static int funcionContarVocales(string palabra){
    int respuesta = 0;
    palabra = palabra.ToUpper();

    for(int i = 0; i < palabra.Length; i++){
      if("AEIOU".Contains(palabra[i])){
        respuesta += 1;
      }
    }

    return respuesta;
  }
}
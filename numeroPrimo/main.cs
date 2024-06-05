using System;

class Program {
  public static void Main (string[] args) {
    string userDate = String.Empty;
    string respuesta = String.Empty;
    int numero;
    bool seguir = false;
    
    while(!seguir){

      Console.Write("Ingrese el número: ");
      userDate = Console.ReadLine();
      
      if(int.TryParse(userDate, out numero)){
        seguir = true;
        respuesta = funcionNumPrimo(numero);
        Console.WriteLine(respuesta);
      }else{
        Console.WriteLine("No es un número válido");
      }  
    }
  }

  private static string funcionNumPrimo(int numero){
    string respuesta = String.Empty;
    int contador = 0;
    for(int i = 1; i <= numero; i++){
      if(numero % i == 0){
        contador++;
      }
    }

    if(contador == 2){
      respuesta = ($"El numero {numero} es primo.");
    }else{
      respuesta = ($"El numero {numero} no es primo.");
    }
    return respuesta;
  }
}
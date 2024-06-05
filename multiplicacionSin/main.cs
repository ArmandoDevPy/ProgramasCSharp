using System;

class Program {
  public static void Main (string[] args) {
    int num1;
    int num2;
    int multiplo;
    string dateUser = String.Empty;
    bool bucle1 = false;
    bool bucle2 = false;

    while(!bucle1){
      Console.Write("Ingresa número positivo 1: ");
      dateUser = Console.ReadLine();
      
      if(int.TryParse(dateUser, out num1) && num1 > 0){
        
        bucle1 = true;

        while(!bucle2){
          Console.Write("Ingresa número positivo 2: ");
          dateUser = Console.ReadLine();

          if(int.TryParse(dateUser, out num2) && num2 > 0){
            multiplo = funcionMultiplicacionSinSigno(num1, num2);
            Console.WriteLine($"El multiplo es: {multiplo}");
            bucle2 = true;
          }else{
            Console.WriteLine("Has ingresado un dato no correcto.");
          }
        }
      }else{
        Console.WriteLine("Has ingresado un dato no correcto.");
      }
    }
    Console.ReadKey();
  }

  private static int funcionMultiplicacionSinSigno(int num1, int num2){
    int respuesta = 0;
    
    for(int i = 0; i < num1; i++){
      respuesta += num2;
    }

    return respuesta;
  }
}
using System;

class Program {
  public static void Main (string[] args) {
    int dia;
    int mes;
    bool bucle1 = false;
    bool bucle2 = false;
    bool bucle3 = false;
    bool bucle4 = false;
    string userData = String.Empty;
    char seguir;
    
    while(!bucle4){
      
    while(!bucle1){
      
      Console.Write("Ingrese su día de nacimiento: ");
      userData = Console.ReadLine();
      
      if(int.TryParse(userData, out dia) && (dia >= 1 && dia <= 31) ){
        Console.Clear();
        bucle1 = true;
        
        while(!bucle2){
          Console.Write("Ingrese su mes de nacimiento: ");
          userData = Console.ReadLine();
          if(int.TryParse(userData, out mes) && (mes >= 1 && mes <= 12)){
            Console.Clear();
            bucle2 = true;
            funcionZodiaco(dia, mes);
          }else{
            Console.WriteLine("EL dato no es válido");
          }
        }
        bucle2 = false;
      }else{
        Console.WriteLine("EL dato no es válido");
        }
    }
      bucle1 = false;
      
        while(!bucle3){
          Console.WriteLine("|---------------------------------------|");
          Console.Write("Desea ingresar otra fecha? precione 'S' para otra consulta u otra tecla para finalizar: ");
          userData = Console.ReadLine();

          if(char.TryParse(userData, out seguir)){
            seguir = char.ToUpper(seguir);
            bucle3 = true;
            if(seguir != 'S'){
              bucle4 = true;
              Console.Clear();
              Console.WriteLine("Programa Finalizó");
            }else{
              Console.Clear();
            }
          }else{
            Console.WriteLine("Dato inválido");
          }
      }
      bucle3 = false;
      
    }
    Console.ReadKey();
  }

  private static void funcionZodiaco(int dia, int mes){
    Console.Clear();
    Console.WriteLine($"Fecha: {dia}/{mes}");
    string signo = String.Empty;
    
    if((dia >= 21 && dia <= 31 && mes == 3) || (dia >=1 && dia <= 20 && mes == 4)){
      signo = "Aries";
    }else if((dia >= 21 && dia <= 31 && mes == 4) || (dia >=1 && dia <= 20 && mes == 5)){
      signo = "Tauro";
    }else if((dia >= 21 && dia <= 31 && mes == 5) || (dia >=1 && dia <= 20 && mes == 6)){
      signo = "Géminis";
    }else if((dia >= 21 && dia <= 31 && mes == 6) || (dia >=1 && dia <= 20 && mes == 7)){
      signo = "Cáncer";
    }else if((dia >= 21 && dia <= 31 && mes == 7) || (dia >=1 && dia <= 22 && mes == 8)){
      signo = "Leo";
    }else if((dia >= 24 && dia <= 31 && mes == 8) || (dia >=1 && dia <= 22 && mes == 9)){
      signo = "Virgo";
    }else if((dia >= 23 && dia <= 31 && mes == 9) || (dia >=1 && dia <= 23 && mes == 10)){
      signo = "Libra";
    }else if((dia >= 24 && dia <= 31 && mes == 10) || (dia >=1 && dia <= 22 && mes == 11)){
      signo = "Escorpio";
    }else if((dia >= 23 && dia <= 31 && mes == 11) || (dia >=1 && dia <= 21 && mes == 12)){
      signo = "Sagitario";
    }else if((dia >= 22 && dia <= 31 && mes == 12) || (dia >=1 && dia <= 20 && mes == 1)){
      signo = "Capricornio";
    }else if((dia >= 21 && dia <= 31 && mes == 1) || (dia >=1 && dia <= 19 && mes == 2)){
      signo = "Acuario";
    }else if((dia >= 20 && dia <= 31 && mes == 2) || (dia >=1 && dia <= 20 && mes == 3)){
      signo = "Piscis";
    }else{
      Console.WriteLine("La fecha no existe");
    }

    Console.WriteLine($"Tu signo es: {signo}");
  }
}
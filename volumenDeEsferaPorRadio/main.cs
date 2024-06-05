using System;

class Program {
  public static void Main (string[] args) {

    double radio;
    double volumen;
    string userData = String.Empty;
    string caracter = "\u00B3";
    bool bucle = false;
    
    while(!bucle){
      Console.Write("Ingresa el radio: ");
      userData = Console.ReadLine();
      if(double.TryParse(userData, out radio) && (radio > 0)){
        volumen = funcionVolumenEsfera(radio);
        Console.WriteLine($"El volumen es: {volumen} cm{caracter}");
        bucle = true;
      }else{
        Console.WriteLine("Radio incorrecto.");
      }
    }
    
    Console.ReadKey();
  }

  private static double funcionVolumenEsfera(double radio){
    double volumen;

    volumen = (4 * Math.PI * Math.Pow(radio, 3)) / 3;

    return Math.Round(volumen, 1);
  }
}
using System;

class Program {
  public static void Main (string[] args) {

    string userDate = String.Empty;
    double _base;
    double _altura;
    double _area;

    Console.WriteLine("Ingrese la base: ");
    userDate = Console.ReadLine();
    
    if(double.TryParse(userDate, out _base)){

      Console.WriteLine("Ingrese la altura: ");
      userDate = Console.ReadLine();

      if(double.TryParse(userDate, out _altura)){
        
        _area = (_base * _altura) / 2;
        Console.WriteLine($"El Área es: {_area}");
        
      }else{
        Console.WriteLine("Ingresaste un dato incorrecto");
      }

    }else{
      Console.WriteLine("Ingresaste un dato incorrecto");
    }
    
    Console.ReadKey();
  }
}
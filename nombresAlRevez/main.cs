using System;

class Program {
  public static void Main (string[] args) {
    string nombre = String.Empty;
    string apellido = String.Empty;
    string nombreCompletoRevez;

    Console.Write("Ingresar nombre: ");
    nombre = Console.ReadLine();
    
    Console.Write("Ingresar apellido: ");
    apellido = Console.ReadLine();

    nombreCompletoRevez = funcionNombreRevez(nombre, apellido);
    Console.WriteLine(nombreCompletoRevez);

    Console.ReadKey();
  }

  private static string funcionNombreRevez(string nombre, string apellido){
    string revez = String.Empty;

    char[] charNombre = nombre.ToCharArray();
    char[] charApellido = apellido.ToCharArray();

    Array.Reverse(charNombre);
    Array.Reverse(charApellido);

    string nombreRevez = new String(charNombre);
    string apellidoRevez = new String(charApellido);

    revez = $"{apellidoRevez} {nombreRevez}";

    return revez;
  }
}
using System;

class Program {
  public static void Main (string[] args) {
    int numero;
    int suma = 0;
    string dataUser = String.Empty; 
    bool bucle = false;
    
    while(!bucle){
      Console.Write("Ingresar números o escribir 'BASTA': ");
      dataUser = Console.ReadLine();
      
      if(dataUser.ToUpper() == "BASTA"){
        bucle = true;
      }else{
        numero = int.Parse(dataUser);
        suma += numero;
      }
    }

    Console.WriteLine($"la suma total es: {suma}");
    
    Console.ReadLine();
  }
}
using System;

class Perguntar {

  public static void Tipo () {
    
  Console.WriteLine("\n-----------");
  Console.WriteLine("1 - Comprar ");
  Console.WriteLine("2 - Alugar");
  Console.WriteLine("-----------");
  Console.WriteLine("Insira o que você gostaria: ");
  int sis = int.Parse(Console.ReadLine());

  if(sis == 2){
    Lista.Alugar();
  }else if(sis == 1){
    List.Comprar();
  }else{
    Console.WriteLine("Erro!!");

    }
  }
}
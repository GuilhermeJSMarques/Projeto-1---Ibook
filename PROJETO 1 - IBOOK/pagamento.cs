using System;

class Forma {
  
  public static void Pagamento () {

  Console.WriteLine("\nInsira a forma de pagamento: Cartão(1) ou dinheiro(2) ");
  int pag = int.Parse(Console.ReadLine());

  if(pag == 1){
    Console.WriteLine("Qual a bandeira do cartão");
  }else if(pag == 2){
    Console.WriteLine("Precisa de troco ? se sim, quanto?");
  }else{
    Console.WriteLine("Erro!!");
  }
 }
}
using System;

class MainClass {
  public static void Main (string[] args) {
  
  //abertura
  Abertura.App();

  //cadastrar,perguntar se ele gostaria de alugar ou comprar e finalizar
  Perguntar.Tipo();

  //perguntar forma de pagamento
  Forma.Pagamento();


  }
}
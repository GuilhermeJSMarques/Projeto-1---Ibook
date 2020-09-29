using System;

class List {
  
  public static void Comprar () {
  
  Console.WriteLine("\nInsira o seu cpf: ");
  double cpf = double.Parse(Console.ReadLine());

  Console.WriteLine("\nInsira o nome da sua rua: ");
  string nomerua = Console.ReadLine();

  Console.WriteLine("\nInsira o número da sua casa: ");
  int numrua = int.Parse(Console.ReadLine());

  Console.WriteLine("\nLista de Livros para comprar.");
  Console.WriteLine("----------------------------------");
  Console.WriteLine("100 - As Crônicas de Nárnia R$25,00");
  Console.WriteLine("101 - O Pequeno Príncipe    R$20,00");
  Console.WriteLine("102 - Dom Casmurgo          R$20,00");
  Console.WriteLine("103 - As Mil e uma Noites   R$25,00");
  Console.WriteLine("104 - Os Miseráveis         R$20,00");
  Console.WriteLine("105 - A Cabana              R$20,00");
  Console.WriteLine("000 - Cancelar pedido       .......");
  Console.WriteLine("----------------------------------");

  Console.WriteLine("Insira o código do produto: ");
  int cod = int.Parse(Console.ReadLine());
  
  if(cod == 100 ){
    Console.WriteLine("O livro será entregue para o cpf {0} na rua {1} número {2} e o Valor final: R${3}", cpf, nomerua, numrua, 25.00);
  }else if(cod == 101){
    Console.WriteLine("O livro será entregue para o cpf {0} na rua {1} número {2} e o Valor final: R${3}", cpf, nomerua, numrua, 20.00);
  }else if(cod == 102){
    Console.WriteLine("O livro será entregue para o cpf {0} na rua {1} número {2} e o Valor final: R${3}", cpf, nomerua, numrua, 20.00);
  }else if(cod == 103){
    Console.WriteLine("O livro será entregue para o cpf {0} na rua {1} número {2} e o Valor final: R${3}", cpf, nomerua, numrua, 20.00);
  }else if(cod == 104){
    Console.WriteLine("O livro será entregue para o cpf {0} na rua {1} número {2} e o Valor final: R${3}", cpf, nomerua, numrua, 25.00);
  }else if(cod == 105){
    Console.WriteLine("O livro será entregue para o cpf {0} na rua {1} número {2} e o Valor final: R${3}", cpf, nomerua, numrua, 20.00);
  }else if(cod == 000){
    Console.WriteLine("Pedido cancelado!!");
  }else{
    Console.WriteLine("Erro!!");
  

  }
 }
}
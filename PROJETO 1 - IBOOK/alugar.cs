using System;

class Lista {
  
  public static void Alugar () {
  
  Console.WriteLine("\nInsira o seu cpf: ");
  double cpf = double.Parse(Console.ReadLine());

  Console.WriteLine("\nInsira o nome da sua rua: ");
  string nomerua = Console.ReadLine();

  Console.WriteLine("\nInsira o número da sua casa: ");
  int numrua = int.Parse(Console.ReadLine());

  Console.WriteLine("\nLista de Livros para alugar por 1 semana.");
  Console.WriteLine("----------------------------------");
  Console.WriteLine("106 - As Crônicas de Nárnia R$2,50");
  Console.WriteLine("107 - O Pequeno Príncipe    R$2,00");
  Console.WriteLine("108 - Dom Casmurgo          R$2,00");
  Console.WriteLine("109 - As Mil e uma Noites   R$2,50 ");
  Console.WriteLine("110 - Os Miseráveis         R$2,00 ");
  Console.WriteLine("111 - A Cabana              R$2,00 ");
  Console.WriteLine("000 - Cancelar pedido       ...... ");
  Console.WriteLine("----------------------------------");

  Console.WriteLine("Insira o código do produto: ");
  int cod = int.Parse(Console.ReadLine());

  if(cod == 106 ){
    Console.WriteLine("O livro será entregue para o cpf {0} na rua {1} número {2} e o Valor final: R${3}", cpf, nomerua, numrua, 2.50);
  }else if(cod == 107){
    Console.WriteLine("O livro será entregue para o cpf {0} na rua {1} número {2} e o Valor final: R${3}", cpf, nomerua, numrua, 2.00);   
  }else if(cod == 108){
    Console.WriteLine("O livro será entregue para o cpf {0} na rua {1} número {2} e o Valor final: R${3}", cpf, nomerua, numrua, 2.00);
  }else if(cod == 109){
    Console.WriteLine("O livro será entregue para o cpf {0} na rua {1} número {2} e o Valor final: R${3}", cpf, nomerua, numrua, 2.50);
  }else if(cod == 110){
    Console.WriteLine("O livro será entregue para o cpf {0} na rua {1} número {2} e o Valor final: R${3}", cpf, nomerua, numrua, 2.00);
  }else if(cod == 111){
    Console.WriteLine("O livro será entregue para o cpf {0} na rua {1} número {2} e o Valor final: R${3}", cpf, nomerua, numrua, 2.00);
  }else if(cod == 000){
    Console.WriteLine("Pedido Cancelado");
  }else{
    Console.WriteLine("Erro!!");
  
  }
 }
}
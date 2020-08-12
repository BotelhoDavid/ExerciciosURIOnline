// Escreva um programa para ler as coordenadas (X,Y)
//  de uma quantidade indeterminada de pontos no sistema cartesiano.
// Para cada ponto escrever o quadrante a que ele pertence. 
// O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA
//  (nesta situação sem escrever mensagem alguma).

// Entrada
// A entrada contém vários casos de teste.
// Cada caso de teste contém 2 valores inteiros.

// Saída
// Para cada caso de teste mostre em qual quadrante do sistema cartesiano se encontra
//  a coordenada lida

using System; 

class URI {
  static void Main(string[] args) {  
    while(true){

      string[] _coordenadas = Console.ReadLine().Split();
      int _x = int.Parse(_coordenadas[0]), _y = int.Parse(_coordenadas[1]);

      if(_x != 0 &&  _y != 0){
        if(_x > 0){
          if(_y > 0)Console.WriteLine("primeiro");
          else Console.WriteLine("quarto");
        }
        if(_x < 0){
          if(_y > 0)Console.WriteLine("segundo");
          else Console.WriteLine("terceiro");
        }
      }else break;
    }
  }
}
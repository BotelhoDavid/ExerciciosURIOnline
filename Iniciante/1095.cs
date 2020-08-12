// Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

// Entrada
// Não há nenhuma entrada neste problema.

// Saída
// Imprima a sequencia conforme exemplo abaixo

// Exemplo de Entrada   |   Exemplo de Saída
//                      |     I=1 J=60
//                      |     I=4 J=55
//                      |     I=7 J=50
//                      |     ...
//                      |     I=? J=0

using System; 

class URI {
  static void Main(string[] args) {     
    var i = 1;

    for(int j=60; j >= 0; j-=5)
    {
      Console.WriteLine($"I={i} J={j}");
      i+=3;
    }
  }
}
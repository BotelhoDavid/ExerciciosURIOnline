// Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

// Entrada
// Não há nenhuma entrada neste problema.

// Saída
// Imprima a sequencia conforme exemplo abaixo.

// Exemplo de Entrada   |   Exemplo de Saída
//                      |      I=1 J=7
//                      |      I=1 J=6
//                      |      I=1 J=5
//                      |      I=3 J=9
//                      |      I=3 J=8
//                      |      I=3 J=7
//                      |      ...
//                      |      I=9 J=15
//                      |      I=9 J=14
//                      |      I=9 J=13

using System; 

class URI {
  static void Main(string[] args) {
    int _numb = 7, _numb2 = _numb-2;

    for (int i = 1; i <= 9; i+=2)
    {
      for (int j = _numb; j >= _numb2; j--)
      {   
        Console.WriteLine($"I={i} J={j}");
      }
      _numb+= 2;
      _numb2+= 2;
    }
  }
}
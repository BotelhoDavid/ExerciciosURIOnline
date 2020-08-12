// Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

// Entrada
// Não há nenhuma entrada neste problema.

// Saída
// Imprima a sequencia conforme exemplo abaixo.

// Exemplo de Entrada   |   Exemplo de Saída
//                      |     I=0 J=1
//                      |     I=0 J=2
//                      |     I=0 J=3
//                      |     I=0.2 J=1.2
//                      |     I=0.2 J=2.2
//                      |     I=0.2 J=3.2
//                      |     .....
//                      |     I=2 J=?
//                      |     I=2 J=?
//                      |     I=2 J=?

using System; 

class URI {
  static void Main(string[] args) {
    decimal _dec = 0;
    for (decimal i = 0; i <= 2; i += 0.2m){
      for (int j = 1; j <= 3; j++){
        if(Decimal.ToInt32(i) != i)Console.WriteLine($"I={i} J={j + _dec}");
        else Console.WriteLine($"I={i:f0} J={(j + _dec):f0}");
      }
      _dec += 0.2m;
    }
  }
}
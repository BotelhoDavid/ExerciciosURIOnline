// Leia 100 valores inteiros. Apresente então o maior valor lido
//  e a posição dentre os 100 valores lidos.

// Entrada
// O arquivo de entrada contém 100 números inteiros, positivos e distintos.

// Saída
// Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.

// Exemplo de Entrada   |   Exemplo de Saída
//       2              |       34565
//       113            |       4
//       45             |       
//       34565          |       
//       6              |       
//       ...            |       
//       8              |       

using System; 

class URI {
  static void Main(string[] args) {
    int[] _numeros = new int[100];
    int[] _keys = new int[100];

    for (int i = 0; i < 100; i++){
      _numeros[i] = int.Parse(Console.ReadLine());
      _keys[i] = i+1;                
    }

    Array.Sort(_numeros, _keys);
    Console.WriteLine(_numeros[99] + "\n" +_keys[99]);            
  }
}
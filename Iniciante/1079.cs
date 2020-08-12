// Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

// Entrada
// O arquivo de entrada contém um valor inteiro N na primeira linha. Cada N linha a seguir contém um caso de teste com três valores com uma casa decimal cada valor.

// Saída
// Para cada caso de teste, imprima a média ponderada dos 3 valores, conforme exemplo abaixo.

// Exemplo de Entrada   |   Exemplo de Saída
// 3                    |       5.7
// 6.5 4.3 6.2          |       6.3
// 5.1 4.2 8.1          |       9.3
// 8.0 9.0 10.0         |   

using System; 

class URI {
  static void Main(string[] args) {

    int _casos = int.Parse(Console.ReadLine());

    for (int i = 0; i < _casos; i++)
    {
      String[] _numbs = Console.ReadLine().Split();
      double N1 = double.Parse(_numbs[0]);
      double N2 = double.Parse(_numbs[1]);
      double N3 = double.Parse(_numbs[2]);

      var _media = ((N1 * 2) + (N2 * 3) + (N3 * 5)) / 10;

      Console.WriteLine(_media.ToString("f1"));
    }
  }
}

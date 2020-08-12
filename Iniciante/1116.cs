// Escreva um algoritmo que leia 2 números
//  e imprima o resultado da divisão do primeiro pelo segundo. 
// Caso não for possível mostre a mensagem “divisao impossivel” para os valores em questão.

// Entrada
// A entrada contém um número inteiro N. 
// Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

// Saída
// Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal,
//  ou “divisao impossivel” caso não seja possível efetuar o cálculo.

using System; 

class URI {
  static void Main(string[] args) {
    int _cases = int.Parse(Console.ReadLine());

    for (int i = 0; i < _cases; i++){
      string[] _valores = Console.ReadLine().Split();

      decimal _x = decimal.Parse(_valores[0]);
      decimal _y = decimal.Parse(_valores[1]);
      
      try
      {
        decimal _total = _x / _y;
        Console.WriteLine($"{_total:f1}");
      }
      catch (DivideByZeroException)
      {
        Console.WriteLine("divisao impossivel");                
      }
    }
  } 
}
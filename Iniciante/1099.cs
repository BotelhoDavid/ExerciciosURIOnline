// Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir.
// Cada caso de teste consiste de dois inteiros X e Y.
// Você deve apresentar a soma de todos os ímpares existentes entre X e Y.

// Entrada
// A primeira linha de entrada é um inteiro N
//  que é a quantidade de casos de teste que vem a seguir. 
//  Cada caso de teste consiste em uma linha contendo dois inteiros X e Y.

// Saída
// Imprima a soma de todos valores ímpares entre X e Y.

using System; 

class URI {
  static void Main(string[] args) {
    int _cases = int.Parse(Console.ReadLine());

    for (int i = 0; i < _cases; i++){
      int _total = 0;
      string[] _numbs= Console.ReadLine().Split();
      
      int _numb1 = int.Parse(_numbs[0]);
      int _numb2 = int.Parse(_numbs[1]);
  
      if(_numb1 != _numb2){
        for (int j = Math.Min(_numb1, _numb2) +1; 
                  j < Math.Max(_numb1, _numb2); j++)
        {
          if(j%2!=0)_total += j;
        }
        Console.WriteLine(_total);
      }else Console.WriteLine(0);
    }
  }
}
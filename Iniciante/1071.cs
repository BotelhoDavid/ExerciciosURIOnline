// Leia 2 valores inteiros X e Y. A seguir, 
// calcule e mostre a soma dos números impares entre eles.

// Entrada
// O arquivo de entrada contém dois valores inteiros.

// Saída
// O programa deve imprimir um valor inteiro. 
// Este valor é a soma dos valores ímpares que estão entre os valores fornecidos na entrada
//  que deverá caber em um inteiro.

using System; 

class URI {
  static void Main(string[] args) {        
    int _numb1 = int.Parse(Console.ReadLine());
    int _numb2 = int.Parse(Console.ReadLine());
    int _total = 0;

    if(_numb1 != _numb2){
      for (int i = Math.Min(_numb1, _numb2) +1; i < Math.Max(_numb1, _numb2); i++){
        if(i%2!=0)_total += i;
      }
      Console.WriteLine(_total);
    }else Console.WriteLine(0);
  }
}
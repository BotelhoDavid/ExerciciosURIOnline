// Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares,
//  quantos valores digitados foram ímpares, 
//  quantos valores digitados foram positivos e quantos valores digitados foram negativos.

// Entrada
// O arquivo de entrada contém 5 valores inteiros quaisquer.

// Saída
// Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha,
//  não esquecendo o final de linha após cada uma.

// Exemplo de Entrada   |   Exemplo de Saída
//      -5              |      3 valor(es) par(es)
//      0               |      2 valor(es) impar(es)
//      -3              |      1 valor(es) positivo(s)
//      -4              |      3 valor(es) negativo(s)
//      12              |      

using System; 

class URI {
  static void Main(string[] args) {   
    int _odd = 0, _even = 0, _positive = 0, _negative = 0;
    int[] _inteiros = new int[5];
    for (int i = 0; i < 5; i++){                 
      _inteiros[i] = int.Parse(Console.ReadLine());                             
    }
    for (int i = 0; i < _inteiros.Length; i++){
      if (_inteiros[i] != 0){
        if (_inteiros[i] > 0) _positive++;
        else _negative++;
      }        
      if (_inteiros[i]%2 == 0) _even++;
      else _odd++;   
    }
    Console.WriteLine(_even +" valor(es) par(es)\n" + 
                      _odd +" valor(es) impar(es)\n" +
                      _positive +" valor(es) positivo(s)\n" +
                      _negative +" valor(es) negativo(s)");
  }
}
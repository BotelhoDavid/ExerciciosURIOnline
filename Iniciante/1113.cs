// Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. 
// Escreva para cada X e Y uma mensagem que indique se estes valores foram
//  digitados em ordem crescente ou decrescente.

// Entrada
// A entrada contém vários casos de teste. 
// Cada caso contém dois valores inteiros X e Y. 
// A leitura deve ser encerrada ao ser fornecido valores iguais para X e Y.

// Saída
// Para cada caso de teste imprima “Crescente”, 
//  caso os valores tenham sido digitados na ordem crescente,
//  caso contrário imprima a mensagem “Decrescente”.

using System; 

class URI {
  static void Main(string[] args) {
    while (true){   
      string[] _numbers = Console.ReadLine().Split(); 
      int _numb1 = int.Parse(_numbers[0]);
      int _numb2 = int.Parse(_numbers[1]);

      if (_numb1 != _numb2){
        if(_numb1 > _numb2) Console.WriteLine("Decrescente");
        else Console.WriteLine("Crescente");
      }else break;
    }
  }
}
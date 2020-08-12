// Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.

// Entrada
// O arquivo de entrada contém 5 valores inteiros quaisquer.

// Saída
// Imprima a mensagem conforme o exemplo fornecido, indicando a quantidade de valores pares lidos.

// Exemplo de Entrada  |      	Exemplo de Saída
//         7           |    3 valores pares
//         -5          |
//         6           |
//         -4          |
//         12          |

using System; 

class URI {

    static void Main(string[] args) { 
        
        int _contador = 0;

        for (int i = 0; i < 5; i++)
        {            
            double _numb = double.Parse(Console.ReadLine());

            if (_numb % 2 == 0)
            {
                _contador++;
            }
        }
        Console.WriteLine($"{_contador} valores pares");
    }

}
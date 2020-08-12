// Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos (desconsidere os valores nulos). A seguir, mostre a quantidade de valores positivos digitados.

// Entrada
// Seis valores, negativos e/ou positivos.

// Saída
// Imprima uma mensagem dizendo quantos valores positivos foram lidos.

// Exemplo de Entrada  | 	Exemplo de Saída
//       7             |      4 valores positivos
//       -5            |
//       6             |
//       -3.4          |
//       4.6           |
//       12            |

using System; 

class URI {

    static void Main(string[] args) { 

        int result = 0;
		
		for (int i = 0; i <= 5; i++)
			{
				double numb = double.Parse(Console.ReadLine());
				if(numb > 0){result++;};
			}
		Console.WriteLine($"{result} valores positivos");

    }

}
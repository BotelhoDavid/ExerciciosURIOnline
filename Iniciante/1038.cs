// Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. 
// A seguir, calcule e mostre o valor da conta a pagar.

// |Codigo  | Especificação     |    Preço |
// |///////////////////////////////////////|
// |1	    | Cachorro Quente   |   R$4.00 |
// |2	    | X-Salada          |   R$4.50 |
// |3	    | X-Bacon           |   R$5.00 |
// |4	    | Torrada simples   |   R$2.00 |
// |5	    | Refrigerante      |   R$1.50 |

// Entrada
// O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.

// Saída
// O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.

using System; 

class URI {

    static void Main(string[] args) { 

            int Cod, Quant;
            double Result;
            double[] Precos = { 0, 4.00, 4.50, 5.00, 2.00, 1.50};
            string[] Entrada = Console.ReadLine().Split();

            Cod = int.Parse(Entrada[0]);
            Quant = int.Parse(Entrada[1]);

            Result = Quant * Precos[Cod];

            Console.WriteLine($"Total: R$ {Result:f2}");

    }

}
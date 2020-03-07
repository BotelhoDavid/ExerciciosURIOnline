// Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, 
// o valor unitário de cada peça 1, o código de uma peça 2, 
// o número de peças 2 e o valor unitário de cada peça 2. 
// Após, calcule e mostre o valor a ser pago.

// Entrada
// O arquivo de entrada contém duas linhas de dados. 
// Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

// Saída
// A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, 
// lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". 
// O valor deverá ser apresentado com 2 casas após o ponto.

using System; 

class URI {

    static void Main(string[] args) { 

            int P1, Q1, P2, Q2;
            Double V1, V2, Vt;

            string [] Linha1 = Console.ReadLine().Split(' ');
            P1 = int.Parse(Linha1[0]);
            Q1 = int.Parse(Linha1[1]);
            V1 = Double.Parse(Linha1[2]);

            string[] Linha2 = Console.ReadLine().Split(' ');
            P2 = int.Parse(Linha2[0]);
            Q2 = int.Parse(Linha2[1]);
            V2 = Double.Parse(Linha2[2]);

            Vt = (Q1 * V1) + (Q2 * V2);

            Console.WriteLine("VALOR A PAGAR: R$ {0:f}", Vt);
    }
}
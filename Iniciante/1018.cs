// Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto.
// As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. 
// A seguir mostre o valor lido e a relação de notas necessárias.

// Entrada
// O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

// Saída
// Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias,
// conforme o exemplo fornecido. Não esqueça de imprimir o fim de linha após cada linha,
// caso contrário seu programa apresentará a mensagem: “Presentation Error”.


using System; 

class URI {

    static void Main(string[] args) { 

        int valor;
        int[] lista = {100, 50, 20, 10, 5, 2, 1};

        valor = int.Parse(Console.ReadLine());
        Console.WriteLine(valor);
        for (int i = 0; i < lista.Length; i++)
        {
            int cedulas = lista[i];
            int quantCedulas = valor / cedulas;
            valor %= cedulas;
            Console.WriteLine(quantCedulas + " nota(s) de R$ " + cedulas + ",00");
        }
    }
}
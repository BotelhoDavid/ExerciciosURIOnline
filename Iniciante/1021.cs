// Leia um valor de ponto flutuante com duas casas decimais. 
// Este valor representa um valor monetário. 
// A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto.
// As notas consideradas são de 100, 50, 20, 10, 5, 2.
// As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01.
// A seguir mostre a relação de notas necessárias.

// Entrada
// O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

// Saída
// Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial,
// conforme exemplo fornecido.

// Obs: Utilize ponto (.) para separar a parte decimal.

using System; 

class URI {

    static void Main(string[] args) { 

        decimal[] cedulas, moedas;
        decimal dinheiro, quantCedulas, quantMoedas;
        dinheiro = decimal.Parse(Console.ReadLine());
        cedulas = new decimal[] { 100.00m, 50.00m, 20.00m, 10.00m, 5.00m, 2.00m};
        moedas = new decimal [] { 1.00m, 0.50m, 0.25m, 0.1m, 0.05m, 0.01m};

        Console.WriteLine("NOTAS:");
        for(int i = 0; i < cedulas.Length; i++) {
            quantCedulas = dinheiro / cedulas[i];
            dinheiro %= cedulas[i];

            Console.WriteLine((int)quantCedulas + " nota(s) de R$ {0:f2}",cedulas[i]);
        }
        Console.WriteLine("MOEDAS:");
        for (int i = 0; i < moedas.Length; i++) {
            quantMoedas = dinheiro / moedas[i];
            dinheiro %= moedas[i]; 
            
            Console.WriteLine($"{(int)quantMoedas} moeda(s) de R$ {moedas[i]:f2}");
        }
    }
}
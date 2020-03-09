// Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. 
// Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, 
// caso haja uma divisão por 0 ou raiz de numero negativo.

// Entrada
// Leia três valores de ponto flutuante (double) A, B e C.

// Saída
// Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". 
// Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, 
// com uma mensagem correspondente conforme exemplo abaixo. 
// Imprima sempre o final de linha após cada mensagem.

using System; 

class URI {

    static void Main(string[] args) { 

        double A, B, C, X1, X2, Delta;

        string[] Line = Console.ReadLine().Split(' ');

        // A = double.Parse(Line[0]);
        // B = double.Parse(Line[1]);
        // C = double.Parse(Line[2]);

        A = 10.0;
        B = 20.1;
        C = 5.1;

        Delta = Math.Sqrt((B*B) - 4 * A * C);
        if ((A != 0) && (Delta > 0)) {
            X1 = (-B + Delta) / (2 * A);
            X2 = (-B - Delta) / (2 * A);

            Console.WriteLine($"R1 = {X1} \n R2 = {X2}");
        }
        else{ 
            Console.WriteLine("Impossivel calcular");
        }
    

    }
}
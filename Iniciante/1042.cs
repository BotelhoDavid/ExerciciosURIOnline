// Leia 3 valores inteiros e ordene-os em ordem crescente.No final, mostre os valores em ordem crescente, 
// uma linha em branco e em seguida, os valores na sequência como foram lidos.

// Entrada
// A entrada contem três números inteiros.

// Saída
// Imprima a saída conforme foi especificado.

using System; 

class URI {

    static void Main(string[] args) {
        
        int a, b, c;

        string[] str = Console.ReadLine().Split();

        a = int.Parse(str[0]);
        b = int.Parse(str[1]);
        c = int.Parse(str[2]);

        double[] num = {a, b, c};
        Array.Sort(num);

        Console.WriteLine($"{num[0]}\n{num[1]}\n{num[2]}");
        Console.WriteLine($"\n{a}\n{b}\n{c}");           
    }
}
// Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. 
// Utilize a fórmula: MaiorAB = (a+b+abs(a-b))/2

// Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). 
// Um segundo passo, portanto é necessário para chegar no resultado esperado.

// Entrada
// O arquivo de entrada contém três valores inteiros.

// Saída
// Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

using System; 

class URI {

    static void Main(string[] args) { 

        int A, B, C, MAB, MABC;
            string[] line = Console.ReadLine().Split(' ');

            A = int.Parse(line[0]);
            B = int.Parse(line[1]);
            C = int.Parse(line[2]);

            MAB = (A + B + Math.Abs(A - B)) / 2;
            MABC = (MAB + C + Math.Abs(MAB - C)) / 2;
            
            Console.WriteLine($"{MABC} eh o maior");
    }
}
// Leia 4 valores inteiros A, B, C e D. 
// A seguir, se B for maior do que C e se D for maior do que A, 
// e a soma de C com D for maior que a soma de A e B e se C e D, ambos, 
// forem positivos e se a variável A for par escrever a mensagem "Valores aceitos", 
// senão escrever "Valores nao aceitos".

// Entrada
// Quatro números inteiros A, B, C e D.

// Saída
// Mostre a respectiva mensagem após a validação dos valores.

using System; 

class URI {

    static void Main(string[] args) { 

        int A, B, C, D;

        string[] Line = Console.ReadLine().Split(' ');

        A = int.Parse(Line[0]);
        B = int.Parse(Line[1]);
        C = int.Parse(Line[2]);
        D = int.Parse(Line[3]);

        if(B > C && 
            D > A &&
                C + D > A + B &&
                    C > 0 && D > 0){
            Console.WriteLine("Valores aceitos");
        }
        else{
            Console.WriteLine("Valores nao aceitos");
        }

    }
}
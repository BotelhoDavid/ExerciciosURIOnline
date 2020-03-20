// Leia 2 valores inteiros (A e B). Após, 
// o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", 
// indicando se os valores lidos são múltiplos entre si.

// Entrada
// A entrada contém valores inteiros.

// Saída
// A saída deve conter uma das mensagens conforme descrito acima.

using System; 

class URI {

    static void Main(string[] args) { 

       int a, b, c, resto;
        var num = Console.ReadLine().Split();

        a = int.Parse(num[0]);
        b = int.Parse(num[1]);

        resto = Math.DivRem(Math.Max(a,b), Math.Min(a,b), out c);

        if (c == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}
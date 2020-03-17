// Leia 3 valores inteiros e ordene-os em ordem crescente.No final, mostre os valores em ordem crescente, 
// uma linha em branco e em seguida, os valores na sequência como foram lidos.

// Entrada
// A entrada contem três números inteiros.

// Saída
// Imprima a saída conforme foi especificado.

using System; 

class URI {

    static void Main(string[] args) { 

        int num0, num1, num2, maior, medio, menor;

        string[] num = Console.ReadLine().Split();
        
        num0 = int.Parse(num[0]);
        num1 = int.Parse(num[1]);
        num2 = int.Parse(num[2]);

        if (num0 > num1 && num0 > num2)
        {
            maior = num0;
            if (num1 > num2)
            {
                medio = num1;
                menor = num2;
            }
            else
            {
                medio = num2;
                menor = num1;
            }
        }
        else if (num1 > num2)
        {
            maior = num1;
            if (num0 > num2)
            {
                medio = num0;
                menor = num2;
            }
            else
            {
                medio = num2;
                menor = num0;
            }
        }
        else
        {
            maior = num2;
            if (num0 > num1)
            {
                medio = num0;
                menor = num1;
            }
            else
            {
                medio = num1;
                menor = num0;
            }
        }
        Console.WriteLine($"{menor}\n{medio}\n{maior}");
        Console.WriteLine($"\n{num0}\n{num1}\n{num2}");

    }

}
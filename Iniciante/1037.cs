// Você deve fazer um programa que leia um valor qualquer
//  e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. 
//  Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

// O símbolo ( representa "maior que". Por exemplo:
// [0,25]  indica valores entre 0 e 25.0000, inclusive eles.
// (25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000

// Entrada
// O arquivo de entrada contém um número com ponto flutuante qualquer.

// Saída
// A saída deve ser uma mensagem conforme exemplo abaixo.

using System; 

class URI {

    static void Main(string[] args) { 

        double Num;
        bool A, B, C, D;

        Num = double.Parse(Console.ReadLine());
        A = Num >= 0.0 && Num <= 25.0;
        B = Num > 25 && Num <= 50.0;
        C = Num > 50 && Num <= 75.0;
        D = Num > 75 && Num <= 100.0;

        if (Num >= 0.0 && Num <= 100.0) {
            if (A) { Console.WriteLine("Intervalo [0,25]");}
            if (B) { Console.WriteLine("Intervalo (25,50]");}
            if (C) { Console.WriteLine("Intervalo (50,75]");}
            if (D) { Console.WriteLine("Intervalo (75,100]");} 
        }
        else { Console.WriteLine("Fora de intervalo");}

    }

}
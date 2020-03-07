// Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. 
// Em seguida, calcule e mostre:
// a) a área do triângulo retângulo que tem A por base e C por altura.
// b) a área do círculo de raio C. (pi = 3.14159)
// c) a área do trapézio que tem A e B por bases e C por altura.
// d) a área do quadrado que tem lado B.
// e) a área do retângulo que tem lados A e B.

// Entrada
// O arquivo de entrada contém três valores com um dígito após o ponto decimal.

// Saída
// O arquivo de saída deverá conter 5 linhas de dados. 
// Cada linha corresponde a uma das áreas descritas acima, 
// sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. 
// O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.

using System; 

class URI {

    static void Main(string[] args) { 

            double A, B, C, Pi;

            string[] Line = Console.ReadLine().Split(' ');

            Pi = 3.14159;
            A = double.Parse(Line[0]);
            B = double.Parse(Line[1]);
            C = double.Parse(Line[2]);

            Console.WriteLine("TRIANGULO: {0:f3}\nCIRCULO: {1:f3}\nTRAPEZIO: {2:f3}\nQUADRADO: {3:f3}\nRETANGULO: {4:f3}", ((A*C)/2),(Pi * Math.Pow(C,2)),(((A+B)*C)/2),(B*B),(A*B));
    }
}
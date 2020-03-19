// Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. 
// Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:

// Perimetro = XX.X

// Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem

// Area = XX.X

// Entrada
// A entrada contém três valores reais.

// Saída
// O resultado deve ser apresentado com uma casa decimal.

using System; 

class URI {

    static void Main(string[] args) { 

        double a, b, c, per, area;
        string[] num = Console.ReadLine().Split();

        a = double.Parse(num[0]);
        b = double.Parse(num[1]);
        c = double.Parse(num[2]);

        per = a + b + c;
        area = ((a + b) * c) / 2;

        if (a + b > c && b + c > a && a + c > b)
        {
            Console.WriteLine($"Perimetro = {per:f1}");                
        }
        else
        {
            Console.WriteLine($"Area = {area:f1}");
        }
    }
}
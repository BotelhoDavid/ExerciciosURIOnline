// Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, 
// p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, 
// mostrando 4 casas decimais após a vírgula, segundo a fórmula:

// Distancia = √(x2-x1)^2 + (y2-y1)^2

// Entrada
// O arquivo de entrada contém duas linhas de dados. 
// A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

// Saída
// Calcule e imprima o valor da distância segundo a fórmula fornecida, 
// com 4 casas após o ponto decimal.

using System; 

class URI {

    static void Main(string[] args) { 

            double x1, x2, y1, y2;
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');

            x1 = double.Parse(line1[0]);
            x2 = double.Parse(line2[0]);
            y1 = double.Parse(line1[1]);
            y2 = double.Parse(line2[1]);

            Console.WriteLine("{0:f4}",Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
    }
}
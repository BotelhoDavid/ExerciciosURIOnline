// Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. 
// A seguir, determine qual o quadrante ao qual pertence o ponto, 
// ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

//  Q2  |  Q1
//______|______
//      |      
// Q3   |  Q4  

// Se o ponto estiver na origem, escreva a mensagem “Origem”.

// Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

// Entrada
// A entrada contem as coordenadas de um ponto.

// Saída
// A saída deve apresentar o quadrante em que o ponto se encontra.

using System; 

class URI {

    static void Main(string[] args) { 

        double x, y;

        string[] coord = Console.ReadLine().Split();

        x = double.Parse(coord[0]);
        y = double.Parse(coord[1]);

        if (x > 0)
        {
            if (y > 0)
            {
                Console.WriteLine("Q1");
            }
            if (y < 0)
            {
                Console.WriteLine("Q4");
            }
        }

        if (x < 0)
        {


            if (y > 0)
            {
                Console.WriteLine("Q2");
            }
            if (y < 0)
            {
                Console.WriteLine("Q3");
            }
        }

        if (x == 0 && y == 0)
        {
            Console.WriteLine("Origem");
        }

        if (x == 0 && y > 0 || x == 0 && y < 0)
        {
            Console.WriteLine("Eixo Y");
        }

        if (y == 0 && x > 0 || y == 0 && x < 0)
        {
            Console.WriteLine("Eixo X");
        }
    }
}
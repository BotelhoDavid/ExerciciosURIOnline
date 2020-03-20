// Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, 
// de modo que o lado A representa o maior dos 3 lados. 
// A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, 
// sempre escrevendo uma mensagem adequada:
// se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
// se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
// se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
// se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
// se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
// se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

// Entrada
// A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

// Saída
// Imprima todas as classificações do triângulo especificado na entrada.


using System; 

class URI {

    static void Main(string[] args) { 

        double maior, medio, menor;

        var str = Console.ReadLine().Split();
        double[] num = {double.Parse(str[0]), double.Parse(str[1]), double.Parse(str[2]) };
        
        Array.Sort(num);
        Array.Reverse(num);

        maior = num[0];
        medio = num[1];
        menor = num[2];


        if (maior >= medio + menor)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if ((maior * maior) == (medio * medio + menor * menor))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if ((maior * maior) > (medio * medio + menor * menor))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if ((maior * maior) < (medio * medio + menor * menor))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (maior == medio && maior == menor)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if ((maior == medio && maior != menor)
                || (maior == menor && maior != medio)
                || medio == menor && medio != maior)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }

}
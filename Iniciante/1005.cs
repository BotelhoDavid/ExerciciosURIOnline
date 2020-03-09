// Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. 
// A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). 
// Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

// Entrada
// O arquivo de entrada contém 2 valores com uma casa decimal cada um.

// Saída
// Calcule e imprima a variável MEDIA conforme exemplo abaixo, 
// com 5 dígitos após o ponto decimal e com um espaço em branco antes e depois da igualdade. 
// Utilize variáveis de dupla precisão (double) e como todos os problemas, 
// não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

using System; 

class URI {

    static void Main(string[] args) { 

            double N1, N2, Media;

            N1 = double.Parse(Console.ReadLine());
            N2 = double.Parse(Console.ReadLine());
            Media = ((N1 * 3.5) + (N2 * 7.5)) / (3.5 + 7.5);

            Console.WriteLine($"MEDIA = {Media:f5}");
    }
}
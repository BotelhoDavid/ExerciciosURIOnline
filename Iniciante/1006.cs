// Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. 
//A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. 
// Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

// Entrada
// O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

// Saída
// Imprima a variável MEDIA, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade. 
// Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, 
// caso contrário, você receberá "Presentation Error".

using System; 

class URI {

    static void Main(string[] args) { 

            double N1, N2, N3, Media;
            

            N1 = double.Parse(Console.ReadLine());
            N2 = double.Parse(Console.ReadLine());
            N3 = double.Parse(Console.ReadLine());
            Media = ((N1 * 2) + (N2 * 3) + (N3 * 5)) / (2 + 3 + 5);
            
           Console.WriteLine("MEDIA = {0:f1}", Media);
    }
}
// Leia um valor inteiro, 
// que é o tempo de duração em segundos de um determinado evento em uma fábrica,
// e informe-o expresso no formato horas:minutos:segundos.

// Entrada
// O arquivo de entrada contém um valor inteiro N.

// Saída
// Imprima o tempo lido no arquivo de entrada (segundos), 
// convertido para horas:minutos:segundos, conforme exemplo fornecido.

using System; 

class URI {

    static void Main(string[] args) { 

        int segundos, hor, min, seg;

            segundos = int.Parse(Console.ReadLine());

            hor = segundos / (60 * 60);
            min = (segundos - (hor * 60 * 60)) / 60;
            seg = segundos - (hor * 60 * 60) - (min * 60);

            Console.WriteLine(hor+":"+min+":"+seg);
    }
}
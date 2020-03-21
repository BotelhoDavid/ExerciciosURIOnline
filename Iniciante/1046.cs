// Leia a hora inicial e a hora final de um jogo. 
// A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, 
// tendo uma duração mínima de 1 hora e máxima de 24 horas.

// Entrada
// A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.

// Saída
// Apresente a duração do jogo conforme exemplo abaixo.

//              O JOGO DUROU 10 HORA(S)

using System; 

class URI {

    static void Main(string[] args) {

            int hora1, hora2;
            DateTime date1, date2;
            TimeSpan result;

            var horas = Console.ReadLine().Split();
            hora1 = int.Parse(horas[0]);
            hora2 = int.Parse(horas[1]);

            date1 = new DateTime(1, 1, 1, hora1, 0, 0);

            if (hora2 <= hora1)
            {
                date2 = new DateTime(1, 1, 2, hora2, 0, 0);
            }
            else
            {
                date2 = new DateTime(1, 1, 1, hora2, 0, 0);
            }

            result = date2 - date1;

            if (result.Days > 0)
            {
                Console.WriteLine($"O JOGO DUROU {(result.Days * 24) + result.Hours} HORA(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {result.Hours} HORA(S)");
            }
        }

}
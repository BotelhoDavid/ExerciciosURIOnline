// Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por linha, inclusive o X ser for o caso.

// Entrada
// A entrada será um valor inteiro positivo.

// Saída
// A saída será uma sequência de seis números ímpares.

using System; 

class URI {

    static void Main(string[] args) {
        
        int _numb = int.Parse(Console.ReadLine());

        if (!(_numb % 2 == 0))
        {
            Console.WriteLine(_numb);
            for (int i = 0; i < 5; i++)
            {
                _numb+=2;
                Console.WriteLine(_numb);
            }
        }else
        {
            _numb += 1;
            Console.WriteLine(_numb);
            for (int i = 0; i < 5; i++)
            {
                _numb+=2;
                Console.WriteLine(_numb);
            }
        }
    }
}
// Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na próxima linha, deve-se mostrar a média de todos os valores positivos digitados, com um dígito após o ponto decimal.

// Entrada
// A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes números será positivo.

// Saída
// O primeiro valor de saída é a quantidade de valores positivos. A próxima linha deve mostrar a média dos valores positivos digitados.

// Exemplo de Entrada   |	        Exemplo de Saída
//          7           |     4 valores positivos
//          -5          |     7.4
//          6           |
//          -3.4        |
//          4.6         |
//          12          |


using System; 

class URI {

    static void Main(string[] args) {
		decimal _media = 0;
        int _positivo = 0;

    
        for (int i = 0; i < 6; i++)
        {
            decimal _numb = decimal.Parse(Console.ReadLine());
            if (_numb > 0)
            {
                _positivo++;
                _media += _numb;
            }            
        }
        Console.WriteLine(_positivo + " valores positivos");
        Console.WriteLine("{0:f1}", _media/_positivo);
	}

}
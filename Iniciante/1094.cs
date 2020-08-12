// Maria acabou de iniciar seu curso de graduação na faculdade de medicina
//  e precisa de sua ajuda para organizar os experimentos de um laboratório
//   o qual ela é responsável. 
// Ela quer saber no final do ano,
//  quantas cobaias foram utilizadas no laboratório
//   e o percentual de cada tipo de cobaia utilizada.

// Este laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos.
//  Para obter estas informações, ela sabe exatamente o número de experimentos que foram realizados, o tipo de cobaia utilizada e a quantidade de cobaias utilizadas em cada experimento.

// Entrada
// A primeira linha de entrada contém um valor inteiro N
//  que indica os vários casos de teste que vem a seguir. 
// Cada caso de teste contém um inteiro Quantia (1 ≤ Quantia ≤ 15) que representa a quantidade de cobaias utilizadas e um caractere Tipo ('C', 'R' ou 'S'), indicando o tipo de cobaia (R:Rato S:Sapo C:Coelho).

// Saída
// Apresente o total de cobaias utilizadas, 
//  o total de cada tipo de cobaia utilizada
//  e o percentual de cada uma em relação ao total de cobaias utilizadas,
// sendo que o percentual deve ser apresentado com dois dígitos após o ponto.

using System; 

class URI {
  static void Main(string[] args) {

    int _casos = int.Parse(Console.ReadLine());
    double _coelhos = 0,_ratos = 0, _sapos = 0, _total = 0;            

    for (int i = 0; i < _casos; i++)
    {
      String[] _cobaia = Console.ReadLine().Split();
      int _quantia = int.Parse(_cobaia[0]);
      String _tipo = _cobaia[1];

      _total += _quantia;

      if (_tipo.ToUpper() == "C"){
        _coelhos += _quantia;
      }
      if (_tipo.ToUpper() == "R"){
        _ratos += _quantia;
      }
      if (_tipo.ToUpper() == "S"){
        _sapos += _quantia;
      }
    }

    double _tCoelhos = _coelhos * 100 / _total;
    double _tRatos = _ratos * 100 / _total;
    double _tSapos = _sapos * 100 / _total;

    Console.WriteLine($"Total: {_total} cobaias");
    Console.WriteLine($"Total de coelhos: {_coelhos}");
    Console.WriteLine($"Total de ratos: {_ratos}");
    Console.WriteLine($"Total de sapos: {_sapos}");
    Console.WriteLine($"Percentual de coelhos: {_tCoelhos:f2} %");
    Console.WriteLine($"Percentual de ratos: {_tRatos:f2} %");
    Console.WriteLine($"Percentual de sapos: {_tSapos:f2} %");
	}
}
// Leia um valor inteiro entre 1 e 12, inclusive. Correspondente a este valor, deve ser apresentado como resposta o mês do ano por extenso, em inglês, com a primeira letra maiúscula.

// Entrada
// A entrada contém um único valor inteiro.

// Saída
// Imprima por extenso o nome do mês correspondente ao número existente na entrada, com a primeira letra em maiúscula.

// Exemplo de Entrada	|   Exemplo de Saída
//          4         |         April


using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 
        IDictionary<string, string> _listameses = new Dictionary<string, string> {
            {"1", "January"}
            ,{"2", "February"}
            ,{"3", "March"}
            ,{"4", "April"}
            ,{"5", "May"}
            ,{"6", "June"}
            ,{"7", "July"}
            ,{"8", "August"}
            ,{"9", "September"}
            ,{"10", "October"}
            ,{"11", "November"}
            ,{"12", "December"}};

        string _numb = Console.ReadLine();

        if (_listameses.TryGetValue(_numb, out string _mes)){
            Console.WriteLine($"{_mes}");}
    } 
}
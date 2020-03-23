// Leia um número inteiro que representa um código de DDD para discagem interurbana. 
// Em seguida, informe à qual cidade o DDD pertence.

// Se a entrada for qualquer outro DDD que não esteja presente na tabela, o programa deverá informar:
// DDD nao cadastrado

// Entrada
// A entrada consiste de um único valor inteiro.

// Saída
// Imprima o nome da cidade correspondente ao DDD existente na entrada. 
// Imprima DDD nao cadastrado caso não existir DDD correspondente ao número digitado.

using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) {
        IDictionary<string, string> _listaDDD = new Dictionary<string, string> {
            {"61", "Brasilia"}
            ,{"71", "Salvador"}
            ,{"11", "Sao Paulo"}
            ,{"21", "Rio de Janeiro"}
            ,{"32", "Juiz de Fora"}
            ,{"19", "Campinas"}
            ,{"27", "Vitoria"}
            ,{"31", "Belo Horizonte"}};

        string _ddd = Console.ReadLine();

        if (!_listaDDD.TryGetValue(_ddd, out string _estado))
           Console.WriteLine("DDD nao cadastrado");
        else 
            Console.WriteLine($"{_estado}");
    }
}
// Pedrinho está organizando um evento em sua Universidade.
// O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. 
// O problema é que Pedrinho quer calcular o tempo que o evento vai durar,
//  uma vez que ele sabe quando inicia e quando termina o evento.

// Sabendo que o evento pode durar de poucos segundos a vários dias,
//  você deverá ajudar Pedrinho a calcular a duração deste evento.

// Entrada
// Como entrada, na primeira linha vai haver a descrição “Dia”,
//  seguido de um espaço e o dia do mês no qual o evento vai começar. 
// Na linha seguinte, será informado o momento no qual o evento vai iniciar,
// no formato hh : mm : ss. Na terceira
//  e quarta linha de entrada haverá outra informação no mesmo formato das duas primeiras linhas,
// indicando o término do evento.

// Saída
// Na saída, deve ser apresentada a duração do evento, no seguinte formato:

// W dia(s)
// X hora(s)
// Y minuto(s)
// Z segundo(s)

using System; 

class URI {
  static void Main(string[] args) { 

    string[] _inicio, _horainicio, _final, _horafinal;
    int _dias, _hor, _min, _sec;
    
    _inicio = Console.ReadLine().Split(' ');
    _horainicio = Console.ReadLine().Split(':');
    DateTime _inicioData = new DateTime(2020, 07, int.Parse(_inicio[1])
                                                  ,int.Parse(_horainicio[0])
                                                  ,int.Parse(_horainicio[1])
                                                  ,int.Parse(_horainicio[2]));
    
    _final = Console.ReadLine().Split(' ');
    _horafinal = Console.ReadLine().Split(':');
    DateTime _finalData = new DateTime(2020, 07,int.Parse(_final[1])
                                              ,int.Parse(_horafinal[0])
                                              ,int.Parse(_horafinal[1])
                                              ,int.Parse(_horafinal[2]));
    
    TimeSpan _diferenca = _finalData.Subtract(_inicioData);
    _dias = _diferenca.Days;
    _hor = _diferenca.Hours;
    _min = _diferenca.Minutes;
    _sec = _diferenca.Seconds;
            
    Console.WriteLine($"{_dias} dia(s)\n{_hor} hora(s)\n{_min} minuto(s)\n{_sec} segundo(s)");
 }
}
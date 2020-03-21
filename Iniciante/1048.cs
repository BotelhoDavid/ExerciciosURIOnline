// A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:


//          Salário	              |  Percentual de Reajuste
//      0 - 400.00                |       15%
//      400.01 - 800.00           |       12%
//      800.01 - 1200.00          |       10%
//      1200.01 - 2000.00         |        7%
//      Acima de 2000.00          |        4%

// Leia o salário do funcionário e calcule e mostre o novo salário, 
// bem como o valor de reajuste ganho e o índice reajustado, em percentual.

// Entrada
// A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

// Saída
// Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho.


using System; 

class URI {

    static void Main(string[] args) {
        
        var novosal = 0.0;
        var reaj = 0.0;
        var perc = 0.0;

        var sal = double.Parse(Console.ReadLine());

        if (sal <= 400.00)
        {
            perc = 15;
        }
        else if (sal > 400.00 && sal <= 800.00)
        {
            perc = 12;
        }
        else if (sal > 800.00 && sal <= 1200.00)
        {
            perc = 10;
        }
        else if (sal > 1200.00 && sal <= 2000.00)
        {
            perc = 7;
        }
        else
        {
            perc = 4;
        }

        reaj = (sal / 100) * perc;
        novosal = sal + reaj;

        Console.WriteLine($"Novo salario: {novosal:f2}");
        Console.WriteLine($"Reajuste ganho: {reaj:f2}");
        Console.WriteLine($"Em percentual: {perc} %");
    }
}
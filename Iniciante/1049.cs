// Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, 
//  da esquerda para a direita.  
// Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.

// Entrada
// A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima,
//  com todas as letras minúsculas.

// Saída
// Imprima o nome do animal correspondente à entrada fornecida.

using System; 

class URI {

    static void Main(string[] args) {
        string subfilo, classe, alimento;

        subfilo = Console.ReadLine();
        classe = Console.ReadLine();
        alimento = Console.ReadLine();

        if (subfilo == "vertebrado")
        {
            if (classe == "ave")
            {
                if (alimento == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else
                {
                    Console.WriteLine("pomba");
                }                   
            }
            if (classe == "mamifero")
            {
                if (alimento == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else
                {
                    Console.WriteLine("vaca");
                }
            }
        }
        if (subfilo == "invertebrado")
        {
            if (classe == "inseto")
            {
                if (alimento == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else
                {
                    Console.WriteLine("lagarta");
                }
            }
            if (classe == "anelideo")
            {
                if (alimento == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }

}
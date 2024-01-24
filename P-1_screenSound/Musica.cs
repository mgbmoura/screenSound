//Uma classe no C# é uma estrutura que define o comportamento e
//as propriedades de um objeto, servindo como um molde
//para criar instâncias deste objeto. Ela agrupa dados (atributos)
//e comportamentos (métodos) relacionados em uma única entidade, como ilustra o código abaixo:
using System.Threading.Channels;

class Musica
{
    public string Nome { get; set; }             //Operador =>: É o operador de seta (=>), que separa a lista de parâmetros da                   
    public string Artista { get; set; }          //expressão lambda. Ele indica que os parâmetros estão sendo mapeados para a                                                                                                       
    public int Duracao { get; set; }             //expressão ou bloco de código seguinte.                                                                                                                         
    public bool Disponivel {  get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}";




    public void ExibirFichaTecnica() 
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Disponivel: {Disponivel}");

        if (Disponivel) 
        {
            Console.WriteLine("Disponível no plano.\n");
        } else 
        {
            Console.WriteLine("Não disponível no plano. Adquira o plano Plus+\n");    
        }

    }
}
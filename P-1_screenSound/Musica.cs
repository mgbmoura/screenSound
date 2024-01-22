class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica() 
    {
        Console.WriteLine($"\nNome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        Console.WriteLine($"Disponivel: {disponivel}");

        if (disponivel) 
        {
            Console.WriteLine("Disponível no plano.\n");
        } else 
        {
            Console.WriteLine("Não disponível no plano. Adquira o plano Plus+\n");    
        }

    }
}
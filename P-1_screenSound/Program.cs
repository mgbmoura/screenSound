Musica musica1 = new Musica();
musica1.Nome = "Musica teste1";
musica1.Artista = "Artista teste1";
musica1.Duracao = 305;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);



Musica musica2 = new Musica();
musica2.Nome = "Musica teste2";
musica2.Artista = "Artista teste2";
musica2.Duracao = 305;
musica2.Disponivel = false;
Console.WriteLine(musica2.DescricaoResumida);

Musica musica3 = new Musica();
musica3.Nome = "Musica teste3";
musica3.Artista = "Artista teste3";
musica3.Duracao = 305;
musica3.Disponivel = true;
Console.WriteLine(musica3.DescricaoResumida);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
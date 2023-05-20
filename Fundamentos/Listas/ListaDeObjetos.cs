using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Listas
{
    internal class ListaDeObjetos
    {
        public void Executar()
        {
            List<Filme> filmes = new List<Filme>();

            Filme dragonBallEvolution = new Filme();
            dragonBallEvolution.Nome = "Dragon Ball Evolution";
            dragonBallEvolution.Duracao = 85;
            dragonBallEvolution.Categoria = FilmeCategoriaEnum.LiveAction;

            filmes.Add(dragonBallEvolution);

            Filme beethovenMagnifico = new Filme();
            beethovenMagnifico.Nome = "Beethoven o Magnífico";
            beethovenMagnifico.Duracao = 87;
            beethovenMagnifico.Categoria = FilmeCategoriaEnum.Comedia;

            filmes.Add(beethovenMagnifico);

            Filme noLimiteAmanha = new Filme();
            noLimiteAmanha.Nome = "No Limite do Amanhã";
            noLimiteAmanha.Duracao = 113;
            noLimiteAmanha.Categoria = FilmeCategoriaEnum.LiveAction;

            filmes.Add(noLimiteAmanha);

            Filme mortalKombat = new Filme();
            mortalKombat.Nome = "Mortal Kombat";
            mortalKombat.Duracao = 101;
            mortalKombat.Categoria = FilmeCategoriaEnum.LiveAction;

            filmes.Add(mortalKombat);

            Filme guardioesDaGalaxia3 = new Filme();
            guardioesDaGalaxia3.Nome = "Guardiões da Galáxia Vol. 3";
            guardioesDaGalaxia3.Duracao = 150;
            guardioesDaGalaxia3.Categoria = FilmeCategoriaEnum.Acao;

            filmes.Add(guardioesDaGalaxia3);

            for (int i = 0; i < filmes.Count; i++)
            {
                Console.WriteLine($"\nFilme: {filmes[i].Nome}");
                Console.WriteLine($"    Duração: {filmes[i].Duracao} minutos");
                Console.WriteLine($"    Categoria: {filmes[i].Categoria.ToString()}");
            }
        }

        enum FilmeCategoriaEnum
        {
            LiveAction,
            Comedia,
            Acao
        }

        class Filme
        {
            public string Nome;
            public ushort Duracao;
            public FilmeCategoriaEnum Categoria;
        }
    }
}

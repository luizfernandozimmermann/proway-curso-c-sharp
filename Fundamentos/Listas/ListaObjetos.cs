using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Listas
{
    internal class ListaObjetos : Executor
    {
        public override void Executar()
        {
            var filmes = new List<Filme>();

            Filme dragonBallEvolution = new Filme();
            dragonBallEvolution.Nome = "Dragon Ball Evolution";
            dragonBallEvolution.Duracao = 85;
            dragonBallEvolution.Categoria = FilmeCategoriaEnum.LiveAction;
            filmes.Add(dragonBallEvolution); // 0

            Filme beethovenMagnifico = new Filme();
            beethovenMagnifico.Nome = "Beethoven, O Magnífico";
            beethovenMagnifico.Duracao = 87;
            beethovenMagnifico.Categoria = FilmeCategoriaEnum.Comedia;
            filmes.Add(beethovenMagnifico); // 1

            Filme noLimiteAmanha = new Filme();
            noLimiteAmanha.Nome = "No Limite do Amanhã";
            noLimiteAmanha.Categoria = FilmeCategoriaEnum.LiveAction;
            noLimiteAmanha.Duracao = 113;
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

            Console.WriteLine("Lista de filmes sem for:");
            Console.WriteLine(filmes[0].Nome);
            Console.WriteLine(filmes[0].Duracao);
            Console.WriteLine(filmes[0].Categoria);
            
            Console.WriteLine(filmes[1].Nome);
            Console.WriteLine(filmes[1].Duracao);
            Console.WriteLine(filmes[1].Categoria);
            
            Console.WriteLine(filmes[2].Nome);
            Console.WriteLine(filmes[2].Duracao);
            Console.WriteLine(filmes[2].Categoria);
            
            Console.WriteLine(filmes[3].Nome);
            Console.WriteLine(filmes[3].Duracao);
            Console.WriteLine(filmes[3].Categoria);

            Console.WriteLine("\nFilmes com for:");
            for(int i = 0; i < filmes.Count; i++)
            {
                Console.WriteLine(filmes[i].Nome);
                Console.WriteLine(filmes[i].Duracao);
                Console.WriteLine(filmes[i].Categoria);
            }
        }

        enum FilmeCategoriaEnum
        {
            LiveAction, // 0
            Comedia, // 1
            Acao // 2
        }

        class Filme
        {
            public string Nome;
            public ushort Duracao; // 0..65535
            public FilmeCategoriaEnum Categoria;
        }
    }
}

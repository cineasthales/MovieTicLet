using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabFinal.Classes;

namespace trabFinal.DAO
{
    class FilmesDAO
    {
        private ModelDB db { get; set; }

        public FilmesDAO()
        {
            db = new ModelDB();
        }

        public void Incluir(Filmes filme)
        {       
            db.Filmes.Add(filme);
            db.SaveChanges();
        }

        public void Alterar(Filmes filme)
        {            
            // posiciona no registro a ser alterado
            Filmes filmeAlt = db.Filmes.Where(f => f.Id == filme.Id).First();
            // altera suas propriedades
            filmeAlt.TituloOriginal = filme.TituloOriginal;
            filmeAlt.TituloNacional = filme.TituloNacional;
            filmeAlt.Duracao = filme.Duracao;
            filmeAlt.Classificacao = filme.Classificacao;
            filmeAlt.Sinopse = filme.Sinopse;
            filmeAlt.Genero = filme.Genero;
            // salva o registro alterado
            db.SaveChanges();
        }

        public void Excluir(int id)
        {
            // posiciona no registro a ser excluído
            Filmes filmeExc = db.Filmes.Where(f => f.Id == id).First();
            db.Filmes.Remove(filmeExc);
            db.SaveChanges();
        }

        public IEnumerable<Filmes> Listar()
        {
            return db.Filmes.ToList();
        }
    }
}

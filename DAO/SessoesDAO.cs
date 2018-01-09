using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabFinal.Classes;
using System.Data.Entity;

namespace trabFinal.DAO
{
    class SessoesDAO
    {
        private ModelDB db { get; set; }

        public SessoesDAO()
        {
            db = new ModelDB();
        }

        public void Incluir(Sessoes sessao)
        {
            // "posiciona" na sala selecionada
            sessao.Salas = db.Salas.ToList().Where(s => s.Id == sessao.Salas.Id).First();
            // "posiciona" no filme selecionado
            sessao.Filmes = db.Filmes.ToList().Where(f => f.Id == sessao.Filmes.Id).First();
            db.Sessoes.Add(sessao);
            db.SaveChanges();
        }

        public void Alterar(Sessoes sessao)
        {
            // "posiciona" na sala selecionada
            sessao.Salas = db.Salas.ToList().Where(s => s.Id == sessao.Salas.Id).First();
            // "posiciona" no filme selecionado
            sessao.Filmes = db.Filmes.ToList().Where(f => f.Id == sessao.Filmes.Id).First();
            // posiciona no registro a ser alterado
            Sessoes sessaoAlt = db.Sessoes.Where(se => se.Id == sessao.Id).First();
            // altera suas propriedades
            sessaoAlt.Horario = sessao.Horario;
            sessaoAlt.Legendado = sessao.Legendado;
            sessaoAlt.TresD = sessao.TresD;
            sessaoAlt.Data = sessao.Data;
            sessaoAlt.Salas = sessao.Salas;
            sessaoAlt.Filmes = sessao.Filmes;
            // salva o registro alterado
            db.SaveChanges();
        }

        public void AlterarQnt(Compras compra)
        {
            // posiciona no registro a ser alterado
            Sessoes sessaoAlt = db.Sessoes.Where(se => se.Id == compra.Sessoes.Id).First();
            // altera suas propriedades
            sessaoAlt.QntOcupados = sessaoAlt.QntOcupados + compra.Qnt;
            // salva o registro alterado
            db.SaveChanges();
        }

        public void AlterarQntExc(int qnt, int id)
        {
            // posiciona no registro a ser alterado
            Sessoes sessaoAlt = db.Sessoes.Where(se => se.Id == id).First();
            // altera suas propriedades
            sessaoAlt.QntOcupados = sessaoAlt.QntOcupados - qnt;
            // salva o registro alterado
            db.SaveChanges();
        }

        public void Excluir(int id)
        {
            // posiciona no registro a ser excluído
            Sessoes sessaoExc = db.Sessoes.Where(s => s.Id == id).First();
            db.Sessoes.Remove(sessaoExc);
            db.SaveChanges();
        }

        public IEnumerable<Sessoes> Listar()
        {
            // Include "inclui" dados da tabela relacionada na listagem
            // Obs.: para usar o include deve ser adicionado nos using do cabeçalho:
            // using System.Data.Entity;
            return db.Sessoes.Include(s => s.Salas).Include(s => s.Filmes).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabFinal.Classes;
using System.Data.Entity;

namespace trabFinal.DAO
{
    class ComprasDAO
    {
        private ModelDB db { get; set; }

        public ComprasDAO()
        {
            db = new ModelDB();
        }

        public void Incluir(Compras compra)
        {
            // "posiciona" no usuário selecionado
            compra.Usuarios = db.Usuarios.ToList().Where(u => u.Id == compra.Usuarios.Id).First();
            // "posiciona" na sessão selecionada
            compra.Sessoes = db.Sessoes.ToList().Where(s => s.Id == compra.Sessoes.Id).First();
            db.Compras.Add(compra);
            db.SaveChanges();
        }

        public void Alterar(Compras compra)
        {
            // "posiciona" no usuário selecionado
            compra.Usuarios = db.Usuarios.ToList().Where(u => u.Id == compra.Usuarios.Id).First();
            // "posiciona" na sessão selecionada
            compra.Sessoes = db.Sessoes.ToList().Where(s => s.Id == compra.Sessoes.Id).First();
            // posiciona no registro a ser alterado
            Compras compraAlt = db.Compras.Where(c => c.Id == compra.Id).First();
            // altera suas propriedades
            compraAlt.PrecoUnitario = compra.PrecoUnitario;
            compraAlt.PrecoTotal = compra.PrecoTotal;
            compraAlt.Qnt = compra.Qnt;
            compraAlt.Usuarios = compra.Usuarios;
            compraAlt.Sessoes = compra.Sessoes;
            // salva o registro alterado
            db.SaveChanges();
        }

        public void Excluir(int id)
        {
            // posiciona no registro a ser excluído
            Compras compraExc = db.Compras.Where(c => c.Id == id).First();
            db.Compras.Remove(compraExc);
            db.SaveChanges();
        }

        public IEnumerable<Compras> Listar()
        {
            // Include "inclui" dados da tabela relacionada na listagem
            // Obs.: para usar o include deve ser adicionado nos using do cabeçalho:
            // using System.Data.Entity;
            return db.Compras.Include(c => c.Sessoes).Include(c => c.Usuarios).ToList();
        }
    }
}

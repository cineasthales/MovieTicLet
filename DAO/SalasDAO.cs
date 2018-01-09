using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabFinal.Classes;

namespace trabFinal.DAO
{
    class SalasDAO
    {
        private ModelDB db { get; set; }

        public SalasDAO()
        {
            db = new ModelDB();
        }

        public void Incluir(Salas sala)
        {
            db.Salas.Add(sala);
            db.SaveChanges();
        }

        public void Alterar(Salas sala)
        {
            // posiciona no registro a ser alterado
            Salas salaAlt = db.Salas.Where(s => s.Id == sala.Id).First();
            // altera suas propriedades
            salaAlt.Nome = sala.Nome;
            salaAlt.Capacidade = sala.Capacidade;
            // salva o registro alterado
            db.SaveChanges();
        }

        public void Excluir(int id)
        {
            // posiciona no registro a ser excluído
            Salas salaExc = db.Salas.Where(s => s.Id == id).First();
            db.Salas.Remove(salaExc);
            db.SaveChanges();
        }

        public IEnumerable<Salas> Listar()
        {
            return db.Salas.ToList();
        }
    }
}

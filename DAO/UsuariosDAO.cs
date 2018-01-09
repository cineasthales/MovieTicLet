using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabFinal.Classes;

namespace trabFinal.DAO
{
    class UsuariosDAO
    {
        private ModelDB db { get; set; }

        public UsuariosDAO()
        {
            db = new ModelDB();
        }

        public void Incluir(Usuarios usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();
        }

        public void Alterar(Usuarios usuario)
        {
            // posiciona no registro a ser alterado
            Usuarios usuarioAlt = db.Usuarios.Where(u => u.Id == usuario.Id).First();
            // altera suas propriedades
            usuarioAlt.Login = usuario.Login;
            usuarioAlt.Senha = usuario.Senha;
            usuarioAlt.Nivel = usuario.Nivel;
            // salva o registro alterado
            db.SaveChanges();
        }

        public void Excluir(int id)
        {
            // posiciona no registro a ser excluído
            Usuarios usuarioExc = db.Usuarios.Where(u => u.Id == id).First();
            db.Usuarios.Remove(usuarioExc);
            db.SaveChanges();
        }

        public IEnumerable<Usuarios> Listar()
        {
            return db.Usuarios.ToList();
        }
    }
}

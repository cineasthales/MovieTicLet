using trabFinal.Classes;
using trabFinal.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabFinal
{
    public partial class formLogin : Form
    {
        public static int nivel { get; set; }
        public static int idUsuarioLogado { get; set; }

        public formLogin()
        {
            InitializeComponent();
            nivel = -1;
            idUsuarioLogado = -1;
        }        

        private void btEntrar_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String senha = txtSenha.Text;

            UsuariosDAO usuarioDao = new UsuariosDAO();

            IEnumerable<Usuarios> lista = usuarioDao.Listar().Where(u => u.Login == login && u.Senha == senha);

            if (lista.Count() == 1)
            {
                nivel = lista.ElementAt(0).Nivel;
                idUsuarioLogado = lista.ElementAt(0).Id;
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Login efetuado com sucesso.");
                Close();
            }
            else
            {
                MessageBox.Show("Erro: nome de usuário e/ou senha inválido(s).");
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

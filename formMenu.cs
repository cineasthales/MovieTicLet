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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void sessoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formLogin.idUsuarioLogado <= 0)
            {
                MessageBox.Show("Erro: você não está logado.");
                return;
            }
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is formCadSessoes)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                formCadSessoes novoForm;
                novoForm = new formCadSessoes();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formLogin.idUsuarioLogado <= 0)
            {
                MessageBox.Show("Erro: você não está logado.");
                return;
            }
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is formCadFilmes)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                formCadFilmes novoForm;
                novoForm = new formCadFilmes();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formLogin.idUsuarioLogado <= 0)
            {
                MessageBox.Show("Erro: você não está logado.");
                return;
            }
            if (formLogin.nivel > 1)
            {
                MessageBox.Show("Erro: acesso não autorizado.");
                return;
            }
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is formCadSalas)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                formCadSalas novoForm;
                novoForm = new formCadSalas();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string mensagem, titulo;
            MessageBoxButtons botoes;
            DialogResult resposta;

            mensagem = "Tem certeza que deseja sair?";
            titulo = "Atenção";
            botoes = MessageBoxButtons.YesNo;

            resposta = MessageBox.Show(mensagem, titulo, botoes);

            if (resposta == DialogResult.Yes)
            {
                try
                {                    
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formLogin.idUsuarioLogado <= 0)
            {
                MessageBox.Show("Erro: você não está logado.");
                return;
            }
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is formMovCompras)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                formMovCompras novoForm;
                novoForm = new formMovCompras();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        private void filmesPorComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formLogin.idUsuarioLogado <= 0)
            {
                MessageBox.Show("Erro: você não está logado.");
                return;
            }
            if (formLogin.nivel > 1)
            {
                MessageBox.Show("Erro: acesso não autorizado.");
                return;
            }
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is formGrafFilmes)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                formGrafFilmes novoForm;
                novoForm = new formGrafFilmes();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        private void comprasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (formLogin.idUsuarioLogado <= 0)
            {
                MessageBox.Show("Erro: você não está logado.");
                return;
            }
            if (formLogin.nivel > 1)
            {
                MessageBox.Show("Erro: acesso não autorizado.");
                return;
            }
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is formRelCompras)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                formRelCompras novoForm;
                novoForm = new formRelCompras();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        private void filmesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formLogin.idUsuarioLogado <= 0)
            {
                MessageBox.Show("Erro: você não está logado.");
                return;
            }
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is formPesqFilmes)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                formPesqFilmes novoForm;
                novoForm = new formPesqFilmes();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formLogin.idUsuarioLogado > 0)
            {
                string mensagem, titulo;
                MessageBoxButtons botoes;
                DialogResult resposta;

                mensagem = "Tem certeza que deseja fazer logout?";
                titulo = "Atenção";
                botoes = MessageBoxButtons.YesNo;

                resposta = MessageBox.Show(mensagem, titulo, botoes);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Logout com êxito.");
                        abrirJanelaLogin();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            } else
            {
                abrirJanelaLogin();
            }
            
        }

        private void abrirJanelaLogin()
        {            
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is formLogin)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                formLogin novoForm;
                novoForm = new formLogin();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formLogin.idUsuarioLogado <= 0)
            {
                MessageBox.Show("Erro: você não está logado.");
                return;
            }
            if (formLogin.nivel > 0)
            {
                MessageBox.Show("Erro: acesso não autorizado.");
                return;
            }
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is formCadUsuarios)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                formCadUsuarios novoForm;
                novoForm = new formCadUsuarios();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }
    }
}

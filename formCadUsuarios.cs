using trabFinal.Classes;
using trabFinal.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabFinal
{
    public partial class formCadUsuarios : Form
    {
        private UsuariosDAO usuarioDao { get; set; }

        public formCadUsuarios()
        {
            InitializeComponent();
            usuarioDao = new UsuariosDAO();
        }

        private void formCadUsuarios_Activated(object sender, EventArgs e)
        {
            configuraGrid();
            carregaUsuarios();
        }

        private void configuraGrid()
        {
            // limpa a grid
            dataGrid.Columns.Clear();

            // adiciona as colunas a serem exibidas (conteúdo, título da coluna)
            dataGrid.Columns.Add("Id", "Id");
            dataGrid.Columns.Add("Login", "Login");
            dataGrid.Columns.Add("Senha", "Senha");
            dataGrid.Columns.Add("Nivel", "Nível");

            // alinhamento das colunas
            dataGrid.Columns["Login"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["Senha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["Nivel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            // largura das colunas (o default é 100)
            dataGrid.Columns["Id"].Width = 40;
            dataGrid.Columns["Login"].Width = 100;
            dataGrid.Columns["Senha"].Width = 100;
            dataGrid.Columns["Nivel"].Width = 50;
        }

        private void carregaUsuarios()
        {
            // obtém os dados 
            IEnumerable<Usuarios> lista = usuarioDao.Listar();

            // limpa as linhas da grid
            dataGrid.Rows.Clear();

            // preenche as colunas
            foreach (Usuarios u in lista)
            {
                dataGrid.Rows.Add(u.Id, u.Login, u.Senha, u.Nivel);
            }
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            gbCad.Visible = true;
            gbCad.Text = "Inclusão de Usuário";
            cbNivel.Enabled = true;
            txtLogin.Enabled = true;

            limpaCampos();

            txtLogin.Focus();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (!validaCampos())
            {
                MessageBox.Show("Preencha todos os dados cadastrais.");
                txtLogin.Focus();
                return;
            }

            Usuarios usuario = new Usuarios();
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nivel = cbNivel.SelectedIndex;

            if (gbCad.Text == "Inclusão de Usuário")
            {            
                usuarioDao.Incluir(usuario);
                MessageBox.Show("Usuário cadastrado com sucesso.");
            }
            else
            {
                usuario.Id = Convert.ToInt16(dataGrid.CurrentRow.Cells["Id"].Value.ToString());
                usuarioDao.Alterar(usuario);
                MessageBox.Show("Usuário alterado com sucesso.");
                txtLogin.Enabled = true;
                cbNivel.Enabled = true;
            }

            // atualiza a grid                
            carregaUsuarios();

            gbCad.Visible = false;
        }

        private Boolean validaCampos()
        {
            bool valido = true;

            if (txtSenha.Text == "" ||
                txtLogin.Text == "" ||
                cbNivel.SelectedIndex == -1)
            {
                valido = false;
            }
            return valido;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpaCampos()
        {
            txtLogin.Clear();
            txtSenha.Clear();
            cbNivel.SelectedIndex = -1;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            cbNivel.Enabled = true;
            txtLogin.Enabled = true;
            gbCad.Visible = true;
            gbCad.Text = "Alteração de Usuário";
            txtLogin.Focus();

            txtLogin.Text = dataGrid.CurrentRow.Cells["Login"].Value.ToString();

            switch (Convert.ToInt32(dataGrid.CurrentRow.Cells["Nivel"].Value.ToString()))
            {
                case 0:
                    cbNivel.SelectedIndex = 0;
                    break;
                case 1:
                    cbNivel.SelectedIndex = 1;
                    break;
                case 2:
                    cbNivel.SelectedIndex = 2;
                    break;
            }

            int alterarId = Convert.ToInt32(dataGrid.CurrentRow.Cells["Id"].Value.ToString());
            if (txtLogin.Text == "admin" || alterarId == formLogin.idUsuarioLogado)
            {
                txtLogin.Enabled = false;
                cbNivel.SelectedIndex = 0;
                cbNivel.Enabled = false;
            }
            txtSenha.Text = dataGrid.CurrentRow.Cells["Senha"].Value.ToString();                        
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            String excluir = dataGrid.CurrentRow.Cells["Login"].Value.ToString();
            int excluirId = Convert.ToInt32(dataGrid.CurrentRow.Cells["Id"].Value.ToString());

            if (excluir == "admin" || excluirId == formLogin.idUsuarioLogado)
            {
                MessageBox.Show("Erro: não é possível excluir este usuário.");
                return;
            }

            string mensagem, titulo;
            MessageBoxButtons botoes;
            DialogResult resposta;

            mensagem = "Confirma a exclusão deste usuário?";
            titulo = "Atenção";
            botoes = MessageBoxButtons.YesNo;

            resposta = MessageBox.Show(mensagem, titulo, botoes);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt16(dataGrid.CurrentRow.Cells["Id"].Value.ToString());
                    usuarioDao.Excluir(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                carregaUsuarios();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            gbCad.Visible = false;
        }
    }
}

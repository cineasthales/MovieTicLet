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
    public partial class formCadFilmes : Form
    {
        // indica o caminho do cartaz do filme
        private static string PATH = @"C:\arquivos\cartazes\cartazes";

        private FilmesDAO filmeDao { get; set; }

        public formCadFilmes()
        {
            InitializeComponent();
            filmeDao = new FilmesDAO();
        }

        private void formCadFilmes_Activated(object sender, EventArgs e)
        {
            configuraGrid();
            carregaFilmes();
        }

        private void configuraGrid()
        {
            // limpa a grid
            dataGrid.Columns.Clear();

            // adiciona as colunas a serem exibidas (conteúdo, título da coluna)
            dataGrid.Columns.Add("Id", "Id");
            dataGrid.Columns.Add("TituloOriginal", "Título Original");
            dataGrid.Columns.Add("TituloNacional", "Título Nacional");
            dataGrid.Columns.Add("Genero", "Gênero");
            dataGrid.Columns.Add("Duracao", "Duração (min)");
            dataGrid.Columns.Add("Classificacao", "Classificação");
            dataGrid.Columns.Add("Sinopse", "Sinopse");            

            // alinhamento das colunas
            dataGrid.Columns["TituloOriginal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["TituloNacional"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["Genero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["Duracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["Classificacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["Sinopse"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // largura das colunas (o default é 100)
            dataGrid.Columns["Id"].Width = 30;
            dataGrid.Columns["TituloOriginal"].Width = 200;
            dataGrid.Columns["TituloNacional"].Width = 200;
            dataGrid.Columns["Genero"].Width = 100;
            dataGrid.Columns["Duracao"].Width = 100;
            dataGrid.Columns["Classificacao"].Width = 80;
            dataGrid.Columns["Sinopse"].Width = 300;
        }
        
        private void carregaFilmes()
        {
            // obtém os dados 
            IEnumerable<Filmes> lista = filmeDao.Listar();

            // limpa as linhas da grid
            dataGrid.Rows.Clear();

            // preenche as colunas
            foreach (Filmes f in lista)
            {
                dataGrid.Rows.Add(f.Id, f.TituloOriginal, f.TituloNacional, f.Genero, f.Duracao,f.Classificacao, f.Sinopse);
            }
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            gbCad.Visible = true;
            gbCad.Text = "Inclusão de Filme";

            limpaCampos();

            txtTituloOriginal.Focus();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (!validaCampos())
            {
                MessageBox.Show("Preencha todos os dados.");
                txtTituloOriginal.Focus();
                return;
            }

            Filmes filme = new Filmes();
            filme.TituloOriginal = txtTituloOriginal.Text;
            filme.TituloNacional = txtTituloNacional.Text;
            filme.Sinopse = txtSinopse.Text;
            filme.Genero = cbGenero.Text;
            filme.Classificacao = Convert.ToInt32(cbClassificacao.Text);
            
            try
            {
                filme.Duracao = Convert.ToInt32(txtDuracao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: duração inválida.");
                return;
            }

            if (filme.Duracao <= 0)
            {
                MessageBox.Show("Erro: duração inválida.");
                return;
            }

            if (gbCad.Text == "Inclusão de Filme")
            {
                filmeDao.Incluir(filme);
                File.Copy(openFile.FileName, PATH + Convert.ToString(filme.Id) + ".jpg", true);
                MessageBox.Show("Filme cadastrado com sucesso.");
            }
            else
            {
                filme.Id = Convert.ToInt16(dataGrid.CurrentRow.Cells["Id"].Value.ToString());
                filmeDao.Alterar(filme);
                
                // se alterou o cartaz, irá sobrepor o arquivo com a nova foto
                //if (openFile.FileName != "")
                //{
                    File.Copy(openFile.FileName, PATH + Convert.ToString(filme.Id) + ".jpg", true);
                //}
                MessageBox.Show("Filme alterado com sucesso.");
            }

            // atualiza a grid                
            carregaFilmes();

            gbCad.Visible = false;
        }

        private Boolean validaCampos()
        {
            bool valido = true;

            if (txtTituloNacional.Text == "" ||                
                txtTituloOriginal.Text == "" ||
                txtDuracao.Text == "" ||
                txtSinopse.Text == "" ||
                cbGenero.SelectedIndex == -1 ||
                cbClassificacao.SelectedIndex == -1 ||
                pbCartaz.Image == null)
            {
                valido = false;
            }
            return valido;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCartaz_Click(object sender, EventArgs e)
        {
            try
            {
                openFile.ShowDialog();
                if (openFile.FileName != "")
                {
                    pbCartaz.Load(openFile.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Erro: selecione uma imagem.");
            }
        }

        private void limpaCampos()
        {
            txtTituloOriginal.Clear();
            txtTituloNacional.Clear();
            txtDuracao.Clear();
            txtSinopse.Clear();
            cbGenero.SelectedIndex = -1;
            cbClassificacao.SelectedIndex = -1;
            pbCartaz.Image = null;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            gbCad.Visible = true;
            gbCad.Text = "Alteração de Filmes";
            txtTituloOriginal.Focus();

            txtTituloOriginal.Text = dataGrid.CurrentRow.Cells["TituloOriginal"].Value.ToString();
            txtTituloNacional.Text = dataGrid.CurrentRow.Cells["TituloNacional"].Value.ToString();
            txtDuracao.Text = dataGrid.CurrentRow.Cells["Duracao"].Value.ToString();
            txtSinopse.Text = dataGrid.CurrentRow.Cells["Sinopse"].Value.ToString();
            cbGenero.SelectedIndex = cbGenero.FindString(dataGrid.CurrentRow.Cells["Genero"].Value.ToString());
            cbClassificacao.SelectedIndex = cbClassificacao.FindString(dataGrid.CurrentRow.Cells["Classificacao"].Value.ToString());
            pbCartaz.Image = null;
            // pbCartaz.Load(PATH + dataGrid.CurrentRow.Cells["Id"].Value.ToString() + ".jpg");
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string mensagem, titulo;
            MessageBoxButtons botoes;
            DialogResult resposta;

            mensagem = "Tem certeza que deseja excluir este filme?";
            titulo = "Atenção";
            botoes = MessageBoxButtons.YesNo;

            resposta = MessageBox.Show(mensagem, titulo, botoes);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt16(dataGrid.CurrentRow.Cells["Id"].Value.ToString());
                    filmeDao.Excluir(id);
                    File.Delete(PATH + id + ".jpg");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                carregaFilmes();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            gbCad.Visible = false;
        }
    }
}

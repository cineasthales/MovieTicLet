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
    public partial class formPesqFilmes : Form
    {
        // indica o caminho do cartaz do filme
        private static string PATH = @"C:\arquivos\cartazes\cartazes";

        private FilmesDAO filmeDao { get; set; }

        public formPesqFilmes()
        {
            InitializeComponent();
            filmeDao = new FilmesDAO();
        }

        private void formPesqFilmes_Activated(object sender, EventArgs e)
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
            dataGrid.Columns.Add("Duracao", "Duração");
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
            dataGrid.Columns["Classificacao"].Width = 100;
            dataGrid.Columns["Sinopse"].Width = 200;
        }
        
        private void carregaFilmes(int genero=12, string tituloNac="")
        {
            IEnumerable<Filmes> lista = filmeDao.Listar();

            switch (genero)
            {
                case -1:
                    MessageBox.Show("Selecione um filtro de gênero.");
                    return;
                case 0:
                    lista = filmeDao.Listar().Where(f => f.Genero == "Ação").ToList();
                    break;
                case 1:
                    lista = filmeDao.Listar().Where(f => f.Genero == "Animação").ToList();
                    break;
                case 2:
                    lista = filmeDao.Listar().Where(f => f.Genero == "Aventura").ToList();
                    break;
                case 3:
                    lista = filmeDao.Listar().Where(f => f.Genero == "Comédia").ToList();
                    break;
                case 4:
                    lista = filmeDao.Listar().Where(f => f.Genero == "Documentário").ToList();
                    break;
                case 5:
                    lista = filmeDao.Listar().Where(f => f.Genero == "Drama").ToList();
                    break;
                case 6:
                    lista = filmeDao.Listar().Where(f => f.Genero == "Fantasia").ToList();
                    break;
                case 7:
                    lista = filmeDao.Listar().Where(f => f.Genero == "Ficção Científica").ToList();
                    break;
                case 8:
                    lista = filmeDao.Listar().Where(f => f.Genero == "Musical").ToList();
                    break;
                case 9:
                    lista = filmeDao.Listar().Where(f => f.Genero == "Romance").ToList();
                    break;
                case 10:
                    lista = filmeDao.Listar().Where(f => f.Genero == "Suspense").ToList();
                    break;
                case 11:
                    lista = filmeDao.Listar().Where(f => f.Genero == "Terror").ToList();
                    break;
            }

            if (tituloNac != "")
            {
                lista = filmeDao.Listar().Where(f => f.TituloNacional.ToUpper().Contains(tituloNac.ToUpper())).ToList();
            }

            // limpa as linhas da grid
            dataGrid.Rows.Clear();

            // preenche as colunas
            foreach (Filmes f in lista)
            {
                dataGrid.Rows.Add(f.Id, f.TituloOriginal, f.TituloNacional, f.Genero, f.Duracao, f.Classificacao, f.Sinopse);
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

        private void btOk_Click(object sender, EventArgs e)
        {
            gbCad.Visible = false;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btDetalhes_Click(object sender, EventArgs e)
        {
            gbCad.Visible = true;
            gbCad.Text = "Detalhes do Filme";
            limpaCampos();

            int idFilme = Convert.ToInt16(dataGrid.CurrentRow.Cells["Id"].Value.ToString());

            Filmes filme = new Filmes();
            filme = filmeDao.Listar().Where(f => f.Id == idFilme).First();

            txtTituloOriginal.Text = dataGrid.CurrentRow.Cells["TituloOriginal"].Value.ToString();
            txtTituloNacional.Text = dataGrid.CurrentRow.Cells["TituloNacional"].Value.ToString();
            txtDuracao.Text = dataGrid.CurrentRow.Cells["Duracao"].Value.ToString();
            txtSinopse.Text = dataGrid.CurrentRow.Cells["Sinopse"].Value.ToString();
            cbGenero.SelectedIndex = cbGenero.FindString(dataGrid.CurrentRow.Cells["Genero"].Value.ToString());
            cbClassificacao.SelectedIndex = cbClassificacao.FindString(dataGrid.CurrentRow.Cells["Classificacao"].Value.ToString());
            pbCartaz.Load(PATH + dataGrid.CurrentRow.Cells["Id"].Value.ToString() + ".jpg");

            // desabilita os campos 
            txtTituloOriginal.ReadOnly = true;
            txtTituloNacional.ReadOnly = true;
            txtDuracao.ReadOnly = true;
            txtSinopse.ReadOnly = true;
            cbGenero.Enabled = false;
            cbClassificacao.Enabled = false;

            btOk.Focus();
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            carregaFilmes(cbFiltroGenero.SelectedIndex, txtFiltroTituloNac.Text);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtFiltroTituloNac.Clear();
            cbFiltroGenero.SelectedIndex = 12;
            carregaFilmes();
        }

        private void btOk_Click_1(object sender, EventArgs e)
        {
            gbCad.Visible = false;
        }
    }
}

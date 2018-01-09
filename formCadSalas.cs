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
    public partial class formCadSalas : Form
    {
        // indica o caminho da imagem do mapa da sala
        private static string PATH = @"C:\arquivos\salas\salas";

        private SalasDAO salaDao { get; set; }

        public formCadSalas()
        {
            InitializeComponent();
            salaDao = new SalasDAO();
        }

        private void formCadSalas_Activated(object sender, EventArgs e)
        {
            configuraGrid();
            carregaSalas();
        }

        private void configuraGrid()
        {
            // limpa a grid
            dataGrid.Columns.Clear();

            // adiciona as colunas a serem exibidas (conteúdo, título da coluna)
            dataGrid.Columns.Add("Id", "Id");
            dataGrid.Columns.Add("Nome", "Nome");
            dataGrid.Columns.Add("Capacidade", "Capacidade");

            // alinhamento das colunas
            dataGrid.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["Capacidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            // largura das colunas (o default é 100)
            dataGrid.Columns["Id"].Width = 30;
            dataGrid.Columns["Nome"].Width = 100;
            dataGrid.Columns["Capacidade"].Width = 100;
        }
        
        private void carregaSalas()
        {
            // obtém os dados 
            IEnumerable<Salas> lista = salaDao.Listar();

            // limpa as linhas da grid
            dataGrid.Rows.Clear();

            // preenche as colunas
            foreach (Salas s in lista)
            {
                dataGrid.Rows.Add(s.Id, s.Nome, s.Capacidade);
            }
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            gbCad.Visible = true;
            gbCad.Text = "Inclusão de Sala";

            limpaCampos();

            txtNome.Focus();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (!validaCampos())
            {
                MessageBox.Show("Preencha todos os dados cadastrais");
                txtNome.Focus();
                return;
            }

            Salas sala = new Salas();
            sala.Nome = txtNome.Text;
            
            try {
                sala.Capacidade = Convert.ToInt32(txtCapacidade.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: capacidade inválida.");
                return;
            }
            if (sala.Capacidade <= 0)
            {
                MessageBox.Show("Erro: capacidade inválida.");
                return;
            }

            if (gbCad.Text == "Inclusão de Sala")
            {
                salaDao.Incluir(sala);
                File.Copy(openFile.FileName, PATH + Convert.ToString(sala.Id) + ".jpg", true);
                MessageBox.Show("Sala cadastrada com sucesso.");
            }
            else
            {
                sala.Id = Convert.ToInt16(dataGrid.CurrentRow.Cells["Id"].Value.ToString());
                salaDao.Alterar(sala);
                
                // se alterou a imagem do mapa da sala, irá sobrepor o arquivo com a nova imagem
                //if (openFile.FileName != "")
                //{
                    File.Copy(openFile.FileName, PATH + Convert.ToString(sala.Id) + ".jpg", true);
                //}
                MessageBox.Show("Sala alterada com sucesso.");
            }

            // atualiza a grid                
            carregaSalas();

            gbCad.Visible = false;
        }

        private Boolean validaCampos()
        {
            bool valido = true;

            if (txtCapacidade.Text == "" ||
                txtNome.Text == "" ||
                pbMapa.Image == null)
            {
                valido = false;
            }
            return valido;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btMapa_Click(object sender, EventArgs e)
        {
            try
            {
                openFile.ShowDialog();
                if (openFile.FileName != "")
                {
                    pbMapa.Load(openFile.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Erro: selecione uma imagem.");
            }
        }

        private void limpaCampos()
        {
            txtNome.Clear();
            txtCapacidade.Clear();
            pbMapa.Image = null;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            gbCad.Visible = true;
            gbCad.Text = "Alteração de Sala";
            txtNome.Focus();            

            txtNome.Text = dataGrid.CurrentRow.Cells["Nome"].Value.ToString();
            txtCapacidade.Text = dataGrid.CurrentRow.Cells["Capacidade"].Value.ToString();
            pbMapa.Image = null;
            //pbMapa.Load(PATH + dataGrid.CurrentRow.Cells["Id"].Value.ToString() + ".jpg");
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string mensagem, titulo;
            MessageBoxButtons botoes;
            DialogResult resposta;

            mensagem = "Tem certeza que quer excluir esta sala?";
            titulo = "Atenção";
            botoes = MessageBoxButtons.YesNo;

            resposta = MessageBox.Show(mensagem, titulo, botoes);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt16(dataGrid.CurrentRow.Cells["Id"].Value.ToString());
                    salaDao.Excluir(id);
                    File.Delete(PATH + id + ".jpg");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                carregaSalas();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            gbCad.Visible = false;
        }
    }
}

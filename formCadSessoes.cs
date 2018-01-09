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
    public partial class formCadSessoes : Form
    {
        private SessoesDAO sessaoDao { get; set; }
        private SalasDAO salaDao { get; set; }
        private FilmesDAO filmeDao { get; set; }

        public formCadSessoes()
        {
            InitializeComponent();
            sessaoDao = new SessoesDAO();
            salaDao = new SalasDAO();
            filmeDao = new FilmesDAO();
        }

        private void formCadSessoes_Activated(object sender, EventArgs e)
        {
            configuraGrid();
            carregaSessoes();
        }

        private void configuraGrid()
        {
            // limpa a grid
            dataGrid.Columns.Clear();

            // adiciona as colunas a serem exibidas (conteúdo, título da coluna)
            dataGrid.Columns.Add("Id", "Id");
            dataGrid.Columns.Add("Filmes.TituloNacional", "Filme");
            dataGrid.Columns.Add("Horario", "Horário");
            dataGrid.Columns.Add("Data", "Data");
            dataGrid.Columns.Add("Legendado", "Tipo");
            dataGrid.Columns.Add("TresD", "3D");            
            dataGrid.Columns.Add("Salas.Nome", "Sala");
            dataGrid.Columns.Add("QntOcupados", "Lugares Ocupados");

            // alinhamento das colunas
            dataGrid.Columns["Filmes.TituloNacional"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["Horario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["Legendado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["TresD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["Salas.Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["QntOcupados"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            // formatação da coluna data
            dataGrid.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // largura das colunas (o default é 100)
            dataGrid.Columns["Filmes.TituloNacional"].Width = 200;
            dataGrid.Columns["Horario"].Width = 100;
            dataGrid.Columns["Legendado"].Width = 100;
            dataGrid.Columns["TresD"].Width = 50;
            dataGrid.Columns["Salas.Nome"].Width = 100;
            dataGrid.Columns["QntOcupados"].Width = 150;
            dataGrid.Columns["Data"].Width = 150;
        }

        private void carregaSessoes()
        {
            // obtém os dados 
            IEnumerable<Sessoes> lista = sessaoDao.Listar();

            // limpa as linhas da grid
            dataGrid.Rows.Clear();

            // preenche as colunas
            foreach (Sessoes s in lista)
            {
                dataGrid.Rows.Add(s.Id, s.Filmes.TituloNacional, s.Horario, s.Data, s.Legendado ? "Legendado" : "Dublado", s.TresD ? "Sim" : "Não", s.Salas.Nome, s.QntOcupados);
            }
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            gbCad.Visible = true;
            gbCad.Text = "Inclusão de Sessão";

            limpaCampos();

            PreencheComboSalas();
            PreencheListaFilmes();

            listFilmes.Focus();
        }

        private void PreencheComboSalas()
        {
            cbSala.DataSource = salaDao.Listar();
            cbSala.DisplayMember = "Nome";
            cbSala.ValueMember = "Id";
            cbSala.SelectedIndex = -1;
        }

        private void PreencheListaFilmes()
        {
            listFilmes.DataSource = filmeDao.Listar();
            listFilmes.DisplayMember = "TituloNacional";
            listFilmes.ValueMember = "Id";
            listFilmes.SelectedIndex = -1;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (!validaCampos())
            {
                MessageBox.Show("Preencha todos os dados.");
                listFilmes.Focus();
                return;
            }

            Sessoes sessao = new Sessoes();
            sessao.Horario = txtHorario.Text;

            int hora = Convert.ToInt32(sessao.Horario.Substring(0, 2));
            if (hora < 0 || hora > 23)
            {
                MessageBox.Show("Erro: horário inválido.");
                return;
            }

            int min = Convert.ToInt32(sessao.Horario.Substring(3, 2));
            if (min < 0 || min > 59)
            {
                MessageBox.Show("Erro: horário inválido.");
                return;
            }

            String data = Convert.ToString(calendarioData.SelectionStart);
            sessao.Data = data.Substring(0, 10);
            sessao.Legendado = chkLegendado.Checked;
            sessao.TresD = chk3D.Checked;            
            // conforme o filme e sala selecionados
            sessao.Filmes = filmeDao.Listar().Where(f => f.Id == Convert.ToInt16(listFilmes.SelectedValue)).First();
            sessao.Salas = salaDao.Listar().Where(s => s.Id == Convert.ToInt16(cbSala.SelectedValue)).First();

            // preenche textoSessao que será mostrado na lista no cadastro de compras
            sessao.TextoSessao = sessao.Data + " - " + sessao.Horario + " - " + sessao.Filmes.TituloNacional;

            if (sessao.Legendado == true)
            {
                sessao.TextoSessao = sessao.TextoSessao + " - Legendado";
            } else
            {
                sessao.TextoSessao = sessao.TextoSessao + " - Dublado";
            }

            if (sessao.TresD == true)
            {
                sessao.TextoSessao = sessao.TextoSessao + " - 3D";
            }

            sessao.TextoSessao = sessao.TextoSessao + "- Sala " + sessao.Salas.Nome;

            if (gbCad.Text == "Inclusão de Sessão")
            {
                sessao.QntOcupados = 0;              
                sessaoDao.Incluir(sessao);
                MessageBox.Show("Sessão cadastrada com sucesso.");
            }
            else
            {
                sessao.Id = Convert.ToInt16(dataGrid.CurrentRow.Cells["Id"].Value.ToString());
                sessaoDao.Alterar(sessao);
                MessageBox.Show("Sessão alterada com sucesso.");
            }

            // atualiza a grid                
            carregaSessoes();
        }

        private Boolean validaCampos()
        {
            bool valido = true;

            if (listFilmes.SelectedIndex == -1 ||
                cbSala.SelectedIndex == -1 ||
                txtHorario.Text == "__:__"               
                )
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
            listFilmes.SelectedIndex = -1;
            cbSala.SelectedIndex = -1;
            txtHorario.Text = "";
            chk3D.Checked = false;
            chkLegendado.Checked = false;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            gbCad.Visible = true;
            gbCad.Text = "Alteração de Sessão";            

            PreencheComboSalas();
            PreencheListaFilmes();
            listFilmes.Focus();

            txtHorario.Text = dataGrid.CurrentRow.Cells["Horario"].Value.ToString();
            if (dataGrid.CurrentRow.Cells["Legendado"].Value.ToString() == "Legendado")
            {
                chkLegendado.Checked = true;
            }
            else
            {
                chkLegendado.Checked = false;
            }
            if (dataGrid.CurrentRow.Cells["TresD"].Value.ToString() == "Sim")
            {
                chk3D.Checked = true;
            }
            else
            {
                chk3D.Checked = false;
            }
            cbSala.SelectedIndex = cbSala.FindString(dataGrid.CurrentRow.Cells["Salas.Nome"].Value.ToString());
            listFilmes.SelectedIndex = listFilmes.FindString(dataGrid.CurrentRow.Cells["Filmes.TituloNacional"].Value.ToString());
            calendarioData.SelectionStart = Convert.ToDateTime(dataGrid.CurrentRow.Cells["Data"].Value.ToString());
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string mensagem, titulo;
            MessageBoxButtons botoes;
            DialogResult resposta;

            mensagem = "Tem certeza que quer excluir esta sessão?";
            titulo = "Atenção";
            botoes = MessageBoxButtons.YesNo;

            resposta = MessageBox.Show(mensagem, titulo, botoes);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt16(dataGrid.CurrentRow.Cells["Id"].Value.ToString());
                    sessaoDao.Excluir(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                carregaSessoes();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            gbCad.Visible = false;
        }

        private void gbCad_Enter(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class formMovCompras : Form
    {
        private ComprasDAO compraDao { get; set; }
        private UsuariosDAO usuarioDao { get; set; }
        private SessoesDAO sessaoDao { get; set; }
        
        private int q { get; set; }

        public formMovCompras()
        {
            InitializeComponent();
            compraDao = new ComprasDAO();
            usuarioDao = new UsuariosDAO();
            sessaoDao = new SessoesDAO();
        }

        private void formMovCompras_Activated(object sender, EventArgs e)
        {
            configuraGrid();
            carregaCompras();
        }

        private void configuraGrid()
        {
            // limpa a grid
            dataGrid.Columns.Clear();

            // adiciona as colunas a serem exibidas (conteúdo, título da coluna)
            dataGrid.Columns.Add("Id", "Id");
            dataGrid.Columns.Add("Sessoes.TextoSessao", "Resumo da Sessão");
            dataGrid.Columns.Add("PrecoUnitario", "Preço Unitário (R$)");
            dataGrid.Columns.Add("Qnt", "Quantidade");
            dataGrid.Columns.Add("PrecoTotal", "Preço Total (R$)");
            dataGrid.Columns.Add("Usuarios.Login", "Vendedor");
            
            // coluna sessao.id é apenas para auxiliar na localização para devolução
            dataGrid.Columns.Add("Sessoes.Id", "x");
            dataGrid.Columns["Sessoes.Id"].Visible = false;

            // alinhamento das colunas
            dataGrid.Columns["Sessoes.TextoSessao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["PrecoUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["Qnt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["PrecoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.Columns["Usuarios.Login"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            // largura das colunas (o default é 100)
            dataGrid.Columns["Sessoes.TextoSessao"].Width = 400;
            dataGrid.Columns["PrecoUnitario"].Width = 150;
            dataGrid.Columns["Qnt"].Width = 100;
            dataGrid.Columns["PrecoTotal"].Width = 150;
            dataGrid.Columns["Usuarios.Login"].Width = 200;
        }

        private void carregaCompras(int linha=0)
        {
            // obtém os dados 
            IEnumerable<Compras> lista = compraDao.Listar();

            // limpa as linhas da grid
            dataGrid.Rows.Clear();

            // preenche as colunas
            foreach (Compras c in lista)
            {
                dataGrid.Rows.Add(c.Id, c.Sessoes.TextoSessao, c.PrecoUnitario, c.Qnt, c.PrecoTotal, c.Usuarios.Login, c.Sessoes.Id);
            }
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            gbCad.Visible = true;
            gbCad.Text = "Nova Compra";

            limpaCampos();

            carregaListaSessoes();
            carregaComboUsuarios();

            listSessoes.Focus();
        }

        private void limpaCampos()
        {
            txtPreco.Clear();
            txtQnt.Clear();
        }

        private void carregaListaSessoes()
        {
            // instanciar novamente o objeto força o "refresh" com a alteração efetuada na tabela
            // sessaoDao = new SessoesDAO();

            listSessoes.DataSource = sessaoDao.Listar();
            listSessoes.DisplayMember = "TextoSessao";
            listSessoes.ValueMember = "Id";
            listSessoes.SelectedIndex = -1;
        }

        private void carregaComboUsuarios()
        {            
            cbUsuario.DataSource = usuarioDao.Listar();
            cbUsuario.DisplayMember = "Login";
            cbUsuario.ValueMember = "Id";
            cbUsuario.SelectedIndex = -1;
        }

        private void listSessoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(listSessoes.SelectedValue.ToString());
            //Sessoes sessao = sessaoDao.Listar().Where(s => s.Id == id).First();
        }

        public Boolean validaCampos()
        {
            bool valido = true;

            if (cbUsuario.SelectedIndex == -1 || listSessoes.SelectedIndex == -1
                || txtPreco.Text == "" || txtQnt.Text == "")
            {
                valido = false;
            }
            return valido;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (!validaCampos())
            {
                MessageBox.Show("Preencha todos os campos.");
                listSessoes.Focus();
                return;
            }

            Compras compra = new Compras();
            compra.Usuarios = usuarioDao.Listar().Where(u => u.Id == Convert.ToInt16(cbUsuario.SelectedValue)).First();
            compra.Sessoes = sessaoDao.Listar().Where(s => s.Id == Convert.ToInt16(listSessoes.SelectedValue)).First();         

            try
            {
                compra.PrecoUnitario = Convert.ToDouble(txtPreco.Text);
                compra.Qnt = Convert.ToInt32(txtQnt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: preço e/ou quantidade inválido(a).");
                return;
            }

            if (compra.Qnt <= 0 || compra.PrecoUnitario <= 0)
            {
                MessageBox.Show("Erro: preço e/ou quantidade inválido(a).");
                return;
            }

            compra.PrecoTotal = compra.PrecoUnitario * compra.Qnt;            

            if (gbCad.Text == "Nova Compra")
            {
                DialogResult resposta = MessageBox.Show("Total: R$ "+ compra.PrecoTotal+".\n\n Confirmar a compra?", "Confirmação da compra", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    if (compra.Sessoes.Salas.Capacidade < (compra.Sessoes.QntOcupados + compra.Qnt))
                    {
                        MessageBox.Show("Erro: quantidade a comprar supera capacidade da sala.");
                        return;
                    }
                    compraDao.Incluir(compra);
                    sessaoDao.AlterarQnt(compra);
                    MessageBox.Show("Compra realizada com sucesso.");
                    // atualiza a grid                
                    carregaCompras();
                    gbCad.Visible = false;
                } else {
                    MessageBox.Show("Compra cancelada.");
                }
            }
            else
            {
                compra.Id = Convert.ToInt16(dataGrid.CurrentRow.Cells["Id"].Value.ToString());

                int idNovaSessao = Convert.ToInt32(listSessoes.SelectedValue.ToString());
                int idAntigaSessao = Convert.ToInt32(dataGrid.CurrentRow.Cells["Sessoes.Id"].Value.ToString());
                // se o usuário trocar de sessão, exclui da antiga e adiciona na nova
                if (idAntigaSessao != idNovaSessao){
                    compra.Sessoes.Id = idNovaSessao;
                    if (compra.Sessoes.Salas.Capacidade < (compra.Sessoes.QntOcupados + compra.Qnt))
                    {
                        MessageBox.Show("Erro: quantidade a alterar supera capacidade da sala.");
                        gbCad.Visible = false;
                        return;
                    }
                    int qnt = Convert.ToInt16(dataGrid.CurrentRow.Cells["Qnt"].Value.ToString());
                    sessaoDao.AlterarQntExc(qnt, idAntigaSessao);
                    sessaoDao.AlterarQnt(compra);
                }
                else
                {
                    if (q != compra.Qnt)
                    {
                        int aux = compra.Qnt;
                        compra.Qnt = compra.Qnt - q;
                        if (compra.Sessoes.Salas.Capacidade < (compra.Sessoes.QntOcupados + compra.Qnt))
                        {
                            MessageBox.Show("Erro: quantidade a alterar supera capacidade da sala.");
                            gbCad.Visible = false;
                            return;
                        }
                        sessaoDao.AlterarQnt(compra);
                        compra.Qnt = aux;
                    }
                }                              
                compraDao.Alterar(compra);
                MessageBox.Show("Compra alterada com sucesso.");
                carregaCompras();
                gbCad.Visible = false;
            }            
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            gbCad.Visible = true;
            gbCad.Text = "Alteração de Compra";            

            carregaListaSessoes();
            carregaComboUsuarios();
            listSessoes.Focus();

            txtPreco.Text = dataGrid.CurrentRow.Cells["PrecoUnitario"].Value.ToString();
            txtQnt.Text = dataGrid.CurrentRow.Cells["Qnt"].Value.ToString();
            q = Convert.ToInt32(txtQnt.Text);
            listSessoes.SelectedIndex = listSessoes.FindString(dataGrid.CurrentRow.Cells["Sessoes.TextoSessao"].Value.ToString());
            cbUsuario.SelectedIndex = cbUsuario.FindString(dataGrid.CurrentRow.Cells["Usuarios.Login"].Value.ToString());
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            gbCad.Visible = false;
        }

        private void btExcluir_Click_1(object sender, EventArgs e)
        {          
            string mensagem, titulo;
            MessageBoxButtons botoes;
            DialogResult resposta;

            mensagem = "Tem certeza que deseja excluir esta compra?";
            titulo = "Atenção";
            botoes = MessageBoxButtons.YesNo;

            resposta = MessageBox.Show(mensagem, titulo, botoes);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    int idSessao = Convert.ToInt16(dataGrid.CurrentRow.Cells["Sessoes.Id"].Value.ToString());
                    int qnt = Convert.ToInt16(dataGrid.CurrentRow.Cells["Qnt"].Value.ToString());
                    int idCompra = Convert.ToInt16(dataGrid.CurrentRow.Cells["Id"].Value.ToString());
                    sessaoDao.AlterarQntExc(qnt, idSessao);
                    compraDao.Excluir(idCompra);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                carregaCompras();
            }
        }
    }
}

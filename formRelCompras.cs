using trabFinal.Classes;
using trabFinal.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabFinal
{
    public partial class formRelCompras : Form
    {
        private ModelDB db { get; set; }

        public formRelCompras()
        {
            InitializeComponent();
            db = new ModelDB();
        }
        
        private void geraRelatorio()
        {
            // GroupBy: nome da propriedade (campo) a ser agrupado
            // Select: a informação a ser obtida. Pode ser count, sum, average
            // s.Key: deve ser a mesma coluna indicada em GroupBy
            // Num: nome da coluna (Num) e o que ela obtém (count, sum, average)
            // Total: nome da coluna (Total) e o que ela obtém (sum)
            //var lista = db.Locacoes.GroupBy(l => l.DataInicio).Select(s => new { DataInicio = s.Key, Num = s.Count(), Total = s.Sum(l => l.ValorPago) }).ToList();

            double precoInicial;
            double precoFinal;

            try
            {
                precoInicial = Convert.ToDouble(txtPrecoInicial.Text);
                precoFinal = Convert.ToDouble(txtPrecoFinal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: preço(s) inválido(s).");
                return;
            }

            if (precoInicial > precoFinal)
            {
                MessageBox.Show("Erro: preco inicial maior que preço final.");
                return;
            }

            var lista = db.Compras
                        .Where(c => c.PrecoTotal >= precoInicial && c.PrecoTotal <= precoFinal)
                        .GroupBy(g => g.Usuarios.Login)
                        .Select(s => new { Usuario = s.Key, Num = s.Count(), Total = s.Sum(p => p.PrecoTotal) }).ToList();

            StreamWriter wr = new StreamWriter(@"c:\arquivos\relatorioCompras.html");
            wr.WriteLine("<html>");
            wr.WriteLine("<head>");
            wr.WriteLine("<meta name='viewport' content='width=device-width, initial-scale=1'>");
            wr.WriteLine("<meta charset='utf-8'>");
            wr.WriteLine("<link rel='stylesheet' href='http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css'>");
            wr.WriteLine("<script src='https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js'></script>");
            wr.WriteLine("<script src='http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js'></script>");
            wr.WriteLine("<div class='container'>");
            wr.WriteLine("<h2>Relatório de Compras - Resumo por Vendedores</h2>");

            wr.WriteLine("<div class='table-responsive'>");
            wr.WriteLine("<table class='table table-hover'>");
            wr.WriteLine("<thead>");
            wr.WriteLine("<tr>");
            wr.WriteLine("<th>Vendedor</th>");
            wr.WriteLine("<th>Número de Vendas</th>");
            wr.WriteLine("<th>Total Vendido</th>");
            wr.WriteLine("</tr>");
            wr.WriteLine("</thead>");
            wr.WriteLine("</tbody>");
            foreach (var linha in lista)
            {
                wr.WriteLine("<tr><td>" + linha.Usuario + "</td>");
                wr.WriteLine("<td>" + linha.Num + "</td>");
                wr.WriteLine("<td> R$ " + linha.Total + "</td></tr>");
            }
            wr.WriteLine("</tbody>");
            wr.WriteLine("</table>");
            wr.WriteLine("</div>");
            wr.WriteLine("</div>");
            wr.WriteLine("</body>");
            wr.WriteLine("</html>");

            wr.Close();

            // Exemplo de carga do chrome
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", @"c:\arquivos\relatorioCompras.html");
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            geraRelatorio();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

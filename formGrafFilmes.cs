using trabFinal.Classes;
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
    public partial class formGrafFilmes : Form
    {

        private ModelDB db { get; set; }

        public formGrafFilmes()
        {
            InitializeComponent();
            db = new ModelDB();
        }

        private void formGrafFilmes_Activated(object sender, EventArgs e)
        {
            // GroupBy: nome da propriedade (campo) a ser agrupado
            // Select: a informação a ser obtida. Pode ser count, sum, average
            // s.Key: deve ser a mesma coluna indicada em GroupBy
            // Num: nome da coluna (Num) e o que ela obtém (count, sum, average)
            // var lista = db.Locacoes.GroupBy(l => l.Carro).Select(s => new { Carro = s.Key, Num = s.Count() }).ToList();
            var lista = db.Sessoes.GroupBy(c => c.Filmes).Select(f => new { Filme = f.Key, Num = f.Count() }).ToList();

            StreamWriter wr = new StreamWriter(@"c:\arquivos\graficoFilmes.html");
            wr.WriteLine("<html>");
            wr.WriteLine("<head>");
            wr.WriteLine("<meta charset='utf-8'>");
            wr.WriteLine("<script type='text/javascript' src='https://www.gstatic.com/charts/loader.js'></script>");
            wr.WriteLine("<script type='text/javascript'>");
            wr.WriteLine("google.charts.load('current', {packages:['corechart']});");
            wr.WriteLine("google.charts.setOnLoadCallback(drawChart);");
            wr.WriteLine("function drawChart() {");
            wr.WriteLine("var data = google.visualization.arrayToDataTable([");
            wr.WriteLine("['Filmes', 'Sessões']");

            foreach (var linha in lista)
            {
                wr.WriteLine(",['" + linha.Filme.TituloNacional + "', " + linha.Num + "]");
            }
            wr.WriteLine("]);");
            wr.WriteLine("var options = {");
            wr.WriteLine("title: 'Gráfico Filmes e Sessões',");
            wr.WriteLine("is3D: true};");

            wr.WriteLine("var chart = new google.visualization.PieChart(document.getElementById('piechart_3d'));");
            wr.WriteLine("chart.draw(data, options);");
            wr.WriteLine("}");
            wr.WriteLine("</script>");
            wr.WriteLine("</head>");
            wr.WriteLine("<body>");
            wr.WriteLine("<div id='piechart_3d' style='width: 900px; height: 480px;'></div>");
            wr.WriteLine("</body>");
            wr.WriteLine("</html>");

            wr.Close();

            webBrowserFilmes.Navigate(@"c:\arquivos\graficoFilmes.html");
        }
    }
}

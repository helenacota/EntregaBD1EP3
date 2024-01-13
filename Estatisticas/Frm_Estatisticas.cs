using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MisPeliculas.Arquitetura;
using Npgsql;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;

namespace MisPeliculas
{
    public partial class Frm_Estatisticas : Form
    {

        private PlotView plotView; // Adicione este campo

        public Frm_Estatisticas()
        {
            InitializeComponent();
        }

        private void Btn_graph_Art_Click(object sender, EventArgs e)
        {
            //Frm_graph_Art graphForm = new Frm_graph_Art();
            //graphForm.Show();

            InitializePVArt(); // Adicione esta chamada para inicializar o PlotView
            carregarPVArt();
        }

        private void carregarPVArt()
        {
            using (MisPeliculas.Arquitetura.DbConnection conn = new DbConnection())
            {
                try
                {
                    // Consulta SQL
                    string sSql = @"
                      SELECT
                          NomeArt AS Nome,
                          COUNT(*) AS TotalPremios
                      FROM
                          mispeliculas.ENominado
                      WHERE
                          Ganhou = TRUE
                      GROUP BY
                          NomeArt
                      ORDER BY
                          TotalPremios DESC
                      LIMIT 10";

                    DataTable dataTable = conn.getDataTable(sSql);

                    // *********


                    var model = new PlotModel { Title = "Atores Mais Premiados" };

                    List<BarItem> barItems = new List<BarItem>();
                    List<string> nomeados = new List<string>();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string nomeArt = row["Nome"].ToString();
                        double totalPremios = Convert.ToDouble(row["TotalPremios"]);

                        barItems.Add(new BarItem(totalPremios));

                        nomeados.Add(nomeArt);
                    }

                    var barSeries = new BarSeries
                    {
                        ItemsSource = barItems,
                        LabelPlacement = LabelPlacement.Inside,
                        LabelFormatString = "{0:.}"
                    };

                    model.Series.Add(barSeries);

                    model.Axes.Add(new CategoryAxis
                    {
                        Position = AxisPosition.Left,
                        Key = "Premiados",
                        ItemsSource = nomeados.ToArray()
                    });
                    plotView.Model = model;
                    // *******

                    // Cria um novo formulário para exibir o gráfico
                    Form graphForm = new Form();
                    graphForm.Controls.Add(plotView);
                    graphForm.Size = new System.Drawing.Size(600, 400);
                    graphForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    string erro = ex.Message;
                    MessageBox.Show("Erro ao consultar e exibir gráfico: \n" + erro);
                }
            }
        }

        private void InitializePVArt()
        {
            plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
        }

        private void Btn_graph_Film_Click(object sender, EventArgs e)
        {
            //Frm_graph_Film graphForm = new Frm_graph_Film();
            //graphForm.Show();

            InitializePVFilm(); // Adicione esta chamada para inicializar o PlotView
            carregarPVFilm();
        }

        private void carregarPVFilm()
        {
            using (MisPeliculas.Arquitetura.DbConnection conn = new DbConnection())
            {
                try
                {
                    // Consulta SQL
                    string sSql = @"
                      select a.TituloOriginal as nome, 
                         (count(b.idfilme)) as totalPremios
                        from mispeliculas.filmes a, mispeliculas.filmenominado b
                        where a.idfilme = b.idfilme
                        group by a.titulooriginal
                        order by totalPremios
                        limit 10";

                    DataTable dataTable = conn.getDataTable(sSql);

                    var model = new PlotModel { Title = "Filmes Mais Premiados" };

                    List<BarItem> barItems = new List<BarItem>();
                    List<string> nomeados = new List<string>();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string nomeArt = row["nome"].ToString();
                        double totalPremios = Convert.ToDouble(row["totalPremios"]);

                        barItems.Add(new BarItem(totalPremios));

                        nomeados.Add(nomeArt);
                    }

                    var barSeries = new BarSeries
                    {
                        ItemsSource = barItems,
                        LabelPlacement = LabelPlacement.Inside,
                        LabelFormatString = "{0:.}"
                    };

                    model.Series.Add(barSeries);

                    model.Axes.Add(new CategoryAxis
                    {
                        Position = AxisPosition.Left,
                        Key = "Premiados",
                        ItemsSource = nomeados.ToArray()
                    });
                    plotView.Model = model;
                    // *******

                    // Cria um novo formulário para exibir o gráfico
                    Form graphForm = new Form();
                    graphForm.Controls.Add(plotView);
                    graphForm.Size = new System.Drawing.Size(600, 400);
                    graphForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    string erro = ex.Message;
                    MessageBox.Show("Erro ao consultar e exibir gráfico: \n" + erro);
                }
            }
        }

        private void InitializePVFilm()
        {
            plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
        }

        private void Btn_graph_Film_Arrecada_Click(object sender, EventArgs e)
        {
            //Frm_graph_Film_Arrecada graphForm = new Frm_graph_Film_Arrecada();
            //graphForm.Show();

            InitializePVArrecada();
            CarregaPVArrecada();
        }

        private void CarregaPVArrecada()
        {
            using (MisPeliculas.Arquitetura.DbConnection conn = new DbConnection())
            {
                try
                {
                    // Consulta SQL
                    string sSql = @"SELECT
                            TituloOriginal AS Nome,
                            ArrecadaoPrimAno AS Arrecadacao
                        FROM
                            mispeliculas.Filmes
                        ORDER BY
                            Arrecadacao DESC
                        LIMIT 10";

                    DataTable dataTable = conn.getDataTable(sSql);

                    var model = new PlotModel { Title = "Filmes Que Mais Arrecadaram" };

                    List<BarItem> barItems = new List<BarItem>();
                    List<string> nomeados = new List<string>();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string nomeArt = row["Nome"].ToString();
                        double totalPremios = Convert.ToDouble(row["Arrecadacao"]);

                        barItems.Add(new BarItem(totalPremios));

                        nomeados.Add(nomeArt);
                    }

                    var barSeries = new BarSeries
                    {
                        ItemsSource = barItems,
                        LabelPlacement = LabelPlacement.Inside,
                        LabelFormatString = "{0:.}"
                    };

                    model.Series.Add(barSeries);

                    model.Axes.Add(new CategoryAxis
                    {
                        Position = AxisPosition.Left,
                        Key = "Filmes",
                        ItemsSource = nomeados.ToArray()
                    });
                    plotView.Model = model;
                    // *******

                    // Cria um novo formulário para exibir o gráfico
                    Form graphForm = new Form();
                    graphForm.Controls.Add(plotView);
                    graphForm.Size = new System.Drawing.Size(600, 400);
                    graphForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    string erro = ex.Message;
                    MessageBox.Show("Erro ao consultar e exibir gráfico: \n" + erro);
                }
            }
        }

        private void InitializePVArrecada()
        {
            plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
        }


    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MisPeliculas.Arquitetura;
using Npgsql;

namespace MisPeliculas.Cadastro.TelaIndividual
{
    public partial class Frm_Filme : Form
    {
        private Form? currentChildForm;

        public Frm_Filme()
        {
            InitializeComponent();
            CarregaTodosFilmes();
        }

        private void CarregaTodosFilmes()
        {
            // Conexão para popular o DataGridView
            DbConnection dbConnection = new DbConnection();

            string sSQL = $"{dbConnection.search_path} SELECT * FROM Filmes";


            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(sSQL, dbConnection.Connection);


            DataSet dataset = new DataSet();


            adaptador.Fill(dataset, "Filmes");


            Dt_TodosFilmes.DataSource = dataset.Tables["Filmes"];

            // Renomear as colunas do DataGridView
            Dt_TodosFilmes.Columns["IdFilme"].HeaderText = "ID";
            Dt_TodosFilmes.Columns["ArrecadaoPrimAno"].HeaderText = "Arrecadação no Primeiro Ano";
            Dt_TodosFilmes.Columns["IdiomaOrig"].HeaderText = "Idioma Original";
            Dt_TodosFilmes.Columns["Classe"].HeaderText = "Classe";
            Dt_TodosFilmes.Columns["AnoProducao"].HeaderText = "Ano de Produção";
            Dt_TodosFilmes.Columns["TituloOriginal"].HeaderText = "Título Original";
            Dt_TodosFilmes.Columns["DataEstreia"].HeaderText = "Data de Estreia";
            Dt_TodosFilmes.Columns["TituloBrasil"].HeaderText = "Título no Brasil";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MisPeliculas.Arquitetura.DbConnection conn = new DbConnection())
            {
                try
                {
                    string sSql = "INSERT INTO MISPELICULAS.FILMES (IDFILME, ARRECADAOPRIMANO, IDIOMAORIG, CLASSE, ANOPRODUCAO, TITULOORIGINAL, DATAESTREIA, TITULOBRASIL)";
                    sSql += "VALUEs (" + this.txtIDFilme.Text + ", " + this.txtArrec1ano.Text + ", '" + this.txtIdiOrig.Text + "', '" + this.txtClasse.Text + "', " + this.txtAnoProd.Text + ", '" + this.txtTitOrig.Text + "', '" + this.txtDataEst.Text + "', '" + this.txtTitBr.Text + "')";
                    conn.execCommand(sSql);

                    sSql = "INSERT INTO MISPELICULAS.LOCALESTREIA (LOCALIZACAO, IDFILME)";
                    sSql += "VALUEs ('" + this.txtLocEstr.Text + "', " + this.txtIDFilme.Text + ")";
                    conn.execCommand(sSql);

                    if (this.txtClasse.Text == "Outros")
                    {
                        sSql = "INSERT INTO MISPELICULAS.OUTROS (IDFILME)";
                        sSql += "VALUEs (" + this.txtIDFilme.Text + ")";
                        conn.execCommand(sSql);
                    }
                    else
                    {
                        sSql = "INSERT INTO MISPELICULAS.DOCUMENTARIOS (IDFILME)";
                        sSql += "VALUEs (" + this.txtIDFilme.Text + ")";
                        conn.execCommand(sSql);
                    }

                    MessageBox.Show("Salvo com sucesso!");
                    CarregaTodosFilmes();

                }
                catch (Exception ex)
                {
                    String err = ex.Message;
                    MessageBox.Show("Erro ao salvar informações! Verifique se foram escritas corretamente\n" + err);
                }
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnNovaFun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Criando nova Função");
            Frm_Funcao novoForm = new Frm_Funcao();
            novoForm.Show();


        }


    }
}

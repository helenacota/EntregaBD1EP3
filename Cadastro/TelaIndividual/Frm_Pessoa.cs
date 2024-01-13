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
    public partial class Frm_Pessoa : Form
    {
        //private Form? currentChildForm;

        public Frm_Pessoa()
        {
            InitializeComponent();
            CarregaPessoas();
        }

        private void CarregaPessoas()
        {
            // Conexão para popular o DataGridView
            DbConnection dbConnection = new DbConnection();

            string sSQL = $"{dbConnection.search_path} SELECT * FROM Pessoa";


            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(sSQL, dbConnection.Connection);


            DataSet dataset = new DataSet();


            adaptador.Fill(dataset, "Pessoa");


            Dt_Pessoas.DataSource = dataset.Tables["Pessoa"];

            // Renomear as colunas do DataGridView
            Dt_Pessoas.Columns["NomeArt"].HeaderText = "Nome do Artista";
            Dt_Pessoas.Columns["NomeVerdadeiro"].HeaderText = "Nome Verdadeiro";
            Dt_Pessoas.Columns["Sexo"].HeaderText = "Sexo";
            Dt_Pessoas.Columns["AnoNasc"].HeaderText = "Ano de Nascimento";
            Dt_Pessoas.Columns["Site"].HeaderText = "Site";
            Dt_Pessoas.Columns["AnoInic"].HeaderText = "Ano de Início";
            Dt_Pessoas.Columns["Situacao"].HeaderText = "Situação";
            Dt_Pessoas.Columns["NroTotalAnos"].HeaderText = "Anos Trabalhando";

            dbConnection.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (MisPeliculas.Arquitetura.DbConnection conn = new DbConnection())
            {
                try
                {
                    string sSql = "INSERT INTO MISPELICULAS.PESSOA (NOMEART, NOMEVERDADEIRO, SEXO, ANONASC, SITE, ANOINIC, SITUACAO, NROTOTALANOS)";
                    sSql += "VALUEs ('" + this.txtNomeArt.Text + "', '" + this.txtNomeVer.Text + "', '" + this.txtSexo.Text + "', '" + this.txtAnoNasc.Text + "', '" + this.txtSite.Text + "', '" + this.txtAnoIni.Text + "', '" + this.txtSituacao.Text + "', '" + this.txtTotalAnos.Text + "')";
                    conn.execCommand(sSql);

                    MessageBox.Show("Salvo com sucesso!");
                    CarregaPessoas();

                }
                catch (Exception ex)
                {
                    String erro = ex.Message;
                    MessageBox.Show("Erro ao salvar informações! Verifique se foram escritas corretamente : \n" + erro);
                }
            }
        }
    }
}

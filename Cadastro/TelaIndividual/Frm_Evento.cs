using MisPeliculas.Arquitetura;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisPeliculas.Cadastro.TelaIndividual
{
    public partial class Frm_Evento : Form
    {

        public Frm_Evento()
        {
            InitializeComponent();
            CarregaDt();
        }

        public void CarregaDt()
        {
            // Conexão para popular o DataGridView
            DbConnection dbConnection = new DbConnection();

            string sSQL = $"{dbConnection.search_path} SELECT * FROM Eventos";


            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(sSQL, dbConnection.Connection);


            DataSet dataset = new DataSet();


            adaptador.Fill(dataset, "Eventos");


            Dt_Eventos.DataSource = dataset.Tables["Eventos"];

            // Renomear as colunas do DataGridView
            Dt_Eventos.Columns["Nome"].HeaderText = "Nome do Evento";
            Dt_Eventos.Columns["AnoInicio"].HeaderText = "Ano de Início";
            Dt_Eventos.Columns["Nacionalidade"].HeaderText = "Nacionalidade";
            Dt_Eventos.Columns["Tipo"].HeaderText = "Tipo";

            dbConnection.Dispose();
        }


        private void Btn_AddEdicao_Click(object sender, EventArgs e)
        {
            Frm_Edicao novoForm = new Frm_Edicao();
            novoForm.Show();
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            using (MisPeliculas.Arquitetura.DbConnection conn = new DbConnection())
            {
                try
                {
                    string sSql = $"{conn.search_path} INSERT INTO EVENTOS (Nome, AnoInicio, Nacionalidade, Tipo)";
                    sSql += "VALUEs ('" + this.Txt_Nome.Text + "', " + this.Txt_AnoIni.Text + ", '" + this.Txt_Nacionalidade.Text + "', '" + this.CmbBx_Tipo.Text + "')";
                    conn.execCommand(sSql);

                    MessageBox.Show("Salvo com sucesso!");
                    CarregaDt();
                }
                catch (Exception ex)
                {
                    string err = ex.Message;
                    MessageBox.Show("Erro ao salvar informações! Verifique se foram escritas corretamente" + err);
                }
            }
        }
    }
}
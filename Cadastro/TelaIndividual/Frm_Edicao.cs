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
    public partial class Frm_Edicao : Form
    {
        public Frm_Edicao()
        {
            InitializeComponent();
            CarregaTodosEventos();
            CarregaTodosPremios();
        }

        private void CarregaTodosEventos()
        {
            // Conexão para popular o DataGridView
            DbConnection dbConnection = new DbConnection();

            string sSQL = $"{dbConnection.search_path} SELECT Nome FROM Eventos";


            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(sSQL, dbConnection.Connection);


            DataSet dataset = new DataSet();


            adaptador.Fill(dataset, "Eventos");


            Dt_Eventos.DataSource = dataset.Tables["Eventos"];

            // Renomear as colunas do DataGridView
            Dt_Eventos.Columns["Nome"].HeaderText = "Nome do Evento";
        }

        private void CarregaTodosPremios()
        {
            // Conexão para popular o DataGridView
            DbConnection dbConnection = new DbConnection();

            string sSQL = $"{dbConnection.search_path} SELECT * FROM Edicao";


            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sSQL, dbConnection.Connection))
            {
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "Edicao");

                // Associar o conjunto de dados ao DataGridView
                Dt_Edicao.DataSource = dataset.Tables["Edicao"];
            }

            // Renomear as colunas do DataGridView
            Dt_Edicao.Columns["Ano"].HeaderText = "Ano da Edição";
            Dt_Edicao.Columns["DataEd"].HeaderText = "Data da Edição";
            Dt_Edicao.Columns["Localizacao"].HeaderText = "Localização";
            Dt_Edicao.Columns["NomeEvento"].HeaderText = "Nome do Evento";


            dbConnection.Dispose();
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            using (MisPeliculas.Arquitetura.DbConnection conn = new DbConnection())
            {
                try
                {
                    string sSql = $"{conn.search_path} INSERT INTO EDICAO (Ano, NomeEvento, DataEd, Localizacao)";
                    sSql += "VALUEs (" + Txt_AnoIni.Text + ", '" + Txt_Nome.Text + "', '" + Msk_Data.Text + "', '" + Txt_Local.Text + "')";
                    conn.execCommand(sSql);

                    MessageBox.Show("Salvo com sucesso!");
                    CarregaTodosPremios();

                }
                catch (Exception ex)
                {
                    string err = ex.Message;
                    MessageBox.Show("Erro ao salvar informações! Verifique se foram escritas corretamente" + err);
                }
            }
        }

        private void btnAdicionarJuri_Click(object sender, EventArgs e)
        {
            using (MisPeliculas.Arquitetura.DbConnection conn = new DbConnection())
            {
                try
                {
                    string sSql;

                    // adicionar verificacao se é nominado aqui
                    // Verifica se já existe um registro correspondente na tabela EJURI
                    sSql = "SELECT COUNT(*) FROM MISPELICULAS.ENOMINADO WHERE NOMEART = '" + this.Txt_NomeJuri.Text + "' AND ANOEDICAO = " + this.Txt_AnoIni.Text + " AND NOMEEVENTO = '" + this.Txt_Nome.Text + "'";
                    NpgsqlCommand cmdVerificarExistencia = new NpgsqlCommand(sSql, conn.Connection);

                    int registrosExistentes = Convert.ToInt32(cmdVerificarExistencia.ExecuteScalar());

                    if (registrosExistentes > 0)
                    {
                        MessageBox.Show("Essa pessoa já é NOMINADA nessa edição do evento.");
                    }
                    else
                    {
                        sSql = $"{conn.search_path} INSERT INTO EJURI (ANO, NOMEART, NOMEEVENTO)";
                        sSql += "VALUES (" + this.Txt_AnoIni.Text + ", '" + this.Txt_NomeJuri.Text + "', '" + this.Txt_Nome.Text + "')";
                        conn.execCommand(sSql);

                        MessageBox.Show("Juri registrado com sucesso!");
                        CarregaTodosPremios();
                    }
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

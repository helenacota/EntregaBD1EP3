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

namespace MisPeliculas.Informacoes
{
    public partial class Frm_MelhorAtorTodosEventos : Form
    {
        public Frm_MelhorAtorTodosEventos()
        {
            InitializeComponent();
            CarregaDt();
        }

        private void CarregaDt()
        {
            // Conexão para popular o DataGridView
            DbConnection dbConnection = new DbConnection();

            string sSQL = $"{dbConnection.search_path} SELECT DISTINCT P.NomeArt, P.NomeVerdadeiro FROM Pessoa P INNER JOIN ENominado N ON P.NomeArt = N.NomeArt INNER JOIN Premio Pr ON N.Tipo = Pr.Tipo AND N.AnoEdicao = Pr.AnoEdicao AND N.NomeEvento = Pr.NomeEvento WHERE Pr.Tipo IN('Melhor Ator Principal', 'Melhor Ator Elenco');";

            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(sSQL, dbConnection.Connection);


            DataSet dataset = new DataSet();


            adaptador.Fill(dataset, "Pessoas");


            Dt_AtoresAtrizesNominados.DataSource = dataset.Tables["Pessoas"];

            // Renomear as colunas do DataGridView
            Dt_AtoresAtrizesNominados.Columns["NomeArt"].HeaderText = "Nome do Artista";
            Dt_AtoresAtrizesNominados.Columns["NomeVerdadeiro"].HeaderText = "Nome Verdadeiro";
        }
    }
}

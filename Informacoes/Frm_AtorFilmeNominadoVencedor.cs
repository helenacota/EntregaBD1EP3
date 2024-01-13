using MisPeliculas.Arquitetura;
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
    public partial class Frm_AtorFilmeNominadoVencedor : Form
    {
        public Frm_AtorFilmeNominadoVencedor()
        {
            InitializeComponent();
            PreencherComboBoxEventos();
        }

        private void PreencherComboBoxEventos()
        {
            DbConnection dbConnection = new DbConnection();

            // Define a consulta SQL para obter os nomes dos eventos
            string consultaSql = $"{dbConnection.search_path} SELECT Nome FROM Eventos";

            try
            {
                // Obtém os dados do banco de dados usando a classe DbConnection
                DataTable tabelaEventos = dbConnection.getDataTable(consultaSql);

                // Preenche o ComboBox com os nomes dos eventos
                foreach (DataRow row in tabelaEventos.Rows)
                {
                    Cmb_Evento.Items.Add(row["Nome"].ToString());
                }



            }
            catch (Exception ex)
            {
                // Trate exceções conforme necessário
                MessageBox.Show("Erro ao recuperar os eventos: " + ex.Message);
            }

            dbConnection.Dispose();
        }


        private void Cmb_Evento_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();

            Cmb_Edicao.Enabled = true;

            // Limpa os itens atuais do ComboBox de edições
            Cmb_Edicao.Items.Clear();

            // Obtém o nome do evento selecionado no ComboBox de eventos
            string nomeEventoSelecionado = Cmb_Evento.SelectedItem as string;

            if (!string.IsNullOrEmpty(nomeEventoSelecionado))
            {
                // Define a consulta SQL para obter os anos das edições com base no nome do evento
                string consultaSqlEdicoes = $"{dbConnection.search_path} SELECT Ano FROM Edicao WHERE NomeEvento = '{nomeEventoSelecionado}'";

                try
                {
                    // Obtém os dados do banco de dados usando a classe DbConnection
                    DataTable tabelaEdicoes = dbConnection.getDataTable(consultaSqlEdicoes);

                    // Preenche o ComboBox de edições com os anos das edições
                    foreach (DataRow row in tabelaEdicoes.Rows)
                    {
                        Cmb_Edicao.Items.Add(row["Ano"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    // Trate exceções conforme necessário
                    MessageBox.Show("Erro ao recuperar os anos das edições: " + ex.Message);
                }
            }
        }

        private void Cmb_Edicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();

            Cmb_Premio.Enabled = true;

            Cmb_Premio.Items.Clear();

            string anoEdicaoSelecionada = Cmb_Edicao.SelectedItem as string;

            if (!string.IsNullOrEmpty(anoEdicaoSelecionada))
            {
                string nomeEventoSelecionado = Cmb_Evento.SelectedItem as string;

                string consultaSqlPremios = $"{dbConnection.search_path} SELECT Tipo FROM Premio WHERE AnoEdicao = {anoEdicaoSelecionada} AND NomeEvento = '{nomeEventoSelecionado}'";

                try
                {
                    DataTable tabelaPremios = dbConnection.getDataTable(consultaSqlPremios);


                    foreach (DataRow row in tabelaPremios.Rows)
                    {
                        Cmb_Premio.Items.Add(row["Tipo"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao recuperar os tipos de prêmios: " + ex.Message);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();

            // Verifica se os ComboBoxes não estão vazios
            if (string.IsNullOrEmpty(Cmb_Evento.Text) || string.IsNullOrEmpty(Cmb_Edicao.Text) || string.IsNullOrEmpty(Cmb_Premio.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtém os valores selecionados nos ComboBoxes
            string nomeEvento = Cmb_Evento.Text;
            string anoEdicao = Cmb_Edicao.Text;
            string tipoPremio = Cmb_Premio.Text;

            // Verifica se o tipo de prêmio é para pessoas
            if (tipoPremio == "Melhor Ator Principal" || tipoPremio == "Melhor Ator Elenco")
            {
                // Consulta para obter os dados das pessoas indicadas e vencedoras
                string consultaSqlPessoas = $@"{dbConnection.search_path} 
                    SELECT NomeArt, IdFilme, Ganhou
                    FROM ENominado
                    WHERE NomeEvento = '{nomeEvento}' AND AnoEdicao = {anoEdicao} AND Tipo = '{tipoPremio}'";

                // Obtém os dados do banco de dados usando a classe DbConnection
                DataTable tabelaPessoas = dbConnection.getDataTable(consultaSqlPessoas);

                // Preenche o DataGridView com os dados das pessoas indicadas e vencedoras
                Dt_AtoresAtrizesNominados.DataSource = tabelaPessoas;
            }
            else // Tipo de prêmio para filmes
            {
                // Consulta para obter os títulos dos filmes indicados e vencedores
                string consultaSqlFilmes = $@"{dbConnection.search_path} 
                    SELECT F.Titulo, FN.Premiado
                    FROM FilmeNominado FN
                    JOIN Filmes F ON FN.IdFilme = F.IdFilme
                    WHERE FN.NomeEvento = '{nomeEvento}' AND FN.AnoEdicao = {anoEdicao} AND FN.Tipo = '{tipoPremio}'";

                // Obtém os dados do banco de dados usando a classe DbConnection
                DataTable tabelaFilmes = dbConnection.getDataTable(consultaSqlFilmes);

                // Preenche o DataGridView com os dados dos filmes indicados e vencedores
                Dt_AtoresAtrizesNominados.DataSource = tabelaFilmes;
            }

            RenomearColunasDataGridView();
        }

        private void RenomearColunasDataGridView()
        {
            // Verifica se o DataGridView possui colunas
            if (Dt_AtoresAtrizesNominados.Columns.Count > 0)
            {
                // Renomeia as colunas conforme necessário
                foreach (DataGridViewColumn coluna in Dt_AtoresAtrizesNominados.Columns)
                {
                    switch (coluna.HeaderText)
                    {
                        case "nomeart":
                            coluna.HeaderText = "Nome do Artista";
                            break;
                        case "idfilme":
                            coluna.HeaderText = "ID do Filme";
                            break;
                        case "ganhou":
                            coluna.HeaderText = "Ganhou o Prêmio";
                            break;
                        case "titulo":
                            coluna.HeaderText = "Título do Filme";
                            break;
                        case "premiado":
                            coluna.HeaderText = "Filme Premiado";
                            break;

                    }
                }
            }

        }
    }
}
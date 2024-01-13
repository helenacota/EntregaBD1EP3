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

namespace MisPeliculas.Cadastro.TelaIndividual
{
    public partial class Frm_Premio : Form
    {
        public Frm_Premio()
        {
            InitializeComponent();
            PreencherComboBoxEventos();
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            using (MisPeliculas.Arquitetura.DbConnection conn = new DbConnection())
            {
                try
                {
                    string sSql = "INSERT INTO MISPELICULAS.PREMIO (TIPO, NOME, ANOEDICAO, NOMEEVENTO) ";
                    sSql += " VALUES ('" + this.txt_Tipo.Text + "', '" + this.Txt_NomePremio.Text + "', " + this.Txt_AnoEdicao.Text + ", '" + this.Txt_NomeEvento.Text + "')";
                    conn.execCommand(sSql);

                    MessageBox.Show("Premio Salvo com sucesso!");
                    PreencherComboBoxEventos();
                }
                catch (Exception ex)
                {
                    String erro = ex.Message;
                    MessageBox.Show("Erro ao salvar informações! Verifique se foram escritas corretamente : \n" + erro);
                }
            }

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            // Verifica se as strings nos ComboBox 'Cmb_Evento' e 'Cmb_Edicao' não são vazias
            if (string.IsNullOrEmpty(Cmb_Evento.Text) || string.IsNullOrEmpty(Cmb_Edicao.Text))
            {
                MessageBox.Show("Por favor, preencha os campos 'Evento' e 'Edição'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtém os valores selecionados nos ComboBoxes
            string nomeEvento = Cmb_Evento.Text;
            string anoEdicao = Cmb_Edicao.Text;

            // Consulta para obter todos os prêmios registrados para o evento e edição especificados
            string consultaSqlPremios = $@"{dbConnection.search_path} SELECT Tipo, Nome FROM Premio WHERE NomeEvento = '{nomeEvento}' AND AnoEdicao = {anoEdicao}";

            // Obtém os dados do banco de dados usando a classe DbConnection
            DataTable tabelaPremios = dbConnection.getDataTable(consultaSqlPremios);

            // Preenche o DataGridView com os prêmios obtidos
            Dt_Premios.DataSource = tabelaPremios;

            Dt_Premios.Columns["tipo"].HeaderText = "Tipo do Prêmio";
            Dt_Premios.Columns["nome"].HeaderText = "Nome do Prêmio Original";
        }
    }
}

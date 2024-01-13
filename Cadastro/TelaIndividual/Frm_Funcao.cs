using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MisPeliculas.Arquitetura;
using Npgsql;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MisPeliculas.Cadastro.TelaIndividual
{
    public partial class Frm_Funcao : Form
    {
        public Frm_Funcao()
        {
            InitializeComponent();
            CarregaTodosFilmes();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (MisPeliculas.Arquitetura.DbConnection conn = new DbConnection())
            {
                try
                {
                    string fun = txtFuncao.Text;

                    switch (fun)
                    {
                        case "Diretor":
                            {
                                string sSql = "INSERT INTO MISPELICULAS.DIRETOR (NOMEART) ";
                                sSql += "VALUEs ('" + this.txtNomeArt.Text + "') ON CONFLICT (NOMEART) DO UPDATE SET NOMEART = '" + this.txtNomeArt.Text + "'";
                                conn.execCommand(sSql);

                                sSql = "INSERT INTO MISPELICULAS.EDIRETOR (IDFILME, NOMEART, EPRINCIPAL) ";
                                sSql += "VALUEs (" + this.txtIDFilme.Text + ", '" + this.txtNomeArt.Text + "' , '" + this.txtEPrinc.Text + "')";
                                conn.execCommand(sSql);
                                break;
                            };
                        case "Produtor":
                            {
                                string sSql = "INSERT INTO MISPELICULAS.PRODUTOR (NOMEART) ";
                                sSql += "VALUEs ('" + this.txtNomeArt.Text + "') ON CONFLICT (NOMEART) DO UPDATE SET NOMEART = '" + this.txtNomeArt.Text + "'";
                                conn.execCommand(sSql);

                                sSql = "INSERT INTO MISPELICULAS.EPRODUTOR (IDFILME, NOMEART) ";
                                sSql += "VALUEs (" + this.txtIDFilme.Text + ", '" + this.txtNomeArt.Text + "')";
                                conn.execCommand(sSql);
                                break;
                            };
                        case "Roteirista":
                            {
                                string sSql = "INSERT INTO MISPELICULAS.ROTEIRISTA (NOMEART) ";
                                sSql += "VALUEs ('" + this.txtNomeArt.Text + "') ON CONFLICT (NOMEART) DO UPDATE SET NOMEART = '" + this.txtNomeArt.Text + "'";
                                conn.execCommand(sSql);

                                sSql = "INSERT INTO MISPELICULAS.EROTEIRISTA (IDFILME, NOMEART) ";
                                sSql += "VALUEs (" + this.txtIDFilme.Text + ", '" + this.txtNomeArt.Text + "')";
                                conn.execCommand(sSql);
                                break;
                            };
                        case "Ator Principal":
                            {
                                string sSql = "INSERT INTO MISPELICULAS.ATOR (NOMEART) ";
                                sSql += "VALUEs ('" + this.txtNomeArt.Text + "') ON CONFLICT (NOMEART) DO UPDATE SET NOMEART = '" + this.txtNomeArt.Text + "'";
                                conn.execCommand(sSql);

                                sSql = "INSERT INTO MISPELICULAS.ATORPRINC (IDFILME, NOMEART) ";
                                sSql += "VALUEs (" + this.txtIDFilme.Text + ", '" + this.txtNomeArt.Text + "')";
                                conn.execCommand(sSql);
                                break;
                            };
                        case "Ator Elenco":
                            {
                                string sSql = "INSERT INTO MISPELICULAS.ATOR (NOMEART) ";
                                sSql += "VALUEs ('" + this.txtNomeArt.Text + "') ON CONFLICT (NOMEART) DO UPDATE SET NOMEART = '" + this.txtNomeArt.Text + "'";
                                conn.execCommand(sSql);

                                sSql = "INSERT INTO MISPELICULAS.ATORELENCO (IDFILME, NOMEART) ";
                                sSql += "VALUEs ('" + this.txtIDFilme.Text + "' , '" + this.txtNomeArt.Text + "')";
                                conn.execCommand(sSql);
                                break;
                            };
                        default: MessageBox.Show("Erro ao salvar informações! Verifique se foram escritas corretamente"); break;
                    }

                    MessageBox.Show("Salvo com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar informações! Verifique se foram escritas corretamente\n" + ex.Message);
                }
            }
        }

        private void CarregaTodosFilmes()
        {
            // Conexão para popular o DataGridView
            DbConnection dbConnection = new DbConnection();

            string sSQL = $"{dbConnection.search_path} SELECT IdFilme,TituloOriginal FROM Filmes";


            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(sSQL, dbConnection.Connection);


            DataSet dataset = new DataSet();


            adaptador.Fill(dataset, "Filmes");


            Dt_TodosFilmes.DataSource = dataset.Tables["Filmes"];

            // Renomear as colunas do DataGridView
            Dt_TodosFilmes.Columns["IdFilme"].HeaderText = "ID";
            Dt_TodosFilmes.Columns["TituloOriginal"].HeaderText = "Titulo Original";
        }

        private void Icn_Pesquisa_Click(object sender, EventArgs e)
        {
            {
                // Obtém o ID do filme e a função selecionada
                int idFilme = Convert.ToInt32(Txt_IdFilmePesquisa.Text);
                string funcaoSelecionada = txtFuncaoPesquisa.Text;

                using (DbConnection dbConnection = new DbConnection())
                {
                    // Consulta SQL baseada na função selecionada
                    string consultaSql = "";
                    switch (funcaoSelecionada)
                    {
                        case "Diretor":
                            consultaSql = $"{dbConnection.search_path} SELECT NomeArt FROM EDiretor WHERE IdFilme = {idFilme}";
                            break;

                        case "Produtor":
                            consultaSql = $"{dbConnection.search_path} SELECT NomeArt FROM EProdutor WHERE IdFilme = {idFilme}";
                            break;

                        case "Roteirista":
                            consultaSql = $"{dbConnection.search_path} SELECT NomeArt FROM ERoteirista WHERE IdFilme = {idFilme}";
                            break;

                        case "Ator Principal":
                            consultaSql = $"{dbConnection.search_path} SELECT NomeArt FROM AtorPrinc WHERE IdFilme = {idFilme}";
                            break;

                        case "Ator Elenco":
                            consultaSql = $"{dbConnection.search_path} SELECT NomeArt FROM AtorElenco WHERE IdFilme = {idFilme}";
                            break;

                        default:
                            MessageBox.Show("Erro ao fazer a consulta! Verifique se foram escritas corretamente\n");
                            break;
                    }

                    if (!string.IsNullOrEmpty(consultaSql))
                    {
                        NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(consultaSql, dbConnection.Connection);


                        DataSet dataset = new DataSet();


                        adaptador.Fill(dataset, "funcaoSelecionada");


                        Dt_FuncoesFilmes.DataSource = dataset.Tables["funcaoSelecionada"];

                        // Renomear as colunas do DataGridView
                        Dt_FuncoesFilmes.Columns["NomeArt"].HeaderText = "Nome do Artista";
                    }
                }
            }
        }

        private void txtFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se a opção selecionada é "Diretor"
            if (txtFuncao.SelectedItem != null && txtFuncao.SelectedItem.ToString() == "Diretor")
            {
                // Torna o Label2 e txtEPrinc visíveis
                label2.Visible = true;
                txtEPrinc.Visible = true;
            }
            else
            {
                // Caso contrário, torna o Label2 e txtEPrinc invisíveis
                label2.Visible = false;
                txtEPrinc.Visible = false;
            }
        }
    }
}

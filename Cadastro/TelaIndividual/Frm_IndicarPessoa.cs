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
    public partial class Frm_IndicarPessoa : Form
    {
        public Frm_IndicarPessoa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (MisPeliculas.Arquitetura.DbConnection conn = new DbConnection())
            {
                try
                {
                    string sSql;

                    // Verifica se já existe um registro correspondente na tabela EJURI
                    sSql = "SELECT COUNT(*) FROM MISPELICULAS.EJURI WHERE NOMEART = '" + this.txtNomeArt.Text + "' AND ANO = " + this.txtAnoEdicao.Text + " AND NOMEEVENTO = '" + this.txt_NomeEvento.Text + "'";
                    NpgsqlCommand cmdVerificarExistencia = new NpgsqlCommand(sSql, conn.Connection);

                    int registrosExistentes = Convert.ToInt32(cmdVerificarExistencia.ExecuteScalar());

                    if (registrosExistentes > 0)
                    {
                        MessageBox.Show("Essa pessoa já é JURI nessa edição do evento.");
                    }
                    else
                    {
                        string ganhou = "false";
                        if (this.cmb_Ganhou.Text == "Sim")
                        {
                            sSql = "UPDATE MISPELICULAS.ENOMINADO SET GANHOU = 'false' WHERE TIPO = '" + this.txt_Tipo.Text + "' AND ANOEDICAO = " + this.txtAnoEdicao.Text + " AND NOMEEVENTO = '" + this.txt_NomeEvento.Text + "'";
                            conn.execCommand(sSql);
                            ganhou = "true";
                        }

                        sSql = "INSERT INTO MISPELICULAS.ENOMINADO (NOMEART, IDFILME, TIPO, ANOEDICAO, NOMEEVENTO, GANHOU)";
                        sSql += "VALUEs ('" + this.txtNomeArt.Text + "', '" + this.txt_IdFilme.Text + "', '" + this.txt_Tipo.Text + "', '" + this.txtAnoEdicao.Text + "', '" + this.txt_NomeEvento.Text + "', '" + ganhou + "')";
                        conn.execCommand(sSql);

                        MessageBox.Show("Salvo com sucesso!");
                    }


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

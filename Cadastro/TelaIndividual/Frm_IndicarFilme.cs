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
    public partial class Frm_IndicarFilme : Form
    {
        public Frm_IndicarFilme()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            using (MisPeliculas.Arquitetura.DbConnection conn = new DbConnection())
            {
                try
                {
                    string sSql;
                    string ganhou = "false";

                    if (this.cmb_Ganhou.Text == "Sim")
                    {
                        sSql = "UPDATE MISPELICULAS.FILMENOMINADO SET PREMIADO = 'false' WHERE TIPO = '" + this.txt_Tipo.Text + "' AND ANOEDICAO = " + this.txtAnoEdicao.Text + " AND NOMEEVENTO = '" + this.txt_NomeEvento.Text + "'";
                        conn.execCommand(sSql);
                        ganhou = "true";
                    }

                    sSql = "INSERT INTO MISPELICULAS.FILMENOMINADO (IDFILME, TIPO, ANOEDICAO, NOMEEVENTO, PREMIADO)";
                    sSql += "VALUEs ('" + this.txt_IdFilme.Text + "', '" + this.txt_Tipo.Text + "', '" + this.txtAnoEdicao.Text + "', '" + this.txt_NomeEvento.Text + "', '" + ganhou + "')";
                    conn.execCommand(sSql);

                    MessageBox.Show("Salvo com sucesso!");

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

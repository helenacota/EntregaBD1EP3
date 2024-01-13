using MisPeliculas.Cadastro.TelaIndividual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisPeliculas.Cadastro
{
    public partial class Frm_Cadastro : Form
    {
        private Form? currentChildForm;

        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Pnl_Show.Controls.Add(childForm);
            Pnl_Show.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Btn_Pessoa_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new Frm_Pessoa());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void Btn_Filme_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Filme());
        }

        private void Btn_Evento_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Evento());
        }

        private void Btn_Premio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Premio());
        }

        private void Btn_IndicarPessoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_IndicarPessoa());
        }

        private void Btn_IndicarFilme_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_IndicarFilme());
        }
    }
}

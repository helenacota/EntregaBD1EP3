using MisPeliculas.Cadastro;

namespace MisPeliculas
{
    public partial class Frm_Menu : Form
    {
        private Form currentChildForm;

        public Frm_Menu()
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
            Pnl_Exibicao.Controls.Add(childForm);
            Pnl_Exibicao.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Cadastro());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void Btn_Estatisticas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Estatisticas());
        }

        private void Btn_Informacoes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Info());
        }

        private void Pnl_Exibicao_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
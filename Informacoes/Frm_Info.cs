using MisPeliculas.Informacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisPeliculas
{
    public partial class Frm_Info : Form
    {
        public Frm_Info()
        {
            InitializeComponent();
        }

        private void Btn_AtorNominadoTodosEventos_Click(object sender, EventArgs e)
        {
            Frm_MelhorAtorTodosEventos novoForm = new Frm_MelhorAtorTodosEventos();
            novoForm.Show();
        }

        private void Btn_AtorFilmeNominadoVencedor_Click(object sender, EventArgs e)
        {
            Frm_AtorFilmeNominadoVencedor novoForm = new Frm_AtorFilmeNominadoVencedor();
            novoForm.Show();
        }
    }
}

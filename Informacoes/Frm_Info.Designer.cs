namespace MisPeliculas
{
    partial class Frm_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_AtorNominadoTodosEventos = new Button();
            Btn_AtorFilmeNominadoVencedor = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Btn_AtorNominadoTodosEventos
            // 
            Btn_AtorNominadoTodosEventos.BackColor = Color.FromArgb(255, 201, 14);
            Btn_AtorNominadoTodosEventos.Cursor = Cursors.Hand;
            Btn_AtorNominadoTodosEventos.FlatAppearance.BorderSize = 0;
            Btn_AtorNominadoTodosEventos.FlatStyle = FlatStyle.Flat;
            Btn_AtorNominadoTodosEventos.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Btn_AtorNominadoTodosEventos.Location = new Point(50, 272);
            Btn_AtorNominadoTodosEventos.Margin = new Padding(3, 4, 3, 4);
            Btn_AtorNominadoTodosEventos.Name = "Btn_AtorNominadoTodosEventos";
            Btn_AtorNominadoTodosEventos.Size = new Size(359, 96);
            Btn_AtorNominadoTodosEventos.TabIndex = 41;
            Btn_AtorNominadoTodosEventos.Text = "Atores Nominados Como Melhor Ator em Todos os Eventos Existentes";
            Btn_AtorNominadoTodosEventos.UseVisualStyleBackColor = false;
            Btn_AtorNominadoTodosEventos.Click += Btn_AtorNominadoTodosEventos_Click;
            // 
            // Btn_AtorFilmeNominadoVencedor
            // 
            Btn_AtorFilmeNominadoVencedor.BackColor = Color.FromArgb(255, 201, 14);
            Btn_AtorFilmeNominadoVencedor.Cursor = Cursors.Hand;
            Btn_AtorFilmeNominadoVencedor.FlatAppearance.BorderSize = 0;
            Btn_AtorFilmeNominadoVencedor.FlatStyle = FlatStyle.Flat;
            Btn_AtorFilmeNominadoVencedor.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Btn_AtorFilmeNominadoVencedor.Location = new Point(462, 272);
            Btn_AtorFilmeNominadoVencedor.Margin = new Padding(3, 4, 3, 4);
            Btn_AtorFilmeNominadoVencedor.Name = "Btn_AtorFilmeNominadoVencedor";
            Btn_AtorFilmeNominadoVencedor.Size = new Size(359, 96);
            Btn_AtorFilmeNominadoVencedor.TabIndex = 41;
            Btn_AtorFilmeNominadoVencedor.Text = "Atores/Filmes Nominados e Premiados (prêmio específico)";
            Btn_AtorFilmeNominadoVencedor.UseVisualStyleBackColor = false;
            Btn_AtorFilmeNominadoVencedor.Click += Btn_AtorFilmeNominadoVencedor_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(43, 43, 43);
            iconPictureBox1.ForeColor = Color.Gainsboro;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            iconPictureBox1.IconColor = Color.Gainsboro;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 240;
            iconPictureBox1.Location = new Point(97, 43);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(245, 240);
            iconPictureBox1.TabIndex = 42;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(43, 43, 43);
            iconPictureBox2.ForeColor = Color.Gainsboro;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            iconPictureBox2.IconColor = Color.Gainsboro;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 240;
            iconPictureBox2.Location = new Point(526, 43);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(245, 240);
            iconPictureBox2.TabIndex = 42;
            iconPictureBox2.TabStop = false;
            // 
            // Frm_Info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(875, 488);
            Controls.Add(Btn_AtorFilmeNominadoVencedor);
            Controls.Add(Btn_AtorNominadoTodosEventos);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Name = "Frm_Info";
            Text = "Frm_Info";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_AtorNominadoTodosEventos;
        private Button Btn_AtorFilmeNominadoVencedor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}
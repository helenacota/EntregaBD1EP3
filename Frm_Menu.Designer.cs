namespace MisPeliculas
{
    partial class Frm_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Btn_Informacoes = new FontAwesome.Sharp.IconButton();
            Btn_Estatisticas = new FontAwesome.Sharp.IconButton();
            Btn_Cadastro = new FontAwesome.Sharp.IconButton();
            Pnl_Exibicao = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Pnl_Exibicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 23, 23);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Btn_Informacoes);
            panel1.Controls.Add(Btn_Estatisticas);
            panel1.Controls.Add(Btn_Cadastro);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 70);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.pipocaLogo;
            pictureBox1.Location = new Point(32, 8);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Btn_Informacoes
            // 
            Btn_Informacoes.BackColor = Color.FromArgb(255, 201, 14);
            Btn_Informacoes.Cursor = Cursors.Hand;
            Btn_Informacoes.FlatAppearance.BorderColor = Color.FromArgb(43, 43, 43);
            Btn_Informacoes.FlatAppearance.BorderSize = 3;
            Btn_Informacoes.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            Btn_Informacoes.FlatStyle = FlatStyle.Flat;
            Btn_Informacoes.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Informacoes.IconChar = FontAwesome.Sharp.IconChar.None;
            Btn_Informacoes.IconColor = Color.Black;
            Btn_Informacoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Informacoes.Location = new Point(629, 16);
            Btn_Informacoes.Margin = new Padding(3, 2, 3, 2);
            Btn_Informacoes.Name = "Btn_Informacoes";
            Btn_Informacoes.Size = new Size(200, 41);
            Btn_Informacoes.TabIndex = 2;
            Btn_Informacoes.Text = "Informações";
            Btn_Informacoes.UseVisualStyleBackColor = false;
            Btn_Informacoes.Click += Btn_Informacoes_Click;
            // 
            // Btn_Estatisticas
            // 
            Btn_Estatisticas.BackColor = Color.FromArgb(255, 201, 14);
            Btn_Estatisticas.Cursor = Cursors.Hand;
            Btn_Estatisticas.FlatAppearance.BorderColor = Color.FromArgb(43, 43, 43);
            Btn_Estatisticas.FlatAppearance.BorderSize = 3;
            Btn_Estatisticas.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            Btn_Estatisticas.FlatStyle = FlatStyle.Flat;
            Btn_Estatisticas.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Estatisticas.IconChar = FontAwesome.Sharp.IconChar.None;
            Btn_Estatisticas.IconColor = Color.Black;
            Btn_Estatisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Estatisticas.Location = new Point(396, 16);
            Btn_Estatisticas.Margin = new Padding(3, 2, 3, 2);
            Btn_Estatisticas.Name = "Btn_Estatisticas";
            Btn_Estatisticas.Size = new Size(200, 41);
            Btn_Estatisticas.TabIndex = 1;
            Btn_Estatisticas.Text = "Estatísticas";
            Btn_Estatisticas.UseVisualStyleBackColor = false;
            Btn_Estatisticas.Click += Btn_Estatisticas_Click;
            // 
            // Btn_Cadastro
            // 
            Btn_Cadastro.BackColor = Color.FromArgb(255, 201, 14);
            Btn_Cadastro.Cursor = Cursors.Hand;
            Btn_Cadastro.FlatAppearance.BorderColor = Color.FromArgb(43, 43, 43);
            Btn_Cadastro.FlatAppearance.BorderSize = 3;
            Btn_Cadastro.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            Btn_Cadastro.FlatStyle = FlatStyle.Flat;
            Btn_Cadastro.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Cadastro.IconChar = FontAwesome.Sharp.IconChar.None;
            Btn_Cadastro.IconColor = Color.Black;
            Btn_Cadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Cadastro.Location = new Point(158, 16);
            Btn_Cadastro.Margin = new Padding(3, 2, 3, 2);
            Btn_Cadastro.Name = "Btn_Cadastro";
            Btn_Cadastro.Size = new Size(200, 41);
            Btn_Cadastro.TabIndex = 0;
            Btn_Cadastro.Text = "Cadastro";
            Btn_Cadastro.UseVisualStyleBackColor = false;
            Btn_Cadastro.Click += Btn_Cadastro_Click;
            // 
            // Pnl_Exibicao
            // 
            Pnl_Exibicao.BackColor = Color.FromArgb(43, 43, 43);
            Pnl_Exibicao.Controls.Add(label1);
            Pnl_Exibicao.Controls.Add(pictureBox2);
            Pnl_Exibicao.Dock = DockStyle.Fill;
            Pnl_Exibicao.Location = new Point(0, 70);
            Pnl_Exibicao.Margin = new Padding(3, 2, 3, 2);
            Pnl_Exibicao.Name = "Pnl_Exibicao";
            Pnl_Exibicao.Size = new Size(920, 349);
            Pnl_Exibicao.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(354, 228);
            label1.Name = "label1";
            label1.Size = new Size(183, 39);
            label1.TabIndex = 4;
            label1.Text = "MisPeliculas";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pipocaLogo;
            pictureBox2.Location = new Point(354, 54);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 172);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Frm_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 419);
            Controls.Add(Pnl_Exibicao);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_Menu";
            Text = "MisPeliculas";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Pnl_Exibicao.ResumeLayout(false);
            Pnl_Exibicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton Btn_Cadastro;
        private Panel Pnl_Exibicao;
        private FontAwesome.Sharp.IconButton Btn_Informacoes;
        private FontAwesome.Sharp.IconButton Btn_Estatisticas;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
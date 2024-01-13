namespace MisPeliculas
{
    partial class Frm_Estatisticas
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
            Btn_graph_Art = new Button();
            Btn_graph_Film = new Button();
            Btn_graph_Film_Arrecada = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Btn_graph_Art
            // 
            Btn_graph_Art.BackColor = Color.FromArgb(255, 201, 14);
            Btn_graph_Art.Cursor = Cursors.Hand;
            Btn_graph_Art.FlatAppearance.BorderSize = 0;
            Btn_graph_Art.FlatStyle = FlatStyle.Flat;
            Btn_graph_Art.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Btn_graph_Art.Location = new Point(72, 301);
            Btn_graph_Art.Margin = new Padding(3, 4, 3, 4);
            Btn_graph_Art.Name = "Btn_graph_Art";
            Btn_graph_Art.Size = new Size(242, 92);
            Btn_graph_Art.TabIndex = 41;
            Btn_graph_Art.Text = "10 Atores com maior número de prêmios";
            Btn_graph_Art.UseVisualStyleBackColor = false;
            Btn_graph_Art.Click += Btn_graph_Art_Click;
            // 
            // Btn_graph_Film
            // 
            Btn_graph_Film.BackColor = Color.FromArgb(255, 201, 14);
            Btn_graph_Film.Cursor = Cursors.Hand;
            Btn_graph_Film.FlatAppearance.BorderSize = 0;
            Btn_graph_Film.FlatStyle = FlatStyle.Flat;
            Btn_graph_Film.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Btn_graph_Film.Location = new Point(570, 301);
            Btn_graph_Film.Margin = new Padding(3, 4, 3, 4);
            Btn_graph_Film.Name = "Btn_graph_Film";
            Btn_graph_Film.Size = new Size(242, 92);
            Btn_graph_Film.TabIndex = 41;
            Btn_graph_Film.Text = "10 Filmes com maior número de prêmios";
            Btn_graph_Film.UseVisualStyleBackColor = false;
            Btn_graph_Film.Click += Btn_graph_Film_Click;
            // 
            // Btn_graph_Film_Arrecada
            // 
            Btn_graph_Film_Arrecada.BackColor = Color.FromArgb(255, 201, 14);
            Btn_graph_Film_Arrecada.Cursor = Cursors.Hand;
            Btn_graph_Film_Arrecada.FlatAppearance.BorderSize = 0;
            Btn_graph_Film_Arrecada.FlatStyle = FlatStyle.Flat;
            Btn_graph_Film_Arrecada.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Btn_graph_Film_Arrecada.Location = new Point(321, 301);
            Btn_graph_Film_Arrecada.Margin = new Padding(3, 4, 3, 4);
            Btn_graph_Film_Arrecada.Name = "Btn_graph_Film_Arrecada";
            Btn_graph_Film_Arrecada.Size = new Size(242, 92);
            Btn_graph_Film_Arrecada.TabIndex = 41;
            Btn_graph_Film_Arrecada.Text = "10 Filmes com maior arrecadação";
            Btn_graph_Film_Arrecada.UseVisualStyleBackColor = false;
            Btn_graph_Film_Arrecada.Click += Btn_graph_Film_Arrecada_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(43, 43, 43);
            iconPictureBox1.ForeColor = Color.Gainsboro;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            iconPictureBox1.IconColor = Color.Gainsboro;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 208;
            iconPictureBox1.Location = new Point(93, 68);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(208, 240);
            iconPictureBox1.TabIndex = 42;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(43, 43, 43);
            iconPictureBox2.ForeColor = Color.Gainsboro;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Film;
            iconPictureBox2.IconColor = Color.Gainsboro;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 210;
            iconPictureBox2.Location = new Point(582, 68);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(210, 240);
            iconPictureBox2.TabIndex = 42;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(43, 43, 43);
            iconPictureBox3.ForeColor = Color.Gainsboro;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            iconPictureBox3.IconColor = Color.Gainsboro;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 210;
            iconPictureBox3.Location = new Point(341, 68);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(210, 240);
            iconPictureBox3.TabIndex = 42;
            iconPictureBox3.TabStop = false;
            // 
            // Frm_Estatisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(875, 488);
            Controls.Add(Btn_graph_Art);
            Controls.Add(Btn_graph_Film);
            Controls.Add(Btn_graph_Film_Arrecada);
            Controls.Add(iconPictureBox1);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox3);
            Name = "Frm_Estatisticas";
            Text = "Frm_Estatisticas";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_graph_Art;
        private Button Btn_graph_Film;
        private Button Btn_graph_Film_Arrecada;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}

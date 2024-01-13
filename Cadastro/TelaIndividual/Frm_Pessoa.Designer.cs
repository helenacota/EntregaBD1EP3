namespace MisPeliculas.Cadastro.TelaIndividual
{
    partial class Frm_Pessoa
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
            txtNomeArt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAnoNasc = new TextBox();
            label4 = new Label();
            txtNomeVer = new TextBox();
            label5 = new Label();
            txtAnoIni = new TextBox();
            label6 = new Label();
            txtSite = new TextBox();
            label7 = new Label();
            txtTotalAnos = new TextBox();
            label8 = new Label();
            txtSexo = new ComboBox();
            txtSituacao = new ComboBox();
            btnSalvar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            Dt_Pessoas = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dt_Pessoas).BeginInit();
            SuspendLayout();
            // 
            // txtNomeArt
            // 
            txtNomeArt.Location = new Point(200, 22);
            txtNomeArt.Margin = new Padding(3, 4, 3, 4);
            txtNomeArt.Name = "txtNomeArt";
            txtNomeArt.Size = new Size(100, 26);
            txtNomeArt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(44, 22);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 1;
            label1.Text = "Nome Artistico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(137, 95);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 3;
            label2.Text = "Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(3, 129);
            label3.Name = "label3";
            label3.Size = new Size(193, 28);
            label3.TabIndex = 5;
            label3.Text = "Ano de Nascimento";
            // 
            // txtAnoNasc
            // 
            txtAnoNasc.Location = new Point(200, 132);
            txtAnoNasc.Margin = new Padding(3, 4, 3, 4);
            txtAnoNasc.Name = "txtAnoNasc";
            txtAnoNasc.Size = new Size(100, 26);
            txtAnoNasc.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(18, 59);
            label4.Name = "label4";
            label4.Size = new Size(176, 28);
            label4.TabIndex = 7;
            label4.Text = "Nome Verdadeiro";
            // 
            // txtNomeVer
            // 
            txtNomeVer.Location = new Point(200, 59);
            txtNomeVer.Margin = new Padding(3, 4, 3, 4);
            txtNomeVer.Name = "txtNomeVer";
            txtNomeVer.Size = new Size(100, 26);
            txtNomeVer.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(337, 54);
            label5.Name = "label5";
            label5.Size = new Size(134, 28);
            label5.TabIndex = 12;
            label5.Text = "Ano de Inicio";
            // 
            // txtAnoIni
            // 
            txtAnoIni.Location = new Point(484, 56);
            txtAnoIni.Margin = new Padding(3, 4, 3, 4);
            txtAnoIni.Name = "txtAnoIni";
            txtAnoIni.Size = new Size(100, 26);
            txtAnoIni.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(422, 19);
            label6.Name = "label6";
            label6.Size = new Size(49, 28);
            label6.TabIndex = 10;
            label6.Text = "Site";
            // 
            // txtSite
            // 
            txtSite.Location = new Point(484, 19);
            txtSite.Margin = new Padding(3, 4, 3, 4);
            txtSite.Name = "txtSite";
            txtSite.Size = new Size(100, 26);
            txtSite.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonShadow;
            label7.Location = new Point(332, 128);
            label7.Name = "label7";
            label7.Size = new Size(139, 28);
            label7.TabIndex = 16;
            label7.Text = "Total de Anos";
            // 
            // txtTotalAnos
            // 
            txtTotalAnos.Location = new Point(484, 129);
            txtTotalAnos.Margin = new Padding(3, 4, 3, 4);
            txtTotalAnos.Name = "txtTotalAnos";
            txtTotalAnos.Size = new Size(100, 26);
            txtTotalAnos.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(375, 92);
            label8.Name = "label8";
            label8.Size = new Size(96, 28);
            label8.TabIndex = 14;
            label8.Text = "Situacao";
            // 
            // txtSexo
            // 
            txtSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSexo.FormattingEnabled = true;
            txtSexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Outro" });
            txtSexo.Location = new Point(200, 95);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(100, 27);
            txtSexo.TabIndex = 24;
            // 
            // txtSituacao
            // 
            txtSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSituacao.FormattingEnabled = true;
            txtSituacao.Items.AddRange(new object[] { "Atuando", "Aposentado", "Falecido" });
            txtSituacao.Location = new Point(484, 94);
            txtSituacao.Name = "txtSituacao";
            txtSituacao.Size = new Size(100, 27);
            txtSituacao.TabIndex = 25;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(255, 201, 14);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(629, 52);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 85);
            btnSalvar.TabIndex = 41;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNomeVer);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(txtNomeArt);
            panel1.Controls.Add(txtSituacao);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSexo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtAnoNasc);
            panel1.Controls.Add(txtTotalAnos);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSite);
            panel1.Controls.Add(txtAnoIni);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 177);
            panel1.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.Controls.Add(Dt_Pessoas);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 393);
            panel2.TabIndex = 43;
            // 
            // Dt_Pessoas
            // 
            Dt_Pessoas.AllowUserToAddRows = false;
            Dt_Pessoas.AllowUserToDeleteRows = false;
            Dt_Pessoas.AllowUserToOrderColumns = true;
            Dt_Pessoas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Dt_Pessoas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Pessoas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dt_Pessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_Pessoas.Location = new Point(39, 16);
            Dt_Pessoas.Name = "Dt_Pessoas";
            Dt_Pessoas.RowHeadersVisible = false;
            Dt_Pessoas.RowHeadersWidth = 51;
            Dt_Pessoas.RowTemplate.Height = 29;
            Dt_Pessoas.Size = new Size(710, 212);
            Dt_Pessoas.TabIndex = 9;
            // 
            // Frm_Pessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(800, 570);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_Pessoa";
            Text = "Frm_Pessoa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dt_Pessoas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNomeArt;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAnoNasc;
        private Label label4;
        private TextBox txtNomeVer;
        private Label label5;
        private TextBox txtAnoIni;
        private Label label6;
        private TextBox txtSite;
        private Label label7;
        private TextBox txtTotalAnos;
        private Label label8;
        private ComboBox txtSexo;
        private ComboBox txtSituacao;
        private Button btnSalvar;
        private Panel panel1;
        private Panel panel2;
        private DataGridView Dt_Pessoas;
    }
}
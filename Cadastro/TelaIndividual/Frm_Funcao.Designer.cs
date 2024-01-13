namespace MisPeliculas.Cadastro.TelaIndividual
{
    partial class Frm_Funcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Funcao));
            txtFuncao = new ComboBox();
            txtNomeArt = new TextBox();
            label1 = new Label();
            label10 = new Label();
            txtIDFilme = new TextBox();
            label4 = new Label();
            btnSalvar = new Button();
            panel1 = new Panel();
            txtEPrinc = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            Dt_FuncoesFilmes = new DataGridView();
            Lbl_FuncoesFilme = new Label();
            Lbl_TodosFilmes = new Label();
            Dt_TodosFilmes = new DataGridView();
            panel3 = new Panel();
            Icn_Pesquisa = new FontAwesome.Sharp.IconPictureBox();
            txtFuncaoPesquisa = new ComboBox();
            Lbl_FuncFilmePesquisa = new Label();
            Lbl_IdFilmePesquisa = new Label();
            Txt_IdFilmePesquisa = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dt_FuncoesFilmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dt_TodosFilmes).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icn_Pesquisa).BeginInit();
            SuspendLayout();
            // 
            // txtFuncao
            // 
            txtFuncao.DropDownStyle = ComboBoxStyle.DropDownList;
            txtFuncao.FormattingEnabled = true;
            txtFuncao.Items.AddRange(new object[] { "Diretor", "Produtor", "Roteirista", "Ator Principal", "Ator Elenco" });
            txtFuncao.Location = new Point(560, 51);
            txtFuncao.Name = "txtFuncao";
            txtFuncao.Size = new Size(114, 28);
            txtFuncao.TabIndex = 38;
            txtFuncao.SelectedIndexChanged += txtFuncao_SelectedIndexChanged;
            // 
            // txtNomeArt
            // 
            txtNomeArt.Location = new Point(215, 47);
            txtNomeArt.Margin = new Padding(3, 4, 3, 4);
            txtNomeArt.Name = "txtNomeArt";
            txtNomeArt.Size = new Size(114, 27);
            txtNomeArt.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(80, 101);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 37;
            label1.Text = "ID do Filme";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonShadow;
            label10.Location = new Point(448, 51);
            label10.Name = "label10";
            label10.Size = new Size(80, 28);
            label10.TabIndex = 42;
            label10.Text = "Função";
            // 
            // txtIDFilme
            // 
            txtIDFilme.Location = new Point(215, 101);
            txtIDFilme.Margin = new Padding(3, 4, 3, 4);
            txtIDFilme.Name = "txtIDFilme";
            txtIDFilme.Size = new Size(114, 27);
            txtIDFilme.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(47, 47);
            label4.Name = "label4";
            label4.Size = new Size(150, 28);
            label4.TabIndex = 39;
            label4.Text = "Nome Artístico";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(255, 201, 14);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnSalvar.Location = new Point(725, 51);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 85);
            btnSalvar.TabIndex = 40;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtEPrinc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFuncao);
            panel1.Controls.Add(txtNomeArt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtIDFilme);
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 161);
            panel1.TabIndex = 43;
            // 
            // txtEPrinc
            // 
            txtEPrinc.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEPrinc.FormattingEnabled = true;
            txtEPrinc.Items.AddRange(new object[] { "Sim", "Não" });
            txtEPrinc.Location = new Point(560, 105);
            txtEPrinc.Name = "txtEPrinc";
            txtEPrinc.Size = new Size(114, 28);
            txtEPrinc.TabIndex = 43;
            txtEPrinc.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(382, 105);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 44;
            label2.Text = "É Diretor Princ.";
            label2.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(Dt_FuncoesFilmes);
            panel2.Controls.Add(Lbl_FuncoesFilme);
            panel2.Controls.Add(Lbl_TodosFilmes);
            panel2.Controls.Add(Dt_TodosFilmes);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 266);
            panel2.TabIndex = 44;
            // 
            // Dt_FuncoesFilmes
            // 
            Dt_FuncoesFilmes.AllowUserToAddRows = false;
            Dt_FuncoesFilmes.AllowUserToDeleteRows = false;
            Dt_FuncoesFilmes.AllowUserToOrderColumns = true;
            Dt_FuncoesFilmes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Dt_FuncoesFilmes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_FuncoesFilmes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dt_FuncoesFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_FuncoesFilmes.Location = new Point(398, 52);
            Dt_FuncoesFilmes.Name = "Dt_FuncoesFilmes";
            Dt_FuncoesFilmes.RowHeadersVisible = false;
            Dt_FuncoesFilmes.RowHeadersWidth = 51;
            Dt_FuncoesFilmes.RowTemplate.Height = 29;
            Dt_FuncoesFilmes.Size = new Size(381, 180);
            Dt_FuncoesFilmes.TabIndex = 37;
            // 
            // Lbl_FuncoesFilme
            // 
            Lbl_FuncoesFilme.AutoSize = true;
            Lbl_FuncoesFilme.Font = new Font("Impact", 13.8F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            Lbl_FuncoesFilme.ForeColor = SystemColors.ButtonFace;
            Lbl_FuncoesFilme.Location = new Point(398, 19);
            Lbl_FuncoesFilme.Name = "Lbl_FuncoesFilme";
            Lbl_FuncoesFilme.Size = new Size(322, 28);
            Lbl_FuncoesFilme.TabIndex = 29;
            Lbl_FuncoesFilme.Text = "Funções do Filme por ID e Função";
            // 
            // Lbl_TodosFilmes
            // 
            Lbl_TodosFilmes.AutoSize = true;
            Lbl_TodosFilmes.Font = new Font("Impact", 13.8F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            Lbl_TodosFilmes.ForeColor = SystemColors.ButtonFace;
            Lbl_TodosFilmes.Location = new Point(47, 19);
            Lbl_TodosFilmes.Name = "Lbl_TodosFilmes";
            Lbl_TodosFilmes.Size = new Size(215, 28);
            Lbl_TodosFilmes.TabIndex = 29;
            Lbl_TodosFilmes.Text = "ID de Todos os Filmes";
            // 
            // Dt_TodosFilmes
            // 
            Dt_TodosFilmes.AllowUserToAddRows = false;
            Dt_TodosFilmes.AllowUserToDeleteRows = false;
            Dt_TodosFilmes.AllowUserToOrderColumns = true;
            Dt_TodosFilmes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_TodosFilmes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dt_TodosFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_TodosFilmes.Location = new Point(47, 52);
            Dt_TodosFilmes.Name = "Dt_TodosFilmes";
            Dt_TodosFilmes.RowHeadersVisible = false;
            Dt_TodosFilmes.RowHeadersWidth = 51;
            Dt_TodosFilmes.RowTemplate.Height = 29;
            Dt_TodosFilmes.Size = new Size(262, 180);
            Dt_TodosFilmes.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(Icn_Pesquisa);
            panel3.Controls.Add(txtFuncaoPesquisa);
            panel3.Controls.Add(Lbl_FuncFilmePesquisa);
            panel3.Controls.Add(Lbl_IdFilmePesquisa);
            panel3.Controls.Add(Txt_IdFilmePesquisa);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(785, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(129, 266);
            panel3.TabIndex = 45;
            // 
            // Icn_Pesquisa
            // 
            Icn_Pesquisa.BackColor = Color.FromArgb(43, 43, 43);
            Icn_Pesquisa.ForeColor = Color.Gainsboro;
            Icn_Pesquisa.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            Icn_Pesquisa.IconColor = Color.Gainsboro;
            Icn_Pesquisa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Icn_Pesquisa.IconSize = 62;
            Icn_Pesquisa.Location = new Point(32, 170);
            Icn_Pesquisa.Name = "Icn_Pesquisa";
            Icn_Pesquisa.Size = new Size(74, 62);
            Icn_Pesquisa.TabIndex = 45;
            Icn_Pesquisa.TabStop = false;
            Icn_Pesquisa.Click += Icn_Pesquisa_Click;
            // 
            // txtFuncaoPesquisa
            // 
            txtFuncaoPesquisa.DropDownStyle = ComboBoxStyle.DropDownList;
            txtFuncaoPesquisa.FormattingEnabled = true;
            txtFuncaoPesquisa.Items.AddRange(new object[] { "Diretor", "Produtor", "Roteirista", "Ator Principal", "Ator Elenco" });
            txtFuncaoPesquisa.Location = new Point(7, 125);
            txtFuncaoPesquisa.Name = "txtFuncaoPesquisa";
            txtFuncaoPesquisa.Size = new Size(114, 28);
            txtFuncaoPesquisa.TabIndex = 40;
            // 
            // Lbl_FuncFilmePesquisa
            // 
            Lbl_FuncFilmePesquisa.AutoSize = true;
            Lbl_FuncFilmePesquisa.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_FuncFilmePesquisa.ForeColor = Color.White;
            Lbl_FuncFilmePesquisa.Location = new Point(7, 103);
            Lbl_FuncFilmePesquisa.Name = "Lbl_FuncFilmePesquisa";
            Lbl_FuncFilmePesquisa.Size = new Size(54, 19);
            Lbl_FuncFilmePesquisa.TabIndex = 43;
            Lbl_FuncFilmePesquisa.Text = "Função";
            // 
            // Lbl_IdFilmePesquisa
            // 
            Lbl_IdFilmePesquisa.AutoSize = true;
            Lbl_IdFilmePesquisa.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_IdFilmePesquisa.ForeColor = Color.White;
            Lbl_IdFilmePesquisa.Location = new Point(7, 37);
            Lbl_IdFilmePesquisa.Name = "Lbl_IdFilmePesquisa";
            Lbl_IdFilmePesquisa.Size = new Size(77, 19);
            Lbl_IdFilmePesquisa.TabIndex = 44;
            Lbl_IdFilmePesquisa.Text = "ID do Filme";
            // 
            // Txt_IdFilmePesquisa
            // 
            Txt_IdFilmePesquisa.Location = new Point(7, 59);
            Txt_IdFilmePesquisa.Name = "Txt_IdFilmePesquisa";
            Txt_IdFilmePesquisa.Size = new Size(114, 27);
            Txt_IdFilmePesquisa.TabIndex = 41;
            // 
            // Frm_Funcao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(914, 427);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_Funcao";
            Text = "Cadastrar e Visualizar Funções";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dt_FuncoesFilmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dt_TodosFilmes).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Icn_Pesquisa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox txtFuncao;
        private TextBox txtNomeArt;
        private Label label1;
        private Label label10;
        private TextBox txtIDFilme;
        private Label label4;
        private Button btnSalvar;
        private Panel panel1;
        private Panel panel2;
        private DataGridView Dt_TodosFilmes;
        private Label Lbl_TodosFilmes;
        private DataGridView Dt_FuncoesFilmes;
        private Label Lbl_FuncoesFilme;
        private Panel panel3;
        private ComboBox txtFuncaoPesquisa;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label Lbl_FuncFilmePesquisa;
        private Label Lbl_IdFilmePesquisa;
        private TextBox Txt_IdFilmePesquisa;
        private ComboBox txtEPrinc;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox Icn_Pesquisa;
    }
}
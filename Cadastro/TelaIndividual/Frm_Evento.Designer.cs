namespace MisPeliculas.Cadastro.TelaIndividual
{
    partial class Frm_Evento
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
            Dt_Eventos = new DataGridView();
            Txt_Nome = new TextBox();
            Btn_Enviar = new FontAwesome.Sharp.IconButton();
            Txt_AnoIni = new TextBox();
            Lbl_Nome = new Label();
            Txt_Nacionalidade = new TextBox();
            Lbl_AnoIni = new Label();
            CmbBx_Tipo = new ComboBox();
            Lbl_Nacionalidade = new Label();
            Lbl_Tipo = new Label();
            Btn_AddEdicao = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)Dt_Eventos).BeginInit();
            SuspendLayout();
            // 
            // Dt_Eventos
            // 
            Dt_Eventos.AllowUserToAddRows = false;
            Dt_Eventos.AllowUserToDeleteRows = false;
            Dt_Eventos.AllowUserToOrderColumns = true;
            Dt_Eventos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Dt_Eventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Eventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dt_Eventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_Eventos.Location = new Point(38, 201);
            Dt_Eventos.Name = "Dt_Eventos";
            Dt_Eventos.RowHeadersVisible = false;
            Dt_Eventos.RowHeadersWidth = 51;
            Dt_Eventos.RowTemplate.Height = 29;
            Dt_Eventos.Size = new Size(807, 171);
            Dt_Eventos.TabIndex = 8;
            // 
            // Txt_Nome
            // 
            Txt_Nome.Location = new Point(146, 31);
            Txt_Nome.MaxLength = 44;
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(140, 27);
            Txt_Nome.TabIndex = 23;
            // 
            // Btn_Enviar
            // 
            Btn_Enviar.BackColor = Color.FromArgb(255, 201, 14);
            Btn_Enviar.Cursor = Cursors.Hand;
            Btn_Enviar.FlatAppearance.BorderColor = Color.Silver;
            Btn_Enviar.FlatAppearance.BorderSize = 0;
            Btn_Enviar.FlatStyle = FlatStyle.Flat;
            Btn_Enviar.Font = new Font("Impact", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            Btn_Enviar.ForeColor = Color.Black;
            Btn_Enviar.IconChar = FontAwesome.Sharp.IconChar.None;
            Btn_Enviar.IconColor = Color.Black;
            Btn_Enviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Enviar.Location = new Point(673, 27);
            Btn_Enviar.Name = "Btn_Enviar";
            Btn_Enviar.Size = new Size(111, 85);
            Btn_Enviar.TabIndex = 17;
            Btn_Enviar.Text = "Enviar";
            Btn_Enviar.UseVisualStyleBackColor = false;
            Btn_Enviar.Click += Btn_Enviar_Click;
            // 
            // Txt_AnoIni
            // 
            Txt_AnoIni.Location = new Point(495, 31);
            Txt_AnoIni.MaxLength = 4;
            Txt_AnoIni.Name = "Txt_AnoIni";
            Txt_AnoIni.Size = new Size(153, 27);
            Txt_AnoIni.TabIndex = 24;
            // 
            // Lbl_Nome
            // 
            Lbl_Nome.AutoSize = true;
            Lbl_Nome.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Lbl_Nome.ForeColor = SystemColors.ButtonShadow;
            Lbl_Nome.Location = new Point(64, 27);
            Lbl_Nome.Name = "Lbl_Nome";
            Lbl_Nome.Size = new Size(66, 28);
            Lbl_Nome.TabIndex = 18;
            Lbl_Nome.Text = "Nome";
            // 
            // Txt_Nacionalidade
            // 
            Txt_Nacionalidade.Location = new Point(495, 83);
            Txt_Nacionalidade.MaxLength = 44;
            Txt_Nacionalidade.Name = "Txt_Nacionalidade";
            Txt_Nacionalidade.Size = new Size(153, 27);
            Txt_Nacionalidade.TabIndex = 25;
            // 
            // Lbl_AnoIni
            // 
            Lbl_AnoIni.AutoSize = true;
            Lbl_AnoIni.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Lbl_AnoIni.ForeColor = SystemColors.ButtonShadow;
            Lbl_AnoIni.Location = new Point(344, 27);
            Lbl_AnoIni.Name = "Lbl_AnoIni";
            Lbl_AnoIni.Size = new Size(134, 28);
            Lbl_AnoIni.TabIndex = 21;
            Lbl_AnoIni.Text = "Ano de Início";
            // 
            // CmbBx_Tipo
            // 
            CmbBx_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBx_Tipo.FormattingEnabled = true;
            CmbBx_Tipo.Items.AddRange(new object[] { "Academia", "Festival", "Concurso" });
            CmbBx_Tipo.Location = new Point(146, 81);
            CmbBx_Tipo.Name = "CmbBx_Tipo";
            CmbBx_Tipo.Size = new Size(140, 28);
            CmbBx_Tipo.TabIndex = 22;
            // 
            // Lbl_Nacionalidade
            // 
            Lbl_Nacionalidade.AutoSize = true;
            Lbl_Nacionalidade.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Lbl_Nacionalidade.ForeColor = SystemColors.ButtonShadow;
            Lbl_Nacionalidade.Location = new Point(329, 83);
            Lbl_Nacionalidade.Name = "Lbl_Nacionalidade";
            Lbl_Nacionalidade.Size = new Size(149, 28);
            Lbl_Nacionalidade.TabIndex = 20;
            Lbl_Nacionalidade.Text = "Nacionalidade";
            // 
            // Lbl_Tipo
            // 
            Lbl_Tipo.AutoSize = true;
            Lbl_Tipo.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Lbl_Tipo.ForeColor = SystemColors.ButtonShadow;
            Lbl_Tipo.Location = new Point(78, 81);
            Lbl_Tipo.Name = "Lbl_Tipo";
            Lbl_Tipo.Size = new Size(53, 28);
            Lbl_Tipo.TabIndex = 19;
            Lbl_Tipo.Text = "Tipo";
            // 
            // Btn_AddEdicao
            // 
            Btn_AddEdicao.BackColor = Color.Brown;
            Btn_AddEdicao.Cursor = Cursors.Hand;
            Btn_AddEdicao.FlatAppearance.BorderColor = Color.Silver;
            Btn_AddEdicao.FlatAppearance.BorderSize = 0;
            Btn_AddEdicao.FlatStyle = FlatStyle.Flat;
            Btn_AddEdicao.Font = new Font("Impact", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            Btn_AddEdicao.ForeColor = Color.Black;
            Btn_AddEdicao.IconChar = FontAwesome.Sharp.IconChar.None;
            Btn_AddEdicao.IconColor = Color.Black;
            Btn_AddEdicao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_AddEdicao.Location = new Point(203, 149);
            Btn_AddEdicao.Name = "Btn_AddEdicao";
            Btn_AddEdicao.Size = new Size(501, 33);
            Btn_AddEdicao.TabIndex = 26;
            Btn_AddEdicao.Text = "Adicionar Nova Edição do Evento";
            Btn_AddEdicao.UseVisualStyleBackColor = false;
            Btn_AddEdicao.Click += Btn_AddEdicao_Click;
            // 
            // Frm_Evento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(917, 405);
            Controls.Add(Btn_AddEdicao);
            Controls.Add(Txt_Nome);
            Controls.Add(Btn_Enviar);
            Controls.Add(Txt_AnoIni);
            Controls.Add(Lbl_Nome);
            Controls.Add(Txt_Nacionalidade);
            Controls.Add(Lbl_AnoIni);
            Controls.Add(CmbBx_Tipo);
            Controls.Add(Lbl_Nacionalidade);
            Controls.Add(Lbl_Tipo);
            Controls.Add(Dt_Eventos);
            Name = "Frm_Evento";
            Text = "Frm_Evento";
            ((System.ComponentModel.ISupportInitialize)Dt_Eventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Dt_Eventos;
        private TextBox Txt_Nome;
        private FontAwesome.Sharp.IconButton Btn_Enviar;
        private TextBox Txt_AnoIni;
        private Label Lbl_Nome;
        private TextBox Txt_Nacionalidade;
        private Label Lbl_AnoIni;
        private ComboBox CmbBx_Tipo;
        private Label Lbl_Nacionalidade;
        private Label Lbl_Tipo;
        private FontAwesome.Sharp.IconButton Btn_AddEdicao;
    }
}
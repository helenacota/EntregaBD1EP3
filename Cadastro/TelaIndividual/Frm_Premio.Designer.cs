namespace MisPeliculas.Cadastro.TelaIndividual
{
    partial class Frm_Premio
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
            Txt_NomePremio = new TextBox();
            Btn_Enviar = new FontAwesome.Sharp.IconButton();
            Txt_AnoEdicao = new TextBox();
            Lbl_NomePremio = new Label();
            Txt_NomeEvento = new TextBox();
            Lbl_AnoIni = new Label();
            Lbl_Nacionalidade = new Label();
            Lbl_Tipo = new Label();
            txt_Tipo = new ComboBox();
            btnSalvar = new Button();
            Cmb_Edicao = new ComboBox();
            label3 = new Label();
            Cmb_Evento = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            Dt_Premios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Dt_Premios).BeginInit();
            SuspendLayout();
            // 
            // Txt_NomePremio
            // 
            Txt_NomePremio.Location = new Point(185, 53);
            Txt_NomePremio.MaxLength = 44;
            Txt_NomePremio.Name = "Txt_NomePremio";
            Txt_NomePremio.Size = new Size(140, 27);
            Txt_NomePremio.TabIndex = 1;
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
            Btn_Enviar.Location = new Point(712, 53);
            Btn_Enviar.Name = "Btn_Enviar";
            Btn_Enviar.Size = new Size(111, 85);
            Btn_Enviar.TabIndex = 5;
            Btn_Enviar.Text = "Enviar";
            Btn_Enviar.UseVisualStyleBackColor = false;
            Btn_Enviar.Click += Btn_Enviar_Click;
            // 
            // Txt_AnoEdicao
            // 
            Txt_AnoEdicao.Location = new Point(534, 57);
            Txt_AnoEdicao.MaxLength = 4;
            Txt_AnoEdicao.Name = "Txt_AnoEdicao";
            Txt_AnoEdicao.Size = new Size(153, 27);
            Txt_AnoEdicao.TabIndex = 2;
            // 
            // Lbl_NomePremio
            // 
            Lbl_NomePremio.AutoSize = true;
            Lbl_NomePremio.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Lbl_NomePremio.ForeColor = SystemColors.ButtonShadow;
            Lbl_NomePremio.Location = new Point(32, 49);
            Lbl_NomePremio.Name = "Lbl_NomePremio";
            Lbl_NomePremio.Size = new Size(138, 28);
            Lbl_NomePremio.TabIndex = 27;
            Lbl_NomePremio.Text = "Nome Prêmio";
            // 
            // Txt_NomeEvento
            // 
            Txt_NomeEvento.Location = new Point(534, 109);
            Txt_NomeEvento.MaxLength = 44;
            Txt_NomeEvento.Name = "Txt_NomeEvento";
            Txt_NomeEvento.Size = new Size(153, 27);
            Txt_NomeEvento.TabIndex = 4;
            // 
            // Lbl_AnoIni
            // 
            Lbl_AnoIni.AutoSize = true;
            Lbl_AnoIni.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Lbl_AnoIni.ForeColor = SystemColors.ButtonShadow;
            Lbl_AnoIni.Location = new Point(383, 53);
            Lbl_AnoIni.Name = "Lbl_AnoIni";
            Lbl_AnoIni.Size = new Size(115, 28);
            Lbl_AnoIni.TabIndex = 30;
            Lbl_AnoIni.Text = "Ano Edição";
            // 
            // Lbl_Nacionalidade
            // 
            Lbl_Nacionalidade.AutoSize = true;
            Lbl_Nacionalidade.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Lbl_Nacionalidade.ForeColor = SystemColors.ButtonShadow;
            Lbl_Nacionalidade.Location = new Point(368, 109);
            Lbl_Nacionalidade.Name = "Lbl_Nacionalidade";
            Lbl_Nacionalidade.Size = new Size(132, 28);
            Lbl_Nacionalidade.TabIndex = 29;
            Lbl_Nacionalidade.Text = "Nome Evento";
            // 
            // Lbl_Tipo
            // 
            Lbl_Tipo.AutoSize = true;
            Lbl_Tipo.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Lbl_Tipo.ForeColor = SystemColors.ButtonShadow;
            Lbl_Tipo.Location = new Point(117, 108);
            Lbl_Tipo.Name = "Lbl_Tipo";
            Lbl_Tipo.Size = new Size(53, 28);
            Lbl_Tipo.TabIndex = 28;
            Lbl_Tipo.Text = "Tipo";
            // 
            // txt_Tipo
            // 
            txt_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_Tipo.FormattingEnabled = true;
            txt_Tipo.Items.AddRange(new object[] { "Melhor Ator Principal", "Melhor Ator Elenco", "Melhor Filme", "Melhor Diretor", "Melhor Roteiro Original", "Melhor Roteiro Adaptado", "Melhor Produção", "Melhor Documentário" });
            txt_Tipo.Location = new Point(185, 108);
            txt_Tipo.Margin = new Padding(3, 4, 3, 4);
            txt_Tipo.Name = "txt_Tipo";
            txt_Tipo.Size = new Size(140, 28);
            txt_Tipo.TabIndex = 60;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(255, 201, 14);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnSalvar.Location = new Point(127, 318);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(658, 38);
            btnSalvar.TabIndex = 67;
            btnSalvar.Text = "Buscar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Cmb_Edicao
            // 
            Cmb_Edicao.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Edicao.Enabled = false;
            Cmb_Edicao.FormattingEnabled = true;
            Cmb_Edicao.Location = new Point(565, 269);
            Cmb_Edicao.Name = "Cmb_Edicao";
            Cmb_Edicao.Size = new Size(126, 28);
            Cmb_Edicao.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(494, 272);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 64;
            label3.Text = "Edição";
            // 
            // Cmb_Evento
            // 
            Cmb_Evento.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Evento.FormattingEnabled = true;
            Cmb_Evento.Location = new Point(276, 269);
            Cmb_Evento.Name = "Cmb_Evento";
            Cmb_Evento.Size = new Size(126, 28);
            Cmb_Evento.TabIndex = 62;
            Cmb_Evento.SelectedIndexChanged += Cmb_Evento_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(205, 272);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 61;
            label2.Text = "Evento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(229, 218);
            label1.Name = "label1";
            label1.Size = new Size(445, 35);
            label1.TabIndex = 68;
            label1.Text = "Buscar Todos os Prêmios Registrados";
            // 
            // Dt_Premios
            // 
            Dt_Premios.AllowUserToAddRows = false;
            Dt_Premios.AllowUserToDeleteRows = false;
            Dt_Premios.AllowUserToOrderColumns = true;
            Dt_Premios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Dt_Premios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Premios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dt_Premios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_Premios.Location = new Point(127, 376);
            Dt_Premios.Name = "Dt_Premios";
            Dt_Premios.RowHeadersVisible = false;
            Dt_Premios.RowHeadersWidth = 51;
            Dt_Premios.RowTemplate.Height = 29;
            Dt_Premios.Size = new Size(658, 212);
            Dt_Premios.TabIndex = 69;
            // 
            // Frm_Premio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(914, 600);
            Controls.Add(Dt_Premios);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(Cmb_Edicao);
            Controls.Add(label3);
            Controls.Add(Cmb_Evento);
            Controls.Add(label2);
            Controls.Add(txt_Tipo);
            Controls.Add(Txt_NomePremio);
            Controls.Add(Btn_Enviar);
            Controls.Add(Txt_AnoEdicao);
            Controls.Add(Lbl_NomePremio);
            Controls.Add(Txt_NomeEvento);
            Controls.Add(Lbl_AnoIni);
            Controls.Add(Lbl_Nacionalidade);
            Controls.Add(Lbl_Tipo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_Premio";
            Text = "Frm_Premio";
            ((System.ComponentModel.ISupportInitialize)Dt_Premios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_NomePremio;
        private FontAwesome.Sharp.IconButton Btn_Enviar;
        private TextBox Txt_AnoEdicao;
        private Label Lbl_NomePremio;
        private TextBox Txt_NomeEvento;
        private Label Lbl_AnoIni;
        private Label Lbl_Nacionalidade;
        private Label Lbl_Tipo;
        private ComboBox txt_Tipo;
        private Button btnSalvar;
        private ComboBox Cmb_Edicao;
        private Label label3;
        private ComboBox Cmb_Evento;
        private Label label2;
        private Label label1;
        private DataGridView Dt_Premios;
    }
}
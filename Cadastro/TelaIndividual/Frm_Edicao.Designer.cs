namespace MisPeliculas.Cadastro.TelaIndividual
{
    partial class Frm_Edicao
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
            Txt_Nome = new TextBox();
            Btn_Enviar = new FontAwesome.Sharp.IconButton();
            Txt_AnoIni = new TextBox();
            Lbl_Nome = new Label();
            Txt_Local = new TextBox();
            Lbl_AnoEdicao = new Label();
            Lbl_Localizacao = new Label();
            Lbl_Data = new Label();
            Msk_Data = new MaskedTextBox();
            Dt_Eventos = new DataGridView();
            Lbl_TodosEventos = new Label();
            label1 = new Label();
            Dt_Edicao = new DataGridView();
            Txt_NomeJuri = new TextBox();
            btnAdicionarJuri = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Dt_Eventos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dt_Edicao).BeginInit();
            SuspendLayout();
            // 
            // Txt_Nome
            // 
            Txt_Nome.Location = new Point(178, 40);
            Txt_Nome.MaxLength = 44;
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(122, 27);
            Txt_Nome.TabIndex = 32;
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
            Btn_Enviar.Location = new Point(648, 36);
            Btn_Enviar.Name = "Btn_Enviar";
            Btn_Enviar.Size = new Size(117, 84);
            Btn_Enviar.TabIndex = 26;
            Btn_Enviar.Text = "Enviar";
            Btn_Enviar.UseVisualStyleBackColor = false;
            Btn_Enviar.Click += Btn_Enviar_Click;
            // 
            // Txt_AnoIni
            // 
            Txt_AnoIni.Location = new Point(474, 40);
            Txt_AnoIni.MaxLength = 4;
            Txt_AnoIni.Name = "Txt_AnoIni";
            Txt_AnoIni.Size = new Size(153, 27);
            Txt_AnoIni.TabIndex = 33;
            // 
            // Lbl_Nome
            // 
            Lbl_Nome.AutoSize = true;
            Lbl_Nome.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Lbl_Nome.ForeColor = SystemColors.ButtonShadow;
            Lbl_Nome.Location = new Point(11, 39);
            Lbl_Nome.Name = "Lbl_Nome";
            Lbl_Nome.Size = new Size(160, 28);
            Lbl_Nome.TabIndex = 27;
            Lbl_Nome.Text = "Nome do Evento";
            // 
            // Txt_Local
            // 
            Txt_Local.Location = new Point(474, 91);
            Txt_Local.MaxLength = 44;
            Txt_Local.Name = "Txt_Local";
            Txt_Local.Size = new Size(153, 27);
            Txt_Local.TabIndex = 34;
            // 
            // Lbl_AnoEdicao
            // 
            Lbl_AnoEdicao.AutoSize = true;
            Lbl_AnoEdicao.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Lbl_AnoEdicao.ForeColor = SystemColors.ButtonShadow;
            Lbl_AnoEdicao.Location = new Point(315, 36);
            Lbl_AnoEdicao.Name = "Lbl_AnoEdicao";
            Lbl_AnoEdicao.Size = new Size(143, 28);
            Lbl_AnoEdicao.TabIndex = 30;
            Lbl_AnoEdicao.Text = "Ano da Edição";
            // 
            // Lbl_Localizacao
            // 
            Lbl_Localizacao.AutoSize = true;
            Lbl_Localizacao.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Lbl_Localizacao.ForeColor = SystemColors.ButtonShadow;
            Lbl_Localizacao.Location = new Point(335, 91);
            Lbl_Localizacao.Name = "Lbl_Localizacao";
            Lbl_Localizacao.Size = new Size(123, 28);
            Lbl_Localizacao.TabIndex = 29;
            Lbl_Localizacao.Text = "Localização";
            // 
            // Lbl_Data
            // 
            Lbl_Data.AutoSize = true;
            Lbl_Data.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Lbl_Data.ForeColor = SystemColors.ButtonShadow;
            Lbl_Data.Location = new Point(117, 89);
            Lbl_Data.Name = "Lbl_Data";
            Lbl_Data.Size = new Size(56, 28);
            Lbl_Data.TabIndex = 28;
            Lbl_Data.Text = "Data";
            // 
            // Msk_Data
            // 
            Msk_Data.Location = new Point(178, 91);
            Msk_Data.Mask = "0000/00/00";
            Msk_Data.Name = "Msk_Data";
            Msk_Data.Size = new Size(122, 27);
            Msk_Data.TabIndex = 35;
            Msk_Data.ValidatingType = typeof(DateTime);
            // 
            // Dt_Eventos
            // 
            Dt_Eventos.AllowUserToAddRows = false;
            Dt_Eventos.AllowUserToDeleteRows = false;
            Dt_Eventos.AllowUserToOrderColumns = true;
            Dt_Eventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Eventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dt_Eventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_Eventos.Location = new Point(34, 192);
            Dt_Eventos.Name = "Dt_Eventos";
            Dt_Eventos.RowHeadersVisible = false;
            Dt_Eventos.RowHeadersWidth = 51;
            Dt_Eventos.RowTemplate.Height = 29;
            Dt_Eventos.Size = new Size(198, 243);
            Dt_Eventos.TabIndex = 36;
            // 
            // Lbl_TodosEventos
            // 
            Lbl_TodosEventos.AutoSize = true;
            Lbl_TodosEventos.Font = new Font("Impact", 13.8F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            Lbl_TodosEventos.ForeColor = SystemColors.ButtonFace;
            Lbl_TodosEventos.Location = new Point(34, 145);
            Lbl_TodosEventos.Name = "Lbl_TodosEventos";
            Lbl_TodosEventos.Size = new Size(174, 28);
            Lbl_TodosEventos.TabIndex = 28;
            Lbl_TodosEventos.Text = "Todos os Eventos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(315, 145);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 28;
            label1.Text = "Edições Registradas";
            // 
            // Dt_Edicao
            // 
            Dt_Edicao.AllowUserToAddRows = false;
            Dt_Edicao.AllowUserToDeleteRows = false;
            Dt_Edicao.AllowUserToOrderColumns = true;
            Dt_Edicao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Dt_Edicao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Edicao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dt_Edicao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_Edicao.Location = new Point(315, 192);
            Dt_Edicao.Name = "Dt_Edicao";
            Dt_Edicao.RowHeadersVisible = false;
            Dt_Edicao.RowHeadersWidth = 51;
            Dt_Edicao.RowTemplate.Height = 29;
            Dt_Edicao.Size = new Size(424, 243);
            Dt_Edicao.TabIndex = 36;
            // 
            // Txt_NomeJuri
            // 
            Txt_NomeJuri.Location = new Point(224, 549);
            Txt_NomeJuri.MaxLength = 44;
            Txt_NomeJuri.Name = "Txt_NomeJuri";
            Txt_NomeJuri.Size = new Size(140, 27);
            Txt_NomeJuri.TabIndex = 40;
            // 
            // btnAdicionarJuri
            // 
            btnAdicionarJuri.BackColor = Color.FromArgb(255, 201, 14);
            btnAdicionarJuri.Cursor = Cursors.Hand;
            btnAdicionarJuri.FlatAppearance.BorderColor = Color.Silver;
            btnAdicionarJuri.FlatAppearance.BorderSize = 0;
            btnAdicionarJuri.FlatStyle = FlatStyle.Flat;
            btnAdicionarJuri.Font = new Font("Impact", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnAdicionarJuri.ForeColor = Color.Black;
            btnAdicionarJuri.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAdicionarJuri.IconColor = Color.Black;
            btnAdicionarJuri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdicionarJuri.Location = new Point(453, 519);
            btnAdicionarJuri.Name = "btnAdicionarJuri";
            btnAdicionarJuri.Size = new Size(111, 85);
            btnAdicionarJuri.TabIndex = 37;
            btnAdicionarJuri.Text = "Adicionar";
            btnAdicionarJuri.UseVisualStyleBackColor = false;
            btnAdicionarJuri.Click += btnAdicionarJuri_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(178, 488);
            label2.Name = "label2";
            label2.Size = new Size(264, 28);
            label2.TabIndex = 38;
            label2.Text = "Adicionar membros do Juri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(107, 549);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 39;
            label3.Text = "Nome Juri";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Location = new Point(14, 453);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(751, 13);
            panel1.TabIndex = 41;
            // 
            // Frm_Edicao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(800, 652);
            Controls.Add(panel1);
            Controls.Add(Txt_NomeJuri);
            Controls.Add(btnAdicionarJuri);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(Dt_Edicao);
            Controls.Add(Dt_Eventos);
            Controls.Add(Msk_Data);
            Controls.Add(Txt_Nome);
            Controls.Add(Btn_Enviar);
            Controls.Add(Txt_AnoIni);
            Controls.Add(Lbl_Nome);
            Controls.Add(Txt_Local);
            Controls.Add(Lbl_AnoEdicao);
            Controls.Add(Lbl_Localizacao);
            Controls.Add(label1);
            Controls.Add(Lbl_TodosEventos);
            Controls.Add(Lbl_Data);
            Name = "Frm_Edicao";
            Text = "Frm_Premio";
            ((System.ComponentModel.ISupportInitialize)Dt_Eventos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dt_Edicao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Nome;
        private FontAwesome.Sharp.IconButton Btn_Enviar;
        private TextBox Txt_AnoIni;
        private Label Lbl_Nome;
        private TextBox Txt_Local;
        private Label Lbl_AnoEdicao;
        private Label Lbl_Localizacao;
        private Label Lbl_Data;
        private MaskedTextBox Msk_Data;
        private DataGridView Dt_Eventos;
        private Label Lbl_TodosEventos;
        private Label label1;
        private DataGridView Dt_Edicao;
        private TextBox Txt_NomeJuri;
        private FontAwesome.Sharp.IconButton btnAdicionarJuri;
        private Label label2;
        private Label label3;
        private Panel panel1;
    }
}
namespace MisPeliculas.Informacoes
{
    partial class Frm_AtorFilmeNominadoVencedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AtorFilmeNominadoVencedor));
            Dt_AtoresAtrizesNominados = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            Cmb_Evento = new ComboBox();
            Cmb_Edicao = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            Cmb_Premio = new ComboBox();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)Dt_AtoresAtrizesNominados).BeginInit();
            SuspendLayout();
            // 
            // Dt_AtoresAtrizesNominados
            // 
            Dt_AtoresAtrizesNominados.AllowUserToAddRows = false;
            Dt_AtoresAtrizesNominados.AllowUserToDeleteRows = false;
            Dt_AtoresAtrizesNominados.AllowUserToOrderColumns = true;
            Dt_AtoresAtrizesNominados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Dt_AtoresAtrizesNominados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_AtoresAtrizesNominados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dt_AtoresAtrizesNominados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_AtoresAtrizesNominados.Location = new Point(70, 167);
            Dt_AtoresAtrizesNominados.Name = "Dt_AtoresAtrizesNominados";
            Dt_AtoresAtrizesNominados.RowHeadersVisible = false;
            Dt_AtoresAtrizesNominados.RowHeadersWidth = 51;
            Dt_AtoresAtrizesNominados.RowTemplate.Height = 29;
            Dt_AtoresAtrizesNominados.Size = new Size(658, 250);
            Dt_AtoresAtrizesNominados.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(97, 24);
            label1.Name = "label1";
            label1.Size = new Size(616, 25);
            label1.TabIndex = 39;
            label1.Text = "Lista dos Atores ou Filmes Nominados e Premiados de Acordo com o Prêmio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(70, 65);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 41;
            label2.Text = "Evento";
            // 
            // Cmb_Evento
            // 
            Cmb_Evento.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Evento.FormattingEnabled = true;
            Cmb_Evento.Location = new Point(141, 62);
            Cmb_Evento.Name = "Cmb_Evento";
            Cmb_Evento.Size = new Size(126, 28);
            Cmb_Evento.TabIndex = 42;
            Cmb_Evento.SelectedIndexChanged += Cmb_Evento_SelectedIndexChanged;
            // 
            // Cmb_Edicao
            // 
            Cmb_Edicao.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Edicao.Enabled = false;
            Cmb_Edicao.FormattingEnabled = true;
            Cmb_Edicao.Location = new Point(375, 62);
            Cmb_Edicao.Name = "Cmb_Edicao";
            Cmb_Edicao.Size = new Size(126, 28);
            Cmb_Edicao.TabIndex = 44;
            Cmb_Edicao.SelectedIndexChanged += Cmb_Edicao_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(304, 65);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 43;
            label3.Text = "Edição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(531, 65);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 43;
            label4.Text = "Prêmio";
            // 
            // Cmb_Premio
            // 
            Cmb_Premio.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Premio.Enabled = false;
            Cmb_Premio.FormattingEnabled = true;
            Cmb_Premio.Location = new Point(602, 62);
            Cmb_Premio.Name = "Cmb_Premio";
            Cmb_Premio.Size = new Size(126, 28);
            Cmb_Premio.TabIndex = 44;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(255, 201, 14);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnSalvar.Location = new Point(70, 110);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(658, 38);
            btnSalvar.TabIndex = 45;
            btnSalvar.Text = "Buscar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Frm_AtorFilmeNominadoVencedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(Cmb_Premio);
            Controls.Add(label4);
            Controls.Add(Cmb_Edicao);
            Controls.Add(label3);
            Controls.Add(Cmb_Evento);
            Controls.Add(label2);
            Controls.Add(Dt_AtoresAtrizesNominados);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_AtorFilmeNominadoVencedor";
            Text = "Informações de Prêmios";
            ((System.ComponentModel.ISupportInitialize)Dt_AtoresAtrizesNominados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Dt_AtoresAtrizesNominados;
        private Label label1;
        private Label label2;
        private ComboBox Cmb_Evento;
        private ComboBox Cmb_Edicao;
        private Label label3;
        private Label label4;
        private ComboBox Cmb_Premio;
        private Button btnSalvar;
    }
}
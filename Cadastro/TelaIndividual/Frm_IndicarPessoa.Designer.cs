namespace MisPeliculas.Cadastro.TelaIndividual
{
    partial class Frm_IndicarPessoa
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
            btnSalvar = new Button();
            txtNomeArt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_NomeEvento = new TextBox();
            label8 = new Label();
            label5 = new Label();
            txt_IdFilme = new TextBox();
            txtAnoEdicao = new TextBox();
            lbl_IdFilme = new Label();
            cmb_Ganhou = new ComboBox();
            txt_Tipo = new ComboBox();
            lbl_tipo = new Label();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(255, 201, 14);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(707, 45);
            btnSalvar.Margin = new Padding(3, 5, 3, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(131, 113);
            btnSalvar.TabIndex = 58;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNomeArt
            // 
            txtNomeArt.Location = new Point(225, 45);
            txtNomeArt.Margin = new Padding(3, 5, 3, 5);
            txtNomeArt.Name = "txtNomeArt";
            txtNomeArt.Size = new Size(114, 27);
            txtNomeArt.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(53, 45);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 43;
            label1.Text = "Nome Artistico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(70, 147);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 44;
            label2.Text = "Nome Evento";
            // 
            // txt_NomeEvento
            // 
            txt_NomeEvento.Location = new Point(225, 147);
            txt_NomeEvento.Margin = new Padding(3, 5, 3, 5);
            txt_NomeEvento.Name = "txt_NomeEvento";
            txt_NomeEvento.Size = new Size(114, 27);
            txt_NomeEvento.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(423, 143);
            label8.Name = "label8";
            label8.Size = new Size(85, 28);
            label8.TabIndex = 53;
            label8.Text = "Ganhou";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(79, 95);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 52;
            label5.Text = "Ano Edição";
            // 
            // txt_IdFilme
            // 
            txt_IdFilme.Location = new Point(541, 45);
            txt_IdFilme.Margin = new Padding(3, 5, 3, 5);
            txt_IdFilme.Name = "txt_IdFilme";
            txt_IdFilme.Size = new Size(114, 27);
            txt_IdFilme.TabIndex = 49;
            // 
            // txtAnoEdicao
            // 
            txtAnoEdicao.Location = new Point(225, 99);
            txtAnoEdicao.Margin = new Padding(3, 5, 3, 5);
            txtAnoEdicao.Name = "txtAnoEdicao";
            txtAnoEdicao.Size = new Size(114, 27);
            txtAnoEdicao.TabIndex = 51;
            // 
            // lbl_IdFilme
            // 
            lbl_IdFilme.AutoSize = true;
            lbl_IdFilme.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_IdFilme.ForeColor = SystemColors.ButtonShadow;
            lbl_IdFilme.Location = new Point(422, 45);
            lbl_IdFilme.Name = "lbl_IdFilme";
            lbl_IdFilme.Size = new Size(86, 28);
            lbl_IdFilme.TabIndex = 50;
            lbl_IdFilme.Text = "Id Filme";
            // 
            // cmb_Ganhou
            // 
            cmb_Ganhou.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Ganhou.FormattingEnabled = true;
            cmb_Ganhou.Items.AddRange(new object[] { "Sim", "Não" });
            cmb_Ganhou.Location = new Point(541, 143);
            cmb_Ganhou.Margin = new Padding(3, 4, 3, 4);
            cmb_Ganhou.Name = "cmb_Ganhou";
            cmb_Ganhou.Size = new Size(114, 28);
            cmb_Ganhou.TabIndex = 59;
            // 
            // txt_Tipo
            // 
            txt_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_Tipo.FormattingEnabled = true;
            txt_Tipo.Items.AddRange(new object[] { "Melhor Ator Principal", "Melhor Ator Elenco", "Melhor Diretor", "Melhor Roteiro Original", "Melhor Roteiro Adaptado", "Melhor Produção" });
            txt_Tipo.Location = new Point(541, 95);
            txt_Tipo.Margin = new Padding(3, 4, 3, 4);
            txt_Tipo.Name = "txt_Tipo";
            txt_Tipo.Size = new Size(114, 28);
            txt_Tipo.TabIndex = 61;
            // 
            // lbl_tipo
            // 
            lbl_tipo.AutoSize = true;
            lbl_tipo.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_tipo.ForeColor = SystemColors.ButtonShadow;
            lbl_tipo.Location = new Point(460, 91);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(53, 28);
            lbl_tipo.TabIndex = 60;
            lbl_tipo.Text = "Tipo";
            // 
            // Frm_IndicarPessoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(914, 600);
            Controls.Add(txt_Tipo);
            Controls.Add(lbl_tipo);
            Controls.Add(cmb_Ganhou);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeArt);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txt_NomeEvento);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(txt_IdFilme);
            Controls.Add(txtAnoEdicao);
            Controls.Add(lbl_IdFilme);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_IndicarPessoa";
            Text = "Frm_Premiacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalvar;
        private TextBox txtNomeArt;
        private ComboBox txtSituacao;
        private Label label1;
        private ComboBox txtSexo;
        private Label label2;
        private Label label7;
        private TextBox txt_NomeEvento;
        private TextBox txtTotalAnos;
        private Label label3;
        private Label label8;
        private Label label5;
        private TextBox txt_IdFilme;
        private TextBox txtAnoEdicao;
        private Label lbl_IdFilme;
        private ComboBox cmb_Ganhou;
        private ComboBox txt_Tipo;
        private Label lbl_tipo;
    }
}
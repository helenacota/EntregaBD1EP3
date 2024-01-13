namespace MisPeliculas.Cadastro.TelaIndividual
{
    partial class Frm_IndicarFilme
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
            cmb_Ganhou = new ComboBox();
            btnSalvar = new Button();
            label2 = new Label();
            txt_NomeEvento = new TextBox();
            label8 = new Label();
            lbl_tipo = new Label();
            label5 = new Label();
            txt_IdFilme = new TextBox();
            txtAnoEdicao = new TextBox();
            lbl_IdFilme = new Label();
            txt_Tipo = new ComboBox();
            SuspendLayout();
            // 
            // cmb_Ganhou
            // 
            cmb_Ganhou.FormattingEnabled = true;
            cmb_Ganhou.Items.AddRange(new object[] { "Sim", "Não" });
            cmb_Ganhou.Location = new Point(567, 101);
            cmb_Ganhou.Margin = new Padding(3, 4, 3, 4);
            cmb_Ganhou.Name = "cmb_Ganhou";
            cmb_Ganhou.Size = new Size(114, 28);
            cmb_Ganhou.TabIndex = 72;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(255, 201, 14);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(735, 53);
            btnSalvar.Margin = new Padding(3, 5, 3, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(131, 113);
            btnSalvar.TabIndex = 71;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(97, 155);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 62;
            label2.Text = "Nome Evento";
            // 
            // txt_NomeEvento
            // 
            txt_NomeEvento.Location = new Point(253, 155);
            txt_NomeEvento.Margin = new Padding(3, 5, 3, 5);
            txt_NomeEvento.Name = "txt_NomeEvento";
            txt_NomeEvento.Size = new Size(114, 27);
            txt_NomeEvento.TabIndex = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(449, 101);
            label8.Name = "label8";
            label8.Size = new Size(85, 28);
            label8.TabIndex = 70;
            label8.Text = "Ganhou";
            // 
            // lbl_tipo
            // 
            lbl_tipo.AutoSize = true;
            lbl_tipo.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_tipo.ForeColor = SystemColors.ButtonShadow;
            lbl_tipo.Location = new Point(171, 103);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(53, 28);
            lbl_tipo.TabIndex = 65;
            lbl_tipo.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(422, 49);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 69;
            label5.Text = "Ano Edição";
            // 
            // txt_IdFilme
            // 
            txt_IdFilme.Location = new Point(253, 53);
            txt_IdFilme.Margin = new Padding(3, 5, 3, 5);
            txt_IdFilme.Name = "txt_IdFilme";
            txt_IdFilme.Size = new Size(114, 27);
            txt_IdFilme.TabIndex = 66;
            // 
            // txtAnoEdicao
            // 
            txtAnoEdicao.Location = new Point(567, 53);
            txtAnoEdicao.Margin = new Padding(3, 5, 3, 5);
            txtAnoEdicao.Name = "txtAnoEdicao";
            txtAnoEdicao.Size = new Size(114, 27);
            txtAnoEdicao.TabIndex = 68;
            // 
            // lbl_IdFilme
            // 
            lbl_IdFilme.AutoSize = true;
            lbl_IdFilme.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_IdFilme.ForeColor = SystemColors.ButtonShadow;
            lbl_IdFilme.Location = new Point(134, 53);
            lbl_IdFilme.Name = "lbl_IdFilme";
            lbl_IdFilme.Size = new Size(86, 28);
            lbl_IdFilme.TabIndex = 67;
            lbl_IdFilme.Text = "Id Filme";
            // 
            // txt_Tipo
            // 
            txt_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_Tipo.FormattingEnabled = true;
            txt_Tipo.Items.AddRange(new object[] { "Melhor Documentário", "Melhor Filme" });
            txt_Tipo.Location = new Point(253, 105);
            txt_Tipo.Margin = new Padding(3, 4, 3, 4);
            txt_Tipo.Name = "txt_Tipo";
            txt_Tipo.Size = new Size(114, 28);
            txt_Tipo.TabIndex = 73;
            // 
            // Frm_IndicarFilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(914, 600);
            Controls.Add(txt_Tipo);
            Controls.Add(cmb_Ganhou);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(txt_NomeEvento);
            Controls.Add(label8);
            Controls.Add(lbl_tipo);
            Controls.Add(label5);
            Controls.Add(txt_IdFilme);
            Controls.Add(txtAnoEdicao);
            Controls.Add(lbl_IdFilme);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_IndicarFilme";
            Text = "Frm_Indicacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_Ganhou;
        private Button btnSalvar;
        private Label label2;
        private TextBox txt_NomeEvento;
        private Label label8;
        private Label lbl_tipo;
        private Label label5;
        private TextBox txt_IdFilme;
        private TextBox txtAnoEdicao;
        private Label lbl_IdFilme;
        private ComboBox txt_Tipo;
    }
}
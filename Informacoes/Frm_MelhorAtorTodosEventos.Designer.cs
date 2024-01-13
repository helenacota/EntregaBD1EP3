namespace MisPeliculas.Informacoes
{
    partial class Frm_MelhorAtorTodosEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MelhorAtorTodosEventos));
            label1 = new Label();
            Dt_AtoresAtrizesNominados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Dt_AtoresAtrizesNominados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(36, 51);
            label1.Name = "label1";
            label1.Size = new Size(716, 25);
            label1.TabIndex = 0;
            label1.Text = "Lista dos Atores e Atrizes nominados como melhor ator em todos os eventos existentes. ";
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
            Dt_AtoresAtrizesNominados.Location = new Point(100, 135);
            Dt_AtoresAtrizesNominados.Name = "Dt_AtoresAtrizesNominados";
            Dt_AtoresAtrizesNominados.RowHeadersVisible = false;
            Dt_AtoresAtrizesNominados.RowHeadersWidth = 51;
            Dt_AtoresAtrizesNominados.RowTemplate.Height = 29;
            Dt_AtoresAtrizesNominados.Size = new Size(607, 276);
            Dt_AtoresAtrizesNominados.TabIndex = 38;
            // 
            // Frm_MelhorAtorTodosEventos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(800, 450);
            Controls.Add(Dt_AtoresAtrizesNominados);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_MelhorAtorTodosEventos";
            Text = "Informações de Todos os Eventos";
            ((System.ComponentModel.ISupportInitialize)Dt_AtoresAtrizesNominados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView Dt_AtoresAtrizesNominados;
    }
}
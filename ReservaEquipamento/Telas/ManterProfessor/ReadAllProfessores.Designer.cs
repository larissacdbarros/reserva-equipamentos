namespace ReservaEquipamento.Telas.ManterProfessor
{
    partial class ReadAllProfessores
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
            this.btnExcluirEquipamento = new System.Windows.Forms.Button();
            this.btnEditarEquipamento = new System.Windows.Forms.Button();
            this.listBoxListaProfessores = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExcluirEquipamento
            // 
            this.btnExcluirEquipamento.Location = new System.Drawing.Point(540, 250);
            this.btnExcluirEquipamento.Name = "btnExcluirEquipamento";
            this.btnExcluirEquipamento.Size = new System.Drawing.Size(120, 26);
            this.btnExcluirEquipamento.TabIndex = 10;
            this.btnExcluirEquipamento.Text = "EXCLUIR";
            this.btnExcluirEquipamento.UseVisualStyleBackColor = true;
            // 
            // btnEditarEquipamento
            // 
            this.btnEditarEquipamento.Location = new System.Drawing.Point(540, 218);
            this.btnEditarEquipamento.Name = "btnEditarEquipamento";
            this.btnEditarEquipamento.Size = new System.Drawing.Size(120, 26);
            this.btnEditarEquipamento.TabIndex = 11;
            this.btnEditarEquipamento.Text = "EDITAR";
            this.btnEditarEquipamento.UseVisualStyleBackColor = true;
            // 
            // listBoxListaProfessores
            // 
            this.listBoxListaProfessores.FormattingEnabled = true;
            this.listBoxListaProfessores.ItemHeight = 20;
            this.listBoxListaProfessores.Location = new System.Drawing.Point(102, 110);
            this.listBoxListaProfessores.Name = "listBoxListaProfessores";
            this.listBoxListaProfessores.Size = new System.Drawing.Size(309, 324);
            this.listBoxListaProfessores.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "PROFESSORES CADASTRADOS NO SISTEMA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(540, 282);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(120, 26);
            this.btnRetornar.TabIndex = 12;
            this.btnRetornar.Text = "RETORNAR";
            this.btnRetornar.UseVisualStyleBackColor = true;
            // 
            // ReadAllProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnExcluirEquipamento);
            this.Controls.Add(this.btnEditarEquipamento);
            this.Controls.Add(this.listBoxListaProfessores);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReadAllProfessores";
            this.Text = "ReadAllProfessores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirEquipamento;
        private System.Windows.Forms.Button btnEditarEquipamento;
        private System.Windows.Forms.ListBox listBoxListaProfessores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRetornar;
    }
}
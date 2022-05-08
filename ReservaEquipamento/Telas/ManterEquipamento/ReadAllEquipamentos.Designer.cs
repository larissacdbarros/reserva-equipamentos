namespace ReservaEquipamento.Telas.ManterEquipamento
{
    partial class ReadAllEquipamentos
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
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxListaEquipamentos = new System.Windows.Forms.ListBox();
            this.btnExcluirEquipamento = new System.Windows.Forms.Button();
            this.btnEditarEquipamento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(515, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "EQUIPAMENTOS CADASTRADOS NO SISTEMA";
            // 
            // listBoxListaEquipamentos
            // 
            this.listBoxListaEquipamentos.FormattingEnabled = true;
            this.listBoxListaEquipamentos.ItemHeight = 20;
            this.listBoxListaEquipamentos.Location = new System.Drawing.Point(64, 89);
            this.listBoxListaEquipamentos.Name = "listBoxListaEquipamentos";
            this.listBoxListaEquipamentos.Size = new System.Drawing.Size(309, 324);
            this.listBoxListaEquipamentos.TabIndex = 5;
            // 
            // btnExcluirEquipamento
            // 
            this.btnExcluirEquipamento.Location = new System.Drawing.Point(502, 229);
            this.btnExcluirEquipamento.Name = "btnExcluirEquipamento";
            this.btnExcluirEquipamento.Size = new System.Drawing.Size(120, 26);
            this.btnExcluirEquipamento.TabIndex = 6;
            this.btnExcluirEquipamento.Text = "EXCLUIR";
            this.btnExcluirEquipamento.UseVisualStyleBackColor = true;
            // 
            // btnEditarEquipamento
            // 
            this.btnEditarEquipamento.Location = new System.Drawing.Point(502, 197);
            this.btnEditarEquipamento.Name = "btnEditarEquipamento";
            this.btnEditarEquipamento.Size = new System.Drawing.Size(120, 26);
            this.btnEditarEquipamento.TabIndex = 7;
            this.btnEditarEquipamento.Text = "EDITAR";
            this.btnEditarEquipamento.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(502, 261);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(120, 26);
            this.btnRetornar.TabIndex = 6;
            this.btnRetornar.Text = "RETORNAR";
            this.btnRetornar.UseVisualStyleBackColor = true;
            // 
            // ReadAllEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExcluirEquipamento);
            this.Controls.Add(this.btnEditarEquipamento);
            this.Controls.Add(this.listBoxListaEquipamentos);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReadAllEquipamentos";
            this.Text = "ListarEquipamentos";
            this.Load += new System.EventHandler(this.ReadAllEquipamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxListaEquipamentos;
        private System.Windows.Forms.Button btnExcluirEquipamento;
        private System.Windows.Forms.Button btnEditarEquipamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRetornar;
    }
}
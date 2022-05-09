namespace ReservaEquipamento.Telas.MaterReservaEquipamento.ReadReserva
{
    partial class ReadAllReservas
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
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnExcluirReserva = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.listBoxListaMinhasReservas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(559, 285);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(120, 26);
            this.btnRetornar.TabIndex = 17;
            this.btnRetornar.Text = "RETORNAR";
            this.btnRetornar.UseVisualStyleBackColor = true;
            // 
            // btnExcluirReserva
            // 
            this.btnExcluirReserva.Location = new System.Drawing.Point(559, 253);
            this.btnExcluirReserva.Name = "btnExcluirReserva";
            this.btnExcluirReserva.Size = new System.Drawing.Size(120, 26);
            this.btnExcluirReserva.TabIndex = 15;
            this.btnExcluirReserva.Text = "EXCLUIR";
            this.btnExcluirReserva.UseVisualStyleBackColor = true;
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.Location = new System.Drawing.Point(559, 221);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(120, 26);
            this.btnEditarReserva.TabIndex = 16;
            this.btnEditarReserva.Text = "EDITAR";
            this.btnEditarReserva.UseVisualStyleBackColor = true;
            // 
            // listBoxListaMinhasReservas
            // 
            this.listBoxListaMinhasReservas.FormattingEnabled = true;
            this.listBoxListaMinhasReservas.ItemHeight = 20;
            this.listBoxListaMinhasReservas.Location = new System.Drawing.Point(121, 113);
            this.listBoxListaMinhasReservas.Name = "listBoxListaMinhasReservas";
            this.listBoxListaMinhasReservas.Size = new System.Drawing.Size(309, 324);
            this.listBoxListaMinhasReservas.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "MINHAS RESERVAS";
            // 
            // ReadAllReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnExcluirReserva);
            this.Controls.Add(this.btnEditarReserva);
            this.Controls.Add(this.listBoxListaMinhasReservas);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReadAllReservas";
            this.Text = "ReadAllReservas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnExcluirReserva;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.ListBox listBoxListaMinhasReservas;
        private System.Windows.Forms.Label label3;
    }
}
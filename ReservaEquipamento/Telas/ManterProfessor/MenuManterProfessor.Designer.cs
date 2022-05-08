namespace ReservaEquipamento.Telas.ManterProfessor
{
    partial class MenuManterProfessor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinhasReservas = new System.Windows.Forms.Button();
            this.btnNovaReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "MENU PROFESSOR";
            // 
            // btnMinhasReservas
            // 
            this.btnMinhasReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinhasReservas.Location = new System.Drawing.Point(246, 241);
            this.btnMinhasReservas.Name = "btnMinhasReservas";
            this.btnMinhasReservas.Size = new System.Drawing.Size(258, 43);
            this.btnMinhasReservas.TabIndex = 6;
            this.btnMinhasReservas.Text = "LISTAR PROFESSORES";
            this.btnMinhasReservas.UseVisualStyleBackColor = true;
            // 
            // btnNovaReserva
            // 
            this.btnNovaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaReserva.Location = new System.Drawing.Point(244, 177);
            this.btnNovaReserva.Name = "btnNovaReserva";
            this.btnNovaReserva.Size = new System.Drawing.Size(258, 43);
            this.btnNovaReserva.TabIndex = 7;
            this.btnNovaReserva.Text = "CADASTRAR PROFESSOR";
            this.btnNovaReserva.UseVisualStyleBackColor = true;
            // 
            // MenuManterProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinhasReservas);
            this.Controls.Add(this.btnNovaReserva);
            this.Name = "MenuManterProfessor";
            this.Text = "MenuManterProfessor";
            this.Load += new System.EventHandler(this.MenuManterProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinhasReservas;
        private System.Windows.Forms.Button btnNovaReserva;
    }
}
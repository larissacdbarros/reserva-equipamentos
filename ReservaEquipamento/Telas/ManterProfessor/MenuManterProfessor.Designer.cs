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
            this.btnListarProfessores = new System.Windows.Forms.Button();
            this.btnCadastrarProfessor = new System.Windows.Forms.Button();
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
            // btnListarProfessores
            // 
            this.btnListarProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProfessores.Location = new System.Drawing.Point(246, 241);
            this.btnListarProfessores.Name = "btnListarProfessores";
            this.btnListarProfessores.Size = new System.Drawing.Size(258, 43);
            this.btnListarProfessores.TabIndex = 6;
            this.btnListarProfessores.Text = "LISTAR PROFESSORES";
            this.btnListarProfessores.UseVisualStyleBackColor = true;
            this.btnListarProfessores.Click += new System.EventHandler(this.btnListarProfessores_Click);
            // 
            // btnCadastrarProfessor
            // 
            this.btnCadastrarProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProfessor.Location = new System.Drawing.Point(244, 177);
            this.btnCadastrarProfessor.Name = "btnCadastrarProfessor";
            this.btnCadastrarProfessor.Size = new System.Drawing.Size(258, 43);
            this.btnCadastrarProfessor.TabIndex = 7;
            this.btnCadastrarProfessor.Text = "CADASTRAR PROFESSOR";
            this.btnCadastrarProfessor.UseVisualStyleBackColor = true;
            this.btnCadastrarProfessor.Click += new System.EventHandler(this.btnCadastrarProfessor_Click);
            // 
            // MenuManterProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarProfessores);
            this.Controls.Add(this.btnCadastrarProfessor);
            this.Name = "MenuManterProfessor";
            this.Text = "MenuManterProfessor";
            this.Load += new System.EventHandler(this.MenuManterProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListarProfessores;
        private System.Windows.Forms.Button btnCadastrarProfessor;
    }
}
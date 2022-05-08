namespace ReservaEquipamento
{
    partial class MenuManterEquipamento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovaReserva = new System.Windows.Forms.Button();
            this.btnMinhasReservas = new System.Windows.Forms.Button();
            this.btnManterEquipamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovaReserva
            // 
            this.btnNovaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaReserva.Location = new System.Drawing.Point(254, 153);
            this.btnNovaReserva.Name = "btnNovaReserva";
            this.btnNovaReserva.Size = new System.Drawing.Size(227, 43);
            this.btnNovaReserva.TabIndex = 0;
            this.btnNovaReserva.Text = "NOVA RESERVA";
            this.btnNovaReserva.UseVisualStyleBackColor = true;
            this.btnNovaReserva.Click += new System.EventHandler(this.btnNovaReserva_Click);
            // 
            // btnMinhasReservas
            // 
            this.btnMinhasReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinhasReservas.Location = new System.Drawing.Point(254, 220);
            this.btnMinhasReservas.Name = "btnMinhasReservas";
            this.btnMinhasReservas.Size = new System.Drawing.Size(227, 43);
            this.btnMinhasReservas.TabIndex = 0;
            this.btnMinhasReservas.Text = "MINHA RESERVAS";
            this.btnMinhasReservas.UseVisualStyleBackColor = true;
            // 
            // btnManterEquipamento
            // 
            this.btnManterEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManterEquipamento.Location = new System.Drawing.Point(254, 279);
            this.btnManterEquipamento.Name = "btnManterEquipamento";
            this.btnManterEquipamento.Size = new System.Drawing.Size(227, 43);
            this.btnManterEquipamento.TabIndex = 0;
            this.btnManterEquipamento.Text = "MANTER EQUIPAMENTO";
            this.btnManterEquipamento.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(254, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "MANTER PROFESSOR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuManterEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnManterEquipamento);
            this.Controls.Add(this.btnMinhasReservas);
            this.Controls.Add(this.btnNovaReserva);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuManterEquipamento";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaReserva;
        private System.Windows.Forms.Button btnMinhasReservas;
        private System.Windows.Forms.Button btnManterEquipamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}


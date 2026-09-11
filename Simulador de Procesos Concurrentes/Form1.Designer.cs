namespace Simulador_de_Procesos_Concurrentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblEstado = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnReiniciar = new System.Windows.Forms.Button();
            this.ListbCohete = new System.Windows.Forms.ListBox();
            this.ListbEdificio = new System.Windows.Forms.ListBox();
            this.ListbVideojuegos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(265, 40);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(126, 16);
            this.LblEstado.TabIndex = 0;
            this.LblEstado.Text = "Estado : Esperando";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(198, 87);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(101, 51);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnReiniciar
            // 
            this.BtnReiniciar.Location = new System.Drawing.Point(331, 87);
            this.BtnReiniciar.Name = "BtnReiniciar";
            this.BtnReiniciar.Size = new System.Drawing.Size(101, 51);
            this.BtnReiniciar.TabIndex = 2;
            this.BtnReiniciar.Text = "Reiniciar";
            this.BtnReiniciar.UseVisualStyleBackColor = true;
            this.BtnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // ListbCohete
            // 
            this.ListbCohete.FormattingEnabled = true;
            this.ListbCohete.ItemHeight = 16;
            this.ListbCohete.Location = new System.Drawing.Point(12, 208);
            this.ListbCohete.Name = "ListbCohete";
            this.ListbCohete.Size = new System.Drawing.Size(185, 228);
            this.ListbCohete.TabIndex = 3;
            // 
            // ListbEdificio
            // 
            this.ListbEdificio.FormattingEnabled = true;
            this.ListbEdificio.ItemHeight = 16;
            this.ListbEdificio.Location = new System.Drawing.Point(228, 208);
            this.ListbEdificio.Name = "ListbEdificio";
            this.ListbEdificio.Size = new System.Drawing.Size(185, 228);
            this.ListbEdificio.TabIndex = 4;
            // 
            // ListbVideojuegos
            // 
            this.ListbVideojuegos.FormattingEnabled = true;
            this.ListbVideojuegos.ItemHeight = 16;
            this.ListbVideojuegos.Location = new System.Drawing.Point(437, 208);
            this.ListbVideojuegos.Name = "ListbVideojuegos";
            this.ListbVideojuegos.Size = new System.Drawing.Size(185, 228);
            this.ListbVideojuegos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cohete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edificio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Videojuegos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListbVideojuegos);
            this.Controls.Add(this.ListbEdificio);
            this.Controls.Add(this.ListbCohete);
            this.Controls.Add(this.BtnReiniciar);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.LblEstado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnReiniciar;
        private System.Windows.Forms.ListBox ListbCohete;
        private System.Windows.Forms.ListBox ListbEdificio;
        private System.Windows.Forms.ListBox ListbVideojuegos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


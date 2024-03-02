namespace Ejemplo_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNumerosPunto = new System.Windows.Forms.TextBox();
            this.txbLetras = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Números y punto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Letras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // txbNumerosPunto
            // 
            this.txbNumerosPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumerosPunto.Location = new System.Drawing.Point(260, 71);
            this.txbNumerosPunto.Name = "txbNumerosPunto";
            this.txbNumerosPunto.Size = new System.Drawing.Size(268, 27);
            this.txbNumerosPunto.TabIndex = 3;
            this.txbNumerosPunto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumerosPunto_KeyPress);
            // 
            // txbLetras
            // 
            this.txbLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLetras.Location = new System.Drawing.Point(260, 148);
            this.txbLetras.Name = "txbLetras";
            this.txbLetras.Size = new System.Drawing.Size(268, 27);
            this.txbLetras.TabIndex = 4;
            this.txbLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLetras_KeyPress);
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(260, 225);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(268, 27);
            this.txbEmail.TabIndex = 5;
            this.txbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEmail_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 294);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbLetras);
            this.Controls.Add(this.txbNumerosPunto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNumerosPunto;
        private System.Windows.Forms.TextBox txbLetras;
        private System.Windows.Forms.TextBox txbEmail;
    }
}


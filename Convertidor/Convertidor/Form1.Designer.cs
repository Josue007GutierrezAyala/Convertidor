namespace Convertidor
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
            this.Centigrados = new System.Windows.Forms.Label();
            this.Faherenheit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Centigrados
            // 
            this.Centigrados.AutoSize = true;
            this.Centigrados.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Centigrados.Location = new System.Drawing.Point(41, 94);
            this.Centigrados.Name = "Centigrados";
            this.Centigrados.Size = new System.Drawing.Size(147, 23);
            this.Centigrados.TabIndex = 0;
            this.Centigrados.Text = "Grados centigrados";
            this.Centigrados.Click += new System.EventHandler(this.Centigrados_Click);
            // 
            // Faherenheit
            // 
            this.Faherenheit.AutoSize = true;
            this.Faherenheit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Faherenheit.Location = new System.Drawing.Point(42, 142);
            this.Faherenheit.Name = "Faherenheit";
            this.Faherenheit.Size = new System.Drawing.Size(150, 23);
            this.Faherenheit.TabIndex = 1;
            this.Faherenheit.Text = "Grados Faherenheit";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(194, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 29);
            this.textBox1.TabIndex = 2;
     
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(194, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 29);
            this.textBox2.TabIndex = 3;
           
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Faherenheit);
            this.Controls.Add(this.Centigrados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Centigrados;
        private System.Windows.Forms.Label Faherenheit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}


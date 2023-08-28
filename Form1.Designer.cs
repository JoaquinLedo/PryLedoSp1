namespace PryLedoSp1
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
            this.BtnArchivo = new System.Windows.Forms.Button();
            this.BtnLeer = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.Txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnArchivo
            // 
            this.BtnArchivo.Location = new System.Drawing.Point(12, 221);
            this.BtnArchivo.Name = "BtnArchivo";
            this.BtnArchivo.Size = new System.Drawing.Size(114, 37);
            this.BtnArchivo.TabIndex = 0;
            this.BtnArchivo.Text = "Crear Archivo";
            this.BtnArchivo.UseVisualStyleBackColor = true;
            this.BtnArchivo.Click += new System.EventHandler(this.BtnArchivo_Click);
            // 
            // BtnLeer
            // 
            this.BtnLeer.Location = new System.Drawing.Point(181, 221);
            this.BtnLeer.Name = "BtnLeer";
            this.BtnLeer.Size = new System.Drawing.Size(114, 37);
            this.BtnLeer.TabIndex = 1;
            this.BtnLeer.Text = "Leer Archivo";
            this.BtnLeer.UseVisualStyleBackColor = true;
            this.BtnLeer.Click += new System.EventHandler(this.BtnLeer_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Location = new System.Drawing.Point(96, 178);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(114, 37);
            this.BtnGrabar.TabIndex = 2;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // Txt
            // 
            this.Txt.Location = new System.Drawing.Point(36, 12);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(236, 20);
            this.Txt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 270);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.BtnLeer);
            this.Controls.Add(this.BtnArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnArchivo;
        private System.Windows.Forms.Button BtnLeer;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.TextBox Txt;
    }
}


namespace Ejercicio1
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
            this.tbVer = new System.Windows.Forms.TextBox();
            this.btProcesar = new System.Windows.Forms.Button();
            this.rbString = new System.Windows.Forms.RadioButton();
            this.rbRegex = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ver";
            // 
            // tbVer
            // 
            this.tbVer.Location = new System.Drawing.Point(12, 29);
            this.tbVer.Multiline = true;
            this.tbVer.Name = "tbVer";
            this.tbVer.ReadOnly = true;
            this.tbVer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbVer.Size = new System.Drawing.Size(550, 173);
            this.tbVer.TabIndex = 1;
            // 
            // btProcesar
            // 
            this.btProcesar.Location = new System.Drawing.Point(568, 29);
            this.btProcesar.Name = "btProcesar";
            this.btProcesar.Size = new System.Drawing.Size(117, 82);
            this.btProcesar.TabIndex = 2;
            this.btProcesar.Text = "Procesar";
            this.btProcesar.UseVisualStyleBackColor = true;
            this.btProcesar.Click += new System.EventHandler(this.btProcesar_Click);
            // 
            // rbString
            // 
            this.rbString.AutoSize = true;
            this.rbString.Location = new System.Drawing.Point(582, 130);
            this.rbString.Name = "rbString";
            this.rbString.Size = new System.Drawing.Size(52, 17);
            this.rbString.TabIndex = 3;
            this.rbString.TabStop = true;
            this.rbString.Text = "String";
            this.rbString.UseVisualStyleBackColor = true;
            // 
            // rbRegex
            // 
            this.rbRegex.AutoSize = true;
            this.rbRegex.Location = new System.Drawing.Point(582, 164);
            this.rbRegex.Name = "rbRegex";
            this.rbRegex.Size = new System.Drawing.Size(56, 17);
            this.rbRegex.TabIndex = 4;
            this.rbRegex.TabStop = true;
            this.rbRegex.Text = "Regex";
            this.rbRegex.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 219);
            this.Controls.Add(this.rbRegex);
            this.Controls.Add(this.rbString);
            this.Controls.Add(this.btProcesar);
            this.Controls.Add(this.tbVer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVer;
        private System.Windows.Forms.Button btProcesar;
        private System.Windows.Forms.RadioButton rbString;
        private System.Windows.Forms.RadioButton rbRegex;
    }
}


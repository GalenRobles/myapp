namespace myapp
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.BtnProceso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(224, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(79, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "NOMBRE";
            this.txtNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(228, 100);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(284, 26);
            this.txtbox.TabIndex = 1;
            // 
            // BtnProceso
            // 
            this.BtnProceso.Location = new System.Drawing.Point(228, 190);
            this.BtnProceso.Name = "BtnProceso";
            this.BtnProceso.Size = new System.Drawing.Size(284, 53);
            this.BtnProceso.TabIndex = 2;
            this.BtnProceso.Text = "Enviar";
            this.BtnProceso.UseVisualStyleBackColor = true;
            this.BtnProceso.Click += new System.EventHandler(this.BtnProceso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnProceso);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button BtnProceso;
    }
}


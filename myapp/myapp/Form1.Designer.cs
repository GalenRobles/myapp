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
            this.components = new System.ComponentModel.Container();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.lblRelog = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblEjecucion = new System.Windows.Forms.Label();
            this.btnEncender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmrReloj
            // 
            this.tmrReloj.Interval = 1000;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // lblRelog
            // 
            this.lblRelog.AutoSize = true;
            this.lblRelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelog.Location = new System.Drawing.Point(115, 187);
            this.lblRelog.Name = "lblRelog";
            this.lblRelog.Size = new System.Drawing.Size(75, 82);
            this.lblRelog.TabIndex = 0;
            this.lblRelog.Text = "0";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(115, 28);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(75, 82);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "0";
            // 
            // lblEjecucion
            // 
            this.lblEjecucion.AutoSize = true;
            this.lblEjecucion.Location = new System.Drawing.Point(97, 349);
            this.lblEjecucion.Name = "lblEjecucion";
            this.lblEjecucion.Size = new System.Drawing.Size(156, 20);
            this.lblEjecucion.TabIndex = 3;
            this.lblEjecucion.Text = "Tiempo en Ejecucion";
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(685, 385);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(103, 39);
            this.btnEncender.TabIndex = 4;
            this.btnEncender.Text = "Encender";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.lblEjecucion);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblRelog);
            this.Name = "Form1";
            this.Text = "Temporizador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.Label lblRelog;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblEjecucion;
        private System.Windows.Forms.Button btnEncender;
    }
}


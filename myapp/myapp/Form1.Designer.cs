namespace myapp
{
    partial class frmVideoclub
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPeliculas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripSocios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSocios = new System.Windows.Forms.ToolStripMenuItem();
            this.rentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.agendaToolStripMenuItem,
            this.MenuStripSocios,
            this.rentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(88, 30);
            this.mnuArchivo.Text = "Archivo";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(270, 34);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPeliculas});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(93, 30);
            this.agendaToolStripMenuItem.Text = "Peliculas";
            // 
            // mnuPeliculas
            // 
            this.mnuPeliculas.Name = "mnuPeliculas";
            this.mnuPeliculas.Size = new System.Drawing.Size(270, 34);
            this.mnuPeliculas.Text = "Catalogo Peliculas";
            this.mnuPeliculas.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // MenuStripSocios
            // 
            this.MenuStripSocios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSocios});
            this.MenuStripSocios.Name = "MenuStripSocios";
            this.MenuStripSocios.Size = new System.Drawing.Size(80, 30);
            this.MenuStripSocios.Text = "Socios";
            // 
            // mnuSocios
            // 
            this.mnuSocios.Name = "mnuSocios";
            this.mnuSocios.Size = new System.Drawing.Size(270, 34);
            this.mnuSocios.Text = "Socios Registrados";
            this.mnuSocios.Click += new System.EventHandler(this.sociosRegistradosToolStripMenuItem_Click);
            // 
            // rentasToolStripMenuItem
            // 
            this.rentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRentas});
            this.rentasToolStripMenuItem.Name = "rentasToolStripMenuItem";
            this.rentasToolStripMenuItem.Size = new System.Drawing.Size(80, 30);
            this.rentasToolStripMenuItem.Text = "Rentas";
            // 
            // mnuRentas
            // 
            this.mnuRentas.Name = "mnuRentas";
            this.mnuRentas.Size = new System.Drawing.Size(270, 34);
            this.mnuRentas.Text = "Rentas Informacion";
            this.mnuRentas.Click += new System.EventHandler(this.rentasInformacionToolStripMenuItem_Click);
            // 
            // frmVideoclub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmVideoclub";
            this.Text = "VideoClub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPeliculas;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem MenuStripSocios;
        private System.Windows.Forms.ToolStripMenuItem mnuSocios;
        private System.Windows.Forms.ToolStripMenuItem rentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRentas;
    }
}


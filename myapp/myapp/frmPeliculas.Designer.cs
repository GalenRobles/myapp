namespace myapp
{
    partial class frmPeliculas
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
            this.txtPeliculaNombre = new System.Windows.Forms.TextBox();
            this.btnPeliculaAgregar = new System.Windows.Forms.Button();
            this.btnPeliculaEliminar = new System.Windows.Forms.Button();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.IdPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtPeliculaNombre
            // 
            this.txtPeliculaNombre.Location = new System.Drawing.Point(116, 113);
            this.txtPeliculaNombre.Name = "txtPeliculaNombre";
            this.txtPeliculaNombre.Size = new System.Drawing.Size(186, 26);
            this.txtPeliculaNombre.TabIndex = 1;
            // 
            // btnPeliculaAgregar
            // 
            this.btnPeliculaAgregar.Location = new System.Drawing.Point(336, 110);
            this.btnPeliculaAgregar.Name = "btnPeliculaAgregar";
            this.btnPeliculaAgregar.Size = new System.Drawing.Size(104, 29);
            this.btnPeliculaAgregar.TabIndex = 2;
            this.btnPeliculaAgregar.Text = "Agregar";
            this.btnPeliculaAgregar.UseVisualStyleBackColor = true;
            this.btnPeliculaAgregar.Click += new System.EventHandler(this.btnPeliculaAgregar_Click);
            // 
            // btnPeliculaEliminar
            // 
            this.btnPeliculaEliminar.Location = new System.Drawing.Point(581, 108);
            this.btnPeliculaEliminar.Name = "btnPeliculaEliminar";
            this.btnPeliculaEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnPeliculaEliminar.TabIndex = 3;
            this.btnPeliculaEliminar.Text = "Eliminar";
            this.btnPeliculaEliminar.UseVisualStyleBackColor = true;
            this.btnPeliculaEliminar.Click += new System.EventHandler(this.btnPeliculaEliminar_Click);
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPelicula,
            this.Nombre});
            this.dgvPeliculas.Location = new System.Drawing.Point(37, 199);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.ReadOnly = true;
            this.dgvPeliculas.RowHeadersWidth = 62;
            this.dgvPeliculas.RowTemplate.Height = 28;
            this.dgvPeliculas.Size = new System.Drawing.Size(549, 319);
            this.dgvPeliculas.TabIndex = 4;
            this.dgvPeliculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeliculas_CellClick);
            // 
            // IdPelicula
            // 
            this.IdPelicula.DataPropertyName = "IdPelicula";
            this.IdPelicula.HeaderText = "Id";
            this.IdPelicula.MinimumWidth = 8;
            this.IdPelicula.Name = "IdPelicula";
            this.IdPelicula.ReadOnly = true;
            this.IdPelicula.Visible = false;
            this.IdPelicula.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Pelicula";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "CATALOGO DE PELICULAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(468, 113);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 28);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 558);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.btnPeliculaEliminar);
            this.Controls.Add(this.btnPeliculaAgregar);
            this.Controls.Add(this.txtPeliculaNombre);
            this.Controls.Add(this.label1);
            this.Name = "frmPeliculas";
            this.Text = "frmPeliculas";
            this.Load += new System.EventHandler(this.frmPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeliculaNombre;
        private System.Windows.Forms.Button btnPeliculaAgregar;
        private System.Windows.Forms.Button btnPeliculaEliminar;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btnModificar;
    }
}
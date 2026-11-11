namespace myapp
{
    partial class frmSocios
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
            this.btnSocioEliminar = new System.Windows.Forms.Button();
            this.btnSocioAgregar = new System.Windows.Forms.Button();
            this.txtSocioNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSocioEliminar
            // 
            this.btnSocioEliminar.Location = new System.Drawing.Point(550, 105);
            this.btnSocioEliminar.Name = "btnSocioEliminar";
            this.btnSocioEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnSocioEliminar.TabIndex = 7;
            this.btnSocioEliminar.Text = "Eliminar";
            this.btnSocioEliminar.UseVisualStyleBackColor = true;
            this.btnSocioEliminar.Click += new System.EventHandler(this.btnSocioEliminar_Click);
            // 
            // btnSocioAgregar
            // 
            this.btnSocioAgregar.Location = new System.Drawing.Point(400, 106);
            this.btnSocioAgregar.Name = "btnSocioAgregar";
            this.btnSocioAgregar.Size = new System.Drawing.Size(104, 29);
            this.btnSocioAgregar.TabIndex = 6;
            this.btnSocioAgregar.Text = "Agregar";
            this.btnSocioAgregar.UseVisualStyleBackColor = true;
            this.btnSocioAgregar.Click += new System.EventHandler(this.btnSocioAgregar_Click);
            // 
            // txtSocioNombre
            // 
            this.txtSocioNombre.Location = new System.Drawing.Point(170, 109);
            this.txtSocioNombre.Name = "txtSocioNombre";
            this.txtSocioNombre.Size = new System.Drawing.Size(186, 26);
            this.txtSocioNombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // dgvSocios
            // 
            this.dgvSocios.AllowUserToAddRows = false;
            this.dgvSocios.AllowUserToDeleteRows = false;
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSocio,
            this.Nombre});
            this.dgvSocios.Location = new System.Drawing.Point(87, 179);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.ReadOnly = true;
            this.dgvSocios.RowHeadersWidth = 62;
            this.dgvSocios.RowTemplate.Height = 28;
            this.dgvSocios.Size = new System.Drawing.Size(549, 336);
            this.dgvSocios.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "CATALOGO DE SOCIOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "Id";
            this.IdSocio.MinimumWidth = 8;
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Visible = false;
            this.IdSocio.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSocios);
            this.Controls.Add(this.btnSocioEliminar);
            this.Controls.Add(this.btnSocioAgregar);
            this.Controls.Add(this.txtSocioNombre);
            this.Controls.Add(this.label1);
            this.Name = "frmSocios";
            this.Text = "frmSocios";
            this.Load += new System.EventHandler(this.frmSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSocioEliminar;
        private System.Windows.Forms.Button btnSocioAgregar;
        private System.Windows.Forms.TextBox txtSocioNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}
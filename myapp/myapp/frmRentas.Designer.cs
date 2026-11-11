namespace myapp
{
    partial class frmRentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSocio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.dgvRentasActivas = new System.Windows.Forms.DataGridView();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnRentar = new System.Windows.Forms.Button();
            this.IdRenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentasActivas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Socio";
            // 
            // cboSocio
            // 
            this.cboSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSocio.FormattingEnabled = true;
            this.cboSocio.Location = new System.Drawing.Point(127, 75);
            this.cboSocio.Name = "cboSocio";
            this.cboSocio.Size = new System.Drawing.Size(137, 28);
            this.cboSocio.TabIndex = 1;
            this.cboSocio.SelectedIndexChanged += new System.EventHandler(this.cboSocio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pelicula";
            // 
            // cboPelicula
            // 
            this.cboPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(127, 147);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(260, 28);
            this.cboPelicula.TabIndex = 3;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(414, 78);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(85, 20);
            this.lblContador.TabIndex = 4;
            this.lblContador.Text = "Prestadas:";
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Location = new System.Drawing.Point(127, 202);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(316, 26);
            this.dtpDevolucion.TabIndex = 5;
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.Location = new System.Drawing.Point(34, 207);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(87, 20);
            this.lblDevolucion.TabIndex = 6;
            this.lblDevolucion.Text = "Devolucion";
            // 
            // dgvRentasActivas
            // 
            this.dgvRentasActivas.AllowUserToAddRows = false;
            this.dgvRentasActivas.AllowUserToDeleteRows = false;
            this.dgvRentasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentasActivas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRenta,
            this.Pelicula,
            this.FechaRenta,
            this.FechaDevolucion});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentasActivas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRentasActivas.Location = new System.Drawing.Point(38, 322);
            this.dgvRentasActivas.Name = "dgvRentasActivas";
            this.dgvRentasActivas.ReadOnly = true;
            this.dgvRentasActivas.RowHeadersWidth = 62;
            this.dgvRentasActivas.RowTemplate.Height = 28;
            this.dgvRentasActivas.Size = new System.Drawing.Size(545, 290);
            this.dgvRentasActivas.TabIndex = 7;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(253, 629);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(134, 35);
            this.btnDevolver.TabIndex = 8;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnRentar
            // 
            this.btnRentar.Location = new System.Drawing.Point(253, 269);
            this.btnRentar.Name = "btnRentar";
            this.btnRentar.Size = new System.Drawing.Size(115, 31);
            this.btnRentar.TabIndex = 9;
            this.btnRentar.Text = "Rentar";
            this.btnRentar.UseVisualStyleBackColor = true;
            this.btnRentar.Click += new System.EventHandler(this.btnRentar_Click);
            // 
            // IdRenta
            // 
            this.IdRenta.DataPropertyName = "IdRenta";
            this.IdRenta.HeaderText = "Id";
            this.IdRenta.MinimumWidth = 8;
            this.IdRenta.Name = "IdRenta";
            this.IdRenta.ReadOnly = true;
            this.IdRenta.Visible = false;
            this.IdRenta.Width = 150;
            // 
            // Pelicula
            // 
            this.Pelicula.DataPropertyName = "Pelicula";
            this.Pelicula.HeaderText = "Pelicula";
            this.Pelicula.MinimumWidth = 8;
            this.Pelicula.Name = "Pelicula";
            this.Pelicula.ReadOnly = true;
            this.Pelicula.Width = 150;
            // 
            // FechaRenta
            // 
            this.FechaRenta.DataPropertyName = "FechaRenta";
            this.FechaRenta.HeaderText = "Rentada";
            this.FechaRenta.MinimumWidth = 8;
            this.FechaRenta.Name = "FechaRenta";
            this.FechaRenta.ReadOnly = true;
            this.FechaRenta.Width = 150;
            // 
            // FechaDevolucion
            // 
            this.FechaDevolucion.DataPropertyName = "FechaDevolucion";
            this.FechaDevolucion.HeaderText = "Devolver el";
            this.FechaDevolucion.MinimumWidth = 8;
            this.FechaDevolucion.Name = "FechaDevolucion";
            this.FechaDevolucion.ReadOnly = true;
            this.FechaDevolucion.Width = 150;
            // 
            // frmRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 686);
            this.Controls.Add(this.btnRentar);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.dgvRentasActivas);
            this.Controls.Add(this.lblDevolucion);
            this.Controls.Add(this.dtpDevolucion);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.cboPelicula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSocio);
            this.Controls.Add(this.label1);
            this.Name = "frmRentas";
            this.Text = "frmRentas";
            this.Load += new System.EventHandler(this.frmRentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentasActivas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSocio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPelicula;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.Label lblDevolucion;
        private System.Windows.Forms.DataGridView dgvRentasActivas;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnRentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevolucion;
    }
}
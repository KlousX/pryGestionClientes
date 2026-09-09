namespace pryGestionClientes
{
    partial class frmListadoOrdenado
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
            this.btnListar = new System.Windows.Forms.Button();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboFiltrar = new System.Windows.Forms.ComboBox();
            this.cboOrdenar = new System.Windows.Forms.ComboBox();
            this.lblOdernar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(197, 294);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(207, 23);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFiltrar.Location = new System.Drawing.Point(17, 14);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(59, 15);
            this.lblFiltrar.TabIndex = 18;
            this.lblFiltrar.Text = "Filtrar por";
            // 
            // dgvListadoClientes
            // 
            this.dgvListadoClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colLimite,
            this.colDeuda});
            this.dgvListadoClientes.Location = new System.Drawing.Point(10, 40);
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.Size = new System.Drawing.Size(562, 248);
            this.dgvListadoClientes.TabIndex = 17;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre y Apellido";
            this.colNombre.Name = "colNombre";
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Límite de Crédito";
            this.colLimite.Name = "colLimite";
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.Name = "colDeuda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.cboFiltrar);
            this.panel1.Controls.Add(this.cboOrdenar);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.lblOdernar);
            this.panel1.Controls.Add(this.dgvListadoClientes);
            this.panel1.Controls.Add(this.lblFiltrar);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 329);
            this.panel1.TabIndex = 23;
            // 
            // cboFiltrar
            // 
            this.cboFiltrar.FormattingEnabled = true;
            this.cboFiltrar.Location = new System.Drawing.Point(82, 14);
            this.cboFiltrar.Name = "cboFiltrar";
            this.cboFiltrar.Size = new System.Drawing.Size(179, 21);
            this.cboFiltrar.TabIndex = 22;
            // 
            // cboOrdenar
            // 
            this.cboOrdenar.FormattingEnabled = true;
            this.cboOrdenar.Location = new System.Drawing.Point(393, 13);
            this.cboOrdenar.Name = "cboOrdenar";
            this.cboOrdenar.Size = new System.Drawing.Size(179, 21);
            this.cboOrdenar.TabIndex = 21;
            // 
            // lblOdernar
            // 
            this.lblOdernar.AutoSize = true;
            this.lblOdernar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblOdernar.Location = new System.Drawing.Point(315, 14);
            this.lblOdernar.Name = "lblOdernar";
            this.lblOdernar.Size = new System.Drawing.Size(73, 15);
            this.lblOdernar.TabIndex = 19;
            this.lblOdernar.Text = "Ordenar por";
            // 
            // frmListadoOrdenado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 352);
            this.Controls.Add(this.panel1);
            this.Name = "frmListadoOrdenado";
            this.Text = "frmListadoOrdenado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.DataGridView dgvListadoClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboFiltrar;
        private System.Windows.Forms.ComboBox cboOrdenar;
        private System.Windows.Forms.Label lblOdernar;
    }
}
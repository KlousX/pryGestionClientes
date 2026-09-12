namespace pryGestionClientes
{
    partial class frmListadoOrdenadoDeudores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboFiltrar = new System.Windows.Forms.ComboBox();
            this.cboOrdenar = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblOdernar = new System.Windows.Forms.Label();
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(10, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 405);
            this.panel1.TabIndex = 24;
            // 
            // cboFiltrar
            // 
            this.cboFiltrar.FormattingEnabled = true;
            this.cboFiltrar.Location = new System.Drawing.Point(109, 17);
            this.cboFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.cboFiltrar.Name = "cboFiltrar";
            this.cboFiltrar.Size = new System.Drawing.Size(237, 24);
            this.cboFiltrar.TabIndex = 22;
            // 
            // cboOrdenar
            // 
            this.cboOrdenar.FormattingEnabled = true;
            this.cboOrdenar.Location = new System.Drawing.Point(524, 16);
            this.cboOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.cboOrdenar.Name = "cboOrdenar";
            this.cboOrdenar.Size = new System.Drawing.Size(237, 24);
            this.cboOrdenar.TabIndex = 21;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(263, 362);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(276, 28);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // lblOdernar
            // 
            this.lblOdernar.AutoSize = true;
            this.lblOdernar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblOdernar.Location = new System.Drawing.Point(420, 17);
            this.lblOdernar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdernar.Name = "lblOdernar";
            this.lblOdernar.Size = new System.Drawing.Size(88, 18);
            this.lblOdernar.TabIndex = 19;
            this.lblOdernar.Text = "Ordenar por";
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
            this.dgvListadoClientes.Location = new System.Drawing.Point(13, 49);
            this.dgvListadoClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.RowHeadersWidth = 51;
            this.dgvListadoClientes.Size = new System.Drawing.Size(749, 305);
            this.dgvListadoClientes.TabIndex = 17;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre y Apellido";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Límite de Crédito";
            this.colLimite.MinimumWidth = 6;
            this.colLimite.Name = "colLimite";
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.MinimumWidth = 6;
            this.colDeuda.Name = "colDeuda";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFiltrar.Location = new System.Drawing.Point(23, 17);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(71, 18);
            this.lblFiltrar.TabIndex = 18;
            this.lblFiltrar.Text = "Filtrar por";
            // 
            // frmListadoOrdenadoDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.panel1);
            this.Name = "frmListadoOrdenadoDeudores";
            this.Text = "Listado Ordenado Deudores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboFiltrar;
        private System.Windows.Forms.ComboBox cboOrdenar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblOdernar;
        private System.Windows.Forms.DataGridView dgvListadoClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.Label lblFiltrar;
    }
}
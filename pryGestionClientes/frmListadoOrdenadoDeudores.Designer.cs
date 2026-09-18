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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoOrdenadoDeudores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboFiltrar = new System.Windows.Forms.ComboBox();
            this.cboOrdenar = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblOdernar = new System.Windows.Forms.Label();
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Location = new System.Drawing.Point(8, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 329);
            this.panel1.TabIndex = 24;
            // 
            // cboFiltrar
            // 
            this.cboFiltrar.FormattingEnabled = true;
            this.cboFiltrar.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Deuda",
            "Límite de Crédito"});
            this.cboFiltrar.Location = new System.Drawing.Point(82, 14);
            this.cboFiltrar.Name = "cboFiltrar";
            this.cboFiltrar.Size = new System.Drawing.Size(179, 21);
            this.cboFiltrar.TabIndex = 22;
            // 
            // cboOrdenar
            // 
            this.cboOrdenar.FormattingEnabled = true;
            this.cboOrdenar.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cboOrdenar.Location = new System.Drawing.Point(393, 13);
            this.cboOrdenar.Name = "cboOrdenar";
            this.cboOrdenar.Size = new System.Drawing.Size(179, 21);
            this.cboOrdenar.TabIndex = 21;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(197, 294);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(207, 23);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
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
            this.dgvListadoClientes.RowHeadersWidth = 51;
            this.dgvListadoClientes.Size = new System.Drawing.Size(562, 248);
            this.dgvListadoClientes.TabIndex = 17;
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
            this.colLimite.HeaderText = "Deuda";
            this.colLimite.MinimumWidth = 6;
            this.colLimite.Name = "colLimite";
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Límite de deuda";
            this.colDeuda.MinimumWidth = 6;
            this.colDeuda.Name = "colDeuda";
            // 
            // frmListadoOrdenadoDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(600, 355);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListadoOrdenadoDeudores";
            this.Text = "Listado Ordenado Deudores";
            this.Load += new System.EventHandler(this.frmListadoOrdenadoDeudores_Load);
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
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
    }
}
namespace pryGestionClientes
{
    partial class frmListadoClientes
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
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblQClientes = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMuestraTotal = new System.Windows.Forms.Label();
            this.lblMuestraQ = new System.Windows.Forms.Label();
            this.lblMuestraPromedio = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.SuspendLayout();
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
            this.dgvListadoClientes.Location = new System.Drawing.Point(12, 12);
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.Size = new System.Drawing.Size(562, 248);
            this.dgvListadoClientes.TabIndex = 0;
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDeuda.Location = new System.Drawing.Point(13, 269);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(72, 15);
            this.lblDeuda.TabIndex = 1;
            this.lblDeuda.Text = "Total deuda";
            // 
            // lblQClientes
            // 
            this.lblQClientes.AutoSize = true;
            this.lblQClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblQClientes.Location = new System.Drawing.Point(180, 271);
            this.lblQClientes.Name = "lblQClientes";
            this.lblQClientes.Size = new System.Drawing.Size(118, 15);
            this.lblQClientes.TabIndex = 2;
            this.lblQClientes.Text = "Cantidad de clientes";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPromedio.Location = new System.Drawing.Point(395, 272);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(101, 15);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio Deuda";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMuestraTotal
            // 
            this.lblMuestraTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMuestraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMuestraTotal.Location = new System.Drawing.Point(91, 270);
            this.lblMuestraTotal.Name = "lblMuestraTotal";
            this.lblMuestraTotal.Size = new System.Drawing.Size(72, 15);
            this.lblMuestraTotal.TabIndex = 4;
            // 
            // lblMuestraQ
            // 
            this.lblMuestraQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMuestraQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMuestraQ.Location = new System.Drawing.Point(304, 271);
            this.lblMuestraQ.Name = "lblMuestraQ";
            this.lblMuestraQ.Size = new System.Drawing.Size(72, 15);
            this.lblMuestraQ.TabIndex = 5;
            // 
            // lblMuestraPromedio
            // 
            this.lblMuestraPromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMuestraPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMuestraPromedio.Location = new System.Drawing.Point(502, 272);
            this.lblMuestraPromedio.Name = "lblMuestraPromedio";
            this.lblMuestraPromedio.Size = new System.Drawing.Size(72, 15);
            this.lblMuestraPromedio.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(197, 296);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(207, 23);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
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
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 331);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblMuestraPromedio);
            this.Controls.Add(this.lblMuestraQ);
            this.Controls.Add(this.lblMuestraTotal);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblQClientes);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.dgvListadoClientes);
            this.Name = "frmListadoClientes";
            this.Text = "Listado Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoClientes;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblQClientes;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.Label lblMuestraTotal;
        private System.Windows.Forms.Label lblMuestraQ;
        private System.Windows.Forms.Label lblMuestraPromedio;
        private System.Windows.Forms.Button btnListar;
    }
}
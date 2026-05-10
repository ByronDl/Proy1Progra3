namespace Proy1Progra3
{
    partial class FormPOS
    {
        /// <summary>
        /// Variable del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar recursos.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(42, 54);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(228, 24);
            this.cbProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad a vender";
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(394, 56);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(320, 22);
            this.textCantidad.TabIndex = 2;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(12, 193);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(201, 63);
            this.btnVender.TabIndex = 3;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(238, 211);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(537, 417);
            this.dgvVentas.TabIndex = 4;
            // 
            // FormPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 694);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProductos);
            this.Name = "FormPOS";
            this.Text = "FormPOS";
            this.Load += new System.EventHandler(this.FormPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.DataGridView dgvVentas;
    }
}
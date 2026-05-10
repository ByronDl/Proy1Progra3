namespace Proy1Progra3
{
    partial class FormReportes
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
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdenarNombre = new System.Windows.Forms.Button();
            this.btnMasVendidos = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();

            this.SuspendLayout();

            // dgvReportes
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(98, 84);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 24;
            this.dgvReportes.Size = new System.Drawing.Size(709, 499);
            this.dgvReportes.TabIndex = 0;

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(396, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte";

            // btnOrdenarNombre
            this.btnOrdenarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnOrdenarNombre.Location = new System.Drawing.Point(86, 639);
            this.btnOrdenarNombre.Name = "btnOrdenarNombre";
            this.btnOrdenarNombre.Size = new System.Drawing.Size(237, 88);
            this.btnOrdenarNombre.TabIndex = 2;
            this.btnOrdenarNombre.Text = "Ordenar por Nombre";
            this.btnOrdenarNombre.UseVisualStyleBackColor = true;
            this.btnOrdenarNombre.Click += new System.EventHandler(this.btnOrdenarNombre_Click);

            // btnMasVendidos
            this.btnMasVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMasVendidos.Location = new System.Drawing.Point(558, 639);
            this.btnMasVendidos.Name = "btnMasVendidos";
            this.btnMasVendidos.Size = new System.Drawing.Size(209, 97);
            this.btnMasVendidos.TabIndex = 3;
            this.btnMasVendidos.Text = "Mas vendidos";
            this.btnMasVendidos.UseVisualStyleBackColor = true;
            this.btnMasVendidos.Click += new System.EventHandler(this.btnMasVendidos_Click);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTotal.Location = new System.Drawing.Point(322, 752);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(225, 36);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total Productos";

            // FormReportes
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 811);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnMasVendidos);
            this.Controls.Add(this.btnOrdenarNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReportes);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdenarNombre;
        private System.Windows.Forms.Button btnMasVendidos;
        private System.Windows.Forms.Label lblTotal;
    }
}
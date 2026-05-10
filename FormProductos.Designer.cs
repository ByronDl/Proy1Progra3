namespace Proy1Progra3
{
    partial class FormProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textPrecioCompra = new System.Windows.Forms.TextBox();
            this.textPrecioVenta = new System.Windows.Forms.TextBox();
            this.textExistencia = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca";

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio Compra";

            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(765, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio Venta";

            // label6
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1018, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Existencia";

            // textCodigo
            this.textCodigo.Location = new System.Drawing.Point(12, 103);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(136, 22);
            this.textCodigo.TabIndex = 7;

            // textNombre
            this.textNombre.Location = new System.Drawing.Point(168, 103);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(143, 22);
            this.textNombre.TabIndex = 8;

            // textMarca
            this.textMarca.Location = new System.Drawing.Point(333, 103);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(132, 22);
            this.textMarca.TabIndex = 9;

            // textPrecioCompra
            this.textPrecioCompra.Location = new System.Drawing.Point(497, 108);
            this.textPrecioCompra.Name = "textPrecioCompra";
            this.textPrecioCompra.Size = new System.Drawing.Size(205, 22);
            this.textPrecioCompra.TabIndex = 10;

            // textPrecioVenta
            this.textPrecioVenta.Location = new System.Drawing.Point(725, 108);
            this.textPrecioVenta.Name = "textPrecioVenta";
            this.textPrecioVenta.Size = new System.Drawing.Size(187, 22);
            this.textPrecioVenta.TabIndex = 11;

            // textExistencia
            this.textExistencia.Location = new System.Drawing.Point(957, 110);
            this.textExistencia.Name = "textExistencia";
            this.textExistencia.Size = new System.Drawing.Size(202, 22);
            this.textExistencia.TabIndex = 12;

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(40, 221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 47);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // dgvProductos
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(268, 157);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(804, 568);
            this.dgvProductos.TabIndex = 14;

            // FormProductos
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 752);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textExistencia);
            this.Controls.Add(this.textPrecioVenta);
            this.Controls.Add(this.textPrecioCompra);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textPrecioCompra;
        private System.Windows.Forms.TextBox textPrecioVenta;
        private System.Windows.Forms.TextBox textExistencia;

        private System.Windows.Forms.Button btnGuardar;

        private System.Windows.Forms.DataGridView dgvProductos;
    }
}
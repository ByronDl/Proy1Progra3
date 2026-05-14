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
            this.textNit = new System.Windows.Forms.TextBox();
            this.textNombreCliente = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // textNit
            // 
            this.textNit.Location = new System.Drawing.Point(30, 48);
            this.textNit.Name = "textNit";
            this.textNit.Size = new System.Drawing.Size(200, 22);
            this.textNit.TabIndex = 0;
            // 
            // textNombreCliente
            // 
            this.textNombreCliente.Location = new System.Drawing.Point(30, 110);
            this.textNombreCliente.Name = "textNombreCliente";
            this.textNombreCliente.Size = new System.Drawing.Size(200, 22);
            this.textNombreCliente.TabIndex = 1;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(30, 170);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(200, 22);
            this.textApellido.TabIndex = 2;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(30, 230);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(200, 22);
            this.textDireccion.TabIndex = 3;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(30, 292);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(200, 22);
            this.textTelefono.TabIndex = 4;
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(300, 128);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(220, 22);
            this.textCantidad.TabIndex = 6;
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(300, 48);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(220, 24);
            this.cbProductos.TabIndex = 5;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(300, 203);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(220, 24);
            this.cbEstado.TabIndex = 7;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(30, 356);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(200, 40);
            this.btnBuscarCliente.TabIndex = 8;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(282, 356);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(220, 40);
            this.btnVender.TabIndex = 9;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.Location = new System.Drawing.Point(550, 356);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(220, 40);
            this.btnFinalizarVenta.TabIndex = 10;
            this.btnFinalizarVenta.Text = "Finalizar Venta";
            this.btnFinalizarVenta.UseVisualStyleBackColor = true;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(30, 424);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(740, 250);
            this.dgvVentas.TabIndex = 11;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(27, 695);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(79, 16);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal: Q0";
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingrese el nit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellido del cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Direccion del cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "No de telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Productos registrados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cantidad del producto a vender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Estado de la factura";
            // 
            // FormPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 732);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNit);
            this.Controls.Add(this.textNombreCliente);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnFinalizarVenta);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.lblSubtotal);
            this.Name = "FormPOS";
            this.Text = "FormPOS";
            this.Load += new System.EventHandler(this.FormPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNit;
        private System.Windows.Forms.TextBox textNombreCliente;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textCantidad;

        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.ComboBox cbEstado;

        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnFinalizarVenta;

        private System.Windows.Forms.DataGridView dgvVentas;

        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
namespace Proy1Progra3
{
    partial class FormReportes
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dgvReportes = new System.Windows.Forms.DataGridView();

            this.btnOrdenarNombre = new System.Windows.Forms.Button();
            this.btnMasVendidos = new System.Windows.Forms.Button();

            this.btnTotalVentas = new System.Windows.Forms.Button();
            this.btnGanancia = new System.Windows.Forms.Button();
            this.btnPendientes = new System.Windows.Forms.Button();

            this.lblTotal = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();

            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();

            this.SuspendLayout();

            // dgvReportes
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(25, 25);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 24;
            this.dgvReportes.Size = new System.Drawing.Size(850, 350);

            // btnOrdenarNombre
            this.btnOrdenarNombre.Location = new System.Drawing.Point(25, 400);
            this.btnOrdenarNombre.Name = "btnOrdenarNombre";
            this.btnOrdenarNombre.Size = new System.Drawing.Size(170, 45);
            this.btnOrdenarNombre.Text = "Ordenar Nombre";
            this.btnOrdenarNombre.UseVisualStyleBackColor = true;
            this.btnOrdenarNombre.Click += new System.EventHandler(this.btnOrdenarNombre_Click);

            // btnMasVendidos
            this.btnMasVendidos.Location = new System.Drawing.Point(220, 400);
            this.btnMasVendidos.Name = "btnMasVendidos";
            this.btnMasVendidos.Size = new System.Drawing.Size(170, 45);
            this.btnMasVendidos.Text = "Más Vendidos";
            this.btnMasVendidos.UseVisualStyleBackColor = true;
            this.btnMasVendidos.Click += new System.EventHandler(this.btnMasVendidos_Click);

            // dtInicio
            this.dtInicio.Location = new System.Drawing.Point(25, 480);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(250, 22);

            // dtFinal
            this.dtFinal.Location = new System.Drawing.Point(300, 480);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(250, 22);

            // btnTotalVentas
            this.btnTotalVentas.Location = new System.Drawing.Point(25, 530);
            this.btnTotalVentas.Name = "btnTotalVentas";
            this.btnTotalVentas.Size = new System.Drawing.Size(170, 45);
            this.btnTotalVentas.Text = "Total Ventas";
            this.btnTotalVentas.UseVisualStyleBackColor = true;
            this.btnTotalVentas.Click += new System.EventHandler(this.btnTotalVentas_Click);

            // btnGanancia
            this.btnGanancia.Location = new System.Drawing.Point(220, 530);
            this.btnGanancia.Name = "btnGanancia";
            this.btnGanancia.Size = new System.Drawing.Size(170, 45);
            this.btnGanancia.Text = "Ganancia";
            this.btnGanancia.UseVisualStyleBackColor = true;
            this.btnGanancia.Click += new System.EventHandler(this.btnGanancia_Click);

            // btnPendientes
            this.btnPendientes.Location = new System.Drawing.Point(415, 530);
            this.btnPendientes.Name = "btnPendientes";
            this.btnPendientes.Size = new System.Drawing.Size(170, 45);
            this.btnPendientes.Text = "Pendientes";
            this.btnPendientes.UseVisualStyleBackColor = true;
            this.btnPendientes.Click += new System.EventHandler(this.btnPendientes_Click);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(25, 600);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 16);
            this.lblTotal.Text = "Total productos";

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(25, 630);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(76, 16);
            this.lblResultado.Text = "Resultado:";

            // FormReportes
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 700);

            this.Controls.Add(this.dgvReportes);

            this.Controls.Add(this.btnOrdenarNombre);
            this.Controls.Add(this.btnMasVendidos);

            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.dtFinal);

            this.Controls.Add(this.btnTotalVentas);
            this.Controls.Add(this.btnGanancia);
            this.Controls.Add(this.btnPendientes);

            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblResultado);

            this.Name = "FormReportes";
            this.Text = "FormReportes";

            this.Load += new System.EventHandler(this.FormReportes_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportes;

        private System.Windows.Forms.Button btnOrdenarNombre;
        private System.Windows.Forms.Button btnMasVendidos;

        private System.Windows.Forms.Button btnTotalVentas;
        private System.Windows.Forms.Button btnGanancia;
        private System.Windows.Forms.Button btnPendientes;

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblResultado;

        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFinal;
    }
}
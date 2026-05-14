namespace Proy1Progra3
{
    partial class FormFacturas
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
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnCargarFacturas = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();

            this.SuspendLayout();

            // dgvFacturas
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(28, 151);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.RowHeadersWidth = 51;
            this.dgvFacturas.RowTemplate.Height = 24;
            this.dgvFacturas.Size = new System.Drawing.Size(714, 542);
            this.dgvFacturas.TabIndex = 0;

            // btnCargarFacturas
            this.btnCargarFacturas.Location = new System.Drawing.Point(259, 49);
            this.btnCargarFacturas.Name = "btnCargarFacturas";
            this.btnCargarFacturas.Size = new System.Drawing.Size(210, 68);
            this.btnCargarFacturas.TabIndex = 1;
            this.btnCargarFacturas.Text = "Cargar facturas";
            this.btnCargarFacturas.UseVisualStyleBackColor = true;
            this.btnCargarFacturas.Click += new System.EventHandler(this.btnCargarFacturas_Click);

            // FormFacturas
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 724);
            this.Controls.Add(this.btnCargarFacturas);
            this.Controls.Add(this.dgvFacturas);
            this.Name = "FormFacturas";
            this.Text = "FormFacturas";
            this.Load += new System.EventHandler(this.FormFacturas_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnCargarFacturas;
    }
}
namespace Proy1Progra3
{
    partial class FormMenu
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
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(43, 150);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(199, 44);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(278, 150);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(189, 44);
            this.btnPOS.TabIndex = 1;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(542, 150);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(183, 44);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btnProductos);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnReportes;
    }
}
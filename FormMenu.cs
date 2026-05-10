using System;
using System.Windows.Forms;

namespace Proy1Progra3
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos f = new FormProductos();

            f.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            FormPOS f = new FormPOS();

            f.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes f = new FormReportes();

            f.Show();
        }
    }
}

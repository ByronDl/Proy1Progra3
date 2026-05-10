using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy1Progra3
{
    public partial class FormReportes : Form
    {
        List<Producto> lista = new List<Producto>();

        ArchivoProductos archivo = new ArchivoProductos();

        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            lista = archivo.Leer();

            Mostrar();

            lblTotal.Text = "Total productos: " + lista.Count;
        }

        private void Mostrar()
        {
            dgvReportes.DataSource = null;

            dgvReportes.DataSource = lista;
        }

        private void btnOrdenarNombre_Click(object sender, EventArgs e)
        {
            lista = lista.OrderBy(x => x.Nombre).ToList();

            Mostrar();
        }

        private void btnMasVendidos_Click(object sender, EventArgs e)
        {
            lista = lista.OrderByDescending(x => x.Vendidos).ToList();

            Mostrar();
        }
    }
}
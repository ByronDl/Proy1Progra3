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
    public partial class FormPOS : Form
    {
        List<Producto> lista = new List<Producto>();

        ArchivoProductos archivo = new ArchivoProductos();

        public FormPOS()
        {
            InitializeComponent();
        }

        private void FormPOS_Load(object sender, EventArgs e)
        {
            lista = archivo.Leer();

            cbProductos.DataSource = lista;

            cbProductos.DisplayMember = "Nombre";

            Mostrar();
        }

        private void Mostrar()
        {
            dgvVentas.DataSource = null;

            dgvVentas.DataSource = lista;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Producto p = (Producto)cbProductos.SelectedItem;

            int cantidad = Convert.ToInt32(textCantidad.Text);

            if (cantidad <= p.Existencia)
            {
                p.Existencia -= cantidad;

                p.Vendidos += cantidad;

                archivo.Guardar(lista);

                Mostrar();

                MessageBox.Show("Venta realizada");
            }
            else
            {
                MessageBox.Show("No hay suficiente existencia");
            }
        }
    }
}

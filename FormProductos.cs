using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proy1Progra3
{
    public partial class FormProductos : Form
    {
        List<Producto> lista = new List<Producto>();

        ArchivoProductos archivo = new ArchivoProductos();

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            lista = archivo.Leer();

            Mostrar();
        }

        private void Mostrar()
        {
            dgvProductos.DataSource = null;

            dgvProductos.DataSource = lista;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();

            p.Codigo = textCodigo.Text;

            p.Nombre = textNombre.Text;

            p.Marca = textMarca.Text;

            p.PrecioCompra = Convert.ToDouble(textPrecioCompra.Text);

            p.PrecioVenta = Convert.ToDouble(textPrecioVenta.Text);

            p.Existencia = Convert.ToInt32(textExistencia.Text);

            p.Vendidos = 0;

            lista.Add(p);

            archivo.Guardar(lista);

            Mostrar();

            Limpiar();

            MessageBox.Show("Producto guardado");
        }

        private void Limpiar()
        {
            textCodigo.Clear();

            textNombre.Clear();

            textMarca.Clear();

            textPrecioCompra.Clear();

            textPrecioVenta.Clear();

            textExistencia.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Producto producto = lista.FirstOrDefault(x => x.Codigo == textCodigo.Text);

            if (producto != null)
            {
                producto.Nombre = textNombre.Text;
                producto.Marca = textMarca.Text;
                producto.PrecioCompra = Convert.ToDouble(textPrecioCompra.Text);
                producto.PrecioVenta = Convert.ToDouble(textPrecioVenta.Text);
                producto.Existencia = Convert.ToInt32(textExistencia.Text);

                archivo.Guardar(lista);

                Mostrar();

                Limpiar();

                MessageBox.Show("Producto actualizado correctamente");
            }
            else
            {
                MessageBox.Show("No se encontró un producto con ese código");
            }
        }
    }
}

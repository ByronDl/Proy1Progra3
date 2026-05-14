using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proy1Progra3
{
    public partial class FormPOS : Form
    {
        List<Producto> productos = new List<Producto>();
        List<Cliente> clientes = new List<Cliente>();
        List<Factura> facturas = new List<Factura>();
        List<DetalleFactura> detalleActual = new List<DetalleFactura>();

        ArchivoProductos archivoProductos = new ArchivoProductos();
        ArchivoClientes archivoClientes = new ArchivoClientes();
        ArchivoFacturas archivoFacturas = new ArchivoFacturas();

        public FormPOS()
        {
            InitializeComponent();
        }

        private void FormPOS_Load(object sender, EventArgs e)
        {
            productos = archivoProductos.Leer();
            clientes = archivoClientes.Leer();
            facturas = archivoFacturas.Leer();

            cbProductos.DataSource = null;
            cbProductos.DataSource = productos;
            cbProductos.DisplayMember = "Nombre";

            cbEstado.Items.Clear();
            cbEstado.Items.Add("No entregado");
            cbEstado.Items.Add("Entregado");
            cbEstado.SelectedIndex = 0;

            MostrarDetalle();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = clientes.FirstOrDefault(c => c.Nit == textNit.Text);

            if (cliente != null)
            {
                textNombreCliente.Text = cliente.Nombre;
                textApellido.Text = cliente.Apellido;
                textDireccion.Text = cliente.Direccion;
                textTelefono.Text = cliente.Telefono;

                MessageBox.Show("Cliente encontrado");
            }
            else
            {
                textNombreCliente.Clear();
                textApellido.Clear();
                textDireccion.Clear();
                textTelefono.Clear();

                MessageBox.Show("Cliente no existe. Ingrese sus datos.");
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (cbProductos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            Producto producto = (Producto)cbProductos.SelectedItem;

            int cantidad = Convert.ToInt32(textCantidad.Text);

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero");
                return;
            }

            if (cantidad > producto.Existencia)
            {
                MessageBox.Show("No hay suficiente existencia");
                return;
            }

            DetalleFactura detalle = new DetalleFactura();

            detalle.CodigoProducto = producto.Codigo;
            detalle.Cantidad = cantidad;

            detalleActual.Add(detalle);

            producto.Existencia -= cantidad;
            producto.Vendidos += cantidad;

            archivoProductos.Guardar(productos);

            MostrarDetalle();

            textCantidad.Clear();

            MessageBox.Show("Producto agregado a la venta");
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNit.Text))
            {
                MessageBox.Show("Ingrese el NIT del cliente");
                return;
            }

            if (detalleActual.Count == 0)
            {
                MessageBox.Show("Debe agregar productos a la venta");
                return;
            }

            Cliente cliente = clientes.FirstOrDefault(c => c.Nit == textNit.Text);

            if (cliente == null)
            {
                cliente = new Cliente();

                cliente.Nit = textNit.Text;
                cliente.Nombre = textNombreCliente.Text;
                cliente.Apellido = textApellido.Text;
                cliente.Direccion = textDireccion.Text;
                cliente.Telefono = textTelefono.Text;

                clientes.Add(cliente);

                archivoClientes.Guardar(clientes);
            }

            int numeroFactura = 1;

            if (facturas.Count > 0)
            {
                numeroFactura = facturas.Max(f => f.NumeroFactura) + 1;
            }

            Factura factura = new Factura();

            factura.NumeroFactura = numeroFactura;
            factura.NitCliente = cliente.Nit;
            factura.Fecha = DateTime.Now;
            factura.Estado = cbEstado.Text;
            factura.Detalles = detalleActual;

            facturas.Add(factura);

            archivoFacturas.Guardar(facturas);

            MessageBox.Show("Factura guardada. Número: " + numeroFactura);

            detalleActual = new List<DetalleFactura>();

            Limpiar();

            MostrarDetalle();
        }

        private void MostrarDetalle()
        {
            var datos = detalleActual.Select(d =>
            {
                Producto producto = productos.FirstOrDefault(p => p.Codigo == d.CodigoProducto);

                return new
                {
                    Codigo = d.CodigoProducto,
                    Producto = producto != null ? producto.Nombre : "",
                    Cantidad = d.Cantidad,
                    Precio = producto != null ? producto.PrecioVenta : 0,
                    Subtotal = producto != null ? producto.PrecioVenta * d.Cantidad : 0
                };
            }).ToList();

            dgvVentas.DataSource = null;
            dgvVentas.DataSource = datos;

            double total = datos.Sum(x => x.Subtotal);

            lblSubtotal.Text = "Subtotal: Q" + total;
        }

        private void Limpiar()
        {
            textNit.Clear();
            textNombreCliente.Clear();
            textApellido.Clear();
            textDireccion.Clear();
            textTelefono.Clear();
            textCantidad.Clear();

            cbEstado.SelectedIndex = 0;
        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }
    }
}

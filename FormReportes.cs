using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proy1Progra3
{
    public partial class FormReportes : Form
    {
        List<Producto> productos = new List<Producto>();
        List<Factura> facturas = new List<Factura>();

        ArchivoProductos archivoProductos = new ArchivoProductos();
        ArchivoFacturas archivoFacturas = new ArchivoFacturas();

        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            productos = archivoProductos.Leer();
            facturas = archivoFacturas.Leer();

            MostrarProductos();

            lblTotal.Text = "Total productos: " + productos.Count;
        }

        private void MostrarProductos()
        {
            dgvReportes.DataSource = null;
            dgvReportes.DataSource = productos;
        }

        private void btnOrdenarNombre_Click(object sender, EventArgs e)
        {
            productos = productos.OrderBy(x => x.Nombre).ToList();

            MostrarProductos();
        }

        private void btnMasVendidos_Click(object sender, EventArgs e)
        {
            productos = productos.OrderByDescending(x => x.Vendidos).ToList();

            MostrarProductos();
        }

        private void btnTotalVentas_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtInicio.Value.Date;
            DateTime final = dtFinal.Value.Date.AddDays(1).AddSeconds(-1);

            double total = 0;

            var ventasFiltradas = facturas
                .Where(f => f.Fecha >= inicio && f.Fecha <= final)
                .ToList();

            foreach (var factura in ventasFiltradas)
            {
                foreach (var detalle in factura.Detalles)
                {
                    Producto producto = productos.FirstOrDefault(p => p.Codigo == detalle.CodigoProducto);

                    if (producto != null)
                    {
                        total += producto.PrecioVenta * detalle.Cantidad;
                    }
                }
            }

            lblResultado.Text = "Total de ventas: Q" + total;
        }

        private void btnGanancia_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtInicio.Value.Date;
            DateTime final = dtFinal.Value.Date.AddDays(1).AddSeconds(-1);

            double ganancia = 0;

            var ventasFiltradas = facturas
                .Where(f => f.Fecha >= inicio && f.Fecha <= final)
                .ToList();

            foreach (var factura in ventasFiltradas)
            {
                foreach (var detalle in factura.Detalles)
                {
                    Producto producto = productos.FirstOrDefault(p => p.Codigo == detalle.CodigoProducto);

                    if (producto != null)
                    {
                        ganancia += (producto.PrecioVenta - producto.PrecioCompra) * detalle.Cantidad;
                    }
                }
            }

            lblResultado.Text = "Ganancia: Q" + ganancia;
        }

        private void btnPendientes_Click(object sender, EventArgs e)
        {
            facturas = archivoFacturas.Leer();

            var pendientes = facturas
                .Where(f => f.Estado == "No entregado")
                .Select(f => new
                {
                    Factura = f.NumeroFactura,
                    NIT = f.NitCliente,
                    Fecha = f.Fecha,
                    Estado = f.Estado,
                    Productos = f.Detalles.Count
                })
                .ToList();

            dgvReportes.DataSource = null;
            dgvReportes.DataSource = pendientes;

            lblResultado.Text = "Ventas pendientes: " + pendientes.Count;
        }
    }
}
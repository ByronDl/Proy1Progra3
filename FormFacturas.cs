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
    public partial class FormFacturas : Form
    {
        List<Factura> facturas = new List<Factura>();
        List<Cliente> clientes = new List<Cliente>();

        ArchivoFacturas archivoFacturas = new ArchivoFacturas();
        ArchivoClientes archivoClientes = new ArchivoClientes();

        public FormFacturas()
        {
            InitializeComponent();
        }

        private void FormFacturas_Load(object sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void btnCargarFacturas_Click(object sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void CargarFacturas()
        {
            facturas = archivoFacturas.Leer();
            clientes = archivoClientes.Leer();

            var datos = facturas.Select(f =>
            {
                Cliente cliente = clientes.FirstOrDefault(c => c.Nit == f.NitCliente);

                return new
                {
                    NumeroFactura = f.NumeroFactura,
                    Nit = f.NitCliente,
                    Cliente = cliente != null ? cliente.Nombre + " " + cliente.Apellido : "No encontrado",
                    Fecha = f.Fecha,
                    Estado = f.Estado,
                    ProductosVendidos = f.Detalles.Count
                };
            }).ToList();

            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = datos;
        }
    }
}
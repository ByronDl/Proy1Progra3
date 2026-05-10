using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1Progra3
{
    internal class Factura
    {
        public int NumeroFactura { get; set; }

        public string NitCliente { get; set; }

        public DateTime Fecha { get; set; }

        public string Estado { get; set; }

        public List<DetalleFactura> Detalles { get; set; }
    }
}

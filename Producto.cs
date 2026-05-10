using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1Progra3
{
    public class Producto
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Marca { get; set; }

        public double PrecioCompra { get; set; }

        public double PrecioVenta { get; set; }

        public int Existencia { get; set; }

        public int Vendidos { get; set; }
    }
}

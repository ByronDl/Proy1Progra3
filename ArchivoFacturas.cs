using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proy1Progra3
{
    internal class ArchivoFacturas
    {
        string ruta = "facturas.json";

        public void Guardar(List<Factura> lista)
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);

            File.WriteAllText(ruta, json);
        }

        public List<Factura> Leer()
        {
            if (!File.Exists(ruta))
            {
                return new List<Factura>();
            }

            string json = File.ReadAllText(ruta);

            return JsonConvert.DeserializeObject<List<Factura>>(json)
                   ?? new List<Factura>();
        }
    }
}

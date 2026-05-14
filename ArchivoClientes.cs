using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proy1Progra3
{
    internal class ArchivoClientes
    {
        string ruta = "clientes.json";

        public void Guardar(List<Cliente> lista)
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);

            File.WriteAllText(ruta, json);
        }

        public List<Cliente> Leer()
        {
            if (!File.Exists(ruta))
            {
                return new List<Cliente>();
            }

            string json = File.ReadAllText(ruta);

            return JsonConvert.DeserializeObject<List<Cliente>>(json)
                   ?? new List<Cliente>();
        }
    }
}

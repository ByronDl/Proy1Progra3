using Newtonsoft.Json;
using Proy1Progra3;
using System.Collections.Generic;
using System.IO;

public class ArchivoProductos
{
    string ruta = "productos.json";

    public void Guardar(List<Producto> lista)
    {
        string json = JsonConvert.SerializeObject(lista, Formatting.Indented);

        File.WriteAllText(ruta, json);
    }

    public List<Producto> Leer()
    {
        if (!File.Exists(ruta))
        {
            return new List<Producto>();
        }

        string json = File.ReadAllText(ruta);

        return JsonConvert.DeserializeObject<List<Producto>>(json)
               ?? new List<Producto>();
    }
}

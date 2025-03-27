using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosEmpresa
{
    internal class AsistenciaArchivo
    {
        public void Guardar(string archivo, List<Horas> asistencias)
        {
            string json = JsonConvert.SerializeObject(asistencias);
            System.IO.File.WriteAllText(archivo, json);
        }

        public List<Horas> Leer(string archivo)
        {
            List<Horas> lista = new List<Horas>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Horas>>(json) ?? new List<Horas>();
            return lista;
        }
    }
}

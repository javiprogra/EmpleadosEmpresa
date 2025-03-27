using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosEmpresa
{
    internal class MetodosJson
    {
        public void GuardarJson(string fileName, List<Empleado> empleados)
        {
            string json = JsonConvert.SerializeObject(empleados);
            System.IO.File.WriteAllText(fileName, json);
        }

        public List<Empleado> LeerJson(string fileName)
        {
            List<Empleado> lista = new List<Empleado>();
            StreamReader jsonStream = File.OpenText(fileName);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Empleado>>(json) ?? new List<Empleado>();
            return lista;
        }
    }
}

using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EmpleadosEmpresa
{
    public partial class Form1 : Form
    {
        //Listas
        List<Empleado> empleados = new List<Empleado>();
        List<Horas> horasTrabajadas = new List<Horas>();
        List<SueldoMensual> sueldos = new List<SueldoMensual>();

        string archivoEmpleados = @"../../../empleados.json";
        string archivoHoras = @"../../horas.json";

        public Form1()
        {
            InitializeComponent();
        }

        //Metodos
        private void GuardarEmpleado(string fileName)
        {
            //Serializar (convierte a Json)
            string json = JsonConvert.SerializeObject(empleados);
            System.IO.File.WriteAllText(fileName, json);
        }

        private void LeerJson(string fileName)
        {
            StreamReader jsonStream = File.OpenText(fileName);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            //Se deserializa (convierte) la cadena json
            //y la convierte a la lista a donde se van a cargar los datos
            empleados = JsonConvert.DeserializeObject<List<Empleado>>(json) ?? new List<Empleado>();
        }

        private void CargarEmpleadosEnGrid()
        {
            dataGridViewEmpleados.DataSource = null;
            dataGridViewEmpleados.DataSource = empleados;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerJson(archivoEmpleados);
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            int noEmpleado = int.Parse(textBoxNoEmpleado.Text);
            string nombre = textBoxNombre.Text;
            double sueldoPorHora = double.Parse(textBoxSueldo.Text);

            if (textBoxNombre.Text != "" && textBoxNoEmpleado.Text != "" && textBoxSueldo.Text != "")
            {
                Empleado empleado = new Empleado();
                empleado.nombreEmpleado = nombre;
                empleado.noEmpleado = noEmpleado;
                empleado.sueldoPorHora = sueldoPorHora;

                empleados.Add(empleado);

                GuardarEmpleado(archivoEmpleados);
                Limpiar();
                MessageBox.Show("Empleado añadido exitosamente");
            }
            else
            {
                MessageBox.Show("Llene todos los campos necesarios");
            }


        }

        public void Limpiar()
        {
            textBoxNombre.Text = "";
            textBoxNoEmpleado.Text = "";
            textBoxSueldo.Text = "";
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            CargarEmpleadosEnGrid();
        }
    }
}

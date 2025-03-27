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
        MetodosJson metodosJson = new MetodosJson();
        //Listas
        List<Empleado> empleados = new List<Empleado>();
        List<Horas> horasTrabajadas = new List<Horas>();
        List<SueldoMensual> sueldos = new List<SueldoMensual>();

        string archivoEmpleados = @"../../../empleados.json";
        string archivoHoras = @"../../../horas.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void CargarEmpleadosEnGrid()
        {
            MetodosJson cargarEmpleado = new MetodosJson();
            empleados = cargarEmpleado.LeerJson(archivoEmpleados);

            dataGridViewEmpleados.DataSource = null;
            dataGridViewEmpleados.DataSource = empleados;
            dataGridViewEmpleados.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metodosJson.LeerJson(archivoEmpleados);
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "" && textBoxNoEmpleado.Text != "" && textBoxSueldo.Text != "")
            {
                int noEmpleado = int.Parse(textBoxNoEmpleado.Text);
                string nombre = textBoxNombre.Text;
                double sueldoPorHora = double.Parse(textBoxSueldo.Text);

                Empleado empleado = new Empleado();
                empleado.nombreEmpleado = nombre;
                empleado.noEmpleado = noEmpleado;
                empleado.sueldoPorHora = sueldoPorHora;

                empleados.Add(empleado);

                metodosJson.GuardarJson(archivoEmpleados, empleados);
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

        private void buttonAsistencia_Click(object sender, EventArgs e)
        {
            Asistencia formAsistencia = new Asistencia();
            formAsistencia.Show();
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();
        }
    }
}

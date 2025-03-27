using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosEmpresa
{
    public partial class Asistencia : Form
    {
        AsistenciaArchivo asistenciaArchivo = new AsistenciaArchivo();
        MetodosJson empleadoArchivo = new MetodosJson();
        //Listas
        List<Horas> asistencias = new List<Horas>();
        List<Empleado> empleados = new List<Empleado>();
        //Archivos
        string archivoEmpleados = @"../../../empleados.json";
        string archivoHoras = @"../../../horas.json";
        public Asistencia()
        {
            InitializeComponent();
        }

        private void CargarEmpleados()
        {

            empleados = empleadoArchivo.LeerJson(archivoEmpleados);
        }

        private void CargarAsistencia()
        {

        }

        private void MostrarEmpleados()
        {
            comboBoxEmpleado.ValueMember = "noEmpleado";
            comboBoxEmpleado.DisplayMember = "nombreEmpleado";
            comboBoxEmpleado.DataSource = empleados;
        }

        private void buttonAsistencia_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            MostrarEmpleados();
        }

        private void buttonGuardarAsistencia_Click(object sender, EventArgs e)
        {
            int noEmpleado = Convert.ToInt16(comboBoxEmpleado.SelectedValue);
            int HorasMes = int.Parse(textBoxHorasMes.Text);
            int Mes = int.Parse(textBoxMes.Text);

            Horas horas = new Horas();
            horas.NoEmpleado = noEmpleado;
            horas.HorasMes = HorasMes;
            horas.Mes = Mes;

            asistencias.Add(horas);

            asistenciaArchivo.Guardar(archivoHoras, asistencias);

            MessageBox.Show("Asistencia añadida exitosamente");
        }
    }
}

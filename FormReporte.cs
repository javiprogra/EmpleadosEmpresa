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
    public partial class FormReporte : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        List<Horas> asistencias = new List<Horas>();
        List<SueldoMensual> reportes = new List<SueldoMensual>();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void CargarEmpleados()
        {
            //Pasar los metodos de leer y escribir json a una clase

        }

        private void CargarAsistencia()
        {

        }

        private void FormReporte_Load(object sender, EventArgs e)
        {

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            foreach (var empleado in empleados)
            {
                foreach (var asistencia in asistencias)
                {
                    //Crear un reporte nuevo
                    SueldoMensual reporte = new SueldoMensual();
                    //Nombre del reporte obtenido del empleado
                    reporte.Nombre = empleado.nombreEmpleado;
                    //El mes para el reporte lo obtenemos de la asistencia
                    reporte.Mes = asistencia.Mes.ToString();
                    //El sueldo se calcula multiplicando
                    reporte.Sueldo = empleado.sueldoPorHora * asistencia.HorasMes;
                    //Se agrega el reporte a la lista de reportes
                    reportes.Add(reporte);
                }
            }
        }
    }
}

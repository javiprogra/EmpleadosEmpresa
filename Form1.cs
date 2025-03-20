using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EmpleadosEmpresa
{
    public partial class Form1 : Form
    {
        //Listas
        private List<Empleado> empleados;
        private List<Horas> horasTrabajadas;
        private List<SueldoMensual> sueldos;

        string archivoEmpleados = @"../../empleados.json";
        string archivoHoras = @"../../horas.json";

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}

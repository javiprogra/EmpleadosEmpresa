namespace EmpleadosEmpresa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewEmpleados = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            buttonAñadir = new Button();
            textBoxNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonCargar = new Button();
            buttonAsistencia = new Button();
            textBoxNoEmpleado = new NumericUpDown();
            textBoxSueldo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBoxNoEmpleado).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            dataGridViewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpleados.Location = new Point(469, 131);
            dataGridViewEmpleados.Margin = new Padding(3, 4, 3, 4);
            dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            dataGridViewEmpleados.RowHeadersWidth = 51;
            dataGridViewEmpleados.Size = new Size(424, 339);
            dataGridViewEmpleados.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(534, 49);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 1;
            label1.Text = "Sueldo de Empleados:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 73);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 2;
            label2.Text = "Añadir empleado:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(536, 73);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 3;
            // 
            // buttonAñadir
            // 
            buttonAñadir.Location = new Point(193, 343);
            buttonAñadir.Margin = new Padding(3, 4, 3, 4);
            buttonAñadir.Name = "buttonAñadir";
            buttonAñadir.Size = new Size(86, 31);
            buttonAñadir.TabIndex = 4;
            buttonAñadir.Text = "Añadir";
            buttonAñadir.UseVisualStyleBackColor = true;
            buttonAñadir.Click += buttonAñadir_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(72, 144);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(206, 27);
            textBoxNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 120);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 8;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 189);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 9;
            label4.Text = "No. Empleado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 256);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 10;
            label5.Text = "Sueldo por hora:";
            // 
            // buttonCargar
            // 
            buttonCargar.Location = new Point(681, 72);
            buttonCargar.Margin = new Padding(3, 4, 3, 4);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Size = new Size(133, 31);
            buttonCargar.TabIndex = 11;
            buttonCargar.Text = "Cargar Empleados";
            buttonCargar.UseVisualStyleBackColor = true;
            buttonCargar.Click += buttonCargar_Click;
            // 
            // buttonAsistencia
            // 
            buttonAsistencia.Location = new Point(285, 343);
            buttonAsistencia.Name = "buttonAsistencia";
            buttonAsistencia.Size = new Size(94, 56);
            buttonAsistencia.TabIndex = 12;
            buttonAsistencia.Text = "Ingresar Asistencia";
            buttonAsistencia.UseVisualStyleBackColor = true;
            buttonAsistencia.Click += buttonAsistencia_Click;
            // 
            // textBoxNoEmpleado
            // 
            textBoxNoEmpleado.Location = new Point(72, 212);
            textBoxNoEmpleado.Name = "textBoxNoEmpleado";
            textBoxNoEmpleado.Size = new Size(205, 27);
            textBoxNoEmpleado.TabIndex = 13;
            // 
            // textBoxSueldo
            // 
            textBoxSueldo.Location = new Point(70, 280);
            textBoxSueldo.Margin = new Padding(3, 4, 3, 4);
            textBoxSueldo.Name = "textBoxSueldo";
            textBoxSueldo.Size = new Size(207, 27);
            textBoxSueldo.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBoxNoEmpleado);
            Controls.Add(buttonAsistencia);
            Controls.Add(buttonCargar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxSueldo);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonAñadir);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewEmpleados);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleados";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBoxNoEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmpleados;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button buttonAñadir;
        private TextBox textBoxNombre;
        private TextBox maskedTextBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonCargar;
        private Button buttonAsistencia;
        private NumericUpDown textBoxNoEmpleado;
        private TextBox textBoxSueldo;
        
    }
}

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
            textBoxNoEmpleado = new TextBox();
            textBoxSueldo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonCargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            dataGridViewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpleados.Location = new Point(410, 98);
            dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            dataGridViewEmpleados.Size = new Size(344, 254);
            dataGridViewEmpleados.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(467, 37);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 1;
            label1.Text = "Sueldo de Empleados:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 55);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 2;
            label2.Text = "Añadir empleado:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(469, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // buttonAñadir
            // 
            buttonAñadir.Location = new Point(169, 257);
            buttonAñadir.Name = "buttonAñadir";
            buttonAñadir.Size = new Size(75, 23);
            buttonAñadir.TabIndex = 4;
            buttonAñadir.Text = "Añadir";
            buttonAñadir.UseVisualStyleBackColor = true;
            buttonAñadir.Click += buttonAñadir_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(63, 108);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(181, 23);
            textBoxNombre.TabIndex = 5;
            // 
            // textBoxNoEmpleado
            // 
            textBoxNoEmpleado.Location = new Point(63, 160);
            textBoxNoEmpleado.Name = "textBoxNoEmpleado";
            textBoxNoEmpleado.Size = new Size(181, 23);
            textBoxNoEmpleado.TabIndex = 6;
            // 
            // textBoxSueldo
            // 
            textBoxSueldo.Location = new Point(62, 210);
            textBoxSueldo.Name = "textBoxSueldo";
            textBoxSueldo.Size = new Size(182, 23);
            textBoxSueldo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 90);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 142);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 9;
            label4.Text = "No. Empleado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 192);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 10;
            label5.Text = "Sueldo por hora:";
            // 
            // buttonCargar
            // 
            buttonCargar.Location = new Point(596, 54);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Size = new Size(116, 23);
            buttonCargar.TabIndex = 11;
            buttonCargar.Text = "Cargar Empleados";
            buttonCargar.UseVisualStyleBackColor = true;
            buttonCargar.Click += buttonCargar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCargar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxSueldo);
            Controls.Add(textBoxNoEmpleado);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonAñadir);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewEmpleados);
            Name = "Form1";
            Text = "Empleados";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).EndInit();
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
        private TextBox textBoxNoEmpleado;
        private TextBox textBoxSueldo;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonCargar;
    }
}

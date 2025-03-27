namespace EmpleadosEmpresa
{
    partial class Asistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxEmpleado = new ComboBox();
            textBoxHorasMes = new TextBox();
            textBoxMes = new TextBox();
            buttonGuardarAsistencia = new Button();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(518, 342);
            buttonClose.Margin = new Padding(3, 2, 3, 2);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(82, 45);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Cerrar";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 89);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "No. Empleado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 144);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Horas en el mes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 192);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 3;
            label3.Text = "Mes:";
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(190, 86);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(157, 23);
            comboBoxEmpleado.TabIndex = 4;
            // 
            // textBoxHorasMes
            // 
            textBoxHorasMes.Location = new Point(190, 141);
            textBoxHorasMes.Name = "textBoxHorasMes";
            textBoxHorasMes.Size = new Size(100, 23);
            textBoxHorasMes.TabIndex = 5;
            // 
            // textBoxMes
            // 
            textBoxMes.Location = new Point(190, 189);
            textBoxMes.Name = "textBoxMes";
            textBoxMes.Size = new Size(100, 23);
            textBoxMes.TabIndex = 6;
            // 
            // buttonGuardarAsistencia
            // 
            buttonGuardarAsistencia.Location = new Point(190, 238);
            buttonGuardarAsistencia.Name = "buttonGuardarAsistencia";
            buttonGuardarAsistencia.Size = new Size(95, 45);
            buttonGuardarAsistencia.TabIndex = 7;
            buttonGuardarAsistencia.Text = "Guardar";
            buttonGuardarAsistencia.UseVisualStyleBackColor = true;
            buttonGuardarAsistencia.Click += buttonGuardarAsistencia_Click;
            // 
            // Asistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 398);
            Controls.Add(buttonGuardarAsistencia);
            Controls.Add(textBoxMes);
            Controls.Add(textBoxHorasMes);
            Controls.Add(comboBoxEmpleado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonClose);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Asistencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asistencia";
            Load += Asistencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxEmpleado;
        private TextBox textBoxHorasMes;
        private TextBox textBoxMes;
        private Button buttonGuardarAsistencia;
    }
}
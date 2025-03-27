namespace EmpleadosEmpresa
{
    partial class FormReporte
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
            dataGridViewReporte = new DataGridView();
            buttonMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReporte).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReporte
            // 
            dataGridViewReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReporte.Location = new Point(17, 13);
            dataGridViewReporte.Name = "dataGridViewReporte";
            dataGridViewReporte.RowHeadersWidth = 51;
            dataGridViewReporte.Size = new Size(771, 320);
            dataGridViewReporte.TabIndex = 0;
            // 
            // buttonMostrar
            // 
            buttonMostrar.Location = new Point(293, 340);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(176, 68);
            buttonMostrar.TabIndex = 1;
            buttonMostrar.Text = "Mostrar Reporte";
            buttonMostrar.UseVisualStyleBackColor = true;
            buttonMostrar.Click += buttonMostrar_Click;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(buttonMostrar);
            Controls.Add(dataGridViewReporte);
            Name = "FormReporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReporte";
            Load += FormReporte_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReporte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewReporte;
        private Button buttonMostrar;
    }
}
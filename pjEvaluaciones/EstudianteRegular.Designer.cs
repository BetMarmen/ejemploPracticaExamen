namespace pjEvaluaciones
{
    partial class EstudianteRegular
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbEstadistica = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnDatoNuevo = new System.Windows.Forms.Button();
            this.txtActitudinal = new System.Windows.Forms.TextBox();
            this.txtEva3 = new System.Windows.Forms.TextBox();
            this.txtEva2 = new System.Windows.Forms.TextBox();
            this.txtEva1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lvEstudiante = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE EVALUACIONES - PROGRAMACION I";
            // 
            // lbEstadistica
            // 
            this.lbEstadistica.FormattingEnabled = true;
            this.lbEstadistica.ItemHeight = 20;
            this.lbEstadistica.Location = new System.Drawing.Point(34, 350);
            this.lbEstadistica.Name = "lbEstadistica";
            this.lbEstadistica.Size = new System.Drawing.Size(821, 104);
            this.lbEstadistica.TabIndex = 1;
            this.lbEstadistica.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.btnDatoNuevo);
            this.groupBox1.Controls.Add(this.txtActitudinal);
            this.groupBox1.Controls.Add(this.txtEva3);
            this.groupBox1.Controls.Add(this.txtEva2);
            this.groupBox1.Controls.Add(this.txtEva1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(34, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL ESTUDIANTE";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(663, 74);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(131, 27);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnDatoNuevo
            // 
            this.btnDatoNuevo.Location = new System.Drawing.Point(663, 33);
            this.btnDatoNuevo.Name = "btnDatoNuevo";
            this.btnDatoNuevo.Size = new System.Drawing.Size(131, 35);
            this.btnDatoNuevo.TabIndex = 10;
            this.btnDatoNuevo.Text = "DATO NUEVO";
            this.btnDatoNuevo.UseVisualStyleBackColor = true;
            this.btnDatoNuevo.Click += new System.EventHandler(this.btnDatoNuevo_Click);
            // 
            // txtActitudinal
            // 
            this.txtActitudinal.Location = new System.Drawing.Point(578, 74);
            this.txtActitudinal.Name = "txtActitudinal";
            this.txtActitudinal.Size = new System.Drawing.Size(67, 27);
            this.txtActitudinal.TabIndex = 9;
            // 
            // txtEva3
            // 
            this.txtEva3.Location = new System.Drawing.Point(494, 74);
            this.txtEva3.Name = "txtEva3";
            this.txtEva3.Size = new System.Drawing.Size(67, 27);
            this.txtEva3.TabIndex = 8;
            // 
            // txtEva2
            // 
            this.txtEva2.Location = new System.Drawing.Point(393, 74);
            this.txtEva2.Name = "txtEva2";
            this.txtEva2.Size = new System.Drawing.Size(67, 27);
            this.txtEva2.TabIndex = 7;
            // 
            // txtEva1
            // 
            this.txtEva1.Location = new System.Drawing.Point(306, 74);
            this.txtEva1.Name = "txtEva1";
            this.txtEva1.Size = new System.Drawing.Size(72, 27);
            this.txtEva1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "ACTITUDINAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "EVA.3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "EVA.2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "EVA.1";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(25, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ESTUDIANTE";
            // 
            // lvEstudiante
            // 
            this.lvEstudiante.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvEstudiante.GridLines = true;
            this.lvEstudiante.Location = new System.Drawing.Point(34, 216);
            this.lvEstudiante.Name = "lvEstudiante";
            this.lvEstudiante.Size = new System.Drawing.Size(794, 97);
            this.lvEstudiante.TabIndex = 3;
            this.lvEstudiante.UseCompatibleStateImageBehavior = false;
            this.lvEstudiante.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Estudiante";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Eva.1";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Eva.2";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Eva.3";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Actitudinal";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Promedio";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Condición";
            this.columnHeader7.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ESTUDIANTES";
            // 
            // EstudianteRegular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvEstudiante);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbEstadistica);
            this.Controls.Add(this.label1);
            this.Name = "EstudianteRegular";
            this.Text = "EstudianteRegular";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lbEstadistica;
        private GroupBox groupBox1;
        private ListView lvEstudiante;
        private Label label2;
        private Button btnRegistrar;
        private Button btnDatoNuevo;
        private TextBox txtActitudinal;
        private TextBox txtEva3;
        private TextBox txtEva2;
        private TextBox txtEva1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}
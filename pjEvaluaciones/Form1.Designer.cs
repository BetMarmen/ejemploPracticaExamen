namespace pjEvaluaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstudianteRegular = new System.Windows.Forms.Button();
            this.btnEstudiantePregrado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Evaluacion de Notas";
            // 
            // btnEstudianteRegular
            // 
            this.btnEstudianteRegular.Location = new System.Drawing.Point(180, 215);
            this.btnEstudianteRegular.Name = "btnEstudianteRegular";
            this.btnEstudianteRegular.Size = new System.Drawing.Size(152, 33);
            this.btnEstudianteRegular.TabIndex = 1;
            this.btnEstudianteRegular.Text = "Estudiante Regular";
            this.btnEstudianteRegular.UseVisualStyleBackColor = true;
            this.btnEstudianteRegular.Click += new System.EventHandler(this.btnEstudianteRegular_Click);
            // 
            // btnEstudiantePregrado
            // 
            this.btnEstudiantePregrado.Location = new System.Drawing.Point(438, 215);
            this.btnEstudiantePregrado.Name = "btnEstudiantePregrado";
            this.btnEstudiantePregrado.Size = new System.Drawing.Size(168, 32);
            this.btnEstudiantePregrado.TabIndex = 2;
            this.btnEstudiantePregrado.Text = "Estudiante Pregrado";
            this.btnEstudiantePregrado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEstudiantePregrado);
            this.Controls.Add(this.btnEstudianteRegular);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnEstudianteRegular;
        private Button btnEstudiantePregrado;
    }
}
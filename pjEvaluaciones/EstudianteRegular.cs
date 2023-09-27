using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjEvaluaciones
{
    public partial class EstudianteRegular : Form
    {
        //objeto,instaciamiento de los metodos de la clase PromedioProgramacion
        PromedioProgramacion objA = new();
        
        public EstudianteRegular()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CapturaDatos()
        {
            objA.nombreEstudiante=txtNombre.Text;
            objA.evaluEstudiante[0]=double.Parse(txtEva1.Text);
            objA.evaluEstudiante[1]=double.Parse(txtEva2.Text);
            objA.evaluEstudiante[2]=double.Parse(txtEva3.Text);
            objA.evaluEstudiante[3]=double.Parse(txtActitudinal.Text);
            


        }
        private String clasificacion()
        {
            if (objA.PromedioRegular()>=0 && objA.PromedioRegular()<60)
            {
                
                return "Desaprobado";
                
            }
            else
                return "Aprobado";
               
        }
        private int TotalAprobados()
        {
            int contadorAprobados = 0;
            foreach (ListViewItem item in lvEstudiante.Items)
            {
                if (item.SubItems[6].Text == "Aprobado") // Comprueba si la clasificación es "Aprobado"
                {
                    contadorAprobados++;
                }
            }
            return contadorAprobados;
        }

        private int TotalDesaprobados()
        {
            int contadorDesaprobados = 0;
            foreach (ListViewItem item in lvEstudiante.Items)
            {
                if (item.SubItems[6].Text == "Desaprobado") // Comprueba si la clasificación es "Desaprobado"
                {
                    contadorDesaprobados++;
                }
            }
            return contadorDesaprobados;
        }

        private double PromedioMenor()
        {
            double promedioMenor = double.MaxValue;
            foreach (ListViewItem item in lvEstudiante.Items)
            {
                double promedio = double.Parse(item.SubItems[5].Text);
                if (promedio < promedioMenor)
                {
                    promedioMenor = promedio;
                }
            }
            return promedioMenor;
        }

        private double PromedioMayor()
        {
            double promedioMayor = double.MinValue;
            foreach (ListViewItem item in lvEstudiante.Items)
            {
                double promedio = double.Parse(item.SubItems[5].Text);
                if (promedio > promedioMayor)
                {
                    promedioMayor = promedio;
                }
            }
            return promedioMayor;
        }
        private double SumarPromedios()
        {
            double sumaPromedios = 0.0;

            foreach (ListViewItem item in lvEstudiante.Items)
            {
                double promedio = double.Parse(item.SubItems[5].Text); 
                sumaPromedios += promedio;
            }

            return sumaPromedios;
        }


        private string Valida()
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                txtNombre.Focus();
                return "nombre del Estudiante";
            }
            else if (txtEva1.Text.Trim().Length == 0)
            {
                txtEva1.Focus();
                return "Evaluación 1";
            }
            else if (txtEva2.Text.Trim().Length == 0)
            {
                txtEva2.Focus();
                return "Evaluación 2 ";
            }
            else if (txtEva3.Text.Trim().Length == 0)
            {
                txtEva3.Focus();
                return "Evaluación 3";
            }
            else if (txtActitudinal.Text.Trim().Length == 0)
            {
                txtActitudinal.Focus();
                return "Evaluación Actitudinal";
            }

            return "";
        }
        private void LimpiezaCajas()
        {


            txtNombre.Clear();
            txtEva1.Clear();
            txtEva2.Clear();
            txtEva3.Clear();
            txtActitudinal.Clear();

        }


        private void btnDatoNuevo_Click(object sender, EventArgs e)
        {
            if (Valida() == "")
            {
                CapturaDatos();
                ListViewItem fila = new(txtNombre.Text);
                fila.SubItems.Add(txtEva1.Text);
                fila.SubItems.Add(txtEva2.Text);
                fila.SubItems.Add(txtEva3.Text);
                fila.SubItems.Add(txtActitudinal.Text);
                fila.SubItems.Add(objA.PromedioRegular().ToString());
                fila.SubItems.Add(clasificacion().ToString());
                lvEstudiante.Items.Add(fila);
                LimpiezaCajas();
            }
            else
                MessageBox.Show($"El error se encuentra en {Valida()}");

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            lbEstadistica.Items.Clear();
            lbEstadistica.Items.Add("Suma de Promedios:"+SumarPromedios());
            lbEstadistica.Items.Add("Promedio Mas Alto: " + PromedioMayor());
            lbEstadistica.Items.Add("Promedio Mas Bajo: " + PromedioMenor());
            lbEstadistica.Items.Add("Total de Aprobados: " + TotalAprobados());
            lbEstadistica.Items.Add("Total de Desaprobados: " +TotalDesaprobados());
        }
        
    }
}

namespace pjEvaluaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstudianteRegular_Click(object sender, EventArgs e)
        {
           EstudianteRegular estudianteRegular = new EstudianteRegular();
            estudianteRegular.ShowDialog();
        }
    }
}
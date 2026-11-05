
using ContenedorAlumnos;

namespace ABM
{
    public partial class FormPrincipal : Form
    {
        private List<Alumno> alumnos;
        public FormPrincipal()
        {
            InitializeComponent();

            alumnos = new List<Alumno>() {
                new Alumno("Juan", "Gomez", 22),
                new Alumno("Analia", "Suarez", 19),
                new Alumno("Anibal", "Perez", 18),
                new Alumno("Jimena", "Alvarez", 17),
                new Alumno("Juan", "Gomez", 19)
            };
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs eventoDeCierre)
        {
            //DialogResult respuesta = MessageBox.Show("Estas seguro de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //if (respuesta == DialogResult.No)
            //{
            //    eventoDeCierre.Cancel = true;
            //}
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ActualizarListBox();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno al;

            FormAlumno formAlumno = new FormAlumno();

            formAlumno.ShowDialog();

            if (formAlumno.DialogResult == DialogResult.OK)
            {
                al = formAlumno.AlumnoCreado;

                alumnos.Add(al);

                              
            }
            ActualizarListBox();


        }

        private void ActualizarListBox()
        {
            lstPrincipal.DataSource = null;
            lstPrincipal.DataSource = alumnos;
        }
    }
}

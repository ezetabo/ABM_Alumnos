using ContenedorAlumnos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABM
{
    public partial class FormAlumno : Form
    {
        private Alumno alumno;

        public Alumno AlumnoCreado{
            get
            {
                return alumno;
            }
        }


        public FormAlumno()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = int.Parse(txtEdad.Text);

            alumno = new Alumno(nombre, apellido,edad);

            this.DialogResult = DialogResult.OK;           
           
        }
    }
}
